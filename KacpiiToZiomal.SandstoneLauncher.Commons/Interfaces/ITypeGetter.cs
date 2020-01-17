using System;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces
{
    public interface ITypeGetter
    {
        Type GetType(object o);

        Type GetType<T>();

        Type GetGenericType(Type type);
    }
}