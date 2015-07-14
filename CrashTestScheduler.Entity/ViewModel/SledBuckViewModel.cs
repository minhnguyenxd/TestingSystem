#region

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CrashTestScheduler.Entity.Model;

#endregion

namespace CrashTestScheduler.Entity.ViewModel
{
    public class SledBuckViewModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        public bool IsDestroyed { get; set; }
        //[Display(Name = "Location")]
        public string Location { get; set; }
        //[Display(Name = "Side Picture")]
        public List<string> PictureList { get; set; }
        public List<int> PictureIdList { get; set; }
        public int DeletedPictureId { get; set; }
        [Required]
        public string SledType { get; set; }
        public decimal? SledMass { get; set; }
        public string Capability { get; set; }
        public int? BuildLevelId { get; set; }
        public List<Quadrant> QuadrantList { get; set; }
        public DateTime? CreatedDate { get; set; } // CreatedDate
        public string CreatedBy { get; set; } // CreatedBy
        public DateTime? LastUpdatedDate { get; set; } // LastUpdatedDate
        public string LastUpdatedBy { get; set; } // LastUpdatedBy
        public DateTime? DestroyedDate { get; set; } // DestroyedDate
        public string DestroyedBy { get; set; } // DestroyedBy

    }
}