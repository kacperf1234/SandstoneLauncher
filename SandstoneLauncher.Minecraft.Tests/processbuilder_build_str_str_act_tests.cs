#region

using System;
using System.Diagnostics;
using SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace SandstoneLauncher.Minecraft.Tests
{
    [Spencer.NET.SingleInstance]
public class processbuilder_build_str_str_act_tests
    {
        private string execute()
        {
            ProcessBuilder b = new ProcessBuilder();
            Process proc = b.GetProcess("cmd", "/k hostname & exit");
            proc.Start();
            proc.WaitForExit();

            return proc.StandardOutput.ReadToEnd();
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute());
        }

        [Test]
        public void returns_results_passing_to_enviroment_variable()
        {
            Assert.AreEqual(Environment.MachineName + "\r\n", execute().ToUpper());
        }
    }
}