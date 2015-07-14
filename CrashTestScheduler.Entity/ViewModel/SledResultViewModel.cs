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
    public class SledResultViewModel
    {
        public int Id { get; set; }
        public int SledScheduleTestId { get; set; }
        public string ResultType { get; set; }
        public string TestName { get; set; }
        public string Project { get; set; }
        public string TestPic { get; set; }
        public string TestType { get; set; }
        public string TestDate { get; set; }
        public string TestTime { get; set; }
        public string ResultID { get; set; }
        public string SledType { get; set; }
        public string Buck { get; set; }
        public string Lab { get; set; }
        public bool ResultStatus { get; set; }
        public bool IsOffSiteLab { get; set; }
        public int Speed { get; set; }
        public int ISTTestID { get; set; }
        public string ISTTestName { get; set; }
        public int ISTProjectID { get; set; }
        public string ISTProjectName { get; set; }
        public int ISTSingalID { get; set; }
        public string ISTSingalName { get; set; }
        public string ASISPulseName { get; set; }
        public int AdditionalSledWeight { get; set; }
        public int BreakPressure { get; set; }
        public int OilTemp { get; set; }
        public decimal LabTemp { get; set; }
        public decimal LabHumidity { get; set; }
        public string Comments { get; set; }
        public int IterationId { get; set; }
        public string ISTPreTrigger { get; set; }
        public string ASISTestName { get; set; }
        public string ASISPreTrigger { get; set; }
        public List<SledPreTestViewModel> SledPreTestData { get; set; }
        public List<SledResultCheckListViewModel> SledCheckListData { get; set; }
        public SledResultViewModel()
        {
            SledPreTestData = new List<SledPreTestViewModel>();
            SledCheckListData = new List<SledResultCheckListViewModel>();
        }
    }
}
