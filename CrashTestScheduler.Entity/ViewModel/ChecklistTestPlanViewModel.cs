using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashTestScheduler.Entity.ViewModel
{
    //please use TestRequestChecklistViewModel
    public class ChecklistTestPlanViewModel
    {
        public int Id { get; set; }
        public int TestRequestId { get; set; }
        public int IterationId { get; set; }
        public int ChecklistDataId { get; set; }
        public string Type { get; set; } //Mech, Inst, Final, Post-Test
        public string Description { get; set; } //chcklist question
        public int SequenceNo { get; set; }
        public bool Verified { get; set; }
        public bool SecondApproval { get; set; }
        public bool NeedsInput { get; set; }
        public string TextBoxLabel { get; set; }
        public string UserInput { get; set; }
        public string Unit { get; set; }
        public string Source { get; set; }
        public string DisplayType { get; set; }
    }
}
