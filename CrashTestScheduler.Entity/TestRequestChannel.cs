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
    // TestRequestChannel
    public partial class TestRequestChannel : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int TestRequestId { get; set; } // TestRequestId
        public int ChannelId { get; set; } // ChannelId
        public int SaeClassId { get; set; } // SaeClassId
        public bool Polarity { get; set; } // Polarity
        public decimal Scale { get; set; } // Scale
        public int EngUnitId { get; set; } // EngUnitId
        public string SerialNumber { get; set; } // SerialNumber
        public bool Verified { get; set; } // Verified
        public string VerifiedBy { get; set; } // VerifiedBy
        public DateTime? VerifiedDate { get; set; } // VerifiedDate
        public string Source { get; set; } // Source
        public int Sequenceno { get; set; } // sequenceno

        // Foreign keys
        public virtual Channel Channel { get; set; } // FK_dbo.TestRequestChannel_dbo.Channel_ChannelId
        public virtual EngUnit EngUnit { get; set; } // FK_dbo.TestRequestChannel_dbo.EngUnit_EngUnitId
        public virtual SaeClass SaeClass { get; set; } // FK_dbo.TestRequestChannel_dbo.SaeClass_SaeClassId
        public virtual TestRequest TestRequest { get; set; } // FK_dbo.TestRequestChannel_dbo.TestRequest_TestRequestId
    }

}
