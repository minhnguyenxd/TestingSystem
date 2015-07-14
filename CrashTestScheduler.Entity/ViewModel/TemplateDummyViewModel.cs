using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using CrashTestScheduler.Entity.Model;

namespace CrashTestScheduler.Entity.ViewModel
{

    public class TemplateDummiesViewModel
    {
        public int TemplateId { get; set; }
        public DummyCollectionViewModel Dummies { get; set; }
    }

    public class TestPlanDummyViewModel
    {
        public string SeatingPosition { get; set; }
        public int AtdTypeId { get; set; }
        public int AtdId { get; set; }
        public bool Belted { get; set; }
        public bool Enabled { get; set; }
        public bool InstrumentationLegs { get; set; }
        public int InstrumentedAtdLegId { get; set; }
    }

    public class DummyCollectionViewModel
    {
        private Dictionary<string, TestPlanDummyViewModel> _dictionary; 

        private void PopulateCollection(List<TestPlanDummyViewModel> dummies)
        {
            _dictionary = new Dictionary<string, TestPlanDummyViewModel>();
            dummies.ForEach(a => _dictionary.Add(a.SeatingPosition, a));
        }

        public DummyCollectionViewModel()
        {
            _dictionary = new Dictionary<string, TestPlanDummyViewModel>();
        }

        public DummyCollectionViewModel(List<TestPlanDummyViewModel> dummies)
        {
            PopulateCollection(dummies);
        }

        private TestPlanDummyViewModel GetValue(string seatRowPosition)
        {
            if (!_dictionary.Keys.Contains(seatRowPosition))
            {
                var newval = new TestPlanDummyViewModel
                {
                    SeatingPosition = seatRowPosition
                };
                _dictionary.Add(seatRowPosition, newval);
                return newval;
            }
            TestPlanDummyViewModel returnval;
            if (_dictionary.TryGetValue(seatRowPosition, out returnval))
            {
                return returnval;
            }
            return default(TestPlanDummyViewModel);
        }

        private void SetValue(string seatRowPosition, TestPlanDummyViewModel newval)
        {
            if (_dictionary.Keys.Contains(seatRowPosition))
            {
                _dictionary[seatRowPosition] = newval;
            }
            else
            {
                _dictionary.Add(seatRowPosition, newval);
            }
        }

        public TestPlanDummyViewModel GetValueByKey(string key)
        {
            return GetValue(key);
        }

        public List<TestPlanDummyViewModel> GetCollection()
        {
            var listDummies = new List<TestPlanDummyViewModel>();
            _dictionary.Keys.ToList().ForEach(
                  k => {
                      listDummies.Add(_dictionary[k]);
                  }
                );
            return listDummies;
        }

        //properties
        //"Driver", "Passenger", "RR/L", "RR/C", "RR/R", "3R/L", "3R/C", "3R/R"
        //Driver
        public TestPlanDummyViewModel Driver
        {
            get { return GetValue("Driver"); }
            set { SetValue("Driver", value); }
        }

        public TestPlanDummyViewModel Passenger
        {
            get { return GetValue("Passenger"); }
            set  { SetValue("Passenger", value); }
        }

        public TestPlanDummyViewModel RRL
        {
            get { return GetValue("RR/L"); }
            set { SetValue("RR/L", value); }
        }

        public TestPlanDummyViewModel RRC
        {
            get { return GetValue("RR/C"); }
            set { SetValue("RR/C", value); }
        }

        public TestPlanDummyViewModel RRR
        {
            get { return GetValue("RR/R"); }
            set { SetValue("RR/R", value); }
        }


        public TestPlanDummyViewModel RL3
        {
            get { return GetValue("3R/L"); }
            set { SetValue("3R/L", value); }
        }

        public TestPlanDummyViewModel RC3
        {
            get { return GetValue("3R/C"); }
            set { SetValue("3R/C", value); }
        }

        public TestPlanDummyViewModel RR3
        {
            get { return GetValue("3R/R"); }
            set { SetValue("3R/R", value); }
        }

    }


