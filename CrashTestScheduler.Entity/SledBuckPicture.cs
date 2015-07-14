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
    // SledBuckPicture
    public partial class SledBuckPicture : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int SledBuckId { get; set; } // SledBuckId
        public string Picture { get; set; } // Picture
    }

}
