using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using CrashTestScheduler.Entity.Model;
using CrashTestScheduler.Entity.ViewModel;
using CrashTestScheduler.Entity.Mapper;

namespace CrashTestScheduler.Entity.ViewModel.Extensions
{
    public static class Extensions
    {
        //misc
        public static string UnformatPhoneNumber(this string ph)
        {
            if (string.IsNullOrEmpty(ph))
            {
                return ph;
            }
            ph = Regex.Replace(ph, @"\-()", string.Empty);
            return ph;
        }
        //project
        public static ProjectViewModel ToViewModel(this Project p)
        {
            return new ProjectViewModel
            {
                Id = p.Id,
                Comments = p.Comments,
                ProjectCode = p.ProjectCode,
                FrameCode = p.FrameCode,
                SeatRows = p.SeatRows,
                ProjectLead = p.ProjectLead,
                ProjectLeadEmail = p.ProjectLeadEmail
            };
        }


        public static AtdType ToDataModel(this AtdTypeViewModel atdTypeViewModel)
        {
            var dummtType = new AtdType
            {
                Name = atdTypeViewModel.Name,
                Description = atdTypeViewModel.Description

            };

            if (atdTypeViewModel.Id > 0)
            {
                dummtType.Id = atdTypeViewModel.Id;
            }
            return dummtType;
        }

        public static List<AtdTypeViewModel> ToViewModel(this IList<AtdType> p)
        {
            var plist = new List<AtdTypeViewModel>();
            //convert here
            p.ToList().ForEach(x => plist.Add(x.ToViewModel()));
            return plist;
        }
        public static AtdTypeViewModel ToViewModel(this AtdType p)
        {
            return new AtdTypeViewModel
            {
                Name = p.Name,
                Description = p.Description,
                Id = p.Id
            };
        }

        public static List<ProjectViewModel> ToViewModel(this IList<Project> p)
        {
            var plist = new List<ProjectViewModel>();
            //convert here
            p.ToList().ForEach(x => plist.Add(x.ToViewModel()));
            return plist;
        }

        public static List<ProjectViewModel> ToViewModel(this IEnumerable<Project> p)
        {
            return p.ToList().ToViewModel();
        }

        public static List<SelectListItems> ToSelectList(this IList<ProjectViewModel> p, bool addSelectPrompt = false)
        {
            var selItems = new List<SelectListItems>();
            if (addSelectPrompt)
            {
                selItems.Add(new SelectListItems { ValueField = "-1", TextField = "<--Select Project-->" });
            }
            p.ToList().ForEach(c => selItems.Add(new SelectListItems { ValueField = c.Id.ToString(), TextField = c.FrameCode }));

            return selItems;
        }

        //laboratories
        public static TestLabViewModel ToViewModel(this TestLaboratory t)
        {
            return new TestLabViewModel
            {
                TestLaboratoryId = t.Id.ToString(),
                Name = t.Name,
                Location = t.Location,
                OpenOnWeekends = t.OpenOnWeekend ?? false,
                Active = t.Active
            };
        }

        public static List<TestLabViewModel> ToViewModel(this IList<TestLaboratory> t)
        {
            var labList = new List<TestLabViewModel>();
            t.ToList().ForEach(a => labList.Add(a.ToViewModel()));
            return labList;
        }

        public static List<TestLabViewModel> ToViewModel(this IEnumerable<TestLaboratory> t)
        {
            return t.ToList().ToViewModel();
        }

        public static List<SelectListItems> ToSelectList(this IList<TestLabViewModel> t, bool addSelectPrompt = false)
        {
            var selItems = new List<SelectListItems>();
            if (addSelectPrompt)
            {
                selItems.Add(new SelectListItems { ValueField = "-1", TextField = "<--Select Test Lab Location-->" });
            }
            t.ToList().ForEach(c => selItems.Add(new SelectListItems { ValueField = c.TestLaboratoryId, TextField = c.Name }));
            return selItems;
        }

