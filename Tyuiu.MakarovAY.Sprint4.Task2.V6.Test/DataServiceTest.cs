using Tyuiu.MakarovAY.Sprint4.Task2.V6.Lib;
namespace Tyuiu.MakarovAY.Sprint4.Task2.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] NumsArray = { 2, 3, 4, 5, 6, 7, 8, 2, 3, 4, 5, 6, 7, 8, 3};
            int res = ds.Calculate(NumsArray);
            int wait = 33075;
            Assert.AreEqual(wait, res);

        }
    }
}
