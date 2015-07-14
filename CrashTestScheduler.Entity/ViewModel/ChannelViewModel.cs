#region

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using CrashTestScheduler.Entity.Model;

#endregion

namespace CrashTestScheduler.Entity.ViewModel
{
    public class ChannelViewModel
    {
        public int Id { get; set; }
        //[Display(Name = "Name")]
        //[Required(ErrorMessage = "Please specify the channel name.")]
        public string Name { get; set; }
        public string Description { get; set; }
        public string ChannelGroupName { get; set; }
        public string MeasurementName { get; set; }
        // newly updated
        public string Part { get; set; } // Part
        public string Direction1 { get; set; } // Direction
        public string IndexName { get; set; } // IndexName
        public int? MeasurementId { get; set; } // MeasurementId

        public int ChannelGroupId { get; set; }
        public IEnumerable<SelectListItem> ChannelGroups { get; set; }

        //[Required]
        public string Measurement { get; set; }
        //public string DirectionTypes { get; set; }
    }
}