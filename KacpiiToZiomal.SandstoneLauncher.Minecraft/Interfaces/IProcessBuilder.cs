using System;
using System.Diagnostics;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface IProcessBuilder
    {
        Process GetProcess(string executable, string arguments, Action<string> output);

        Process GetProcess(string executable, string arguments);
    }
}