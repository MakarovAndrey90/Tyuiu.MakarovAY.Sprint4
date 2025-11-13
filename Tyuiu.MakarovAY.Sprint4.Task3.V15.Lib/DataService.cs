using System.Numerics;
using System.Runtime.ExceptionServices;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MakarovAY.Sprint4.Task3.V15.Lib
{
    public class DataService : ISprint4Task3V15
    {
        public int Calculate(int[,] array)
        {
            int c = 0;
            int rows = array.GetUpperBound(0) + 1;
            int colums = array.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++) 
                {
                    if (array[i, j] % 2 != 0)
                    {
                        c++;
                    }
                }
            }
            return c;
        }
    }
}
