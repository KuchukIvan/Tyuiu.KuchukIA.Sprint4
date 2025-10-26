using System;
using Tyuiu.KuchukIA.Sprint4.Task6.V2.Lib;
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
        Console.WriteLine("* Задание #6                                                                                  *");
        Console.WriteLine("* Вариант #2                                                                                  *");
        Console.WriteLine("* Выполнил: Кучук Иван Александрович |  ПИНб-25-1                                             *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                    *");
        Console.WriteLine("* Выведите элементы массива, длина которых больше 5 символов.                                 *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                            *");
        Console.WriteLine("***********************************************************************************************");

        string[] colors = new string[] { "Белый", "Черный", "Зеленый", "Синий", "Красный", "Желтый", "Фиолетовый" };

        Console.WriteLine("Исходный массив: ");

        for (int i = 0; i <= colors.Length - 1; i++)
        {
            Console.WriteLine(colors[i]);
        }




        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                  *");
        Console.WriteLine("***********************************************************************************************");

        string[] res = ds.Calculate(colors);


        Console.WriteLine("Элементы массива, длина которых больше 5 символов: ");

        for (int i = 0; i <= res.Length - 1; i++)
        {
            Console.WriteLine(res[i]);
        }



        Console.ReadKey();

    }
}
