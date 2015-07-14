using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashTestScheduler.Entity.ViewModel
{
    public class RequestTabStateViewModel
    {
        public int Id { get; set; }
        public int TabId { get; set; }
        public int TestRequestId { get; set; }
        public string TabName { get; set; }
        public bool Completed { get; set; }
        public string CompletedBy { get; set; }
    }
}
