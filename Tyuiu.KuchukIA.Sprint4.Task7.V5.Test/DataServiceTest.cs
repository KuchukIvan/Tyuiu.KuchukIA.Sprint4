using Tyuiu.KuchukIA.Sprint4.Task7.V5.Lib;
namespace Tyuiu.KuchukIA.Sprint4.Task7.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int str = 3;
            int stolb = 3;
            string value = "246813579";

            int res = ds.Calculate(str, stolb, value);
            int wait = 4;

            Assert.AreEqual(wait, res);

        }
    }
}
