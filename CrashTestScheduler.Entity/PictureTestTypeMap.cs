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
    // PictureTestTypeMap
    public partial class PictureTestTypeMap : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int PictureId { get; set; } // PictureId
        public int TestTypeId { get; set; } // TestTypeId

        // Foreign keys
        public virtual Picture Picture { get; set; } // FK_dbo.PictureTestTypeMap_dbo.Picture_PictureId
        public virtual TestType TestType { get; set; } // FK_dbo.PictureTestTypeMap_dbo.TestType_TestTypeId
    }

}
