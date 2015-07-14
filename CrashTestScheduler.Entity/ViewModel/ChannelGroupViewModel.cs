using System.ComponentModel.DataAnnotations;

namespace CrashTestScheduler.Entity.ViewModel
{
    public class ChannelGroupViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}