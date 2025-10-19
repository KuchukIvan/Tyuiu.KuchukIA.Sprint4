using System;
using Tyuiu.KuchukIA.Sprint4.Task4.V22.Lib;
internal class Program
{
    static void Main(string[] args)
    {

        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнил: И.А. Кучук | ПИНб-25-1";
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* Спринт #4                                                                                   *");
        Console.WriteLine("* Тема: Обработка структурных типов                                                           *");
        Console.WriteLine("* Задание #4                                                                                  *");
        Console.WriteLine("* Вариант #22                                                                                 *");
        Console.WriteLine("* Выполнил: Кучук Иван Александрович |  ПИНб-25-1                                             *");
        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                    *");
        Console.WriteLine("* Заменить нечетные элементы массива на 0.                                                    *");
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
                Console.Write($"Введите {i}, {j} элемент массива: ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine();
        Console.WriteLine("Исходный массив: ");
        for (int i = 0; i < str; i++)
        {
            for (int j = 0; j < stolb; j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }




        Console.WriteLine("***********************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                  *");
        Console.WriteLine("***********************************************************************************************");

        int[,] res = ds.Calculate(matrix);

        Console.WriteLine("Итоговый массив: ");
        for (int i = 0; i < str; i++)
        {
            for (int j = 0; j < stolb; j++)
            {
                Console.Write($"{res[i, j]} ");
            }
            Console.WriteLine();
        }


        Console.ReadKey();

    }
}
