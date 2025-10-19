using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KuchukIA.Sprint4.Task3.V7.Lib
{
    public class DataService : ISprint4Task3V7
    {
        public int Calculate(int[,] array)
        {
            int str = array.GetUpperBound(0) + 1;
            int stolb = array.Length / str;

            int count = 0;

            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < stolb; j++)
                {
                    if (array[i, j] % 2 != 0)
                    {
                        count += 1;
                    }

                }
            }
            return count;
            
            
        }
    }
}
