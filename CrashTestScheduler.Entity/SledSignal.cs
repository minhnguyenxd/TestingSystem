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
    // SledSignal
    public partial class SledSignal : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int? SignalLocationId { get; set; } // SignalLocationId
        public string Name { get; set; } // Name
        public int? IterationId { get; set; } // IterationId

        // Foreign keys
        public virtual SignalLocation SignalLocation { get; set; } // FK_dbo.SledSignal_dbo.SignalLocation_SignalLocationId
        public virtual SledIteration SledIteration { get; set; } // FK_SledSignal_SledIteration
    }

}
