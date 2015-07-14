#region

using System;



#endregion

namespace CrashTestScheduler.Entity.ViewModel
{



    public class ApprovalViewModel
    {
        public int Id { get; set; } // Id (Primary key)
        public int TestRequestId { get; set; } // TestRequestId
        public string ApproverType { get; set; } // ApproverType
        public string ApproverId { get; set; } // ApproverId
        public string ApproverName { get; set; } // Approver Display Name
        public string ApprovalStatus { get; set; } // ApprovalStatus
        public DateTime? LastUpdatedDate { get; set; } // LastUpdatedDate
        public string Comments { get; set; } // Comments
        public bool IsActive { get; set; } // IsActive
        public bool IsApprover { get; set; }
    }
}
