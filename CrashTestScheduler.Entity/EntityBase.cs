using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;

namespace CrashTestScheduler.Entity
{
    public class EntityBase1
    {
        public ObjectState ObjectState { get; set; }
        public virtual int Id { get; set; }
    }
}
