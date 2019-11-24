using System;
using System.Diagnostics;
using System.Reflection;
using KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Tests.Exceptions;
using KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Types;
using NUnit.Framework;

namespace KacpiiToZiomal.SandstoneLauncher.SideBar.Commons.Tests
{
    public class initializemethodfinder_findinitializemethod_tests
    {
        private MyUserControl instance;
        
        class UserControl
        {
        }

        class MyUserControl : UserControl
        {
            public void InitializeComponent()
            {
                throw new TestException();
            }
        }

        [SetUp]
        public void setup()
        {
            instance = new MyUserControl();
        }
    
        MethodInfo execute()
        {
            InitializeMethodFinder finder = new InitializeMethodFinder(new InitializeMethodNameProvider());
            MethodInfo method = finder.FindInitializeMethod(instance);

            return method;
        }

        [Test]
        public void dont_throws_exceptions_while_methodinfo_getting()
        {
            Assert.DoesNotThrow(() => execute());
        }

        [Test]
        public void returns_not_null_method()
        {
            Assert.NotNull(execute());
        }

        [Test]
        public void returns_method_returnstype_equals_to_void()
        {
            Assert.AreEqual(typeof(void), execute().ReturnType);
        }

        [Test]
        public void returns_method_contains_no_parameters()
        {
            ParameterInfo[] parameters = execute().GetParameters();
            int length = parameters.Length;
            
            Assert.IsTrue(length == 0);
        }

        [Test]
        public void returns_method_throws_testexception_while_invoking()
        {
            try
            {
                execute().Invoke(instance, new object[0]);
            }

            catch (TargetInvocationException target)
            {
                Assert.IsTrue(target.InnerException.Message.Contains(typeof(TestException).Name));
            }
        }
    }
}