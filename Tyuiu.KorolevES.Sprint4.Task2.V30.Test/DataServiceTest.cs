using Tyuiu.KorolevES.Sprint4.Task2.V30.Lib;
namespace Tyuiu.KorolevES.Sprint4.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateTest()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 2, 4, 5, 3, 8, 6, 8 };
            int res = ds.Calculate(array), wait = 15;
            Assert.AreEqual(wait, res);
        }
    }
}