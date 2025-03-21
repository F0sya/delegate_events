using delegate_events;

namespace TestProject6
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var minimum = new Checker();

            int[] arr = { 1, 2, 3, 4, 5 };

            Assert.AreEqual(1, minimum.Minimum(arr));
        }
    }
}