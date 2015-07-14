using System;
using System.Collections.Generic;
using Repository;

namespace CrashTestScheduler.Entity.Model
{
    public  class BridgeType :EntityBase
    {
        public BridgeType()
        {
            this.DummyChannels = new List<AtdChannel>();
        }

        public override int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<AtdChannel> DummyChannels { get; set; }
    }
}
