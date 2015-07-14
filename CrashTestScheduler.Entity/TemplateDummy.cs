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
    // TemplateDummy
    public partial class TemplateDummy : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public int TemplateId { get; set; } // TemplateId
        public int AtdTypeId { get; set; } // AtdTypeId
        public string SeatingPosition { get; set; } // SeatingPosition
        public bool Belted { get; set; } // Belted
        public bool Enabled { get; set; } // Enabled
        public bool InstrumentationLegs { get; set; } // InstrumentationLegs

        // Foreign keys
        public virtual AtdType AtdType { get; set; } // FK_dbo.TemplateDummy_dbo.AtdType_AtdTypeId
    }

}
