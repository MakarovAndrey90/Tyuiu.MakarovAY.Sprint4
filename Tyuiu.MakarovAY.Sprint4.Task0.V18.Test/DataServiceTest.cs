using Tyuiu.MakarovAY.Sprint4.Task0.V18.Lib;
namespace Tyuiu.MakarovAY.Sprint4.Task0.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumOddArrEl()
        {
            DataService ds = new DataService();
            int[] numsArray = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };
            int res = ds.GetSumOddArrEl(numsArray);
            int numsWaitArray = 41;
            Assert.AreEqual(numsWaitArray, res);

        }
    }
}
