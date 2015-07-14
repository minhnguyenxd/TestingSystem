#region

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Humanizer;
using model = CrashTestScheduler.Entity.Model;

#endregion

namespace CrashTestScheduler.Entity.ViewModel
{
}

namespace CrashTestScheduler.Entity.ViewModel
{
    public class BumperPendulumViewModel
    {
        public int Id { get; set; }
        public int TestRequestId { get; set; }
        [Display(Name = "Project Name:")]
        public string ProjectName { get; set; }

        [Display(Name = "Request Date:")]
        public DateTime RequestedTestDate { get; set; }
        public string Engineer { get; set; }

        [Required]
        [Display(Name = "Test Title:")]
        public string TestTitle { get; set; }

        public int SNo { get; set; }
        public int ResultSNo { get; set; }

        public string TestVehicle { get; set; }

        [Display(Name = "Vehicle Level:")]
        public string VehicleLevel { get; set; }
        [Required]
        [Display(Name = "Target Speed:")]
        [RegularExpression(@"^\d+\.?\d*$", ErrorMessage = "Please enter numeric values.")]
        public decimal? TargetSpeed { get; set; }

        [Required]
        [Display(Name = "Swing Height:")]
        [RegularExpression(@"^\d+\.?\d*$", ErrorMessage = "Please enter numeric values.")]
        public decimal? SwingHeight { get; set; } // InitialHeight

        [Required]
        [Display(Name = "Actual Speed CH1:")]
        [RegularExpression(@"^\d+\.?\d*$", ErrorMessage = "Please enter numeric values.")]
        public decimal? ActualSpeedCh1 { get; set; }

        [Required]
        [Display(Name = "Actual Speed CH2:")]
        [RegularExpression(@"^\d+\.?\d*$", ErrorMessage = "Please enter numeric values.")]
        public decimal? ActualSpeedCh2 { get; set; }

        [Display(Name = "Average Speed:")]
        public decimal? AverageSpeed
        {
            get { return ((ActualSpeedCh1.HasValue?ActualSpeedCh1.Value : 0) + (ActualSpeedCh2.HasValue? ActualSpeedCh2.Value : 0 )) / 2; }
        }

        [Required]
        [Display(Name = "Vehicle Weight Front:")]
        [RegularExpression(@"^\d+\.?\d*$", ErrorMessage = "Please enter numeric values.")]
        public decimal? VehicleWeightFront { get; set; }
        
        [Required]
        [Display(Name = "Vehicle Weight Rear:")]
        [RegularExpression(@"^\d+\.?\d*$", ErrorMessage = "Please enter numeric values.")]
        public decimal? VehicleWeightRear { get; set; }
        
        [Required]
        [Display(Name = "Pendulum Weight:")]
        [RegularExpression(@"^\d+\.?\d*$", ErrorMessage = "Please enter numeric values.")]
        public decimal? PendulumWeight { get; set; }
        public string DataLocation { get; set; }
        public bool Anomaly { get; set; }

        public decimal? VehicleWeight
        {
            get
            {
                return (VehicleWeightFront.HasValue ? VehicleWeightFront.Value : 0) + (VehicleWeightRear.HasValue ? VehicleWeightRear.Value : 0);
            }
        }
        public decimal? Pullback
        {
            get
            {
                return TargetSpeed.HasValue ? Math.Round(((((TargetSpeed.Value * 1000) / 3600) * ((TargetSpeed.Value * 1000) / 3600)) * 1000) / Convert.ToDecimal((2 * 9.80665)), 3) : 0;
            }
        }
        public decimal? TestHeight
        {
            get
            {
                return SwingHeight.HasValue ? Math.Round((SwingHeight.Value + Pullback.Value), 3) : 0;
            }
        }

    }
}