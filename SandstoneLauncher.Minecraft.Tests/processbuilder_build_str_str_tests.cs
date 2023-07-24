#region

using System;
using System.Diagnostics;
using SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace SandstoneLauncher.Minecraft.Tests
{
public class processbuilder_build_str_str_tests
    {
        private string execute(Action<string> act)
        {
            string content = "";

            ProcessBuilder b = new ProcessBuilder();
            Process proc = b.GetProcess("cmd", "/k hostname & exit", act);
            proc.Start();
            proc.BeginOutputReadLine();

            return content;
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute(x => { }));
        }
    }
}