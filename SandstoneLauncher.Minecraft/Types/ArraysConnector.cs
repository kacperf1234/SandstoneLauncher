using System.Collections.Generic;
using SandstoneLauncher.Minecraft.Interfaces;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class ArraysConnector<T> : IArraysConnector<T>
    {
        public T[] ConnectArrays(T[] t1, T[] t2)
        {
            List<T> output = new List<T>();

            foreach (T lib in t1) output.Add(lib);

            foreach (T lib in t2) output.Add(lib);

            return output.ToArray();
        }
    }
}