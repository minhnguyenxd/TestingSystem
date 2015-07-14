using System.Collections.Generic;

namespace CrashTestScheduler.Entity.ViewModel
{
    public class ChecklistTechnicianViewModel
    {
        public string ChecklistType { get; set; }
        public List<UserViewModel> Technicians { get; set; }
    }
}
