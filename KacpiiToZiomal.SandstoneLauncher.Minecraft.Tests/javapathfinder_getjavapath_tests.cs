#region

using System;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Tests
{
    public class javapathfinder_getjavapath_tests
    {
        private string execute()
        {
            return new JavaPathFinder().GetJavaPath();
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute());
        }

        [Test]
        public void returns_not_empty()
        {
            Assert.IsNotEmpty(execute());
        }

        [Test]
        public void returns_not_null()
        {
            Assert.NotNull(execute());
        }

        [Test]
        public void returns_string_ends_with_exe()
        {
            Assert.IsTrue(execute().EndsWith(".exe"));
        }

        [Test]
        public void returns_java_exe_or_javaw_exe()
        {
            Assert.IsTrue(execute().EndsWith("javaw.exe") || execute().EndsWith("java.exe"));
        }

        [Test]
        public void returns_directory_is_JAVA_HOME_environment_variable()
        {
            bool startsWith = execute().StartsWith(Environment.GetEnvironmentVariable("JAVA_HOME"));
            
            Assert.IsTrue(startsWith);
        }
    }
}