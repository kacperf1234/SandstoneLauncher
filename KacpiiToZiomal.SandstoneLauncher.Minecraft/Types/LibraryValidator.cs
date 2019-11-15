using KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Enums;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
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