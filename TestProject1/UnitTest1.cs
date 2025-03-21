using Microsoft.VisualStudio.TestPlatform.TestHost;
using delegate_events;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var checker = new Checker();
            Assert.IsTrue(checker.isEven(2));
            Assert.IsFalse(checker.isEven(3));
        }
    }
}