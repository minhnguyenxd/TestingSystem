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
    // EngUnit
    public partial class EngUnit : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name

        // Reverse navigation
        public virtual ICollection<AtdChannel> AtdChannels { get; set; } // AtdChannel.FK_dbo.AtdChannel_dbo.EngUnit_EngUnitId
        public virtual ICollection<TemplateInstrumentationChannel> TemplateInstrumentationChannels { get; set; } // TemplateInstrumentationChannel.FK_dbo.TemplateInstrumentationChannel_dbo.EngUnit_EngUnitId
        public virtual ICollection<TestRequestChannel> TestRequestChannels { get; set; } // TestRequestChannel.FK_dbo.TestRequestChannel_dbo.EngUnit_EngUnitId

        public EngUnit()
        {
            AtdChannels = new List<AtdChannel>();
            TemplateInstrumentationChannels = new List<TemplateInstrumentationChannel>();
            TestRequestChannels = new List<TestRequestChannel>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
