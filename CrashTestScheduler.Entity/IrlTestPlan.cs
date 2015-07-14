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
    // IrlTestPlan
    public partial class IrlTestPlan : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int? IterationId { get; set; } // IterationId
        public int? TestId { get; set; } // TestId
        public string Row { get; set; } // Row
        public string Position { get; set; } // Position
        public string Temperature { get; set; } // Temperature
        public int? PosType { get; set; } // PosType
        public int? PosAtdTypeId { get; set; } // PosAtdTypeId
        public int? SerialNo { get; set; } // SerialNo
        public bool? IsPosTtfFilled { get; set; } // IsPosTtfFilled

        // Foreign keys
        public virtual AtdType AtdType { get; set; } // FK_IrlTestPlan_AtdType
        public virtual SledIteration SledIteration { get; set; } // SledIteration_IrlTesPlan_FK_IterationId
    }

}
