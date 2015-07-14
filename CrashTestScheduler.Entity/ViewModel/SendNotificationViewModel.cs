using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashTestScheduler.Entity.ViewModel
{
    public class SendNotificationViewModel
    {
        public int Id { get; set; }
        public string TestName { get; set; }
        public DateTime? ScheduledTestDate { get; set; }
        public DateTime RequestedTestDate { get; set; }
        public DateTime? ChangeRequestDate { get; set; }
        public string RequesterDisplayName { get; set; }
        public string TestTypeName { get; set; }
        public string TestModeName { get; set; }
        public string PicDisplayName { get; set; }
        public string SensorPicDisplayName { get; set; }

    }
}
