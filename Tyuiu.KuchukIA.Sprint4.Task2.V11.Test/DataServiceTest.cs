using Tyuiu.KuchukIA.Sprint4.Task2.V11.Lib;
namespace Tyuiu.KuchukIA.Sprint4.Task2.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 12, 13, 15, 17, 19, 21, 22 };

            int res = ds.Calculate(nums);
            int wait = 54;

            Assert.AreEqual(wait, res);
        }
    }
}
