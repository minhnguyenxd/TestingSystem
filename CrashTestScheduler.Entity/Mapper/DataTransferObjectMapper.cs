using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CrashTestScheduler.Entity.Mapper
{
    public enum MappingDirection
    {
        ViewToDataEntity,
        DataEntitytoView
    }

    public enum MappingOperation
    {
        Update,
        AddInsert
    }

    public static class DataTransferObjectMapper
    {
        public static void MapEntityModels(object viewModel, object dataModel, MappingDirection direction = MappingDirection.DataEntitytoView, MappingOperation operation = MappingOperation.AddInsert)
        {
            var viewmodelType = viewModel.GetType();
            var props = viewmodelType.GetProperties(BindingFlags.Public | BindingFlags.Instance).ToList();
            if(props != null && props.Count > 0)
            {
                foreach(var prop in props)
                {
                    var att = prop.GetCustomAttribute(typeof(TargetEntityMap), false) as TargetEntityMap;
                    var mapType = operation == MappingOperation.Update ? MappingType.Update  : MappingType.Insert;
                    if(att != null && (att.MapType.HasFlag(mapType) | att.MapType.HasFlag(MappingType.All)) 
                        && !string.IsNullOrEmpty(att.TargetProperty))
                    {
                        var targetType = dataModel.GetType();
                        var targetProp = targetType.GetProperties(BindingFlags.Public | BindingFlags.Instance).ToList()
                            .Where(t => t.Name.ToLower() == prop.Name.ToLower()).FirstOrDefault();
                        if(targetProp != null)
                        {
                            try
                            {
                                //set the value
                                
                                if (prop.PropertyType == targetProp.PropertyType)
                                {
                                    if (direction == MappingDirection.ViewToDataEntity)
                                    {
                                       targetProp.SetValue(dataModel, prop.GetValue(viewModel));
                                    }
                                    else
                                    {
                                        prop.SetValue(viewModel, targetProp.GetValue(dataModel));
                                    }
                                }
                                else
                                {
                                    if (direction == MappingDirection.ViewToDataEntity)
                                    {
                                        var objnewValue = ConvertValue(prop.GetValue(viewModel), targetProp.PropertyType, att.Format);
                                        if (objnewValue != null)
                                        {
                                            targetProp.SetValue(dataModel, objnewValue);
                                        }
                                    }
                                    else
                                    {
                                        var objnewValue = ConvertValue(targetProp.GetValue(dataModel), prop.PropertyType, att.Format);
                                        if (objnewValue != null)
                                        {
                                            prop.SetValue(dataModel, objnewValue);
                                        }
                                    }
                                }
                            }
                            catch {
                                throw new Exception( string.Format("Unable to set value for {0}", targetProp.Name));
                            }
                        }
                    }
                }
            }
        }

        public static object ConvertValue(object inputValue, Type outType, string format)
        {
            if (inputValue == null)
            {
                return null;
            }
            var sourceType = inputValue.GetType();
            var targetType = outType;

            try
            {
                if (sourceType == typeof(DateTime) && targetType == typeof(string))
                {
                    var dt = Convert.ChangeType(inputValue, typeof(DateTime));
                    return ((DateTime)dt).ToString(format);
                }
                if (sourceType == typeof(string))
                {
                    if (targetType == typeof(DateTime))
                    {
                        var strdate = Convert.ChangeType(inputValue, typeof(string));
                        DateTime dt;
                        if (DateTime.TryParse((string)strdate, out dt))
                        {
                            return dt;
                        }
                    }
                }
                var trueType = Nullable.GetUnderlyingType(targetType) ?? targetType;
                var safeValue = inputValue == null ? null
                    : Convert.ChangeType(inputValue, trueType);
                return safeValue;
            }
            catch(Exception ex)
            {
                var msg = ex.Message;
                return null;
            }
            
        }

        //maps only if they have the same propertyname
        public static void MapObjects(object source, object target, string[] excludeTarget)
        {
            var tsource = source.GetType();
            var ttarget = target.GetType();
            var targetProps = ttarget.GetProperties(BindingFlags.Public | BindingFlags.Instance).ToDictionary(p => p.Name.ToLower(), p => p);
            var sourceProps = tsource.GetProperties(BindingFlags.Public | BindingFlags.Instance).ToDictionary(p => p.Name.ToLower(), p => p);
            foreach(var p in targetProps)
            {
                if (excludeTarget.ToList().Any(z => z.ToLower() == p.Key.ToLower()))
                {
                    continue;
                }
                PropertyInfo pinfo;
                if( sourceProps.TryGetValue(p.Key, out pinfo))
                {
                    //same type
                    if(pinfo.PropertyType == p.Value.PropertyType)
                    {
                        p.Value.SetValue(target, pinfo.GetValue(source));
                    }
                    else
                    {
                        //get actual type 
                        var thisPropType = p.Value.PropertyType;
                        if(  thisPropType.IsGenericType &&
                             thisPropType.GetGenericTypeDefinition() == typeof(Nullable<>))
                        {
                            thisPropType = thisPropType.GetGenericArguments()[0];
                        }

                        var objVal = ConvertValue(pinfo.GetValue(source), thisPropType, string.Empty);
                        if(objVal != null)
                        {
                            p.Value.SetValue(target, objVal);
                        }
                    }
                }

            }

        }
    }
}
