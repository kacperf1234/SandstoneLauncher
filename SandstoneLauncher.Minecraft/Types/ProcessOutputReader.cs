using System;
using SandstoneLauncher.Minecraft.Interfaces;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class ProcessOutputReader : IProcessOutputReader
    {
        public void Read(string content)
        {
            Console.WriteLine($"OUT: {content}");
        }
    }
}