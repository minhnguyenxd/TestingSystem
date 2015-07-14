#region

using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
#endregion

namespace CrashTestScheduler.Entity.ViewModel
{

    public class SledTestPlanDetailViewModel
    {
        public int NoOfTotalIternation { get; set; }

        public List<SledIterationViewModel> SledIterationDetails { get; set; }
        public SledTestPlanDetailViewModel()
        {
            SledIterationDetails = new List<SledIterationViewModel>();
        }
    }

}