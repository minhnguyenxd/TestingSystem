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
    // EquipmentEvent
    public partial class EquipmentEvent : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int EquipmentId { get; set; } // EquipmentId
        public int EventType { get; set; } // EventType
        public string Comments { get; set; } // Comments
        public DateTime EventDate { get; set; } // EventDate
        public string Attachment { get; set; } // Attachment
        public bool IsActive { get; set; } // IsActive
        public string CreatedBy { get; set; } // CreatedBy
        public DateTime CreatedDate { get; set; } // CreatedDate
        public DateTime? LastUpdatedDate { get; set; } // LastUpdatedDate
        public string UpdatedBy { get; set; } // UpdatedBy

        // Foreign keys
        public virtual Equipment Equipment { get; set; } // FK_EquipmentEvent_Equipment

        public EquipmentEvent()
        {
            CreatedDate = System.DateTime.Now;
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
