#region

using System;
using System.ComponentModel.DataAnnotations;

#endregion

namespace CrashTestScheduler.Entity.ViewModel
{
    public class SledResultCheckListViewModel
    {
        public int Id { get; set; }
        public int CheckListId { get; set; }
        public string CheckListName { get; set; }
        public int ResultId { get; set; }
    }
}