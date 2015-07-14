#region

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Humanizer;
using model = CrashTestScheduler.Entity.Model;

#endregion

namespace CrashTestScheduler.Entity.ViewModel
{
}

namespace CrashTestScheduler.Entity.ViewModel
{
    public class SledTestPlanViewModel
    {
        public int Id { get; set; }
        public int TestRequestId { get; set; }
        public int IterationId { get; set; }
        public int Speed { get; set; }
        public int TestId { get; set; }
        public int Row { get; set; }
        public string Angle { get; set; }
        public int PosType { get; set; }
        public int? PosAtdTypeId { get; set; }
        public int Pos2Type { get; set; }
        public int? Pos2AtdTypeId { get; set; }
        public int Pos3Type { get; set; }
        public int? Pos3AtdTypeId { get; set; }
        public bool IsPosTtfFilled { get; set; } // IsPosTtfFilled
        public bool IsPos2TtfFilled { get; set; } // IsPos2TtfFilled
        public bool IsPos3TtfFilled { get; set; } // IsPos3TtfFilled
        public string TestNumber { get; set; }
    }
}