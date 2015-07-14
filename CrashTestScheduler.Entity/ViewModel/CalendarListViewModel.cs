using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashTestScheduler.Entity.ViewModel
{
    public class CalendarListViewModel
    {
        public string Status { get; set; }
        public string TestDate { get; set; }
        public string FrameCode { get; set; }
        [Display(Name="Test Mode")]
        public string TestModeName { get; set; }
        
        [Display(Name = "Test Type")]
        public string TestTypeName { get; set; }
        public string VehicleNumber { get; set; }
        public string PicName { get; set; }

        public int TestRequestId { get; set; }

        public string AtdInfo { get; set; }

    }
}
