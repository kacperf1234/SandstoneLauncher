namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Authorization.Interfaces
{
    public interface IBuilder<T>
    {
        T Build();
    }

    public interface IBuilder<T1, T2>
    {
        T1 Build(T2 arg0);
    }

    public interface IBuilder<T1, T2, T3>
    {
        T1 Build(T2 arg0, T3 arg1);
    }

    public interface IBuilder<T1, T2, T3, T4>
    {
        T1 Build(T2 arg0, T3 arg1, T4 arg2);
    }

    public interface IBuilder<T1, T2, T3, T4, T5>
    {
        T1 Build(T2 arg0, T3 arg1, T4 arg2, T5 arg3);
    }
}