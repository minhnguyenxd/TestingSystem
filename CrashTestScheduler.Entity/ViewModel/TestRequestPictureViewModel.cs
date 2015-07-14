namespace CrashTestScheduler.Entity.ViewModel
{
    public class TestRequestPictureViewModel : IInput
    {
        public int Id { get; set; }
        public string PictureName { get; set; }
        public bool PictureTaken { get; set; }
        public int PictureId { get; set; }
        public string PictureType { get; set; }
        public string PictureThumbNailPath { get; set; }
        public string TemplateName { get; set; }
        public int TestRequestId { get; set; }
        public int IterationId { get; set; }
        public int SequenceId { get; set; }
        public int SequenceNo { get; set; }
        public bool Verified { get; set; }
        public string VerifiedBy { get; set; }
    }
}