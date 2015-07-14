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
    // ChecklistData
    public partial class ChecklistData : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public string Type { get; set; } // Type
        public string Description { get; set; } // Description
        public bool SecondApproval { get; set; } // SecondApproval
        public bool NeedsInput { get; set; } // NeedsInput
        public string TextBoxLabel { get; set; } // TextBoxLabel
        public string Unit { get; set; } // Unit
        public string Source { get; set; } // Source
        public bool IncludeInPostTest { get; set; } // IncludeInPostTest
        public string MapColumn { get; set; } // MapColumn
        public string DisplayType { get; set; } // DisplayType
        public bool? IsPostTest { get; set; } // IsPostTest

        // Reverse navigation
        public virtual ICollection<ChecklistTemplateMap> ChecklistTemplateMaps { get; set; } // ChecklistTemplateMap.FK_dbo.ChecklistTemplateMap_dbo.ChecklistData_CheckListDataId
        public virtual ICollection<ChecklistTestPlan> ChecklistTestPlans { get; set; } // ChecklistTestPlan.FK_dbo.ChecklistTestPlan_dbo.ChecklistData_ChecklistDataId

        public ChecklistData()
        {
            IncludeInPostTest = false;
            ChecklistTemplateMaps = new List<ChecklistTemplateMap>();
            ChecklistTestPlans = new List<ChecklistTestPlan>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
