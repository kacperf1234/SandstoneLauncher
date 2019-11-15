using KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Enums;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class NativesValidator : INativesValidator
    {
        public INativesPropertyGetter PropertyGetter;
        public IOperatingSystemConverter SystemConverter;

        public NativesValidator(IOperatingSystemConverter systemConverter, INativesPropertyGetter propertyGetter)
        {
            SystemConverter = systemConverter;
            PropertyGetter = propertyGetter;
        }

        public bool Validate(Natives natives, OS system)
        {
            if (natives == null) return false;

            string name = SystemConverter.Convert(system);
            string val = PropertyGetter.GetValue(natives, name);

            return val == "natives-" + name;
        }
    }
}