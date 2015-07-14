namespace CrashTestScheduler.Entity.ViewModel
{
    public class TestRequestVideoViewModel : IInput
    {
        public int Id { get; set; }
        public string VideoName { get; set; }
        public bool VideoTaken { get; set; }
        public string VideoThumbNailPath { get; set; }
        public int VideoId { get; set; }
        public string TemplateName { get; set; }
        public int TestRequestId { get; set; }
        public int IterationId { get; set; }
        public string VerifiedBy { get; set; }
    }
}