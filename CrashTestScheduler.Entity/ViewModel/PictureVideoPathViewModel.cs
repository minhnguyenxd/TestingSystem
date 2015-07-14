using System;
using System.Xml;
using System.Xml.Serialization;
namespace CrashTestScheduler.Entity.ViewModel
{
    [Serializable]
    public class PictureVideoPathViewModel
    {
        [XmlIgnore]
        public int PicVideoPathId { get; set; }
        
        [XmlIgnore]
        public int TestRequestId { get; set; }

        [XmlIgnore]
        public string BasePath { get; set; }

        [XmlElement(ElementName = "PictureLocation", IsNullable = true)]
        public string PictureSubFolder { get; set; }

        [XmlElement(ElementName = "VideoLocation", IsNullable = true)]
        public string VideoSubFolder { get; set; }
        
        [XmlElement(ElementName = "DatLocation", IsNullable = true)]
        public string DatFolder { get; set; }
        
    }
}
