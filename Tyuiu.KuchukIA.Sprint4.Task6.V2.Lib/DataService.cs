using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KuchukIA.Sprint4.Task6.V2.Lib
{
    public class DataService : ISprint4Task6V2
    {
        public string[] Calculate(string[] array)
        {
            string[] mass = Array.FindAll(array, x => x.Length > 5);
            return mass;
        }
    }
}
