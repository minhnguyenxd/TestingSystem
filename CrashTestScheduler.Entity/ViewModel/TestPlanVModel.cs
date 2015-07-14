#region

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

#endregion

namespace CrashTestScheduler.Entity.ViewModel
{
    public class RequestDetailsViewModel
    {
        public string TestTypeName { get; set; }
        public string TestModeName { get; set; }
        public IEnumerable<RequestTabStateViewModel> TabState { get; set; }
        public string Id { get; set; }

    }
    
    public class TestPlanTemplateVModel
    {
        public string Id { get; set; }
        public int CalendarTypeId { get; set; }
        public int TestTypeId { get; set; }
        public int TestModeId { get; set; }
        public string TestTypeName { get; set; }
        public string TestModeName { get; set; }
        public CustomFieldSelectionViewModel FieldSelector { get; set; }
        public TestPlanVModel TestPlanInfo { get; set; }
        public SRSSettingViewModel SrsSetting { get; set; }
        public List<SRSTemplateMapViewModel> SrsSettingList { get; set; }
        
        public bool IsActive { get; set; }
    }

    public class RequestTestPlanVModel
    {
        public string Id { get; set; }
        public string RequestId { get; set; }
        public CustomFieldSelectionViewModel FieldSelector { get; set; }

        public TestPlanVModel TestPlanInfo { get; set; }
        public SRSSettingViewModel SrsSetting { get; set; }
        
        [XmlArray("SRSList")]
        public List<SRS> SRS { get; set; }
        public int TestTypeId { get; set; }
        public List<SRSTestPlanMapViewModel> SrsSettingList { get; set; }
        //public List<BumperPendulumHitViewModel> BumperPendulumHits { get; set; }
    }

    /// <summary>
    ///     shares info with testplantemplate, testplandefaults
    /// </summary>
    public class TestPlanVModel
    {
        public string TestMode { get; set; }

        public string ImpactSide { get; set; }

        public string ImpactLocation { get; set; }

        public string ImpactPoint { get; set; }

        public string ImpactPointPosition { get; set; }

        public string ImpactBarrier { get; set; }

       
        public decimal? ImpactSpeed { get; set; }

        [RegularExpression(@"^\d+\.?\d*$", ErrorMessage = "Please enter numeric values.")]
        public decimal? PreferredImpactSpeed { get; set; }

        [RegularExpression(@"^\d+\.?\d*$", ErrorMessage = "Please enter numeric values.")]
        public decimal? LowLimit { get; set; }

        [RegularExpression(@"^\d+\.?\d*$", ErrorMessage = "Please enter numeric values.")]
        public decimal? HighLimit { get; set; }

        public string StickerNomenclature { get; set; }
        public bool RollOver { get; set; }

        [Range(1.00, 100.00)]
        public decimal? FuelPercent { get; set; }

        [Range(1.00, 100.00)]
        public decimal? FuelCapacity { get; set; }

        [Range(1.00, 100.00)]
        public decimal? TestFuelAmount { get; set; }

        public string FuelTankContents { get; set; }

        public string TestWeightMethod { get; set; }

         [RegularExpression(@"^\d+\.?\d*$", ErrorMessage = "Please enter numeric values.")]
        public decimal? FrontCurbWt { get; set; }

        [RegularExpression(@"^\d+\.?\d*$", ErrorMessage = "Please enter numeric values.")]
        public decimal? RearCurbWt { get; set; }

        [RegularExpression(@"^\d+\.?\d*$", ErrorMessage = "Please enter numeric values.")]
        public decimal? TotalCurbWt { get; set; }

        [RegularExpression(@"^\d+\.?\d*$", ErrorMessage = "Please enter numeric values.")]
        public decimal? FrontTestWt { get; set; }

        [RegularExpression(@"^\d+\.?\d*$", ErrorMessage = "Please enter numeric values.")]
        public decimal? RearTestWt { get; set; }

        [RegularExpression(@"^\d+\.?\d*$", ErrorMessage = "Please enter numeric values.")]
        public decimal? TotalTestWt { get; set; }

