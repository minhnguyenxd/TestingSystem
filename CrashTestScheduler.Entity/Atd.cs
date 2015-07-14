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
    // Atd
    public partial class Atd : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int AtdTypeId { get; set; } // AtdTypeId
        public string AtdSerialNumber { get; set; } // AtdSerialNumber
        public decimal? WeightInKgs { get; set; } // WeightInKgs
        public DateTime? InstrumentationUpdateDate { get; set; } // InstrumentationUpdateDate
        public string Comments { get; set; } // Comments
        public bool IsDeleted { get; set; } // IsDeleted
        public DateTime? DeletedDate { get; set; } // DeletedDate
        public string DeletedBy { get; set; } // DeletedBy
        public int? G5Id { get; set; } // G5Id
        public int? ChannelCount { get; set; } // ChannelCount

        // Reverse navigation
        public virtual ICollection<AtdChannel> AtdChannels { get; set; } // AtdChannel.FK_dbo.AtdChannel_dbo.Atd_AtdId
        public virtual ICollection<AtdUsage> AtdUsages { get; set; } // AtdUsage.FK_AtdUsage_Atd
        public virtual ICollection<TestRequestDummy> TestRequestDummies { get; set; } // TestRequestDummy.FK_TestRequestDummy_Atd_AtdId

        // Foreign keys
        public virtual AtdType AtdType { get; set; } // FK_dbo.Atd_dbo.AtdType_AtdTypeId
        public virtual G5 G5 { get; set; } // FK_dbo.Atd_dbo.G5_G5Id

        public Atd()
        {
            AtdChannels = new List<AtdChannel>();
            AtdUsages = new List<AtdUsage>();
            TestRequestDummies = new List<TestRequestDummy>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
