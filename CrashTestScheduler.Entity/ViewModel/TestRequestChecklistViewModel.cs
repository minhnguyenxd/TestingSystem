using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashTestScheduler.Entity.ViewModel
{
    public class TestRequestChecklistViewModel
    {
        public int Id { get; set; }
        public int TestRequestId { get; set; }
        public int IterationId { get; set; }
        public int ChecklistDataId { get; set; }
        public string UserInput { get; set; }
        public bool Verified { get; set; }
        public bool SecondApproval { get; set; }
        public string VerifyerName { get; set; }
        public string VerifyerNameDisplay { get; set; }
        public string ApproverName { get; set; }
        public Nullable<int> SequenceNo { get; set; }
        //from checklist data
        public string Type { get; set; } //Mech, Inst, Final, Post-Test
        public string Description { get; set; } //chcklist question
        public bool SecondApprovalNeeded { get; set; }
        public bool NeedsInput { get; set; }
        public string TextBoxLabel { get; set; }
        public string Unit { get; set; }
        public string Source { get; set; }
        public bool IncludeInPostTest { get; set; }
        public string MapColumn { get; set; }
        public String DisplayType { get; set; }
        public string VerifiedStatus
        {
            get
            {
                return Verified ? "Verified" : string.Empty;
            }
        }

        public string ApprovedStatus
        {
            get
            {
                return SecondApproval ? "Approved" : string.Empty;
            }
        }
    }
}
