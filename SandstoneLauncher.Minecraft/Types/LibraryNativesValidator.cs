using SandstoneLauncher.Minecraft.Enums;
using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;

namespace SandstoneLauncher.Minecraft.Types
{
    public class LibraryNativesValidator : ILibraryNativesValidator
    {
        public IClassifiersValidator ClasssifiersValidator;
        public INativesValidator NativesValidator;
        public IRulesValidator RulesValidator;

        public LibraryNativesValidator(INativesValidator nativesValidator, IClassifiersValidator classsifiersValidator)
        {
            NativesValidator = nativesValidator;
            ClasssifiersValidator = classsifiersValidator;
        }

        public bool Validate(Library lib, OS sys)
        {
            return NativesValidator.Validate(lib.Natives, OS.WINDOWS)
                   && ClasssifiersValidator.Validate(lib.Download.Classifiers, sys);
        }
    }
}