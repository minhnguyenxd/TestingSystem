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
    // PictureVideoPath
    public partial class PictureVideoPath : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int TestRequestId { get; set; } // TestRequestId
        public string BasePath { get; set; } // BasePath
        public string PictureSubFolder { get; set; } // PictureSubFolder
        public string VideoSubFolder { get; set; } // VideoSubFolder
        public string DatFolder { get; set; } // DatFolder
    }

}
