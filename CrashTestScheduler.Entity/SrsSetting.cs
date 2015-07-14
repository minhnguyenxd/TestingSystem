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
    // SRSSetting
    public partial class SrsSetting : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name
        public bool IsDeleted { get; set; } // IsDeleted
        public int? LeftChannelId { get; set; } // LeftChannelId
        public int? RightChannelId { get; set; } // RightChannelId

        // Reverse navigation
        public virtual ICollection<SrsTemplateMap> SrsTemplateMaps { get; set; } // SRSTemplateMap.FK_SRSTemplateMap_SRSSetting
        public virtual ICollection<SrsTestPlanMap> SrsTestPlanMaps { get; set; } // SRSTestPlanMap.FK_SRSTestPlanMap_SRSSetting

        // Foreign keys
        public virtual Channel Channel_LeftChannelId { get; set; } // FK_SRSSetting_ChannelLeft
        public virtual Channel Channel_RightChannelId { get; set; } // FK_SRSSetting_ChannelRight

        public SrsSetting()
        {
            SrsTemplateMaps = new List<SrsTemplateMap>();
            SrsTestPlanMaps = new List<SrsTestPlanMap>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
