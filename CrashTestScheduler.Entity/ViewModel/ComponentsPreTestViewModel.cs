#region

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;
using Humanizer;
using model = CrashTestScheduler.Entity.Model;
using CrashTestScheduler.Entity.Model;

#endregion

namespace CrashTestScheduler.Entity.ViewModel
{
    public class ComponentsPreTestViewModel
    {
        public int Id { get; set; }
        public int TestRequestId { get; set; }
        public int TestTypeId { get; set; }
        public int TestModeId { get; set; }
        public int ComponentsTestResultId { get; set; }
        public string RequestedVelocity { get; set; }
        public string RequestedVelocityOther { get; set; }
        public string InputVelocity { get; set; }
        public string ImpactPoint { get; set; }
        public string TimeSinceLastMachineFire { get; set; }
        public string OilTemp { get; set; }
        public string ImpactTargetUp { get; set; }
        public string ImpactAimUp { get; set; }
        public string ImpactTargetLr { get; set; }
        public string ImpactAimLr { get; set; }
        public string HorizontalTestAngle { get; set; }
        public string VerticalTestAngle { get; set; }
        public string SideOfVehicleTested { get; set; }
        public string AtdHeadform { get; set; }
        public string TestAngle { get; set; }
        public string InputPressure { get; set; }
        public string TmsiId { get; set; }
        public string ImpactorMass { get; set; }
        public string ImpactorMassOther { get; set; }
        public string InputMass { get; set; }
        public string InputCorrectionFactor { get; set; }
        public string AtdHeadformLegform { get; set; }
        public string AtdHeadformLegformOther { get; set; }
        public string VehicleIdentificationNumber { get; set; }
        public string MtsId { get; set; }
        public string VehicleFixtureHeightFr { get; set; }
        public string VehicleFixtureHeightRr { get; set; }
        public string SeatbeltLengthDr { get; set; }
        public string SeatbeltLengthCtr { get; set; }
        public string SeatbeltLengthAs { get; set; }
        public string LabTemp { get; set; }
        public string LabHumidity { get; set; }
        public string Comments { get; set; }

        public List<AtdSummaryViewModel> ATDHeadForms { get; set; }
        public SelectList AtdHeadformLegformDropDown { get; set; }
    }
}