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
    // TestMode
    public partial class TestMode : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int TestTypeId { get; set; } // TestTypeId
        public string Name { get; set; } // Name
        public bool? IsDeleted { get; set; } // IsDeleted

        // Reverse navigation
        public virtual ICollection<TestModeTypeTemplateMap> TestModeTypeTemplateMaps { get; set; } // TestModeTypeTemplateMap.FK_dbo.TestModeTypeTemplateMap_dbo.TestMode_TestModeId
        public virtual ICollection<TestRequest> TestRequests { get; set; } // TestRequest.FK_dbo.TestRequest_dbo.TestMode_TestModeId

        // Foreign keys
        public virtual TestType TestType { get; set; } // FK_dbo.TestMode_dbo.TestType_TestTypeId

        public TestMode()
        {
            TestModeTypeTemplateMaps = new List<TestModeTypeTemplateMap>();
            TestRequests = new List<TestRequest>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
