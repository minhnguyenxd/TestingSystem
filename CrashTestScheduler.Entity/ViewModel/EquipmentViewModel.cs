using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using CrashTestScheduler.Entity.Model;

namespace CrashTestScheduler.Entity.ViewModel
{
    public enum MaintenanceSchedule
    {
        Weekly,
        Monthly,
        Annual
    }

    public class EquipmentViewModel : IInput
    {
        //public EquipmentViewModel()
        //{
        //    EquipmentEventViewModels = new List<EquipmentEventViewModel>();
        // //   PICs = new List<EquipmentPic>();
        //}

        public int Id { get; set; }

        public int SNo { get; set; }

        [Required]
        [Display(Name = "Equipment Name")]
        public string EquipmentName { get; set; }

        [Required]
        [Display(Name = "Maintenance Schedule")]
        public int MaintenanceSchedule { get; set; }

        [Display(Name = "Last Calibration Date")]
        public DateTime? LastCalibrationDate { get; set; }

        [Required]
        [Display(Name = "Next Calibration Date")]
        public DateTime NextCalibrationDate { get; set; }
        
        [Required]
        [Display(Name = "Notify PIC")]
        public bool NotifyPic { get; set; }

        public bool IsActive { get; set; }

        //public List<EquipmentPic> PICs { get; set; }
        //public List<EquipmentEventViewModel> EquipmentEventViewModels { get; set; }
    }
}
