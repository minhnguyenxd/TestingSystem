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
    // ImpactDirection
    public partial class ImpactDirection : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name

        // Reverse navigation
        public virtual ICollection<AtdChannel> AtdChannels { get; set; } // AtdChannel.FK_AtdChannel_ImpactDirection

        public ImpactDirection()
        {
            AtdChannels = new List<AtdChannel>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
