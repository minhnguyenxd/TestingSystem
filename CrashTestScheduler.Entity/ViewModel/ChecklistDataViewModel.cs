using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashTestScheduler.Entity.ViewModel
{
    public class ChecklistDataViewModel
    {
        public int Id { get; set; }
        public string Type { get; set; } //Mech, Inst, Final, Post-Test
        public string Description { get; set; } //chcklist question
        public bool SecondApproval { get; set; }
        public bool NeedsInput { get; set; }
        public string TextBoxLabel { get; set; }
        public string Unit { get; set; }
        public string Source { get; set; }
    }
}
