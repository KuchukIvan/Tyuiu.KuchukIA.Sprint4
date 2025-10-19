using Tyuiu.KuchukIA.Sprint4.Task5.V9.Lib;
namespace Tyuiu.KuchukIA.Sprint4.Task5.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest 
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { { 1, 2, 3, -1, 1 },
                                            { 2, 5, 6, 7, -2 },
                                            { -9, 1, 1, 1, 12 },
                                            { 152, 150, -5, 24, 1 },
                                            { 52, 52, 52, 52, -52} };

            int res = ds.Calculate(matrix);
            int wait = 20;

            Assert.AreEqual(wait, res);

        }
    }
}
