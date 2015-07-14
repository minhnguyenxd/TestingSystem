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
    // SledBlock
    public partial class SledBlock : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int? TestRequestId { get; set; } // TestRequestId
        public DateTime? ScheduleStartDate { get; set; } // ScheduleStartDate
        public DateTime? ScheduleEndDate { get; set; } // ScheduleEndDate

        // Foreign keys
        public virtual TestRequest TestRequest { get; set; } // FK_SledBlock_TestRequest
    }

}
