using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashTestScheduler.Entity.ViewModel
{
   public class VerifyCounterMeasureViewModel
    {
       public int Id { get; set; }
       public bool Selected { get; set; }

       public string VerifiedBy { get; set; }
    }
}
