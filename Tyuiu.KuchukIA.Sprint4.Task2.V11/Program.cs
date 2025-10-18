using System;
using Tyuiu.KuchukIA.Sprint4.Task2.V11.Lib;
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
        Console.WriteLine("* Задание #2                                                                                  *");
        Console.WriteLine("* Вариант #11                                                                                 *");
        Console.WriteLine("* Выполнил: Кучук Иван Александрович |  ПИНб-25-1                                             *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                    *");
        Console.WriteLine("* Подсчитать сумму четных элементов массива                                                   *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                            *");
        Console.WriteLine("***********************************************************************************************");


 
        Console.WriteLine("Введите длину массива:");
        int len = Convert.ToInt32(Console.ReadLine());

        int[] nums = new int[len];

        for (int i = 0; i <= nums.Length - 1; i++)
        {
            nums[i] = rnd.Next(3, 9);
        }

        Console.WriteLine();

        Console.WriteLine("Массив: ");

        for (int i = 0; i <= nums.Length - 1; i++)
        {
            Console.WriteLine(nums[i] + "\t");
        }



        Console.WriteLine();
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                  *");
        Console.WriteLine("***********************************************************************************************");

        int res = ds.Calculate(nums);

        Console.WriteLine("Сумма чётных элементов массива: " + res);

        Console.ReadKey();

    }
}
