using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CrashTestScheduler.Entity.ViewModel
{

    // TODO be renamed pic Template view Model
    public class PictureViewModel : IInput
    {
        public int Id { get; set; }
        public string PictureName { get; set; }
        public string PictureType { get; set; }
        public string PictureThumbNailPath { get; set; }
        public bool Selected { get; set; }
        public int PictureId { get; set; }
        public int IterationId { get; set; }
        public int TestRequestId { get; set; }
        public string TemplateName { get; set; }
        public int TemplateId { get; set; }
        public int? SequenceNo { get; set; }
        public string PictureVerifiedBy { get; set; }



    }


    /// <summary>
    /// This view model is used when displaying pictures in picture grid
    /// </summary>
    public class PicViewModel : IInput
    {
		public PicViewModel() {
			this.ThumbNailPath = string.Empty;
			this.ImageUrl = string.Empty;
		    this.PictureTaken = false;
            
		}

        public int Id { get; set; }
        [Required(ErrorMessage = "Picture's name is required")]
        public string Name { get; set; }
        public string ThumbNailPath { get; set; }
        public string ImageUrl { get; set; }
        public List<TestTypeViewModel> TestList { get; set; }
        public bool IsDeleted { get; set; }
        public bool Selected { get; set; }
        
        //"Picture Checklist  Type
        public string Type { get; set; }
        public string SelectedTestTypes { get; set; }

        public string VerifiedBy { get; set; }        
        public bool PictureTaken { get; set; }                   
        public int TestRequestId { get; set; }     
        public int SequenceNo { get; set; }
        public int TemplateId { get; set; }
    }
}
