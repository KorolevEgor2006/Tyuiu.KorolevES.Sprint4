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
            string[] array = new string[] { "����������", "������", "�����", "��������", "���������", "�������", "����������" };
            string[] res = new string[ds.Calculate(array).Length];
            res= ds.Calculate(array);
            string[] wait = new string[] { "������", "�����", "��������", "���������", "�������" };
            CollectionAssert.AreEqual(wait,res);
        }
    }
}