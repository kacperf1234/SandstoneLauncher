using System;
using System.Collections.Generic;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Enums;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface ISimpleParallel
    {
        void ForEach<T>(IEnumerable<T> arr, Action<T> act, ParallelMode mode = ParallelMode.ASYNCHRONOUSLY);
    }
}