using System.Diagnostics;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
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