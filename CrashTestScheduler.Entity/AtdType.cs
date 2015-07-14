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
    // AtdType
    public partial class AtdType : EntityBase
    {
        public override  int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name
        public string Description { get; set; } // Description
        public bool IsBallast { get; set; } // IsBallast
        public bool? IsDeleted { get; set; } // IsDeleted
        public DateTime? DeletedDate { get; set; } // DeletedDate
        public string DeletedBy { get; set; } // DeletedBy

        // Reverse navigation
        public virtual ICollection<Atd> Atds { get; set; } // Atd.FK_dbo.Atd_dbo.AtdType_AtdTypeId
        public virtual ICollection<InstrumentedAtdLeg> InstrumentedAtdLegs { get; set; } // InstrumentedATDLegs.FK_dbo.InstrumentedATDLegs_dbo.AtdType_AtdTypeId
        public virtual ICollection<IrlTestPlan> IrlTestPlans { get; set; } // IrlTestPlan.FK_IrlTestPlan_AtdType
        public virtual ICollection<SledTestPlan> SledTestPlans_Pos2AtdTypeId { get; set; } // SledTestPlan.FK_SledTestPlan_AtdType1
        public virtual ICollection<SledTestPlan> SledTestPlans_Pos3AtdTypeId { get; set; } // SledTestPlan.FK_SledTestPlan_AtdType2
        public virtual ICollection<SledTestPlan> SledTestPlans_PosAtdTypeId { get; set; } // SledTestPlan.FK_SledTestPlan_AtdType
        public virtual ICollection<TemplateDummy> TemplateDummies { get; set; } // TemplateDummy.FK_dbo.TemplateDummy_dbo.AtdType_AtdTypeId
        public virtual ICollection<TestRequestDummy> TestRequestDummies { get; set; } // TestRequestDummy.FK_dbo.TestRequestDummy_dbo.AtdType_AtdTypeId

        public AtdType()
        {
            Atds = new List<Atd>();
            InstrumentedAtdLegs = new List<InstrumentedAtdLeg>();
            IrlTestPlans = new List<IrlTestPlan>();
            SledTestPlans_Pos2AtdTypeId = new List<SledTestPlan>();
            SledTestPlans_Pos3AtdTypeId = new List<SledTestPlan>();
            SledTestPlans_PosAtdTypeId = new List<SledTestPlan>();
            TemplateDummies = new List<TemplateDummy>();
            TestRequestDummies = new List<TestRequestDummy>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
