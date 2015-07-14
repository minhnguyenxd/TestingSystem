using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashTestScheduler.Entity.ViewModel
{
    public class TestDetailViewModel
    {
        public String Name { get; set; }
        public int Count { get; set; }

        public IEnumerable<TodayTestViewModel> TodayTests { get; set; }
    }
}
