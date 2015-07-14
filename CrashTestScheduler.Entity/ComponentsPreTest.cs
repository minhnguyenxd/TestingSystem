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
    // ComponentsPreTest
    public partial class ComponentsPreTest : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int ComponentsTestResultId { get; set; } // ComponentsTestResultId
        public string RequestedVelocity { get; set; } // RequestedVelocity
        public string RequestedVelocityOther { get; set; } // RequestedVelocityOther
        public string InputVelocity { get; set; } // InputVelocity
        public string ImpactPoint { get; set; } // ImpactPoint
        public string TimeSinceLastMachineFire { get; set; } // TimeSinceLastMachineFire
        public string OilTemp { get; set; } // OilTemp
        public string ImpactTargetUp { get; set; } // ImpactTargetUp
        public string ImpactAimUp { get; set; } // ImpactAimUp
        public string ImpactTargetLr { get; set; } // ImpactTargetLR
        public string ImpactAimLr { get; set; } // ImpactAimLR
        public string HorizontalTestAngle { get; set; } // HorizontalTestAngle
        public string VerticalTestAngle { get; set; } // VerticalTestAngle
        public string SideOfVehicleTested { get; set; } // SideOfVehicleTested
        public string AtdHeadform { get; set; } // ATDHeadform
        public string TestAngle { get; set; } // TestAngle
        public string InputPressure { get; set; } // InputPressure
        public string TmsiId { get; set; } // TMSIId
        public string ImpactorMass { get; set; } // ImpactorMass
        public string ImpactorMassOther { get; set; } // ImpactorMassOther
        public string InputMass { get; set; } // InputMass
        public string InputCorrectionFactor { get; set; } // InputCorrectionFactor
        public string AtdHeadformLegform { get; set; } // AtdHeadformLegform
        public string AtdHeadformLegformOther { get; set; } // AtdHeadformLegformOther
        public string VehicleIdentificationNumber { get; set; } // VehicleIdentificationNumber
        public string MtsId { get; set; } // MtsId
        public string VehicleFixtureHeightFr { get; set; } // VehicleFixtureHeightFR
        public string VehicleFixtureHeightRr { get; set; } // VehicleFixtureHeightRR
        public string SeatbeltLengthDr { get; set; } // SeatbeltLengthDR
        public string SeatbeltLengthCtr { get; set; } // SeatbeltLengthCTR
        public string SeatbeltLengthAs { get; set; } // SeatbeltLengthAS
        public string LabTemp { get; set; } // LabTemp
        public string LabHumidity { get; set; } // LabHumidity
        public string Comments { get; set; } // Comments
        public bool? IsAtdUsageAdded { get; set; } // IsATDUsageAdded

        // Foreign keys
        public virtual ComponentsTestResult ComponentsTestResult { get; set; } // FK_ComponentsPreTest_ComponentsTestResult
    }

}
