#region

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Humanizer;
using model = CrashTestScheduler.Entity.Model;
using Repository;

#endregion

namespace CrashTestScheduler.Entity.ViewModel
{
    public class BumperPendulumHitViewModel
    {
        public int Id { get; set; }
        public int TestRequestId { get; set; }
        public int? HitNo { get; set; }
        public string TestSubMode { get; set; }
        public string ImpactLocation { get; set; }
        public decimal? VehicleWeightFront { get; set; }
        public decimal? VehicleWeightRear { get; set; }
        public decimal? PendulumWeight { get; set; }
        public decimal? TargetSpeed { get; set; }
        public decimal? ActualSpeedCh1 { get; set; }
        public decimal? ActualSpeedCh2 { get; set; }
        public decimal? InitialHeight { get; set; }
        public ObjectState ObjectState { get; set; }

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
                return InitialHeight.HasValue ? Math.Round((InitialHeight.Value + Pullback.Value),3) : 0;
            }
        }
    }
}