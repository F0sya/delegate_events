using delegate_events;

namespace TestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var cube = new Checker();

            Assert.AreEqual(125, cube.Cube(5));
            Assert.AreEqual(27, cube.Cube(3));
            Assert.AreEqual(64, cube.Cube(4));
        }
    }
}