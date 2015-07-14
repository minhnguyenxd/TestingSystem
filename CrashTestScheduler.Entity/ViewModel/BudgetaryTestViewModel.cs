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
    public class BudgetaryTestViewModel
    {
        public int Id { get; set; }
        public int CalendarTypeId { get; set; }
        public DateTime RequestedTestDate { get; set; }
        public string PicName { get; set; }
        public string PicPhone { get; set; }
        public int ProjectId { get; set; }
        public int TestTypeId { get; set; }
        public int TestModeId { get; set; }
        public int TestLaboratoryId { get; set; }
    }
}