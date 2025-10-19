using System;
using Tyuiu.KuchukIA.Sprint4.Task3.V7.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнил: И.А. Кучук | ПИНб-25-1";
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* Спринт #4                                                                                   *");
        Console.WriteLine("* Тема: Обработка структурных типов                                                           *");
        Console.WriteLine("* Задание #3                                                                                  *");
        Console.WriteLine("* Вариант #7                                                                                  *");
        Console.WriteLine("* Выполнил: Кучук Иван Александрович |  ПИНб-25-1                                             *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                    *");
        Console.WriteLine("* Подсчитайте количество нечетных элементов во всем массиве.                                  *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                            *");
        Console.WriteLine("***********************************************************************************************");


        int[,] matrix = new int[5, 5] { {9, 6, 9, 3, 7},
                                            {3, 3, 3, 8, 2},
                                            {2, 1, 3, 5, 2},
                                            {6, 2, 3, 2, 5},
                                            {4, 5, 6, 9, 5} };

        int str = matrix.GetUpperBound(0) + 1;
        int stolb = matrix.Length / str;

        Console.WriteLine("Массив: ");

        for (int i = 0; i < str; i++)
        {
            for (int j = 0; j < stolb; j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }



        Console.WriteLine();
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                  *");
        Console.WriteLine("***********************************************************************************************");

        int res = ds.Calculate(matrix);

        Console.WriteLine("Количество нечётных элементов массива: " + res);

        Console.ReadKey();

    }
}
