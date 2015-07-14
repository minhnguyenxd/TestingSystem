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
    // AOCIMapping
    public partial class AociMapping : EntityBase
    {
        public string AoRequirement { get; set; } // AORequirement
        public string CiNumber { get; set; } // CINumber
        public string DisplayCode { get; set; } // DisplayCode
        public int? SortNumber { get; set; } // SortNumber
        public string TestName { get; set; } // TestName
    }

}
