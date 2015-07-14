using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashTestScheduler.Entity.ViewModel
{
    public class SledSignalViewModel
    {
        public int Id { get; set; }
        public int TestRequestId { get; set; }
        public int SignalLocationId { get; set; }
        public string SignaLocation { get; set; }
        public string Name { get; set; }
    }
}
