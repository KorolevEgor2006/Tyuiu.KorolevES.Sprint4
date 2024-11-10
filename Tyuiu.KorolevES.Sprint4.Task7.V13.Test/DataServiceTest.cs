using Tyuiu.KorolevES.Sprint4.Task7.V13.Lib;
namespace Tyuiu.KorolevES.Sprint4.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            string str = "159357246";
            int x = 3, y = 3, wait = 3;
            int res = ds.Calculate(x, y,str);
            Assert.AreEqual(wait, res);
        }
    }
}