        // <summary>
        /// Generic extension function 
        /// </summary>
        /// <typeparam name="T">Generic Type</typeparam>
        /// <param name="t">Generic Object</param>
        /// <param name="selectedValue">Object parameter</param>
        /// <returns>Select List collection</returns>
        public static SelectList ToSelectList<T>(this IEnumerable<T> t, object selectedValue)
        {
            return new SelectList(t, "Id", "Name");
        }

        public static SelectList ToSelectList(this IEnumerable<ChannelGroup> t, object selectedValue)
        {

            return new SelectList(t, "Id", "Name");

        }

        public static SelectList ToSelectList(this IEnumerable<Channel> t, object selectedValue)
        {

            return new SelectList(t, "Id", "Name");

        }
        public static SelectList ToSelectList(this IEnumerable<SaeClass> t, object selectedValue)
        {

            return new SelectList(t, "Id", "Name");

        }
        public static SelectList ToSelectList(this IEnumerable<EngUnit> t, object selectedValue)
        {

            return new SelectList(t, "Id", "Name");

        }

        //crashtestrequest
        public static CrashTestViewModel ToViewModel(this TestRequest r)
        {
            return new CrashTestViewModel() { };
            //return new CrashTestViewModel
            //{
            //   // RequestId = r.TestRequestId.ToString(),
            //    TestDate = r.TestDate.ToString("MM/dd/yyyy"), //convert to local time
            //    TestNumber = r.TestNumber,
            //    PicName = r.PicName,
            //    PicPhone = r.PicPhone,
            //    SensorPic = r.SensorPic,
            //    SensorPicPhone = r.SensorPicPhone,
            //    RequestStatus = r.RequestStatus.ToString(),
            //    Project = r.Project != null ? r.Project.ToViewModel() : default(ProjectViewModel),
            //    TestLaboratory = r.TestLaboratory != null ? r.TestLaboratory.ToViewModel() : default(TestLabViewModel),
            //    TestMode = r.TestMode != null ? r.TestMode.ToViewModel() : default(TestModeViewModel),
            //    TestType = r.TestType != null ? r.TestType.ToViewModel() : default(TestTypeViewModel),
            //    TestPlanGenerated = r.TestPlanGenerated
            //};
        }

        public static List<CrashTestViewModel> ToViewModel(this IList<TestRequest> r)
        {
            var reqList = new List<CrashTestViewModel>();
            r.ToList().ForEach(a => reqList.Add(a.ToViewModel()));
            return reqList;
        }

        public static List<CrashTestViewModel> ToViewModel(this IEnumerable<TestRequest> r)
        {
            return r.ToList().ToViewModel();
        }

        public static TestRequest ToDataModel(this CrashTestViewModel v)
        {
            var t = new TestRequest
            {
                //TestDate = DateTime.Parse(v.TestDate), //convert to utc
                //TestNumber = v.TestNumber,
                //PicName = v.PicName,
                //PicPhone = v.PicPhone.UnformatPhoneNumber(),
                //SensorPic = v.SensorPic,
                //SensorPicPhone = v.SensorPicPhone.UnformatPhoneNumber(),
                //ProjectId = int.Parse(v.ProjectID),
                //TestLaboratoryId = int.Parse(v.TestLaboratoryID),
                //RequestStatus = RequestStatus.Requested
            };
            //if (!string.IsNullOrEmpty(v.Id))
            //{
            //  //  t.TestRequestId = int.Parse(v.RequestId);
            //}
            return t;
        }

        public static TestRequest UpdateFromViewModel(this TestRequest me, CrashTestViewModel vm)
        {
            DataTransferObjectMapper.MapEntityModels(vm, me, MappingDirection.ViewToDataEntity, MappingOperation.Update);
            me.PicPhone = me.PicPhone.UnformatPhoneNumber();
            me.SensorPicPhone = me.SensorPicPhone.UnformatPhoneNumber();
            return me;
        }

