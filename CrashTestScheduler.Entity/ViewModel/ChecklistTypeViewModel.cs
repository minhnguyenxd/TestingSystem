using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashTestScheduler.Entity.ViewModel
{
   public class ChecklistTypeViewModel
    {
        public  int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // CheckListTypes
        public bool IsSelected { get; set; }
    }
}
