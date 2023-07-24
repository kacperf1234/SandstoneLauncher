using SandstoneLauncher.Minecraft.Enums;
using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
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