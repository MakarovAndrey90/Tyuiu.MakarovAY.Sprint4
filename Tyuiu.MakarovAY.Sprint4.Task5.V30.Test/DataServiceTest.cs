using Tyuiu.MakarovAY.Sprint4.Task5.V30.Lib;
namespace Tyuiu.MakarovAY.Sprint4.Task5.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5] { { -2, -1, 1, 2, 3 }, { -2, -1, 1, 2, 3 }, { -2, -1, 1, 2, 3 }, { -2, -1, 1, 2, 4 }, { -2, -1, 1, 2, 3 } };
            int res = ds.Calculate(mas2);
            int wait = 31;
            Assert.AreEqual(wait, res);

        }
    }
}
