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
    // ChannelTestTypeAssociation
    public partial class ChannelTestTypeAssociation : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int ChannelId { get; set; } // ChannelId
        public int TestTypeId { get; set; } // TestTypeId

        // Foreign keys
        public virtual Channel Channel { get; set; } // FK_dbo.ChannelTestTypeAssociation_dbo.Channel_ChannelId
        public virtual TestType TestType { get; set; } // FK_dbo.ChannelTestTypeAssociation_dbo.TestType_TestTypeId
    }

}
