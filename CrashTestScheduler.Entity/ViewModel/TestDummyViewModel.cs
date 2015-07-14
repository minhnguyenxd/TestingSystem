using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashTestScheduler.Entity.ViewModel
{
    public class TestDummyViewModel
    {
        public string Id { get; set; }
        public string SeatRowId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public bool HasLegs { get; set; }
        public bool Belted { get; set; }
    }
}
