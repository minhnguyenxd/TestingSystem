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
    // SledBuckQuadrantMap
    public partial class SledBuckQuadrantMap : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int SledBuckId { get; set; } // SledBuckId
        public int QuadrantId { get; set; } // QuadrantId

        // Foreign keys
        public virtual Quadrant Quadrant { get; set; } // FK_SledBuckQuadrantMap_Quadrant
        public virtual SledBuck SledBuck { get; set; } // FK_SledBuckQuadrantMap_SledBuck
    }

}
