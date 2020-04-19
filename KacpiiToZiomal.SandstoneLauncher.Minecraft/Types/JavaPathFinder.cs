using System;
using System.Diagnostics;
using System.IO;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class JavaPathFinder : IJavaPathFinder
    {
        public string GetJavaPath()
        {
            string javaHome = Environment.GetEnvironmentVariable("JAVA_HOME");
            return Path.Combine(javaHome, "javaw.exe");
        }
    }
}