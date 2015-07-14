using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashTestScheduler.Entity.ViewModel
{
    public class SeatRowViewModel
    {
        public string Id { get; set; }
        public string RequestGenInfoId { get; set; }
        public int RowNumber { get; set; } //order
        public List<TestDummyViewModel> Dummies { get; set; }
    }
}
