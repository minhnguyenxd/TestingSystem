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
    // EquipmentPic
    public partial class EquipmentPic : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int EquipmentId { get; set; } // EquipmentId
        public string PicId { get; set; } // PicId

        // Foreign keys
        public virtual Equipment Equipment { get; set; } // FK_EquipmentPic_Equipment
    }

}
