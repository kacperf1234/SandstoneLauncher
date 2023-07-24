#region

using SandstoneLauncher.Minecraft.Enums;
using SandstoneLauncher.Minecraft.Models;
using SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace SandstoneLauncher.Minecraft.Tests
{
    public class rulesvalidator_validate_tests
    {
        private readonly Rule[] badrules = new Rule[2]
        {
            new Rule(),
            new Rule
            {
                Action = "allow",
                OperatingSystem = new RuleOperatingSystem
                {
                    Name = "osx"
                }
            }
        };

        private readonly Rule[] goodrules = new Rule[2]
        {
            new Rule
            {
                Action = "allow"
            },
            new Rule
            {
                Action = "disallow",
                OperatingSystem = new RuleOperatingSystem
                {
                    Name = "osx"
                }
            }
        };

        private bool execute(Rule[] r)
        {
            RulesValidator rv = new RulesValidator();
            return rv.Validate(r, OS.WINDOWS);
        }

        [Test]
        public void dont_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute(goodrules));
        }

        [Test]
        public void returns_true_when_used_goodrules()
        {
            Assert.IsTrue(execute(goodrules));
        }

        [Test]
        public void returns_false_when_used_badrules()
        {
            Assert.IsFalse(execute(badrules));
        }

        [Test]
        public void returns_true_when_rules_array_is_null()
        {
            Assert.IsTrue(execute(null));
        }
    }
}