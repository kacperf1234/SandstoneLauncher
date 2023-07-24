using System;
using System.Diagnostics;
using SandstoneLauncher.Minecraft.Interfaces;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class ProcessBuilder : IProcessBuilder
    {
        public Process GetProcess(string executable, string arguments, Action<string> output)
        {
            Process proc = new Process();
            ProcessStartInfo info = new ProcessStartInfo();
            info.UseShellExecute = false;
            info.RedirectStandardOutput = true;
            info.FileName = executable;
            info.Arguments = arguments;

            proc.StartInfo = info;
            proc.OutputDataReceived += (x, y) => output.Invoke(y.Data);

            return proc;
        }

        public Process GetProcess(string executable, string arguments)
        {
            Process proc = new Process();
            ProcessStartInfo info = new ProcessStartInfo();
            info.UseShellExecute = false;
            info.FileName = executable;
            info.RedirectStandardOutput = true;
            info.Arguments = arguments;

            proc.StartInfo = info;
            return proc;
        }
    }
}