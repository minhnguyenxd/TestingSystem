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
    // SledPostSummary
    public partial class SledPostSummary : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int? IterationId { get; set; } // IterationId
        public bool? TestAnomaly { get; set; } // TestAnomaly
        public bool? TestMiss { get; set; } // TestMiss
        public bool? DataOnChim { get; set; } // DataOnChim
        public string DataLocation { get; set; } // DataLocation
        public string TestEntryComments { get; set; } // TestEntryComments
        public string ResultComments { get; set; } // ResultComments
        public string SledOperator { get; set; } // SledOperator
        public string Comments { get; set; } // Comments

        // Foreign keys
        public virtual SledIteration SledIteration { get; set; } // FK_SledPostSummary_SledPostSummary
    }

}
