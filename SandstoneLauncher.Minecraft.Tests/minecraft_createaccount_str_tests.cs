using NUnit.Framework;

namespace SandstoneLauncher.Minecraft.Tests
{
    public class minecraft_createaccount_str_tests
    {
        Minecraft Init()
        {
            return Minecraft.GetInstance();
        }

        [Test]
        public void does_not_throw()
        {
            Assert.DoesNotThrow(() =>
            {
                Init().CreateAccount("Kacper");
            });
        }

        [Test]
        public void returns_not_null()
        {
            Assert.NotNull(Init().CreateAccount("Kacper"));
        }
        
    }
}