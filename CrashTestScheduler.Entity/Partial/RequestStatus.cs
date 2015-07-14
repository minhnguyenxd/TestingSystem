namespace CrashTestScheduler.Entity.Model
{
    public enum RequestStatus : byte
    {
        Requested,
        Scheduled,
        // ReSharper disable once InconsistentNaming
        PTCApproved,
        TestCompleted,
        ChangeRequested,
        BudgetaryRequest,
        TestCancelled,
        // ReSharper disable once InconsistentNaming
        PTCRequested,
        BumperPendulum
    }

    public enum PtcRequestStatus
    {
        NotRequested,
        Requested,
        Approved
    }
}