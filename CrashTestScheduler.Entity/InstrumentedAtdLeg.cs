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
    // InstrumentedATDLegs
    public partial class InstrumentedAtdLeg : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int AtdTypeId { get; set; } // AtdTypeId
        public string SerialNumber { get; set; } // SerialNumber
        public bool? IsDeleted { get; set; } // IsDeleted
        public DateTime? DeletedDate { get; set; } // DeletedDate
        public string DeletedBy { get; set; } // DeletedBy

        // Foreign keys
        public virtual AtdType AtdType { get; set; } // FK_dbo.InstrumentedATDLegs_dbo.AtdType_AtdTypeId
    }

}
