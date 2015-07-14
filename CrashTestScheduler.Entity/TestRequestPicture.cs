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
    // TestRequestPicture
    public partial class TestRequestPicture : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int TestRequestId { get; set; } // TestRequestId
        public int PictureId { get; set; } // PictureId
        public string Path { get; set; } // Path
        public bool PictureTaken { get; set; } // PictureTaken
        public string VerifiedBy { get; set; } // VerifiedBy
        public int? Sequenceno { get; set; } // sequenceno
        public int? IterationId { get; set; } // IterationId

        // Foreign keys
        public virtual Picture Picture { get; set; } // FK_dbo.TestRequestPicture_dbo.Picture_PictureId
        public virtual SledIteration SledIteration { get; set; } // FK_dbo_TestRequestPicture_SledIteration_IterationId
        public virtual TestRequest TestRequest { get; set; } // FK_dbo.TestRequestPicture_dbo.TestRequest_TestRequestId
    }

}