        public static TestRequest UpdateFromViewModel(this TestRequest me, SledTestViewModel vm)
        {
            DataTransferObjectMapper.MapEntityModels(vm, me, MappingDirection.ViewToDataEntity, MappingOperation.Update);
            me.PicPhone = me.PicPhone.UnformatPhoneNumber();
            me.SensorPicPhone = me.SensorPicPhone.UnformatPhoneNumber();
            return me;
        }

        public static TestRequest CreateFromViewModel(this TestRequest me, CrashTestViewModel vm, string createdBy)
        {
            DataTransferObjectMapper.MapEntityModels(vm, me, MappingDirection.ViewToDataEntity, MappingOperation.AddInsert);
            me.CreatedBy = createdBy;
            me.CreatedDate = DateTime.UtcNow;
            me.PicPhone = me.PicPhone.UnformatPhoneNumber();
            me.SensorPicPhone = me.SensorPicPhone.UnformatPhoneNumber();
            return me;
        }

        //test type
        public static TestTypeViewModel ToViewModel(this TestType t)
        {
            return new TestTypeViewModel { Id = t.Id, Name = t.Name };
        }

        public static List<TestTypeViewModel> ToViewModel(this List<TestType> t)
        {
            var v = new List<TestTypeViewModel>();
            t.ForEach(c => v.Add(c.ToViewModel()));
            return v;
        }

        public static TestModeViewModel ToViewModel(this TestMode t)
        {
            return new TestModeViewModel { Id = t.Id, Name = t.Name };
        }

        public static SignalLocationViewModel ToViewModel(this SignalLocation t)
        {
            return new SignalLocationViewModel { Id = t.Id, LocationName = t.LocationName };
        }

        public static List<TestModeViewModel> ToViewModel(this List<TestMode> t)
        {
            var v = new List<TestModeViewModel>();
            t.ForEach(c => v.Add(c.ToViewModel()));
            return v;
        }
        public static List<SignalLocationViewModel> ToViewModel(this List<SignalLocation> t)
        {
            var v = new List<SignalLocationViewModel>();
            t.ForEach(c => v.Add(c.ToViewModel()));
            return v;
        }
        public static List<SelectListItems> ToSelectList(this IList<TestTypeViewModel> p, bool addSelectPrompt = false)
        {
            var selItems = new List<SelectListItems>();
            if (addSelectPrompt)
            {
                selItems.Add(new SelectListItems { ValueField = "-1", TextField = "<--Select Test Type-->" });
            }
            p.ToList().ForEach(c => selItems.Add(new SelectListItems { ValueField = c.Id.ToString(), TextField = c.Name }));
            return selItems;
        }


        public static List<SelectListItems> ToSelectList(this IList<SignalLocationViewModel> p, bool addSelectPrompt = false)
        {
            var selItems = new List<SelectListItems>();
            if (addSelectPrompt)
            {
                selItems.Add(new SelectListItems { ValueField = "-1", TextField = "<--Select Test Type-->" });
            }
            p.ToList().ForEach(c => selItems.Add(new SelectListItems { ValueField = c.Id.ToString(), TextField = c.LocationName }));
            return selItems;
        }  
        public static List<SelectListItems> ToSelectList(this IQueryable<SledBuck> p, bool addSelectPrompt = false)
        {
            var selItems = new List<SelectListItems>();
            if (addSelectPrompt)
            {
                selItems.Add(new SelectListItems { ValueField = "", TextField = "<--Select Buck Type-->" });
            }
            p.ToList().ForEach(c => selItems.Add(new SelectListItems { ValueField = c.Id.ToString(), TextField = c.Name }));
            return selItems;
        }

