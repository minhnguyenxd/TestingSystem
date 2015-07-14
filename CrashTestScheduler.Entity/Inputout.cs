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
    // INPUTOUT
    public partial class Inputout : EntityBase
    {
        public int Runid { get; set; } // Runid (Primary key)
        public int? A0Id { get; set; } // A0id
        public int? TestTypeid { get; set; } // TestTypeid
        public int? TestNameid { get; set; } // TestNameid
        public int? Projectid { get; set; } // Projectid
        public byte[] Pdf { get; set; } // Pdf
        public string CreatedBy { get; set; } // CreatedBy
        public DateTime? CreatedDate { get; set; } // CreatedDate
        public string Title { get; set; } // Title
    }

}
