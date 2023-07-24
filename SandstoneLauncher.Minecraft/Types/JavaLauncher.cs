using System.Diagnostics;
using SandstoneLauncher.Minecraft.Interfaces;

namespace SandstoneLauncher.Minecraft.Types
{
    public class JavaLauncher : IJavaLauncher
    {
        public IJavaPathFinder JavaFinder;
        public IProcessOutputReader OutputReader;
        public IProcessBuilder ProcessBuilder;

        public JavaLauncher(IProcessBuilder processBuilder, IProcessOutputReader outputReader,
            IJavaPathFinder pathFinder)
        {
            ProcessBuilder = processBuilder;
            OutputReader = outputReader;
            JavaFinder = pathFinder;
        }

        public void Launch(string command)
        {
            string javapath = JavaFinder.GetJavaPath();

            Process proc;
            if (OutputReader != null)
                proc = ProcessBuilder.GetProcess(javapath, command, x => OutputReader.Read(x));
            else
                proc = ProcessBuilder.GetProcess(javapath, command);

            proc.Start();
            proc.BeginOutputReadLine();
            proc.WaitForExit();
        }
    }
}