        public static List<SelectListItems> ToSelectList(this IList<TestModeViewModel> p, bool addSelectPrompt = false)
        {
            var selItems = new List<SelectListItems>();
            if (addSelectPrompt)
            {
                selItems.Add(new SelectListItems { ValueField = "-1", TextField = "<--Select Test Mode-->" });
            }
            p.ToList().ForEach(c => selItems.Add(new SelectListItems { ValueField = c.Id.ToString(), TextField = c.Name }));
            return selItems;
        }


        public static List<AtdChannelLocationViewModel> ToViewModel(this 
            List<AtdChannelLocation> dummyChannelLocations)
        {
            var v = new List<AtdChannelLocationViewModel>();
            dummyChannelLocations.ForEach(c => v.Add(c.ToViewModel()));
            return v;
        }

        public static AtdChannelLocationViewModel ToViewModel(this AtdChannelLocation atdChannelLocation)
        {
            return new AtdChannelLocationViewModel
            {
                Id = atdChannelLocation.Id,
                Location = atdChannelLocation.Location
            };
        }

        public static AtdChannelLocation ToDataModel(this AtdChannelLocationViewModel atdChannelLocationViewModel)
        {
            var dummyChannelLocation = new AtdChannelLocation
            {
                Location = atdChannelLocationViewModel.Location

            };
            if (atdChannelLocationViewModel.Id > 0)
            {
                dummyChannelLocation.Id = atdChannelLocationViewModel.Id;
            }
            return dummyChannelLocation;
        }

        //test templates 
        public static TestPlanTemplateVModel ToViewModel(this TestPlanTemplate tpl)
        {
            string[] objMapExclude = { "id", "IsDeleted", "DeletedDate", "DeletedBy", "CreatedDate", "CreatedBy", "LastUpdatedDate", "UpdatedBy" };
            var vm = new TestPlanTemplateVModel { Id = tpl.Id.ToString(), TestModeId = tpl.TestModeId, TestTypeId = tpl.TestTypeId };
            vm.TestPlanInfo = new TestPlanVModel();
            DataTransferObjectMapper.MapObjects(tpl, vm.TestPlanInfo, objMapExclude);
            return vm;
        }

        public static TestPlanTemplate UpdateFromViewModel(this TestPlanTemplate me, TestPlanTemplateVModel vm)
        {
            string[] objMapExclude = { "id", "IsDeleted", "DeletedDate", "DeletedBy", "CreatedDate", "CreatedBy", "LastUpdatedDate", "UpdatedBy" };
            if (vm.TestPlanInfo == null)
            {
                return me;
            }
            DataTransferObjectMapper.MapObjects(vm.TestPlanInfo, me, objMapExclude);
            me.Id = int.Parse(vm.Id);
            me.TestTypeId = vm.TestTypeId;
            me.TestModeId = vm.TestModeId;
            me.IsActive = vm.IsActive;
         
            return me;
        }

        public static TestModeTypeTemplateMapViewModel ToViewModel(this TestModeTypeTemplateMap me)
        {
            string[] objMapExclude = { "IsDeleted", "DeletedDate", "DeletedBy", "CreatedDate", "CreatedBy", "LastUpdatedDate", "UpdatedBy" };
            var vm = new TestModeTypeTemplateMapViewModel();
            DataTransferObjectMapper.MapObjects(me, vm, objMapExclude);
            //flatten names
            vm.TestTypeName = me.TestMode.TestType.Name;
            vm.TestModeName = me.TestMode.Name;
            vm.CalendarTypeId = me.TestMode.TestType.CalendarTypeId.HasValue ? me.TestMode.TestType.CalendarTypeId.Value : 1;
            if (vm.CalendarTypeId == 1)
                vm.Action = "Edit";
            else
                vm.Action = "SledEdit";
            vm.TestPlanTemplateId = me.TestPlanTemplateId;
            vm.LastUpdatedDate = me.TestPlanTemplate.LastUpdatedDate;
            return vm;
        }

