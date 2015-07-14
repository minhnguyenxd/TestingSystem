using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using CrashTestScheduler.Entity.Model;

namespace CrashTestScheduler.Entity.ViewModel
{
    public class ProjectViewModel : IInput
    {
        public ProjectViewModel()
        {
            ProjectBuildLevels = new List<ProjectBuildLevelViewModel>();
        }

        public int Id { get; set; }

        [Required]
        [Display(Name = "Project Code")]
        public string ProjectCode { get; set; }
        [Required]
        [Display(Name = "Frame Code")]
        public string FrameCode { get; set; }
        [Required]
        [Display(Name = "# of Rows")]
        public int SeatRows { get; set; }
        [Required]
        [Display(Name = "Lead")]
        public string ProjectLead { get; set; }
        
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Lead Email")]
        public string ProjectLeadEmail { get; set; }

        [Required]
        public string Comments { get; set; }

        //[Display(Name = "Delete")]
        public bool IsDeleted { get; set; }

        public List<ProjectBuildLevelViewModel> ProjectBuildLevels { get; set; }
    }
}
