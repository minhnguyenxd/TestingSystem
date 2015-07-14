using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashTestScheduler.Entity.ViewModel
{
    public class TestLabViewModel
    {
        public string TestLaboratoryId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public bool OpenOnWeekends { get; set; }
        public bool Active { get; set; }
    }
}
