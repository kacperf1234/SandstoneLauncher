namespace KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces
{
    public interface IValidator<in T>
    {
        bool Validate(T obj);
    }
}