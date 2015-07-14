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
    // ChecklistTestPlan
    public partial class ChecklistTestPlan : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int TestRequestId { get; set; } // TestRequestId
        public int ChecklistDataId { get; set; } // ChecklistDataId
        public string UserInput { get; set; } // UserInput
        public bool Verified { get; set; } // Verified
        public bool SecondApproval { get; set; } // SecondApproval
        public string VerifyerName { get; set; } // VerifyerName
        public string ApproverName { get; set; } // ApproverName
        public int SequenceNo { get; set; } // SequenceNo
        public int? IterationId { get; set; } // IterationId

        // Foreign keys
        public virtual ChecklistData ChecklistData { get; set; } // FK_dbo.ChecklistTestPlan_dbo.ChecklistData_ChecklistDataId
        public virtual SledIteration SledIteration { get; set; } // FK_dbo_ChecklistTestPlan_SledIteration_IterationId
        public virtual TestRequest TestRequest { get; set; } // FK_dbo.ChecklistTestPlan_dbo.TestRequest_TestRequestId
    }

}
