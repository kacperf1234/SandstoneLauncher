#region

using SandstoneLauncher.Minecraft.Enums;
using SandstoneLauncher.Minecraft.Models;
using SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace SandstoneLauncher.Minecraft.Tests
{
public class classifiersvalidator_validate_tests
    {
        private bool execute(DownloadArtifact wnd = null, DownloadArtifact lin = null, OS sys = OS.WINDOWS,
            bool cnull = false)
        {
            ClassifiersValidator v = new ClassifiersValidator();
            return v.Validate(cnull == false ? new Classifiers { Windows = wnd, Linux = lin } : null, sys);
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute());
        }

        [Test]
        public void returns_true_if_selected_windows_isnt_null_valid_results()
        {
            Assert.IsTrue(execute(new DownloadArtifact()));
        }

        [Test]
        public void returns_false_when_selected_os_is_null()
        {
            Assert.IsFalse(execute(null, new DownloadArtifact()));
        }

        [Test]
        public void returns_false_when_classifiers_object_are_null()
        {
            Assert.IsFalse(execute(new DownloadArtifact(), new DownloadArtifact(), OS.WINDOWS, true));
        }
    }
}