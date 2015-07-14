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
    // TestPlanFields
    public partial class TestPlanField : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int TestRequestId { get; set; } // TestRequestId
        public string FieldName { get; set; } // FieldName
        public bool Selected { get; set; } // Selected

        // Foreign keys
        public virtual TestRequest TestRequest { get; set; } // FK_dbo.TestPlanFields_dbo.TestRequest_TestRequestId
    }

}
