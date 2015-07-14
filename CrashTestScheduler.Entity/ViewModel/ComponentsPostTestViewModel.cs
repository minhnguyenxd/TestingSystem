#region

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Humanizer;
using model = CrashTestScheduler.Entity.Model;
using CrashTestScheduler.Entity.Model;

#endregion

namespace CrashTestScheduler.Entity.ViewModel
{
    public class ComponentsPostTestViewModel
    {
        public int Id { get; set; }
        public int TestTypeId { get; set; }
        public int TestModeId { get; set; }
        public int ComponentsTestResultId { get; set; }
        public string ActualTestVelocity { get; set; }
        public string ActualImpactUp { get; set; }
        public string ActualImpactLr { get; set; }
        public string ActualActuatorVelocity { get; set; }
        public string ActualVmsAvgVelocity { get; set; }
        public string ActualVmsaTrapVelocity { get; set; }
        public string ActualVmsbTrapVelocity { get; set; }
        public bool TestAnomaly { get; set; }
        public string TestResult { get; set; }
        public string DataLocation { get; set; }
        public string ResultComment { get; set; }
    }
}