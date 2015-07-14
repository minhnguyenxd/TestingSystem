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
    // TestType
    public partial class TestType : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name
        public int? CalendarTypeId { get; set; } // CalendarTypeId

        // Reverse navigation
        public virtual ICollection<ChannelTestTypeAssociation> ChannelTestTypeAssociations { get; set; } // ChannelTestTypeAssociation.FK_dbo.ChannelTestTypeAssociation_dbo.TestType_TestTypeId
        public virtual ICollection<PictureTestTypeMap> PictureTestTypeMaps { get; set; } // PictureTestTypeMap.FK_dbo.PictureTestTypeMap_dbo.TestType_TestTypeId
        public virtual ICollection<TestMode> TestModes { get; set; } // TestMode.FK_dbo.TestMode_dbo.TestType_TestTypeId
        public virtual ICollection<TestRequest> TestRequests { get; set; } // TestRequest.FK_dbo.TestRequest_dbo.TestType_TestTypeId
        public virtual ICollection<VideoList> VideoLists { get; set; } // VideoList.FK_dbo.VideoList_dbo.TestType_TestTypeId
        public virtual ICollection<VideoTestTypeMap> VideoTestTypeMaps { get; set; } // VideoTestTypeMap.FK_dbo.VideoTestTypeMap_dbo.TestType_TestTypeId

        // Foreign keys
        public virtual CalendarType CalendarType { get; set; } // FK_TestType_CalendarType

        public TestType()
        {
            ChannelTestTypeAssociations = new List<ChannelTestTypeAssociation>();
            PictureTestTypeMaps = new List<PictureTestTypeMap>();
            TestModes = new List<TestMode>();
            TestRequests = new List<TestRequest>();
            VideoLists = new List<VideoList>();
            VideoTestTypeMaps = new List<VideoTestTypeMap>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
