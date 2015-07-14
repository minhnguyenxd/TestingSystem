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
    // SledPulseInfo
    public partial class SledPulseInfo : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int? IterationId { get; set; } // IterationId
        public string Pulse { get; set; } // Pulse
        public int? LocationId { get; set; } // LocationId
        public string Name { get; set; } // Name

        // Foreign keys
        public virtual SignalLocation SignalLocation { get; set; } // FK_SledPulseInfo_SignalLocation
        public virtual SledIteration SledIteration { get; set; } // FK_SledPulseInfo_SledIteration
    }

}
