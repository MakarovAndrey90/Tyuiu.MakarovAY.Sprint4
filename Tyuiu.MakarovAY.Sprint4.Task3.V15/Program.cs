using System.Runtime.Serialization.Formatters;
using Tyuiu.MakarovAY.Sprint4.Task3.V15.Lib;
namespace Tyuiu.MakarovAY.Sprint4.Task3.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mas3 = new int[5, 5] { { 7, 4, 2, 5, 3 }, 
                                          { 4, 3, 2, 5, 6 }, 
                                          { 6, 3, 4, 7, 5 },
                                          { 5, 7, 4, 3, 8 },
                                          { 7, 8, 8, 5, 6 } };
            int rows = mas3.GetUpperBound(0) + 1;
            int colums = mas3.Length / rows;
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Макаров А. Я. | РППБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерныe массивs (генератор случайный чисел)                    *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Макаров А. Я. | РППБ-25-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 2 до 9. Подсчитайте количество   *");
            Console.WriteLine("* нечетных элементов во всем массиве.                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Массив");
            for (int i = 0; i < rows; i++) 
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{mas3[i, j]} \t");
                }
                Console.WriteLine();
            }


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(mas3);
            Console.WriteLine("Количество нечетных элементов " + res);
            Console.ReadKey();

        }
    }
}