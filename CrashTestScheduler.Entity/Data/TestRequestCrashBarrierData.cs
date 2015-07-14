using CrashTestScheduler.Entity.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CrashTestScheduler.Entity.Data
{
    [Serializable]
    public class TestRequestCrashBarrierData
    {
        public CrashTestViewModel RequestDetails { get; set; }
        public RequestTestPlanVModel GeneralInfo { get; set; }
        [System.Xml.Serialization.XmlArray("ATD", IsNullable = true)]
        public List<TestRequestDummyViewModel> ATD { get; set; }
        public List<TestRequestChannelViewModel> Sensors { get; set; }


        [System.Xml.Serialization.XmlArray("CounterMeasures", IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItem("CounterMeasure")]
        public List<CounterMeasureViewModel> CounterMeasures { get; set; }

        [System.Xml.Serialization.XmlArray("PictureList", IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItem("Picture")]
        public List<TestRequestPictureViewModel> Pictures { get; set; }

        [System.Xml.Serialization.XmlArray("VideoList", IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItem("Video")]
        public List<TestRequestVideoViewModel> Videos { get; set; }

        [System.Xml.Serialization.XmlArray("ChecklistItems", IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItem("Checklist")]
        public List<TestRequestChecklistViewModel> Checklist { get; set; }

        [System.Xml.Serialization.XmlArray("Comments", IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItem("Comment")]
        public List<CommentViewModel> CommentList { get; set; } 
        //public CrashTestViewModel Checklist { get; set; }

        [XmlElement(ElementName = "Data",IsNullable = true)]
        public PictureVideoPathViewModel PictureVideoPath { get; set; } 

        public TestRequestCrashBarrierData()
        {
            this.RequestDetails = new CrashTestViewModel();
            this.GeneralInfo = new RequestTestPlanVModel();
            this.ATD = new List<TestRequestDummyViewModel>();
            this.Sensors = new List<TestRequestChannelViewModel>();
            this.CounterMeasures = new List<CounterMeasureViewModel>();
            this.Pictures = new List<TestRequestPictureViewModel>();
            this.Videos = new List<TestRequestVideoViewModel>();
            this.Checklist = new List<TestRequestChecklistViewModel>();
        }
        public string ToXML()
        {
            if (this.ATD.Count == 0)
                this.ATD = null;
            if (this.Pictures.Count == 0)
                this.Pictures = null;
            if (this.Videos.Count == 0)
                this.Videos = null;
            var stringwriter = new Utf8StringWriter();
           
            var serializer = new XmlSerializer(this.GetType());
            serializer.Serialize(stringwriter, this);
            return stringwriter.ToString();
        }
    }

    public class Utf8StringWriter : StringWriter
    {
        public override Encoding Encoding
        {
            get { return Encoding.UTF8; }
        }
    }

    public class SledTestRequestData
    {
        
    }
}
