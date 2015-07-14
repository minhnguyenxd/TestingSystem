using System.Collections.Generic;

namespace CrashTestScheduler.Entity.ViewModel
{
    public class CreateCrashTestViewModel
    {
        public CrashTestViewModel CrashTest { get; set; }
        public RequestTestPlanVModel TestPlan { get; set; }
        public List<TestLabViewModel> Labs { get; set; }
        public List<ProjectViewModel> Projects { get; set; }
        public List<SelectListItems> SelectProject{ get; set;}
        public List<SelectListItems> SelectLab{ get; set;}
        public List<SelectListItems> SelectTestType { get; set; }
        public List<SelectListItems> SelectTestMode { get; set; } 
    }
}
