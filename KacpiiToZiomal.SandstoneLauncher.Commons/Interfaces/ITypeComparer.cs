using System;
using System.Reflection;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces
{
    public interface ITypeComparer
    {
        bool Compare(Type t1, Type t2);
    }
}