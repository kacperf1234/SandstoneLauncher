using System.Diagnostics;
using SandstoneLauncher.Minecraft.Interfaces;

namespace SandstoneLauncher.Minecraft.Types
{
    public class JavaPathFinder : IJavaPathFinder
    {
        public string GetJavaPath()
        {
            Process proc = new Process();
            proc.StartInfo = new ProcessStartInfo
            {
                RedirectStandardOutput = true,
                Arguments = "/k for %i in (javaw.exe) do @echo.%~$PATH:i",
                FileName = " cmd.exe"
            };
            proc.Start();

            return proc.StandardOutput.ReadLine();
        }
    }
}