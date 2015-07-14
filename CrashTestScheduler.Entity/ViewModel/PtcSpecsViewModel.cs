using System.Collections.Generic;

namespace CrashTestScheduler.Entity.ViewModel
{
    public class PtcSpecsViewModel
    {
        public int Id { get; set; }
        public int TestRequestId { get; set; }
        public string FileAttachmentPath { get; set; }
        public bool? IsSubmitted { get; set; }
        public bool IsActive { get; set; }
        public bool IsApprover { get; set; }
        public List<ApprovalViewModel> Approvals { get; set; }
    }
}
