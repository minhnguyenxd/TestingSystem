using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using CrashTestScheduler.Entity.Model;

namespace CrashTestScheduler.Entity.ViewModel
{
    public class ProjectBuildLevelViewModel : IInput
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int BuildLevelId { get; set; }
        public string Name { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
