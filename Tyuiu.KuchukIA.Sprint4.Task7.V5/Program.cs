using System;
using Tyuiu.KuchukIA.Sprint4.Task7.V5.Lib;
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
        Console.WriteLine("* Задание #7                                                                                  *");
        Console.WriteLine("* Вариант #5                                                                                  *");
        Console.WriteLine("* Выполнил: Кучук Иван Александрович |  ПИНб-25-1                                             *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                    *");
        Console.WriteLine("* Дана строка из одноразрядных цифр 246813579.                                                *");
        Console.WriteLine("* Преобразуйте ее в матрицу 3 на 3 и подсчитайте количество четных чисел.                     *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                            *");
        Console.WriteLine("***********************************************************************************************");

        int str = 3;
        int stolb = 3;

        string value = "246813579";
        int index = 0;

        Console.WriteLine();
        Console.WriteLine("Массив: ");

        for (int i = 0; i < str; i++)
        {
            for (int j = 0; j < stolb; j++)
            {
                Console.Write($"{value[index]} \t");
                index++;

            }
            Console.WriteLine();
        }





        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                  *");
        Console.WriteLine("***********************************************************************************************");

        int res = ds.Calculate(str, stolb, value);


        Console.WriteLine("Количество чётных чисел в массиве равно: " + res);

        



        Console.ReadKey();

    }
}
