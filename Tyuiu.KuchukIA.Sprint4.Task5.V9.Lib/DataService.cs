using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KuchukIA.Sprint4.Task5.V9.Lib
{
    public class DataService : ISprint4Task5V9
    {
        public int Calculate(int[,] matrix)
        {
            int str = matrix.GetUpperBound(0) + 1;
            int stolb = matrix.Length / str;
            int count = 0;

            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < stolb; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        count++;
                    }
                }
            }
            return count;
            
        }
    }
}
