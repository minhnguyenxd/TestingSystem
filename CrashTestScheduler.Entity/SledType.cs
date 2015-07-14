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
    // SledType
    public partial class SledType : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name
        public bool? IsDeleted { get; set; } // IsDeleted
        public DateTime? DeletedDate { get; set; } // DeletedDate
        public string DeletedBy { get; set; } // DeletedBy

        // Reverse navigation
        public virtual ICollection<SledTestRequest> SledTestRequests { get; set; } // SledTestRequest.FK_dbo.SledTestRequest_dbo.SledType_SledTypeId

        public SledType()
        {
            SledTestRequests = new List<SledTestRequest>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
