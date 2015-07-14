
using System.ComponentModel.DataAnnotations;

namespace CrashTestScheduler.Entity.ViewModel
{
    public class TestModeViewModel : IInput
    {
        public int Id { get; set; }
        [Required (ErrorMessage = "Test Type is required.") ]
        [Display(Name = "Test type")]
        public int TestTypeId { get; set; }

        [Required(ErrorMessage = "Test Mode is required.")]
        [Display(Name = "Test Mode")]
        public string Name { get; set; }

        public string TestTypeName { get; set; }

        [Display(Name = "Delete")]
        public bool? IsDeleted { get; set; }

        public int TestTypeCalendarTypeId { get; set; }

    }
}
