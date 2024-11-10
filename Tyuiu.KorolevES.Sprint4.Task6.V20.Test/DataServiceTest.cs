using Tyuiu.KorolevES.Sprint4.Task6.V20.Lib;
namespace Tyuiu.KorolevES.Sprint4.Task6.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            string[] array = new string[] { "Математика", "Физика", "Химия", "Биология", "География", "История", "Литература" };
            string[] res = new string[ds.Calculate(array).Length];
            res= ds.Calculate(array);
            string[] wait = new string[] { "Физика", "Химия", "Биология", "География", "История" };
            CollectionAssert.AreEqual(wait,res);
        }
    }
}