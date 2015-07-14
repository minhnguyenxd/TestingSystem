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
    // ComponentsPostTest
    public partial class ComponentsPostTest : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int ComponentsTestResultId { get; set; } // ComponentsTestResultId
        public string ActualTestVelocity { get; set; } // ActualTestVelocity
        public string ActualImpactUp { get; set; } // ActualImpactUp
        public string ActualImpactLr { get; set; } // ActualImpactLR
        public string ActualActuatorVelocity { get; set; } // ActualActuatorVelocity
        public string ActualVmsAvgVelocity { get; set; } // ActualVMSAvgVelocity
        public string ActualVmsaTrapVelocity { get; set; } // ActualVMSATrapVelocity
        public string ActualVmsbTrapVelocity { get; set; } // ActualVMSBTrapVelocity
        public bool? TestAnomaly { get; set; } // TestAnomaly
        public string TestResult { get; set; } // TestResult
        public string DataLocation { get; set; } // DataLocation
        public string ResultComment { get; set; } // ResultComment

        // Foreign keys
        public virtual ComponentsTestResult ComponentsTestResult { get; set; } // FK_ComponentsPostTest_ComponentsTestResult
    }

}
