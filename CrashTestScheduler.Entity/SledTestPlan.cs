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
    // SledTestPlan
    public partial class SledTestPlan : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int? IterationId { get; set; } // IterationId
        public int? Speed { get; set; } // Speed
        public int? TestId { get; set; } // TestId
        public int? Row { get; set; } // Row
        public string Angle { get; set; } // Angle
        public int? PosType { get; set; } // PosType
        public int? PosAtdTypeId { get; set; } // PosAtdTypeId
        public int? Pos2Type { get; set; } // Pos2Type
        public int? Pos2AtdTypeId { get; set; } // Pos2AtdTypeId
        public int? Pos3Type { get; set; } // Pos3Type
        public int? Pos3AtdTypeId { get; set; } // Pos3AtdTypeId
        public bool IsPosTtfFilled { get; set; } // IsPosTtfFilled
        public bool IsPos2TtfFilled { get; set; } // IsPos2TtfFilled
        public bool IsPos3TtfFilled { get; set; } // IsPos3TtfFilled

        // Foreign keys
        public virtual AtdType AtdType_Pos2AtdTypeId { get; set; } // FK_SledTestPlan_AtdType1
        public virtual AtdType AtdType_Pos3AtdTypeId { get; set; } // FK_SledTestPlan_AtdType2
        public virtual AtdType AtdType_PosAtdTypeId { get; set; } // FK_SledTestPlan_AtdType
        public virtual SledIteration SledIteration { get; set; } // SledIteration_TesPlan_FK_IterationId

        public SledTestPlan()
        {
            IsPosTtfFilled = false;
            IsPos2TtfFilled = false;
            IsPos3TtfFilled = false;
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
