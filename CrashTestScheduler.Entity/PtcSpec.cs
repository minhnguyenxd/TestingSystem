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
    // PtcSpecs
    public partial class PtcSpec : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int TestRequestId { get; set; } // TestRequestId
        public string FileAttachmentPath { get; set; } // FileAttachmentPath
        public bool? IsSubmitted { get; set; } // IsSubmitted
        public string CreatedBy { get; set; } // CreatedBy
        public DateTime CreatedDate { get; set; } // CreatedDate
        public string UpdatedBy { get; set; } // UpdatedBy
        public DateTime? LastUpdatedDate { get; set; } // LastUpdatedDate

        // Foreign keys
        public virtual TestRequest TestRequest { get; set; } // FK_dbo.PtcSpecs_dbo.TestRequest_TestRequestId

        public PtcSpec()
        {
            IsSubmitted = false;
            CreatedBy = "N'System'";
            CreatedDate = System.DateTime.Now;
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
