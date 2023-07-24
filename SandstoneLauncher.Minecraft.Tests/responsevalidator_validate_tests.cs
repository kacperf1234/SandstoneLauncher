#region

using System;
using System.Net.Http;
using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace SandstoneLauncher.Minecraft.Tests
{
    [Spencer.NET.SingleInstance]
public class responsevalidator_validate_tests
    {
        private bool execute(string url, Func<HttpResponseMessage, bool> f)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage r = client.GetAsync(url).Result;

            if (!url.Contains("https://reqres.in/api/users?page=2"))
                r = client.PostAsync(url, new StringContent("")).Result;

            IResponseValidator validator = new ResponseValidator(f);
            return validator.Validate(r);
        }

        [Test]
        public void not_throws_exceptions()
        {
            Assert.DoesNotThrow(() => execute("https://reqres.in/api/users?page=2", null));
        }

        [Test]
        public void not_throws_exceptions_with_func()
        {
            Assert.DoesNotThrow(() => execute("https://reqres.in/api/users?page=2", x => true));
        }

        [Test]
        public void returns_value_using_func()
        {
            Assert.IsTrue(execute("https://reqres.in/api/users?page=2", x => true));
        }

        [Test]
        public void returns_value_using_status_code()
        {
            Assert.IsTrue(execute("https://reqres.in/api/users?page=2", null));
            Assert.IsFalse(execute("https://reqres.in/api/register", null));
        }
    }
}