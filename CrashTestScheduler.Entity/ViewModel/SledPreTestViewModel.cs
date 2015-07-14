#region

using System;
using System.ComponentModel.DataAnnotations;

#endregion

namespace CrashTestScheduler.Entity.ViewModel
{
    public class SledPreTestViewModel
    {
        public int Id { get; set; }
        public int ResultID { get; set; }
        public int OilTemp { get; set; }
        public string ShotType { get; set; }
    }       
}