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
    // TestRequestComment
    public partial class TestRequestComment : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int TestRequestId { get; set; } // TestRequestId
        public string Comment { get; set; } // Comment
        public string CreatedBy { get; set; } // CreatedBy
        public DateTime CreatedDate { get; set; } // CreatedDate
        public string UpdatedBy { get; set; } // UpdatedBy
        public DateTime? UpdatedDate { get; set; } // UpdatedDate

        // Foreign keys
        public virtual TestRequest TestRequest { get; set; } // FK_dbo.TestRequestComment_dbo.TestRequest_TestRequestId
    }

}
