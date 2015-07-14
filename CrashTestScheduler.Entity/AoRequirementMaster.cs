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
    // AORequirementMaster
    public partial class AoRequirementMaster : EntityBase
    {
        public string AoRequirementId { get; set; } // AORequirementID
        public string Title { get; set; } // Title
        public string Purpose { get; set; } // Purpose
        public string DrivDummytype { get; set; } // DrivDummytype
        public string PassDummyType { get; set; } // PassDummyType
        public string TestMethod { get; set; } // TestMethod
        public string ReqImpactVel { get; set; } // ReqImpactVel
        public int? TotalPages { get; set; } // TotalPages
        public int? ElectricInclude { get; set; } // ElectricInclude
        public int? FuelInclude { get; set; } // FuelInclude
        public string TestName { get; set; } // TestName
    }

}
