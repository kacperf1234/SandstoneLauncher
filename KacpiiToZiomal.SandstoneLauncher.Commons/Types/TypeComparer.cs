using System;
using System.Reflection;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Types
{
    public class TypeComparer : ITypeComparer
    {
        public bool Compare(Type t1, Type t2) => t1 == t2;
    }
}