using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashTestScheduler.Entity.ViewModel
{
    public class VideoViewModel : IInput
    {
        public int Id { get; set; }
        public string VideoName { get; set; }
        public string VideoThumbNailPath { get; set; }
        public bool Selected { get; set; }
        public int VideoId { get; set; }
        public string TemplateName { get; set; }
        public int TemplateId { get; set; }
        public int IterationId { get; set; }
        public int TestRequestId { get; set; }
    }

    public class VidViewModel : IInput
    {
        public VidViewModel()
        {
            this.ThumbNailPath = string.Empty;
            this.ImageUrl = string.Empty;
            this.VideoTaken = false;
            this.Selected = false;
        }

        public int Id { get; set; }
        public int TestRequestId { get; set; }
        [Required(ErrorMessage = "Video's name is required")]
        public string Name { get; set; }
        public string ThumbNailPath { get; set; }
        public string ImageUrl { get; set; }
        public List<TestTypeViewModel> TestList { get; set; }
        public bool IsDeleted { get; set; }
        public bool VideoTaken { get; set; } 
        public string SelectedTestTypes { get; set; }
        public int TemplateId { get; set; }
        public bool Selected { get; set; } 
    }
}



