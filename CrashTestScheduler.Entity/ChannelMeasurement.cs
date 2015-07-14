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
    // ChannelMeasurement
    public partial class ChannelMeasurement : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name
        public string Description { get; set; } // Description

        // Reverse navigation
        public virtual ICollection<Channel> Channels { get; set; } // Channel.FK_Channel_ChannelMeasurement

        public ChannelMeasurement()
        {
            Channels = new List<Channel>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
