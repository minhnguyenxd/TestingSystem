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
    // SRSTemplateMap
    public partial class SrsTemplateMap : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int TemplateId { get; set; } // TemplateId
        public int SrsId { get; set; } // SRSId
        public string LeftTtf { get; set; } // LeftTTF
        public bool LeftPickup { get; set; } // LeftPickup
        public bool LeftSquib { get; set; } // LeftSquib
        public string RightTtf { get; set; } // RightTTF
        public bool RightPickup { get; set; } // RightPickup
        public bool RightSquib { get; set; } // RightSquib
        public bool IsActive { get; set; } // IsActive

        // Foreign keys
        public virtual SrsSetting SrsSetting { get; set; } // FK_SRSTemplateMap_SRSSetting
        public virtual TestPlanTemplate TestPlanTemplate { get; set; } // FK_SRSTemplateMap_TestPlanTemplate

        public SrsTemplateMap()
        {
            IsActive = false;
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
