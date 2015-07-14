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
    // AOInjuryMapping
    public partial class AoInjuryMapping : EntityBase
    {
        public string AoRequirement { get; set; } // AORequirement
        public int DriPass { get; set; } // DriPass
        public string Hic15 { get; set; } // HIC15
        public string Nij { get; set; } // NIJ
        public string Ntl { get; set; } // NTL
        public string Ncl { get; set; } // NCL
        public string ChestG { get; set; } // ChestG
        public string ChestDf { get; set; } // ChestDF
        public string FemurLoadR { get; set; } // FemurLoadR
        public string FemurLoadL { get; set; } // FemurLoadL
        public string Ic { get; set; } // IC
        public string SteeringHorizontalIntrusion { get; set; } // SteeringHorizontalIntrusion
        public string SteeringVerticalIntrusion { get; set; } // SteeringVerticalIntrusion
        public string TestName { get; set; } // TestName
    }

}
