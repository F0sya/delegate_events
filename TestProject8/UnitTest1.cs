using delegate_events;
namespace TestProject6
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var oddList = new Checker();
            int[] input_arr = { 1, 2, 3, 4, 5 };
            int[] expect_arr = { 1, 3, 5 };
            int[] result = oddList.OddList(input_arr);
            CollectionAssert.AreEqual(expect_arr, result); 
        }
    }
} 