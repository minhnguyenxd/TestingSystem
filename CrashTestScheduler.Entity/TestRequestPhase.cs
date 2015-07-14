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
    // TestRequestPhase
    public partial class TestRequestPhase : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name
        public int? CalendarTypeId { get; set; } // CalendarTypeId

        // Foreign keys
        public virtual CalendarType CalendarType { get; set; } // FK_dbo.TestRequestPhase_dbo.CalendarType_CalendarTypeId
    }

}
