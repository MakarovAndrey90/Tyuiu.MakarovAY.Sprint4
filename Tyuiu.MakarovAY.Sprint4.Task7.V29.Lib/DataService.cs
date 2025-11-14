using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MakarovAY.Sprint4.Task7.V29.Lib
{
    public class DataService : ISprint4Task7V29
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] mtrx = new int[4, 3];
            int sum = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mtrx[i, j] = int.Parse(value[i * 3 + j].ToString());
                    if (mtrx[i, j] % 2 == 0)
                    {
                        sum += mtrx[i, j];
                    }
                }
            }
            return sum;
        }
    }
}
