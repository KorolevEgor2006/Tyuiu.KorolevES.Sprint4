using Tyuiu.KorolevES.Sprint4.Task1.V2.Lib;
namespace Tyuiu.KorolevES.Sprint4.Task1.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 1, 7, 2, 2, 6, 2, 3, 2, 3, 5, 7, 7, 1, 2 };
            int res = ds.Calculate(array), wait = 34;
            Assert.AreEqual(wait, res);
        }
    }
}