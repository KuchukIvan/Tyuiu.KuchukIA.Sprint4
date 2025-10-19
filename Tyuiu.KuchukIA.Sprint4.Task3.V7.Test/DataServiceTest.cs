using Tyuiu.KuchukIA.Sprint4.Task3.V7.Lib;
namespace Tyuiu.KuchukIA.Sprint4.Task3.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { {9, 6, 9, 3, 7},
                                            {3, 3, 3, 8, 2},
                                            {2, 1, 3, 5, 2},
                                            {6, 2, 3, 2, 5},
                                            {4, 5, 6, 9, 5} };

            int res = ds.Calculate(matrix);
            int wait = 15;

            Assert.AreEqual(wait, res);
                                                
        }
    }
}
