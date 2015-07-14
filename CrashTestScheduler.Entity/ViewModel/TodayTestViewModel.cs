using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashTestScheduler.Entity.ViewModel
{
    public class TodayTestViewModel
    {
        public int RequestId { get; set; }

        public byte Status { get; set; }
        public String CalendarType { get; set; }
        public String TestDescription { get; set; }
    }
}
