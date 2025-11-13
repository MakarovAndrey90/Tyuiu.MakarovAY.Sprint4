using Tyuiu.MakarovAY.Sprint4.Task5.V30.Lib;
namespace Tyuiu.MakarovAY.Sprint4.Task5.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();
            Console.Title = "Спринт #4 | Выполнил: Макаров А. Я. | РППБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (генератор случайных чисел)                     *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Макаров А. Я. | РППБ-25-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* случайными значениями в диапазоне от -2 до 4. Найти сумму               *");
            Console.WriteLine("* положительных элементов.                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите количество строк в массиве ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов в массиве ");
            int colums = Convert.ToInt32(Console.ReadLine());
            int[,] mtrx = new int[rows, colums];
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    mtrx[i, j] = rnd.Next(-2, 4);

                }
            }
            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }
                Console.WriteLine();
            }


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(mtrx);
            Console.WriteLine("Сумма положительных элементов " + res);
            Console.ReadKey();
        }
    }
}