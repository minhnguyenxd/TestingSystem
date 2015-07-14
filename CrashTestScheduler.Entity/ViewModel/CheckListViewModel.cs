using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Web.Mvc;

using Repository;
using CrashTestScheduler.Entity.Model;

namespace CrashTestScheduler.Entity.ViewModel
{
    public class CheckListUserDataViewModel
    {
        public string Key { get; set; }
        public string Answer { get; set; }
    }

    public class CheckListItemViewModel
    {
        public string Key { get; set; } //unique for the set
        public string ChecklistItem { get; set; } //chcklist question
        public bool Enabled { get; set; }
        public bool Verified { get; set; }
        public string VerifiedBy { get; set; }
        public DateTime? VerifiedDate { get; set; }
        public bool PostVerificationRequired { get; set; }
        public bool PostVerified { get; set; }
        public string PostVerifiedBy { get; set; }
        public DateTime? PostVerfiedDate { get; set; }
        public int SortOrder { get; set; }
        public List<CheckListUserDataViewModel> ChecklistAnswerData { get; set; }
    }


    public class CheckListViewModel
    {
        private Dictionary<string, CheckListItemViewModel> _dictionary = new Dictionary<string,CheckListItemViewModel>();
        private List<CheckListItemViewModel> _listItems = new List<CheckListItemViewModel>();

        public int TestPlanId { get; set; }
        public int TemplateId { get; set; }

        private CheckListItemViewModel GetValuesFromForm( FormCollection formcollection, List<string> keys, string prefix )
        {
            var chk = new CheckListItemViewModel();

            var keyPrefix = prefix + ".";
            foreach(var str in keys)
            {
                var propName = str.Replace(keyPrefix,"");
                var pinfo = chk.GetType().GetProperty(propName);
                if(pinfo != null) //property found
                {
                    var keyVal = formcollection.GetValue(str);
                    pinfo.SetValue(chk, keyVal.ConvertTo(pinfo.PropertyType));
                }
                else
                {
                    if(chk.ChecklistAnswerData == null)
                    {
                        chk.ChecklistAnswerData = new List<CheckListUserDataViewModel>();
                    }
                    chk.ChecklistAnswerData.Add(new CheckListUserDataViewModel { 
                        Key = propName, 
                        Answer = formcollection.GetValue(str).ToString() });
                }

            }
            chk.Key = prefix;
            return chk;
        }

        public List<CheckListItemViewModel> UpdateFromDataModel(List<ChecklistData> defaultDataCollection)
        {
            //populate both;
            _listItems.Clear();
            _dictionary.Clear();
            defaultDataCollection.ForEach(a => {

                var vm = new CheckListItemViewModel
                {
                    Key = a.Key,
                    ChecklistItem = a.ChecklistItem,
                    Enabled = true
                };

                _dictionary.Add(a.Key, vm );
                _listItems.Add(vm);
            });
            return _listItems; //render to view
        }

        public List<CheckListItemViewModel> UpdateFromDataModel(List<CheckListTemplate> templateDataCollection)
        {
            _listItems.Clear();
            _dictionary.Clear();
            templateDataCollection.ForEach(a => {
                var vm = new CheckListItemViewModel
                       {
                           Key = a.Key,
                           ChecklistItem = a.ChecklistItem,
                           Enabled = a.Enabled,
                           PostVerificationRequired = a.PostVerificationRequired
                       };
                _dictionary.Add( a.Key, vm);
                _listItems.Add(vm);
            });
            return _listItems; //render to view
        }

        public List<CheckListItemViewModel> UpdateFromDataModel(List<CheckListTestPlan> testplanDataCollection)
        {
            _listItems.Clear();
            _dictionary.Clear();
            testplanDataCollection.ForEach(a => {
                var tpData = new CheckListItemViewModel
                {
                    Key = a.Key,
                    ChecklistItem = a.ChecklistItem,
                    Verified = a.Verified,
                    VerifiedBy = a.PostVerifiedBy,
                    VerifiedDate = a.VerifiedDate,
                    PostVerified = a.PostVerified,
                    PostVerifiedBy = a.PostVerifiedBy,
                    PostVerfiedDate = a.PostVerfiedDate,
                    PostVerificationRequired = a.PostVerificationRequired
                };
                if( a.CheckListUserData != null && a.CheckListUserData.Count > 0 )
                {
                    tpData.ChecklistAnswerData = new List<CheckListUserDataViewModel>();
                    a.CheckListUserData.ToList().ForEach(v => { tpData.ChecklistAnswerData.Add(new CheckListUserDataViewModel { Key = v.Key, Answer = v.Answer }); });
                }
                _listItems.Add(tpData);
                _dictionary.Add(a.Key, tpData);
            });
            return _listItems; //render to view
        }

        /// <summary>
        /// Accept data from form to viewmodel - viewmodel has to be populated first from data to
        /// obtain valid keys, before calling this method
        /// </summary>
        /// <param name="formCollection"></param>
        /// <returns></returns>
        public List<CheckListItemViewModel> TryUpdateModel( FormCollection formCollection)
        {
            _listItems.Clear();
            //foreach key in _dictionary (earch item), update values from collection
            foreach( var k in _dictionary.Keys)
            {
                var keys = formCollection.AllKeys.Where(a => a.Contains(k)).ToList();
                if( keys.Count > 0)
                {
                    var newitem = GetValuesFromForm(formCollection, keys, k);
                    _listItems.Add(newitem);
                }
            }
            return _listItems;
        }

        //update to db
        public void UpdateDataModel(List<CheckListTemplate> dataModel)
        {
            //add if they are not found, else update

        }

        public void UpdateDataModel(List<CheckListTestPlan> dataModel)
        {

        }

    }
}
