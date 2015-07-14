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
    // TestPlanTemplate
    public partial class TestPlanTemplate : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int TestTypeId { get; set; } // TestTypeId
        public int TestModeId { get; set; } // TestModeId
        public string TestMode { get; set; } // TestMode
        public string ImpactSide { get; set; } // ImpactSide
        public string ImpactLocation { get; set; } // ImpactLocation
        public string ImpactPoint { get; set; } // ImpactPoint
        public string ImpactBarrier { get; set; } // ImpactBarrier
        public decimal? ImpactSpeed { get; set; } // ImpactSpeed
        public decimal? PreferredImpactSpeed { get; set; } // PreferredImpactSpeed
        public decimal? LowLimit { get; set; } // LowLimit
        public decimal? HighLimit { get; set; } // HighLimit
        public string StickerNomenclature { get; set; } // StickerNomenclature
        public bool? RollOver { get; set; } // RollOver
        public decimal? FuelPercent { get; set; } // FuelPercent
        public decimal? FuelCapacity { get; set; } // FuelCapacity
        public decimal? TestFuelAmount { get; set; } // TestFuelAmount
        public string FuelTankContents { get; set; } // FuelTankContents
        public string TestWeightMethod { get; set; } // TestWeightMethod
        public decimal? FrontCurbWt { get; set; } // FrontCurbWt
        public decimal? RearCurbWt { get; set; } // RearCurbWt
        public decimal? TotalCurbWt { get; set; } // TotalCurbWt
        public decimal? FrontTestWt { get; set; } // FrontTestWt
        public decimal? RearTestWt { get; set; } // RearTestWt
        public decimal? TotalTestWt { get; set; } // TotalTestWt
        public decimal? FrontTirePressure { get; set; } // FrontTirePressure
        public decimal? RearTirePressure { get; set; } // RearTirePressure
        public decimal? SpareTirePressure { get; set; } // SpareTirePressure
        public short? SrsStatus { get; set; } // SRSStatus
        public bool? LeftFrontPrimaryAirBagSrs { get; set; } // LeftFrontPrimaryAirBagSRS
        public bool? LeftFrontPrimaryAirBagPu { get; set; } // LeftFrontPrimaryAirBagPU
        public bool? LeftFrontSecondaryAirBagSrs { get; set; } // LeftFrontSecondaryAirBagSRS
        public bool? LeftFrontSecondaryAirBagPu { get; set; } // LeftFrontSecondaryAirBagPU
        public bool? LeftOuterBeltSrs { get; set; } // LeftOuterBeltSRS
        public bool? LeftOuterBeltPu { get; set; } // LeftOuterBeltPU
        public bool? LeftSideAirBagSrs { get; set; } // LeftSideAirBagSRS
        public bool? LeftSideAirBagPu { get; set; } // LeftSideAirBagPU
        public bool? LeftSideCurtainAirBagSrs { get; set; } // LeftSideCurtainAirBagSRS
        public bool? LeftSideCurtainAirBagPu { get; set; } // LeftSideCurtainAirBagPU
        public bool? LeftInnerBuckleSrs { get; set; } // LeftInnerBuckleSRS
        public bool? LeftInnerBucklePu { get; set; } // LeftInnerBucklePU
        public bool? LeftOuterLapSrs { get; set; } // LeftOuterLapSRS
        public bool? LeftOuterLapPu { get; set; } // LeftOuterLapPU
        public bool? LeftKneePrimarySrs { get; set; } // LeftKneePrimarySRS
        public bool? LeftKneePrimaryPu { get; set; } // LeftKneePrimaryPU
        public bool? RightFrontPrimaryAirBagSrs { get; set; } // RightFrontPrimaryAirBagSRS
        public bool? RightFrontPrimaryAirBagPu { get; set; } // RightFrontPrimaryAirBagPU
        public bool? RightFrontSecondaryAirBagSrs { get; set; } // RightFrontSecondaryAirBagSRS
        public bool? RightFrontSecondaryAirBagPu { get; set; } // RightFrontSecondaryAirBagPU
        public bool? RightOuterBeltSrs { get; set; } // RightOuterBeltSRS
        public bool? RightOuterBeltPu { get; set; } // RightOuterBeltPU
        public bool? RightSideAirBagSrs { get; set; } // RightSideAirBagSRS
        public bool? RightSideAirBagPu { get; set; } // RightSideAirBagPU
        public bool? RightSideCurtainAirBagSrs { get; set; } // RightSideCurtainAirBagSRS
        public bool? RightSideCurtainAirBagPu { get; set; } // RightSideCurtainAirBagPU
        public bool? RightInnerBuckleSrs { get; set; } // RightInnerBuckleSRS
        public bool? RightInnerBucklePu { get; set; } // RightInnerBucklePU
        public bool? RightOuterLapSrs { get; set; } // RightOuterLapSRS
        public bool? RightOuterLapPu { get; set; } // RightOuterLapPU
        public bool? RightKneePrimarySrs { get; set; } // RightKneePrimarySRS
        public bool? RightKneePrimaryPu { get; set; } // RightKneePrimaryPU
        public string PostTestLocation { get; set; } // PostTestLocation
        public bool? VehicleReqAddtlTest { get; set; } // VehicleReqAddtlTest
        public bool? ProCam { get; set; } // ProCam
        public bool? Fmvss212WindshieldRetention { get; set; } // FMVSS_212_WindshieldRetention
        public bool? FaroArmReqForDummy { get; set; } // FARO_ArmReqForDummy
        public bool? Fmvss219PartialWindshield { get; set; } // FMVSS_219_PartialWindshield
        public bool? Fmvss219FullWindshield { get; set; } // FMVSS_219_FullWindshield
        public short? Paint { get; set; } // Paint
        public string PaintInstruction { get; set; } // PaintInstruction
        public byte? MoonRoofOpen { get; set; } // MoonRoofOpen
        public bool? WindowsOpen { get; set; } // WindowsOpen
        public string FrontPit { get; set; } // FrontPit
        public string RearPit { get; set; } // RearPit
        public bool? IsDeleted { get; set; } // IsDeleted
        public DateTime? DeletedDate { get; set; } // DeletedDate
        public string DeletedBy { get; set; } // DeletedBy
        public DateTime CreatedDate { get; set; } // CreatedDate
        public string CreatedBy { get; set; } // CreatedBy
        public DateTime? LastUpdatedDate { get; set; } // LastUpdatedDate
        public string UpdatedBy { get; set; } // UpdatedBy
        public bool? AirbagFireSystem { get; set; } // AirbagFireSystem
        public int? TestWeightMethodId { get; set; } // TestWeightMethodId
        public int? Hits { get; set; } // Hits
        public decimal? VehicleWeightFront { get; set; } // VehicleWeightFront
        public decimal? VehicleWeightRear { get; set; } // VehicleWeightRear
        public decimal? PendulumWeight { get; set; } // PendulumWeight
        public bool? IsActive { get; set; } // IsActive
        public bool? Fmvss305 { get; set; } // Fmvss305
        public string PostTestLocationOther { get; set; } // PostTestLocationOther
        public string ImpactPointPosition { get; set; } // ImpactPointPosition

        // Reverse navigation
        public virtual ICollection<ChecklistTemplateMap> ChecklistTemplateMaps { get; set; } // ChecklistTemplateMap.FK_ChecklistTemplateMap_TestPlanTemplate1
        public virtual ICollection<PictureTemplateMap> PictureTemplateMaps { get; set; } // PictureTemplateMap.FK_PictureTemplateMap_TestPlanTemplate
        public virtual ICollection<SrsTemplateMap> SrsTemplateMaps { get; set; } // SRSTemplateMap.FK_SRSTemplateMap_TestPlanTemplate
        public virtual ICollection<TemplateInstrumentationChannel> TemplateInstrumentationChannels { get; set; } // TemplateInstrumentationChannel.FK_dbo.TemplateInstrumentationChannel_dbo.TestPlanTemplate_TemplateId
        public virtual ICollection<TemplateSrsSetting> TemplateSrsSettings { get; set; } // TemplateSRSSetting.FK_dbo.TemplateSRSSetting_dbo.TestPlanTemplate_TemplateId
        public virtual ICollection<TestModeTypeTemplateMap> TestModeTypeTemplateMaps { get; set; } // TestModeTypeTemplateMap.FK_dbo.TestModeTypeTemplateMap_dbo.TestPlanTemplate_TestPlanTemplateId
        public virtual ICollection<TestPlanTemplateField> TestPlanTemplateFields { get; set; } // TestPlanTemplateFields.FK_dbo.TestPlanTemplateFields_dbo.TestPlanTemplate_TestPlanTemplateId
        public virtual ICollection<VideoTemplateMap> VideoTemplateMaps { get; set; } // VideoTemplateMap.FK_dbo.VideoTemplateMap_dbo.TestPlanTemplate_TemplateId

        // Foreign keys
        public virtual TestWeightMethod TestWeightMethod_TestWeightMethodId { get; set; } // FK_TestPlanTemplate_TestWeightMethod

        public TestPlanTemplate()
        {
            ChecklistTemplateMaps = new List<ChecklistTemplateMap>();
            PictureTemplateMaps = new List<PictureTemplateMap>();
            SrsTemplateMaps = new List<SrsTemplateMap>();
            TemplateInstrumentationChannels = new List<TemplateInstrumentationChannel>();
            TemplateSrsSettings = new List<TemplateSrsSetting>();
            TestModeTypeTemplateMaps = new List<TestModeTypeTemplateMap>();
            TestPlanTemplateFields = new List<TestPlanTemplateField>();
            VideoTemplateMaps = new List<VideoTemplateMap>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
