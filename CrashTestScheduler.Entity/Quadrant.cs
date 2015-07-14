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
    // Quadrant
    public partial class Quadrant : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int? SledBuckId { get; set; } // SledBuckId
        public string Name { get; set; } // Name
        public decimal? Mass { get; set; } // Mass

        // Reverse navigation
        public virtual ICollection<SledBuckQuadrantMap> SledBuckQuadrantMaps { get; set; } // SledBuckQuadrantMap.FK_SledBuckQuadrantMap_Quadrant

        public Quadrant()
        {
            SledBuckQuadrantMaps = new List<SledBuckQuadrantMap>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
