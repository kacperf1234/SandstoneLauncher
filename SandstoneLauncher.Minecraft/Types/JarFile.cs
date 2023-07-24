using System;
using SandstoneLauncher.Minecraft.Interfaces;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class JarFile : IJarFile
    {
        private string File;

        public JarFile(string jar)
        {
            File = jar;
        }

        public string[] GetDirectories()
        {
            throw new NotImplementedException();
        }

        public string[] GetFiles()
        {
            throw new NotImplementedException();
        }
    }
}