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
    // SledScheduleTest
    public partial class SledScheduleTest : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int? TestRequestId { get; set; } // TestRequestId
        public DateTime? TestSchduleDate { get; set; } // TestSchduleDate
        public DateTime? TestCompleteDate { get; set; } // TestCompleteDate
        public int? SequenceNo { get; set; } // SequenceNo

        // Reverse navigation
        public virtual ICollection<SledResult> SledResults { get; set; } // SledResult.FK_dbo.SledResult_dbo.SledScheduleTest_SledScheduleTestId

        // Foreign keys
        public virtual Project Project { get; set; } // FK_dbo.SledScheduleTest_dbo.SledTestRequest_TestRequestId

        public SledScheduleTest()
        {
            SledResults = new List<SledResult>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
