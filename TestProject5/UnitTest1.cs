using delegate_events;

namespace TestProject5
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var checker = new Checker();
            Assert.IsTrue(checker.CheckProgrammerDay(256));
            Assert.IsFalse(checker.CheckProgrammerDay(123));
        }
    }
}