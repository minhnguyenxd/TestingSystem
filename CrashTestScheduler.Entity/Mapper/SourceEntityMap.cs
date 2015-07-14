using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashTestScheduler.Entity.Mapper
{
    public enum MappingType
    {
        Insert,
        Update,
        All
    }

    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public class SourceEntityMap : Attribute
    {
        //properties
        public MappingType MapType { get; set; }
        public string Source { get; set; }
        public SourceEntityMap()
        {

        }
    }

    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public class TargetEntityMap : Attribute
    {
        //properties
        public MappingType MapType { get; set; }
        public string TargetProperty { get; set; }
        public string Format { get; set; }
        public TargetEntityMap()
        {

        }
    }
}
