namespace CrashTestScheduler.Entity.ViewModel
{
    public interface IInput
    {
        int Id { get; set; }
    }
    public interface IMapper<TEntity, TInput> 
        where TEntity : class, new() 
        where TInput : new()
    {
        TInput MapToInput(TEntity entity);
        TEntity MapToEntity(TInput input, TEntity entity);
    }

    public class AtdChannelLocationViewModel : IInput
    {
        public int Id { get; set; }
        public string Location { get; set; }
    }
}
