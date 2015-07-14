using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CrashTestScheduler.Entity.ViewModel
{
    public class PostTestSummaryViewModel
    {
        [Display(Name = "Temperature:")]
        public decimal Temperature { get; set; }

        [Display(Name = "Humidity:")]
        public int Humidity { get; set; }


        //Vehicle and Test Particulars
        [Display(Name = "Frame Code:")]
        public string FrameCode { get; set; }

        [Display(Name = "Test Title:")]
        public string StickerNomenclature { get; set; }

        [Display(Name = "Test Mode:")]
        public string TestMode { get; set; }

        [Display(Name = "Mode No.:")]
        public string ModeNo { get; set; }

        [Display(Name = "Test Date:")]
        public string TestDate { get; set; }

        [Display(Name = "Day Test No.:")]
        public string TestNumber { get; set; }

        [Display(Name = "Test Time:")]
        public string TestTime { get; set; }

        [Display(Name = "Build Level:")]
        public string BuildLevel { get; set; }

        [Display(Name = "Vehicle No.:")]
        public string GoukiNumber { get; set; }

        [Display(Name = "Engine No.:")]
        public string EngineVin { get; set; }

        [Display(Name = "Frame No.:")]
        public string VINNumber { get; set; }

        [Display(Name = "PIC Name:")]
        public string PicName { get; set; }


        //Test Vehicle Weights and Ballast (kg)
        [Display(Name = "Front Curb Weight:")]
        public decimal FrontCurbWt { get; set; }

        [Display(Name = "Rear Curb Weight:")]
        public decimal RearCurbWt { get; set; }

        [Display(Name = "Front Target Test Weight:")]
        public decimal FrontTestWt { get; set; }

        [Display(Name = "Rear Target Test Weight:")]
        public decimal RearTestWt { get; set; }

        [Display(Name = "Front As Tested (w/ ATD's):")]
        public decimal FrontAsTested { get; set; }

        [Display(Name = "Rear As Tested (w/ ATD's):")]
        public decimal RearAsTested { get; set; }

        [Display(Name = "Difference:")]
        public decimal Difference { get; set; }

        [Display(Name = "Ballast Added (kg):")]
        public decimal BallastAdded { get; set; }

        [Display(Name = "Ballast Location(s):")]
        public decimal BallastLocations { get; set; }


        //Vehicle Tire Data
        [Display(Name = "Front Right Tire Size:")]
        public decimal FrontRightTireSize { get; set; }

        [Display(Name = "Front Left Tire Size:")]
        public decimal FrontLeftTireSize { get; set; }

        [Display(Name = "Rear Right Tire Size:")]
        public decimal RearRightTireSize { get; set; }

        [Display(Name = "Rear Left Tire Size:")]
        public decimal RearLeftTireSize { get; set; }

        [Display(Name = "Front Right Tire Pressure:")]
        public decimal FrontRightTirePressure { get; set; }

        [Display(Name = "Front Left Tire Pressure:")]
        public decimal FrontLeftTirePressure { get; set; }

        [Display(Name = "Rear Right Tire Pressure:")]
        public decimal RearRightTirePressure { get; set; }

        [Display(Name = "Rear Left Tire Pressure:")]
        public decimal RearLeftTirePressure { get; set; }


        //Fuel System
        [Display(Name = "Test Volume Added:")]
        public decimal FuelCapacity { get; set; }

        [Display(Name = "Fuel Type:")]
        public string FuelTankContents { get; set; }


        //TOM Fire Times
        [Display(Name = "Driver Primary TTF:")]
        public string LeftFrontPrimaryAirBagTTF { get; set; }

        [Display(Name = "Driver Secondary TTF:")]
        public string LeftFrontSecondaryAirBagTTF { get; set; }

        [Display(Name = "Driver ELR:")]
        public string LeftOuterBeltTTF { get; set; }

        [Display(Name = "Driver OLPT:")]
        public string LeftOuterLapTTF { get; set; }

        [Display(Name = "Driver IBPT:")]
        public string LeftInnerBuckleTTF { get; set; }

        [Display(Name = "SAB:")]
        public string LeftSideAirBagTTF { get; set; }

        [Display(Name = "SCAB:")]
        public string LeftSideCurtainAirBagTTF { get; set; }

        [Display(Name = "KNEE:")]
        public string LeftKneePrimaryTTF { get; set; }



        [Display(Name = "Passenger Primary TTF:")]
        public string RightFrontPrimaryAirBagTTF { get; set; }

        [Display(Name = "Passenger Secondary TTF:")]
        public string RightFrontSecondaryAirBagTTF { get; set; }

        [Display(Name = "Driver ELR:")]
        public string RightOuterBeltTTF { get; set; }

        [Display(Name = "Driver OLPT:")]
        public string RightOuterLapTTF { get; set; }

        [Display(Name = "Driver IBPT:")]
        public string RightInnerBuckleTTF { get; set; }

        [Display(Name = "SAB:")]
        public string RightSideAirBagTTF { get; set; }

        [Display(Name = "SCAB:")]
        public string RightSideCurtainAirBagTTF { get; set; }

        [Display(Name = "KNEE:")]
        public string RightKneePrimaryTTF { get; set; }

        //ATD Data
        [Display(Name = "Driver Atd Type:")]
        public string DriverAtdType { get; set; }

        [Display(Name = "Driver Atd Serial#:")]
        public string DriverAtdSno { get; set; }

        [Display(Name = "Passenger Atd Type:")]
        public string PassengerAtdType { get; set; }

        [Display(Name = "Passenger Atd Serial#:")]
        public string PassengerAtdSno { get; set; }

        [Display(Name = "RRL Atd Type:")]
        public string RRLAtdType { get; set; }

        [Display(Name = "RRL Atd Serial#:")]
        public string RRLAtdSno { get; set; }

        [Display(Name = "RRC Atd Type:")]
        public string RRCAtdType { get; set; }

        [Display(Name = "RRC Atd Serial#:")]
        public string RRCAtdSno { get; set; }

        [Display(Name = "RRR Atd Type:")]
        public string RRRAtdType { get; set; }

        [Display(Name = "RRR Atd Serial#:")]
        public string RRRAtdSno { get; set; }

        [Display(Name = "3RL Atd Type:")]
        public string R3LAtdType { get; set; }

        [Display(Name = "3RL Atd Serial#:")]
        public string R3LAtdSno { get; set; }

        [Display(Name = "3RC Atd Type:")]
        public string R3CAtdType { get; set; }

        [Display(Name = "3RC Atd Serial#:")]
        public string R3CAtdSno { get; set; }

        [Display(Name = "3RR Atd Type:")]
        public string R3RAtdType { get; set; }

        [Display(Name = "3RR Atd Serial#:")]
        public string R3RAtdSno { get; set; }

        //Crash Soft Info
        [Display(Name = "Test Name:")]
        public string TestName { get; set; }

        [Display(Name = "Velocity:")]
        public string Velocity { get; set; }

        [Display(Name = "Mass:")]
        public string Mass { get; set; }

        [Display(Name = "Stop Point:")]
        public string StopPoint { get; set; }

        [Display(Name = "Constant Velocity:")]
        public string ConstantVelocity { get; set; }

        [Display(Name = "Start Point:")]
        public string StartPoint { get; set; }

        [Display(Name = "Free Distance:")]
        public string FreeDistance { get; set; }

        //Test Velocity
        [Display(Name = "Required Velocity:")]
        public int PreferredImpactSpeed { get; set; }

        [Display(Name = "Actual Velocity:")]
        public int ActualVelocity { get; set; }

        [Display(Name = "Light Trap A:")]
        public int LightTrapA { get; set; }

        [Display(Name = "Light Trap B:")]
        public int LightTrapB { get; set; }

        [Display(Name = "Light Trap Average speed:")]
        public int LightTrapAvg { get; set; }

        //Battery Voltage
        [Display(Name = "Voltage (1 min pre-test):")]
        public decimal BatteryVoltage { get; set; }

        //Pick Up Coil Fire Times
        [Display(Name = "Driver Primary:")]
        public string LeftFrontPrimaryAirBagACT { get; set; }

        [Display(Name = "Driver Secondary:")]
        public string LeftFrontSecondaryAirBagACT { get; set; }

        [Display(Name = "Driver ELR:")]
        public string LeftOuterBeltACT { get; set; }

        [Display(Name = "Driver OLTP:")]
        public string LeftOuterLapACT { get; set; }

        [Display(Name = "Driver IBPT:")]
        public string LeftInnerBuckleACT { get; set; }

        [Display(Name = "SAB:")]
        public string LeftSideAirBagACT { get; set; }

        [Display(Name = "SCAB:")]
        public string LeftSideCurtainAirBagACT { get; set; }

        [Display(Name = "KNEE:")]
        public string LeftKneePrimaryACT { get; set; }

        [Display(Name = "Passenger Primary:")]
        public string RightFrontPrimaryAirBagACT { get; set; }

        [Display(Name = "Passenger Secondary:")]
        public string RightFrontSecondaryAirBagACT { get; set; }

        [Display(Name = "Driver ELR:")]
        public string RightOuterBeltACT { get; set; }

        [Display(Name = "Driver OLTP:")]
        public string RightOuterLapACT { get; set; }

        [Display(Name = "Driver OLTP:")]
        public string RightInnerBuckleACT { get; set; }

        [Display(Name = "SAB:")]
        public string RightSideAirBagACT { get; set; }

        [Display(Name = "SCAB:")]
        public string RightSideCurtainAirBagACT { get; set; }

        [Display(Name = "KNEE:")]
        public string RightKneePrimaryACT { get; set; }

        //BUMPER/BARRIER HEIGHTS
        [Display(Name = "Vehicle Top:")]
        public decimal VehicleTop { get; set; }

        [Display(Name = "Vehicle Bottom:")]
        public decimal VehicleBottom { get; set; }

        [Display(Name = "Barrier Top:")]
        public decimal BarrierTop { get; set; }

        [Display(Name = "Barrier Bottom:")]
        public decimal BarrierBottom { get; set; }

        //Barrier Heights
        [Display(Name = "Barrier Height FR:")]
        public decimal BarrierHeightFR { get; set; }

        [Display(Name = "Barrier Height RR:")]
        public decimal BarrierHeightRR { get; set; }

        //Test Cart Weights (kg)
        [Display(Name = "Tested Front Weight:")]
        public decimal TestedFrontWt { get; set; }

        [Display(Name = "Tested Rear Weight:")]
        public decimal TestedRearWt { get; set; }

        [Display(Name = "Calculated Front Weight:")]
        public decimal CalcFrontWt { get; set; }

        [Display(Name = "Calculated Rear Weight:")]
        public decimal CalcRearWt { get; set; }

        //Vehicle Wheel Arch Heights
        [Display(Name = "Pre-Test Vehicle Wheel Arch Height1:")]
        public decimal PreWheelArchHeight1 { get; set; }

        [Display(Name = "Pre-Test Vehicle Wheel Arch Height2:")]
        public decimal PreWheelArchHeight2 { get; set; }

        [Display(Name = "Pre-Test Vehicle Wheel Arch Height3:")]
        public decimal PreWheelArchHeight3 { get; set; }

        [Display(Name = "Pre-Test Vehicle Wheel Arch Height4:")]
        public decimal PreWheelArchHeight4 { get; set; }

        [Display(Name = "Pre-Test Vehicle Wheel Arch Height5:")]
        public decimal PreWheelArchHeight5 { get; set; }

        [Display(Name = "Post-Test Vehicle Wheel Arch Height1:")]
        public decimal PostWheelArchHeight1 { get; set; }

        [Display(Name = "Post-Test Vehicle Wheel Arch Height2:")]
        public decimal PostWheelArchHeight2 { get; set; }

        [Display(Name = "Post-Test Vehicle Wheel Arch Height3:")]
        public decimal PostWheelArchHeight3 { get; set; }

        [Display(Name = "Post-Test Vehicle Wheel Arch Height4:")]
        public decimal PostWheelArchHeight4 { get; set; }

        [Display(Name = "Post-Test Vehicle Wheel Arch Height5:")]
        public decimal PostWheelArchHeight5 { get; set; }

        //Frontal Impact Location (mm)
        [Display(Name = "Impact Location:")]
        public string FrontalImpactLocation { get; set; }

        [Display(Name = "Actual Impact:")]
        public string FrontalActualImpact { get; set; }

        [Display(Name = "Deviation of Impact:")]
        public string FrontalImpactDeviation { get; set; }

        //Bumper Test Impact Location (mm)
        [Display(Name = "Impact Location (PRI-UP):")]
        public string BumperImpactLocationPRIUP { get; set; }

        [Display(Name = "Actual Impact (PRI-UP):")]
        public string BumperActualImpactPRIUP { get; set; }

        [Display(Name = "Deviation of Impact (PRI-UP):")]
        public string BumperImpactDeviationPRIUP { get; set; }

        [Display(Name = "Impact Location (PRI-LR):")]
        public string BumperImpactLocationPRILR { get; set; }

        [Display(Name = "Actual Impact (PRI-LR):")]
        public string BumperActualImpactPRILR { get; set; }

        [Display(Name = "Deviation of Impact (PRI-LR):")]
        public string BumperImpactDeviationPRILR { get; set; }

        //Side Impact Location (mm)
        [Display(Name = "Impact Location (PRI-UP):")]
        public string SideImpactLocationPRIUP { get; set; }

        [Display(Name = "Actual Impact (PRI-UP):")]
        public string SideActualImpactPRIUP { get; set; }

        [Display(Name = "Deviation of Impact (PRI-UP):")]
        public string SideImpactDeviationPRIUP { get; set; }

        [Display(Name = "Impact Location (PRI-LR):")]
        public string SideImpactLocationPRILR { get; set; }

        [Display(Name = "Actual Impact (PRI-LR):")]
        public string SideActualImpactPRILR { get; set; }

        [Display(Name = "Deviation of Impact (PRI-LR):")]
        public string SideImpactDeviationPRILR { get; set; }

        [Display(Name = "Impact Location (SEC-UP):")]
        public string SideImpactLocationSECUP { get; set; }

        [Display(Name = "Actual Impact (SEC-UP):")]
        public string SideActualImpactSECUP { get; set; }

        [Display(Name = "Deviation of Impact (SEC-UP):")]
        public string SideImpactDeviationSECUP { get; set; }

        [Display(Name = "Impact Location (SEC-LR):")]
        public string SideImpactLocationSECLR { get; set; }

        [Display(Name = "Actual Impact (SEC-LR):")]
        public string SideActualImpactSECLR { get; set; }

        [Display(Name = "Deviation of Impact (SEC-LR):")]
        public string SideImpactDeviationSECLR { get; set; }


        public decimal SUM(decimal arg1, decimal arg2)
        {
            return arg1 + arg2;
        }

        public decimal MINUS(decimal arg1, decimal arg2)
        {
            return arg1 - arg2;
        }

        public decimal PSItoKPA(decimal psi)
        {
            return psi * Convert.ToDecimal(6.89475729);
        }

        public decimal ConvertToCelcius(decimal temperature)
        {
            return (( temperature -  32) *5/9);
        }

    }
}