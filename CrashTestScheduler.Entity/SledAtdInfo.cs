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
    // SledAtdInfo
    public partial class SledAtdInfo : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int? IterationId { get; set; } // IterationId
        public string SeatingPosition { get; set; } // SeatingPosition
        public int? PositionOrder { get; set; } // PositionOrder
        public int? AtdTypeId { get; set; } // AtdTypeId
        public bool? InstrumentationLegs { get; set; } // InstrumentationLegs

        // Foreign keys
        public virtual SledIteration SledIteration { get; set; } // FK_dbo.SledAtdInfo_dbo.SledIteration_IterationId
    }

}
