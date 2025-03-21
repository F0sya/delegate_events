using delegate_events;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var square = new Checker();

            Assert.AreEqual(25, square.Square(5));
            Assert.AreEqual(9, square.Square(3));
            Assert.AreEqual(144, square.Square(12));
        }
    }
}