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
    // SledPosition
    public partial class SledPosition : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int? IterationId { get; set; } // IterationId
        public int? PositionOrder { get; set; } // PositionOrder
        public int? TypeId { get; set; } // TypeId
        public decimal? Pri { get; set; } // Pri
        public decimal? Sec { get; set; } // Sec
        public decimal? Elr { get; set; } // Elr
        public decimal? Oltp { get; set; } // OLTP
        public decimal? Kab { get; set; } // KAB
        public decimal? Sab { get; set; } // SAB
        public decimal? Scap { get; set; } // SCAP
        public decimal? Av { get; set; } // AV
        public decimal? Buck { get; set; } // Buck
        public string Other { get; set; } // Other
        public bool IsTestPlan { get; set; } // IsTestPlan
        public int? TestPlanPositionId { get; set; } // TestPlanPositionId
        public string AtdSerialNumber { get; set; } // AtdSerialNumber

        // Foreign keys
        public virtual SledIteration SledIteration { get; set; } // FK_dbo.SledPosition_dbo.SledIteration_IterationId

        public SledPosition()
        {
            IsTestPlan = true;
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
