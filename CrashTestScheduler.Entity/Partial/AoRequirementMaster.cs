using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;

namespace CrashTestScheduler.Entity.Model
{
    public partial class Inputout : EntityBase
    {
        public override int Id { get; set; }
    }
    public partial class AoRequirementMaster : EntityBase
    {
        public override int Id { get; set; }
    }
    public partial class Sysdiagram : EntityBase
    {
        public override int Id { get; set; }
    }
    public partial class AoInjuryMapping : EntityBase
    {
        public override int Id { get; set; }
    }
public partial class AociMapping : EntityBase
    {
        public override int Id { get; set; }
    }

}
