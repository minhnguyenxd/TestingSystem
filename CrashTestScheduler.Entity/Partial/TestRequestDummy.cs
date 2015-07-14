using System;

namespace CrashTestScheduler.Entity.Model
{
    public partial class TestRequestDummy : IComparable
    {


        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            var du = obj as TestRequestDummy;
            if (du.Enabled != Enabled) return 1;
            if (du.SeatingPosition != SeatingPosition) return 1;
            if (du.AtdId != AtdId) return 1;
            if (du.Belted != Belted) return 1;
            if (du.InstrumentationLegs != InstrumentationLegs) return 1;
            if (du.AtdTypeId != AtdTypeId) return 1;
            if (du.InstrumentedAtdLegId != InstrumentedAtdLegId) return 1;

            return 0;

        }
    }
}