        public static List<TestModeTypeTemplateMapViewModel> ToViewModel(this List<TestModeTypeTemplateMap> me)
        {
            var vm = new List<TestModeTypeTemplateMapViewModel>();
            me.ForEach(m => vm.Add(m.ToViewModel()));
            return vm;
        }

        //custom field selector
        //to view
        public static CustomFieldSelectionViewModel ToViewModel(this List<TestPlanTemplateField> me)
        {
            var custFields = new List<CustomFieldsViewModel>();
            me.ForEach(a => custFields.Add(new CustomFieldsViewModel { FieldName = a.FieldName, Selected = a.Selected }));
            return new CustomFieldSelectionViewModel(custFields);
        }

        public static CustomFieldSelectionViewModel ToViewModel(this List<TestPlanField> me)
        {
            var custFields = new List<CustomFieldsViewModel>();
            me.ForEach(a => custFields.Add(new CustomFieldsViewModel { FieldName = a.FieldName, Selected = a.Selected }));
            return new CustomFieldSelectionViewModel(custFields);
        }

        public static void UpdateFromViewModel(this List<TestPlanTemplateField> me, CustomFieldSelectionViewModel vm)
        {
            me.ForEach(a =>
            {
                var newval = vm.GetValueByKey(a.FieldName);
                if (newval != a.Selected) //changed
                {
                    a.Selected = newval;
                    a.ObjectState = Repository.ObjectState.Modified;
                }

            });
        }
        //---------------------

        //Template Dummies
        public static TemplateDummiesViewModel ToViewModel(this List<TemplateDummy> me, int templateId)
        {
            var tpDummies = new List<TestPlanDummyViewModel>();
            me.ForEach(a => tpDummies.Add(new TestPlanDummyViewModel
            {
                AtdTypeId = a.AtdTypeId,
                SeatingPosition = a.SeatingPosition,
                Belted = a.Belted,
                Enabled = a.Enabled,
                InstrumentationLegs = a.InstrumentationLegs
            }));
            return new TemplateDummiesViewModel { TemplateId = templateId, Dummies = new DummyCollectionViewModel(tpDummies) };
        }

        public static void UpdateFromViewModel(this List<TemplateDummy> me, TemplateDummiesViewModel vm, int templateId)
        {

            var newdummies = vm.Dummies.GetCollection();
            newdummies.Where(c => c.AtdTypeId > 0).ToList().ForEach(a =>
            {
                var du = me.Find(d => d.SeatingPosition == a.SeatingPosition);
                if (du == null) //add
                {
                    me.Add(new TemplateDummy
                    {
                        SeatingPosition = a.SeatingPosition,
                        AtdTypeId = a.AtdTypeId,
                        Belted = a.Belted,
                        Enabled = a.Enabled,
                        TemplateId = templateId,
                        ObjectState = Repository.ObjectState.Added
                    });
                }
                else //update
                {
                    if (du.AtdTypeId != a.AtdTypeId || du.Belted != a.Belted || du.Enabled != a.Enabled || du.InstrumentationLegs != a.InstrumentationLegs)
                    {
                        du.AtdTypeId = a.AtdTypeId;
                        du.Belted = a.Belted;
                        du.Enabled = a.Enabled;
                        du.InstrumentationLegs = a.InstrumentationLegs;

                        du.ObjectState = Repository.ObjectState.Modified;
                    }
                }
            });
        }

        public static List<SelectListItems> ToSelectList(this List<AtdTypeViewModel> me, bool addSelectPrompt)
        {
            var selItems = new List<SelectListItems>();
            if (addSelectPrompt)
            {
                selItems.Add(new SelectListItems { ValueField = "0", TextField = "<--Select Dummy Type-->" });
            }
            me.ForEach(c => selItems.Add(new SelectListItems { ValueField = c.Id.ToString(), TextField = c.Name }));
            return selItems;
        }
        public static List<SelectListItems> ToSelectList(this string[] p, bool addSelectPrompt = false)
        {
            var selItems = new List<SelectListItems>();
            if (addSelectPrompt)
            {
                selItems.Add(new SelectListItems { ValueField = "-1", TextField = "<--Select Test Type-->" });
            }
            int value = 1;
            p.ToList().ForEach(c => selItems.Add(new SelectListItems { ValueField = (value++).ToString(), TextField = c }));
            return selItems;
        }
        //-----------------------------------

