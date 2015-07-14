// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier

using System;
using Repository;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrashTestScheduler.Entity.Model
{
    // Approval
    public partial class Approval : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int TestRequestId { get; set; } // TestRequestId
        public string ApproverType { get; set; } // ApproverType
        public string ApproverId { get; set; } // ApproverId
        public string ApprovalStatus { get; set; } // ApprovalStatus
        public DateTime? LastUpdatedDate { get; set; } // LastUpdatedDate
        public string Comments { get; set; } // Comments
        public bool IsActive { get; set; } // IsActive

        // Foreign keys
        public virtual TestRequest TestRequest { get; set; } // FK_Approval_TestRequest
    }

}
