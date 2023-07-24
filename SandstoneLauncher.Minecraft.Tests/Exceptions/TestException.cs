#region

using System;

#endregion

namespace SandstoneLauncher.Minecraft.Tests.Exceptions
{
    /// <summary>
    ///     its used when tests have to throws exception, in order to check something
    /// </summary>
    [Spencer.NET.SingleInstance]
public class TestException : Exception
    {
        public TestException() : base("TestException! Its using only by tests. Ignore it.")
        {
        }
    }

    [Spencer.NET.SingleInstance]
public class TestException<T1> : Exception
    {
        public T1 Argument;

        public TestException(T1 arg)
        {
            Argument = arg;
        }
    }
}