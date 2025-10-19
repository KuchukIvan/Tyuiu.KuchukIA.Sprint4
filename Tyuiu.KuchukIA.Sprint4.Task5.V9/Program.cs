using System;
using Tyuiu.KuchukIA.Sprint4.Task5.V9.Lib;
internal class Program
{
    static void Main(string[] args)
    {

        Random rnd = new Random();
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнил: И.А. Кучук | ПИНб-25-1";
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* Спринт #4                                                                                   *");
        Console.WriteLine("* Тема: Обработка структурных типов                                                           *");
        Console.WriteLine("* Задание #5                                                                                  *");
        Console.WriteLine("* Вариант #9                                                                                  *");
        Console.WriteLine("* Выполнил: Кучук Иван Александрович |  ПИНб-25-1                                             *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                    *");
        Console.WriteLine("* Найти количество положительных элементов.                                                   *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                            *");
        Console.WriteLine("***********************************************************************************************");

        Console.Write("Введите количество строк в массиве: ");
        int str = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите количество столбцов в массиве: ");
        int stolb = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[str, stolb];

        for (int i = 0; i < str; i++)
        {
            for (int j = 0; j < stolb; j++)
            {
                matrix[i, j] = rnd.Next(-4, 5);
            }
        }

        Console.WriteLine();
        Console.WriteLine("Исходный массив: ");
        for (int i = 0; i < str; i++)
        {
            for (int j = 0; j < stolb; j++)
            {
                Console.Write($"{matrix[i, j]} \t");
            }
            Console.WriteLine();
        }




        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                  *");
        Console.WriteLine("***********************************************************************************************");

        int res = ds.Calculate(matrix);

        Console.WriteLine("Количество положительных элементов: " + res);
        


        Console.ReadKey();

    }
}
