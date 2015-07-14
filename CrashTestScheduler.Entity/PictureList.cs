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
    // PictureList
    public partial class PictureList : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int TestTypeId { get; set; } // TestTypeId
        public int PictureId { get; set; } // PictureId

        // Foreign keys
        public virtual Picture Picture { get; set; } // FK_dbo.PictureList_dbo.Picture_PictureId
    }

}
