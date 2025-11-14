using Tyuiu.MakarovAY.Sprint4.Task7.V29.Lib;
namespace Tyuiu.MakarovAY.Sprint4.Task7.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int n = 4;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string str = "983157642891";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, str);
            int wait = 28;
            Assert.AreEqual(wait, res);
        }
    }
}