        [RegularExpression(@"^\d+\.?\d*$", ErrorMessage = "Please enter numeric values.")]
        public decimal? FrontTirePressure { get; set; }
         [RegularExpression(@"^\d+\.?\d*$", ErrorMessage = "Please enter numeric values.")]
        public decimal? RearTirePressure { get; set; }
         [RegularExpression(@"^\d+\.?\d*$", ErrorMessage = "Please enter numeric values.")]
        public decimal? SpareTirePressure { get; set; }

        [Range(0,int.MaxValue)]
        public short? SrsStatus { get; set; }

        [Range(0, int.MaxValue)]
        public short? AirbagFireSystem { get; set; }

        public bool LeftFrontPrimaryAirBagSrs { get; set; }
        public bool LeftFrontPrimaryAirBagPu { get; set; }

        public bool LeftFrontSecondaryAirBagSrs { get; set; }
        public bool LeftFrontSecondaryAirBagPu { get; set; }

        public bool LeftOuterBeltSrs { get; set; }
        public bool LeftOuterBeltPu { get; set; }

        public bool LeftSideAirBagSrs { get; set; }
        public bool LeftSideAirBagPu { get; set; }

        public bool LeftSideCurtainAirBagSrs { get; set; }
        public bool LeftSideCurtainAirBagPu { get; set; }

        public bool LeftInnerBuckleSrs { get; set; }
        public bool LeftInnerBucklePu { get; set; }

        public bool LeftOuterLapSrs { get; set; }
        public bool LeftOuterLapPu { get; set; }

        public bool LeftKneePrimarySrs { get; set; }
        public bool LeftKneePrimaryPu { get; set; }

        public bool RightFrontPrimaryAirBagSrs { get; set; }
        public bool RightFrontPrimaryAirBagPu { get; set; }

        public bool RightFrontSecondaryAirBagSrs { get; set; }
        public bool RightFrontSecondaryAirBagPu { get; set; }

        public bool RightOuterBeltSrs { get; set; }
        public bool RightOuterBeltPu { get; set; }

        public bool RightSideAirBagSrs { get; set; }
        public bool RightSideAirBagPu { get; set; }

        public bool RightSideCurtainAirBagSrs { get; set; }
        public bool RightSideCurtainAirBagPu { get; set; }

        public bool RightInnerBuckleSrs { get; set; }
        public bool RightInnerBucklePu { get; set; }

        public bool RightOuterLapSrs { get; set; }
        public bool RightOuterLapPu { get; set; }

        public bool RightKneePrimarySrs { get; set; }
        public bool RightKneePrimaryPu { get; set; }

        public string PostTestLocation { get; set; }
        public string PostTestLocationOther { get; set; }
        public bool VehicleReqAddtlTest { get; set; }
        public bool ProCam { get; set; }
        public bool Fmvss212WindshieldRetention { get; set; }
        public bool FaroArmReqForDummy { get; set; }
        public bool Fmvss219PartialWindshield { get; set; }
        public bool Fmvss219FullWindshield { get; set; }
        public bool Fmvss305 { get; set; }

        public short? Paint { get; set; }
        public string PaintInstruction { get; set; }
        public byte MoonRoofOpen { get; set; }
        public bool WindowsOpen { get; set; }
        public string FrontPit { get; set; }
        public string RearPit { get; set; }

        public int Hits { get; set; }
        public decimal? VehicleWeightFront { get; set; }
        public decimal? VehicleWeightRear { get; set; }
        public decimal? PendulumWeight { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsActive { get; set; }

    }

    public class RequestTestPlanVModelExport
    {
        public string Id { get; set; }
        public string RequestId { get; set; }
        public CustomFieldSelectionViewModel FieldSelector { get; set; }

        public TestPlanVModel TestPlanInfo { get; set; }
        public List<SRS> SrsSetting { get; set; }
    }

    public class SRS
    {
        public string Position { get; set; }
        public string Side { get; set; }
        public string TTF { get; set; }
        public bool Pickup { get; set; }
        public bool Squib { get; set; }
    }
}
