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
    // SledPreTest
    public partial class SledPreTest : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int? ResultId { get; set; } // ResultID
        public int? OilTemp { get; set; } // OilTemp
        public string ShotType { get; set; } // ShotType

        // Foreign keys
        public virtual SledResult SledResult { get; set; } // FK_dbo_SledPreTest_SledResult_ResultID
    }

}
