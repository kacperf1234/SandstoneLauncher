using System;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Types
{
    public class TypeGetter : ITypeGetter
    {
        public Type GetType(object o) => o.GetType();

        public Type GetType<T>() => typeof(T);
    }
}