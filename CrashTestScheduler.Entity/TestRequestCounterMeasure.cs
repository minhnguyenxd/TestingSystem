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
    // TestRequestCounterMeasure
    public partial class TestRequestCounterMeasure : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int TestRequestId { get; set; } // TestRequestId
        public int SequenceId { get; set; } // SequenceId
        public string CounterMeasure { get; set; } // CounterMeasure
        public bool Completed { get; set; } // Completed
        public string VerifiedBy { get; set; } // VerifiedBy
        public int? SequenceNo { get; set; } // SequenceNo

        // Foreign keys
        public virtual TestRequest TestRequest { get; set; } // FK_dbo.TestRequestCounterMeasure_dbo.TestRequest_TestRequestId
    }

}
