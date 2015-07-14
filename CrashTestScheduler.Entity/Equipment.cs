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
    // Equipment
    public partial class Equipment : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public string EquipmentName { get; set; } // EquipmentName
        public int MaintenanceSchedule { get; set; } // MaintenanceSchedule
        public DateTime? LastCalibrationDate { get; set; } // LastCalibrationDate
        public DateTime NextCalibrationDate { get; set; } // NextCalibrationDate
        public bool NotifyPic { get; set; } // NotifyPIC
        public bool IsActive { get; set; } // IsActive
        public string CreatedBy { get; set; } // CreatedBy
        public DateTime CreatedDate { get; set; } // CreatedDate
        public DateTime? LastUpdatedDate { get; set; } // LastUpdatedDate
        public string UpdatedBy { get; set; } // UpdatedBy

        // Reverse navigation
        public virtual ICollection<EquipmentEvent> EquipmentEvents { get; set; } // EquipmentEvent.FK_EquipmentEvent_Equipment
        public virtual ICollection<EquipmentPic> EquipmentPics { get; set; } // EquipmentPic.FK_EquipmentPic_Equipment

        public Equipment()
        {
            CreatedDate = System.DateTime.Now;
            EquipmentEvents = new List<EquipmentEvent>();
            EquipmentPics = new List<EquipmentPic>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
