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
    // Picture
    public partial class Picture : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name
        public string ThumbNailPath { get; set; } // ThumbNailPath
        public bool? IsDeleted { get; set; } // IsDeleted
        public string Type { get; set; } // Type

        // Reverse navigation
        public virtual ICollection<PictureList> PictureLists { get; set; } // PictureList.FK_dbo.PictureList_dbo.Picture_PictureId
        public virtual ICollection<PictureTemplateMap> PictureTemplateMaps { get; set; } // PictureTemplateMap.FK_PictureTemplateMap_Picture
        public virtual ICollection<PictureTestTypeMap> PictureTestTypeMaps { get; set; } // PictureTestTypeMap.FK_dbo.PictureTestTypeMap_dbo.Picture_PictureId
        public virtual ICollection<TestRequestPicture> TestRequestPictures { get; set; } // TestRequestPicture.FK_dbo.TestRequestPicture_dbo.Picture_PictureId

        public Picture()
        {
            PictureLists = new List<PictureList>();
            PictureTemplateMaps = new List<PictureTemplateMap>();
            PictureTestTypeMaps = new List<PictureTestTypeMap>();
            TestRequestPictures = new List<TestRequestPicture>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
