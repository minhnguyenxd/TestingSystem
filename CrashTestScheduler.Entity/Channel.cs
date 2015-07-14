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
    // Channel
    public partial class Channel : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name
        public string Description { get; set; } // Description
        public int? ChannelGroupId { get; set; } // ChannelGroupId
        public string Part { get; set; } // Part
        public string Direction { get; set; } // Direction
        public string IndexName { get; set; } // IndexName
        public int? MeasurementId { get; set; } // MeasurementId

        // Reverse navigation
        public virtual ICollection<ChannelTestTypeAssociation> ChannelTestTypeAssociations { get; set; } // ChannelTestTypeAssociation.FK_dbo.ChannelTestTypeAssociation_dbo.Channel_ChannelId
        public virtual ICollection<SrsSetting> SrsSettings_LeftChannelId { get; set; } // SRSSetting.FK_SRSSetting_ChannelLeft
        public virtual ICollection<SrsSetting> SrsSettings_RightChannelId { get; set; } // SRSSetting.FK_SRSSetting_ChannelRight
        public virtual ICollection<TemplateInstrumentationChannel> TemplateInstrumentationChannels { get; set; } // TemplateInstrumentationChannel.FK_dbo.TemplateInstrumentationChannel_dbo.Channel_ChannelId
        public virtual ICollection<TestRequestChannel> TestRequestChannels { get; set; } // TestRequestChannel.FK_dbo.TestRequestChannel_dbo.Channel_ChannelId

        // Foreign keys
        public virtual ChannelGroup ChannelGroup { get; set; } // FK_Channel_ChannelGroup
        public virtual ChannelMeasurement ChannelMeasurement { get; set; } // FK_Channel_ChannelMeasurement

        public Channel()
        {
            ChannelTestTypeAssociations = new List<ChannelTestTypeAssociation>();
            SrsSettings_LeftChannelId = new List<SrsSetting>();
            SrsSettings_RightChannelId = new List<SrsSetting>();
            TemplateInstrumentationChannels = new List<TemplateInstrumentationChannel>();
            TestRequestChannels = new List<TestRequestChannel>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
