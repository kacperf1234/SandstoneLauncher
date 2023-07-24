using System;
using System.Collections.Generic;
using SandstoneLauncher.Minecraft.Enums;

namespace SandstoneLauncher.Minecraft.Interfaces
{
    public interface ISimpleParallel
    {
        void ForEach<T>(IEnumerable<T> arr, Action<T> act, ParallelMode mode = ParallelMode.ASYNCHRONOUSLY);
    }
}