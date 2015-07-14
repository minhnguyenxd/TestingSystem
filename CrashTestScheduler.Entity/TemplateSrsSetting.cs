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
    // TemplateSRSSetting
    public partial class TemplateSrsSetting : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int TemplateId { get; set; } // TemplateId
        public string LeftFrontPrimaryAirBagTtf { get; set; } // LeftFrontPrimaryAirBagTTF
        public bool LeftFrontPrimaryAirBagPickup { get; set; } // LeftFrontPrimaryAirBagPickup
        public bool LeftFrontPrimaryAirBagSquib { get; set; } // LeftFrontPrimaryAirBagSquib
        public string LeftFrontSecondaryAirBagTtf { get; set; } // LeftFrontSecondaryAirBagTTF
        public bool LeftFrontSecondaryAirBagPickup { get; set; } // LeftFrontSecondaryAirBagPickup
        public bool LeftFrontSecondaryAirBagSquib { get; set; } // LeftFrontSecondaryAirBagSquib
        public string LeftOuterBeltTtf { get; set; } // LeftOuterBeltTTF
        public bool LeftOuterBeltPickup { get; set; } // LeftOuterBeltPickup
        public bool LeftOuterBeltSquib { get; set; } // LeftOuterBeltSquib
        public string LeftSideAirBagTtf { get; set; } // LeftSideAirBagTTF
        public bool LeftSideAirBagPickup { get; set; } // LeftSideAirBagPickup
        public bool LeftSideAirBagSquib { get; set; } // LeftSideAirBagSquib
        public string LeftSideCurtainAirBagTtf { get; set; } // LeftSideCurtainAirBagTTF
        public bool LeftSideCurtainAirBagPickup { get; set; } // LeftSideCurtainAirBagPickup
        public bool LeftSideCurtainAirBagSquib { get; set; } // LeftSideCurtainAirBagSquib
        public string LeftInnerBuckleTtf { get; set; } // LeftInnerBuckleTTF
        public bool LeftInnerBucklePickup { get; set; } // LeftInnerBucklePickup
        public bool LeftInnerBuckleSquib { get; set; } // LeftInnerBuckleSquib
        public string LeftOuterLapTtf { get; set; } // LeftOuterLapTTF
        public bool LeftOuterLapPickup { get; set; } // LeftOuterLapPickup
        public bool LeftOuterLapSquib { get; set; } // LeftOuterLapSquib
        public string LeftKneePrimaryTtf { get; set; } // LeftKneePrimaryTTF
        public bool LeftKneePrimaryPickup { get; set; } // LeftKneePrimaryPickup
        public bool LeftKneePrimarySquib { get; set; } // LeftKneePrimarySquib
        public string RightFrontPrimaryAirBagTtf { get; set; } // RightFrontPrimaryAirBagTTF
        public bool RightFrontPrimaryAirBagPickup { get; set; } // RightFrontPrimaryAirBagPickup
        public bool RightFrontPrimaryAirBagSquib { get; set; } // RightFrontPrimaryAirBagSquib
        public string RightFrontSecondaryAirBagTtf { get; set; } // RightFrontSecondaryAirBagTTF
        public bool RightFrontSecondaryAirBagPickup { get; set; } // RightFrontSecondaryAirBagPickup
        public bool RightFrontSecondaryAirBagSquib { get; set; } // RightFrontSecondaryAirBagSquib
        public string RightOuterBeltTtf { get; set; } // RightOuterBeltTTF
        public bool RightOuterBeltPickup { get; set; } // RightOuterBeltPickup
        public bool RightOuterBeltSquib { get; set; } // RightOuterBeltSquib
        public string RightSideAirBagTtf { get; set; } // RightSideAirBagTTF
        public bool RightSideAirBagPickup { get; set; } // RightSideAirBagPickup
        public bool RightSideAirBagSquib { get; set; } // RightSideAirBagSquib
        public string RightSideCurtainAirBagTtf { get; set; } // RightSideCurtainAirBagTTF
        public bool RightSideCurtainAirBagPickup { get; set; } // RightSideCurtainAirBagPickup
        public bool RightSideCurtainAirBagSquib { get; set; } // RightSideCurtainAirBagSquib
        public string RightInnerBuckleTtf { get; set; } // RightInnerBuckleTTF
        public bool RightInnerBucklePickup { get; set; } // RightInnerBucklePickup
        public bool RightInnerBuckleSquib { get; set; } // RightInnerBuckleSquib
        public string RightOuterLapTtf { get; set; } // RightOuterLapTTF
        public bool RightOuterLapPickup { get; set; } // RightOuterLapPickup
        public bool RightOuterLapSquib { get; set; } // RightOuterLapSquib
        public string RightKneePrimaryTtf { get; set; } // RightKneePrimaryTTF
        public bool RightKneePrimaryPickup { get; set; } // RightKneePrimaryPickup
        public bool RightKneePrimarySquib { get; set; } // RightKneePrimarySquib
        public bool IsDeleted { get; set; } // IsDeleted
        public DateTime? DeletedDate { get; set; } // DeletedDate
        public string DeletedBy { get; set; } // DeletedBy

        // Foreign keys
        public virtual TestPlanTemplate TestPlanTemplate { get; set; } // FK_dbo.TemplateSRSSetting_dbo.TestPlanTemplate_TemplateId
    }

}
