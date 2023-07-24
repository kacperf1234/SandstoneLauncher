using SandstoneLauncher.Minecraft.Enums;
using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class LibraryValidator : ILibraryValidator
    {
        public IRulesValidator RulesValidator;

        public LibraryValidator(IRulesValidator rulesValidator)
        {
            RulesValidator = rulesValidator;
        }

        public bool Validate(Library lib, OS sys)
        {
            return RulesValidator.Validate(lib.Rules, sys) && lib.Download.Artifact != null &&
                   lib.Download.Artifact.Path != null;
        }
    }
}