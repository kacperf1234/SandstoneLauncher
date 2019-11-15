namespace KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces
{
    public interface IJsonDeserializer<T>
    {
        T Deserialize(string json);
    }
}