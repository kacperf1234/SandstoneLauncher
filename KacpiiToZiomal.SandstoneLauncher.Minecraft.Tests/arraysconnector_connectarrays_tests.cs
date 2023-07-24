#region

using KacpiiToZiomal.SandstoneLauncher.Minecraft.Types;
using NUnit.Framework;

#endregion

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Tests
{
    public class arraysconnector_connectarrays_tests
    {
        private int[] execute(int[] x, int[] y)
        {
            ArraysConnector<int> c = new ArraysConnector<int>();
            return c.ConnectArrays(x, y);
        }

        [Test]
        public void does_not_throw_exceptions()
        {
            Assert.DoesNotThrow(() => execute(new int[0] { }, new int[0] { }));
        }

        [Test]
        public void returns_excepted_result_length()
        {
            Assert.IsTrue(execute(new int[2] { 0, 5 }, new int[3] { 1, 1, 5 }).Length == 5);
        }

        [Test]
        public void returns_result_equals_to_excepted_results()
        {
            int[] arr = new int[3] { 0, 5, 10 };
            int[] res = execute(new int[2] { 0, 5 }, new int[1] { 10 });

            Assert.AreEqual(arr, res);
        }
    }
}