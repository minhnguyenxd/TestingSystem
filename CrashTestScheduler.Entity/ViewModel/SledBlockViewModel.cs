using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashTestScheduler.Entity.ViewModel
{

    public class SledBlockViewModel
    {
        public int Id { get; set; }
        public int TestRequestId { get; set; }
        public DateTime ScheduleStartDate { get; set; }
        public DateTime ScheduleEndDate { get; set; }

    }
}
