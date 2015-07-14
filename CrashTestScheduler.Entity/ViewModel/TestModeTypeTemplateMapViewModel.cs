using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashTestScheduler.Entity.ViewModel
{
    public class TestModeTypeTemplateMapViewModel
    {
        public int Id { get; set; }
        public int CalendarTypeId { get; set; }
        public string Action { get; set; }
        public int TestTypeId { get; set; }
        public int TestModeId { get; set; }
        public int TestPlanTemplateId { get; set; }

        //flatten
        public string TestTypeName { get; set; }
        public string TestModeName { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
