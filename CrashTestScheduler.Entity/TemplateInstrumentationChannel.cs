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
    // TemplateInstrumentationChannel
    public partial class TemplateInstrumentationChannel : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int TemplateId { get; set; } // TemplateId
        public int ChannelId { get; set; } // ChannelId
        public int SaeClassId { get; set; } // SaeClassId
        public bool Polarity { get; set; } // Polarity
        public decimal Scale { get; set; } // Scale
        public int EngUnitId { get; set; } // EngUnitId
        public int Sequenceno { get; set; } // sequenceno

        // Foreign keys
        public virtual Channel Channel { get; set; } // FK_dbo.TemplateInstrumentationChannel_dbo.Channel_ChannelId
        public virtual EngUnit EngUnit { get; set; } // FK_dbo.TemplateInstrumentationChannel_dbo.EngUnit_EngUnitId
        public virtual SaeClass SaeClass { get; set; } // FK_dbo.TemplateInstrumentationChannel_dbo.SaeClass_SaeClassId
        public virtual TestPlanTemplate TestPlanTemplate { get; set; } // FK_dbo.TemplateInstrumentationChannel_dbo.TestPlanTemplate_TemplateId
    }

}
