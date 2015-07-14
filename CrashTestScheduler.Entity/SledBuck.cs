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
    // SledBuck
    public partial class SledBuck : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name
        public bool? IsDestroyed { get; set; } // IsDestroyed
        public DateTime? DestroyedDate { get; set; } // DestroyedDate
        public string DestroyedBy { get; set; } // DestroyedBy
        public string Location { get; set; } // Location
        public string SeatFixture { get; set; } // SeatFixture
        public decimal? SledMass { get; set; } // SledMass
        public string SledType { get; set; } // SledType
        public string Capability { get; set; } // Capability
        public int? BuildLevelId { get; set; } // BuildLevelId
        public DateTime? CreatedDate { get; set; } // CreatedDate
        public string CreatedBy { get; set; } // CreatedBy
        public DateTime? LastUpdatedDate { get; set; } // LastUpdatedDate
        public string LastUpdatedBy { get; set; } // LastUpdatedBy

        // Reverse navigation
        public virtual ICollection<SledBuckQuadrantMap> SledBuckQuadrantMaps { get; set; } // SledBuckQuadrantMap.FK_SledBuckQuadrantMap_SledBuck
        public virtual ICollection<SledTestRequest> SledTestRequests { get; set; } // SledTestRequest.FK_dbo.SledTestRequest_dbo.SledBuck_BuckId

        // Foreign keys
        public virtual BuildLevel BuildLevel { get; set; } // FK_SledBuck_BuildLevel

        public SledBuck()
        {
            SledBuckQuadrantMaps = new List<SledBuckQuadrantMap>();
            SledTestRequests = new List<SledTestRequest>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
