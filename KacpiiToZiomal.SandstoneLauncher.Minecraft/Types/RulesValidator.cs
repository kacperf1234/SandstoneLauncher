using KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Enums;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class RulesValidator : IRulesValidator
    {
        public bool Validate(Rule[] rules, OS sys)
        {
            if (rules == null) return true;

            foreach (Rule rule in rules)
            {
                if (rule.Action == null)
                    continue;

                if (rule.Action == "disallow" && rule.OperatingSystem != null)
                    if (rule.OperatingSystem.Name == "osx")
                        return true;
            }

            return false;
        }
    }
}