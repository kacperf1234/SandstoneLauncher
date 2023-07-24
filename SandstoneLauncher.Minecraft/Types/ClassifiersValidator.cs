using SandstoneLauncher.Minecraft.Enums;
using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class ClassifiersValidator : IClassifiersValidator
    {
        public bool Validate(Classifiers c, OS sys)
        {
            if (c == null) return false;

            if (sys == OS.WINDOWS)
                return c.Windows != null;

            if (sys == OS.LINUX)
                return c.Linux != null;

            return false;
        }
    }
}