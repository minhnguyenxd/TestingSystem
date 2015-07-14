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
    // AtdChannelLocation
    public partial class AtdChannelLocation : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public string Location { get; set; } // Location

        // Reverse navigation
        public virtual ICollection<AtdChannel> AtdChannels { get; set; } // AtdChannel.FK_dbo.AtdChannel_dbo.AtdChannelLocation_AtdChannelLocationId

        public AtdChannelLocation()
        {
            AtdChannels = new List<AtdChannel>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
