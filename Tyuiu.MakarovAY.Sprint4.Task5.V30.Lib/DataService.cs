using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MakarovAY.Sprint4.Task5.V30.Lib
{
    public class DataService : ISprint4Task5V30
    {
        public int Calculate(int[,] matrix)
        {
            int c = 0;
            int rows = matrix.GetUpperBound(0) + 1;
            int colums = matrix.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        c += matrix[i, j];
                    }
                }
            }
            return c;
        }
    }
}