    public class TestRequestDummyViewModel
    {
        public string SeatingPosition { get; set; }
        public int AtdTypeId { get; set; }
        public int? G5Id { get; set; }
        // Since users use the ATD Id to choose a serail number, the display label is called ATD Serial Number
        [Display(Name = "ATD Serial Number" )]
        public int? AtdId { get; set; }
        public bool Belted { get; set; }
        public bool Enabled { get; set; }
        public bool InstrumentationLegs { get; set; }
        public int InstrumentedAtdLegId { get; set; }
        public string AtdSerialNumber { get; set; }
      //  public List<Atd> Atds;
        //public NameValueCollection Atds;
        public string SelectedAtdType { get; set; }
        public string SelectedG5 { get; set; }

        public string SelectedAtdTypeDescription { get; set; }
        public string SelectedInstrumentedLeg { get; set; }

    }
    public class TestRequestDummyCollectionViewModel
    {
        public int TestRequestId { get; set; }
        
        private Dictionary<string, TestRequestDummyViewModel> _dictionary;

        private void PopulateCollection(List<TestRequestDummyViewModel> dummies)
        {
            _dictionary = new Dictionary<string, TestRequestDummyViewModel>();
            dummies.ForEach(a => _dictionary.Add(a.SeatingPosition, a));
        }

        public TestRequestDummyCollectionViewModel()
        {
            _dictionary = new Dictionary<string, TestRequestDummyViewModel>();
        }

        public TestRequestDummyCollectionViewModel(List<TestRequestDummyViewModel> dummies)
        {
            PopulateCollection(dummies);
        }

        private TestRequestDummyViewModel GetValue(string seatRowPosition)
        {
            if (!_dictionary.Keys.Contains(seatRowPosition))
            {
                var newval = new TestRequestDummyViewModel
                {
                    SeatingPosition = seatRowPosition
                };
                _dictionary.Add(seatRowPosition, newval);
                return newval;
            }
            TestRequestDummyViewModel returnval;
            if (_dictionary.TryGetValue(seatRowPosition, out returnval))
            {
                return returnval;
            }
            return default(TestRequestDummyViewModel);
        }

        private void SetValue(string seatRowPosition, TestRequestDummyViewModel newval)
        {
            if (_dictionary.Keys.Contains(seatRowPosition))
            {
                _dictionary[seatRowPosition] = newval;
            }
            else
            {
                _dictionary.Add(seatRowPosition, newval);
            }
        }

        public TestRequestDummyViewModel GetValueByKey(string key)
        {
            return GetValue(key);
        }

        public List<TestRequestDummyViewModel> GetCollection()
        {
            var listDummies = new List<TestRequestDummyViewModel>();
            _dictionary.Keys.ToList().ForEach(
                  k =>
                  {
                      listDummies.Add(_dictionary[k]);
                  }
                );
            return listDummies;
        }

        //properties
        //"Driver", "Passenger", "RR/L", "RR/C", "RR/R", "3R/L", "3R/C", "3R/R"
        //Driver
        public TestRequestDummyViewModel Driver
        {
            get { return GetValue("Driver"); }
            set { SetValue("Driver", value); }
        }

        public TestRequestDummyViewModel Passenger
        {
            get { return GetValue("Passenger"); }
            set { SetValue("Passenger", value); }
        }

        public TestRequestDummyViewModel RRL
        {
            get { return GetValue("RR/L"); }
            set { SetValue("RR/L", value); }
        }

        public TestRequestDummyViewModel RRC
        {
            get { return GetValue("RR/C"); }
            set { SetValue("RR/C", value); }
        }

        public TestRequestDummyViewModel RRR
        {
            get { return GetValue("RR/R"); }
            set { SetValue("RR/R", value); }
        }


        public TestRequestDummyViewModel RL3
        {
            get { return GetValue("3R/L"); }
            set { SetValue("3R/L", value); }
        }

        public TestRequestDummyViewModel RC3
        {
            get { return GetValue("3R/C"); }
            set { SetValue("3R/C", value); }
        }

        public TestRequestDummyViewModel RR3
        {
            get { return GetValue("3R/R"); }
            set { SetValue("3R/R", value); }
        }

    }
}
