using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SandstoneLauncher.Minecraft.Enums;
using SandstoneLauncher.Minecraft.Interfaces;

namespace SandstoneLauncher.Minecraft.Types
{
    public class SimpleParallel : ISimpleParallel
    {
        public void ForEach<T>(IEnumerable<T> arr, Action<T> act, ParallelMode mode = ParallelMode.ASYNCHRONOUSLY)
        {
            if (mode == ParallelMode.ASYNCHRONOUSLY)
                ForEachAsynchronously(arr, act);

            else if (mode == ParallelMode.SYNCHRONOUSLY) ForEachSynchronously(arr, act);
        }

        public void ForEachAsynchronously<T>(IEnumerable<T> arr, Action<T> act)
        {
            List<Task> tasks = new List<Task>();

            foreach (T i in arr) tasks.Add(Task.Run(() => act.Invoke(i)));

            Task.WaitAll(tasks.ToArray());
        }

        public void ForEachSynchronously<T>(IEnumerable<T> arr, Action<T> act)
        {
            foreach (T i in arr) act.Invoke(i);
        }
    }
}