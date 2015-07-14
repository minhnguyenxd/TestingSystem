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
    // Video
    public partial class Video : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name
        public string ThumbNailPath { get; set; } // ThumbNailPath
        public bool? IsDeleted { get; set; } // IsDeleted

        // Reverse navigation
        public virtual ICollection<TestRequestVideo> TestRequestVideos { get; set; } // TestRequestVideo.FK_dbo.TestRequestVideo_dbo.Video_VideoId
        public virtual ICollection<VideoList> VideoLists { get; set; } // VideoList.FK_dbo.VideoList_dbo.Video_VideoId
        public virtual ICollection<VideoTemplateMap> VideoTemplateMaps { get; set; } // VideoTemplateMap.FK_dbo.VideoTemplateMap_dbo.Video_VideoId
        public virtual ICollection<VideoTestTypeMap> VideoTestTypeMaps { get; set; } // VideoTestTypeMap.FK_dbo.VideoTestTypeMap_dbo.Video_VideoId

        public Video()
        {
            TestRequestVideos = new List<TestRequestVideo>();
            VideoLists = new List<VideoList>();
            VideoTemplateMaps = new List<VideoTemplateMap>();
            VideoTestTypeMaps = new List<VideoTestTypeMap>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
