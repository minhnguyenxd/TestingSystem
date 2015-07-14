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
    // TestRequestDummy
    public partial class TestRequestDummy : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int TestRequestId { get; set; } // TestRequestId
        public int? AtdId { get; set; } // AtdId
        public int AtdTypeId { get; set; } // AtdTypeId
        public string SeatingPosition { get; set; } // SeatingPosition
        public bool Belted { get; set; } // Belted
        public bool InstrumentationLegs { get; set; } // InstrumentationLegs
        public int InstrumentedAtdLegId { get; set; } // InstrumentedAtdLegId
        public bool Enabled { get; set; } // Enabled
        public int? G5Id { get; set; } // G5Id

        // Foreign keys
        public virtual Atd Atd { get; set; } // FK_TestRequestDummy_Atd_AtdId
        public virtual AtdType AtdType { get; set; } // FK_dbo.TestRequestDummy_dbo.AtdType_AtdTypeId
        public virtual G5 G5 { get; set; } // FK_dbo.TestRequestDummy_dbo.G5_G5Id
        public virtual TestRequest TestRequest { get; set; } // FK_dbo.TestRequestDummy_dbo.TestRequest_TestRequestId
    }

}
