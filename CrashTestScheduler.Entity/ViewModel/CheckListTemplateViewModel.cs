using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashTestScheduler.Entity.ViewModel
{
    public class CheckListTemplateViewModel
    {
        public int Id { get; set; }
        public int TemplateId { get; set; }
        public int CheckListDataId { get; set; }
        public string Type { get; set; } //Mech, Inst, Final, Post-Test
        public string Description { get; set; } //chcklist question
        public bool SecondApproval { get; set; }
        public bool NeedsInput { get; set; }
        public string TextBoxLabel { get; set; }
        public string Unit { get; set; }
        public bool Selected { get; set; }
        public string Source { get; set; }
        public bool IncludeInPostTest { get; set; }
        public int SequenceNo { get; set; }
        public string displayText { get; set; }

        public string DisplayType { get; set; }
    }
}