        //test request test plan
        public static RequestTestPlanVModel ToViewModel(this TestPlan tp)
        {
            string[] objMapExclude = { "id", "IsDeleted", "DeletedDate", "DeletedBy", "CreatedDate", "CreatedBy", "LastUpdatedDate", "UpdatedBy" };
            var vm = new RequestTestPlanVModel { Id = tp.Id.ToString(), RequestId = tp.TestRequestId.ToString(), TestPlanInfo = new TestPlanVModel() };
            DataTransferObjectMapper.MapObjects(tp, vm.TestPlanInfo, objMapExclude);
            return vm;
        }

        //test request vehicle record
        public static VehicleRecordViewModel ToViewModel(this VehicleRecord vr)
        {
            string[] objMapExclude = { "id", "IsDeleted", "DeletedDate", "DeletedBy", "CreatedDate", "CreatedBy", "LastUpdatedDate", "UpdatedBy" };

            var vm = new VehicleRecordViewModel { VehicleRecordId = vr.Id };
            DataTransferObjectMapper.MapObjects(vr, vm, objMapExclude);
            return vm;
        }

        // ----------- Calendar
        public static CalendarViewModel ToCalendarViewModel(this TestRequest request)
        {
            var viewModel = new CalendarViewModel
            {
                Start = request.GetTestDate(),
                Title = request.GetCalendarTitle(),
                textColor = request.GetTextColor(),
                AllDay = true,
                Id = request.Id,
                JointCertification = request.JointCertification
            };
            viewModel.End = viewModel.Start;
            viewModel.backgroundColor = request.GetColorCode();
            viewModel.Url = "/TestRequest/Detail/" + request.Id.ToString();
            return viewModel;
        }


        public static CalendarViewModel ToSledCalendarViewModel(this TestRequest request)
        {
            var viewModel = new CalendarViewModel
            {
                Start = request.GetTestDate(),
                Title = request.GetSledCalendarTitle(),
                textColor = request.GetTextColor(),
                AllDay = true,
                Id = request.Id
            };
            viewModel.End = viewModel.Start;
            viewModel.backgroundColor = request.GetColorCode();
            viewModel.Url = "/SledTestRequest/Detail/" + request.Id.ToString();
            return viewModel;
        }

        public static CalendarViewModel ToIrlCalendarViewModel(this TestRequest request)
        {
            var viewModel = new CalendarViewModel
            {
                Start = request.GetTestDate(),
                Title = request.GetSledCalendarTitle(),
                textColor = request.GetTextColor(),
                AllDay = true,
                Id = request.Id
            };
            viewModel.End = viewModel.Start;
            viewModel.backgroundColor = request.GetColorCode();
            viewModel.Url = "/IrlTestRequest/Detail/" + request.Id.ToString();
            return viewModel;
        }

        public static CalendarViewModel ToCalendarViewModel(this CalendarEvent calendarEvent)
        {
            var viewModel = new CalendarViewModel();
            viewModel.Start = calendarEvent.Start;
            viewModel.Title = calendarEvent.GetTitle();
            viewModel.AllDay = true;
            viewModel.Id = calendarEvent.Id;
            viewModel.End = calendarEvent.End;
            viewModel.backgroundColor = calendarEvent.GetColorCode();
            viewModel.Url = "/TestRequest/Detail/" + calendarEvent.TestRequestId.ToString();
            return viewModel;
        }
    }
}
