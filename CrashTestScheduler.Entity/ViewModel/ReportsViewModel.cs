using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashTestScheduler.Entity.ViewModel
{
    public class ReportsViewModelResult
    {
       

    }
    public class ReportsViewModel
    {
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string StatusIds { get; set; }
        public string LocationIds { get; set; }
        public string ddl_projects { get; set; }
        public string ProjectIds { get; set; }
        public string CalendarIds { get; set; }

        public int CalendarTypeId { get; set; }

      
        
      //  [Range(ErrorMessage = "Please choose a test lab id.")]
        public int? TestLabId { get; set; }
    }
}
