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
    // Attachments
    public partial class Attachment : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int TestRequestId { get; set; } // TestRequestId
        public string FileAttachmentPath { get; set; } // FileAttachmentPath
        public bool? IsSubmitted { get; set; } // IsSubmitted
        public string CreatedBy { get; set; } // CreatedBy
        public DateTime CreatedDate { get; set; } // CreatedDate
        public string UpdatedBy { get; set; } // UpdatedBy
        public DateTime? LastUpdatedDate { get; set; } // LastUpdatedDate
        public string Type { get; set; } // Type

        // Foreign keys
        public virtual TestRequest TestRequest { get; set; } // FK_dbo.Attachments_dbo.TestRequest_TestRequestId
    }

}
