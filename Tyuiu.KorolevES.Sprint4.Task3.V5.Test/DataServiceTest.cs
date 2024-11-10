using Tyuiu.KorolevES.Sprint4.Task3.V5.Lib;
namespace Tyuiu.KorolevES.Sprint4.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateTest()
        {
            DataService ds = new DataService();
            int[,] array = new int[,] { { 3, 4, 8, 6, 3 }, { 9, 9, 3, 6, 9 }, { 5, 6, 7, 2, 3 }, { 3, 6, 2, 3, 8 }, { 5, 7, 2, 6, 4 } };
            int res = ds.Calculate(array),wait =32;
            Assert.AreEqual(wait, res);
        }
    }
}