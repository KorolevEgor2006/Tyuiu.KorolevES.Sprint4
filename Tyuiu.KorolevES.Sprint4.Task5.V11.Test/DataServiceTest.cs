using Tyuiu.KorolevES.Sprint4.Task5.V11.Lib;
namespace Tyuiu.KorolevES.Sprint4.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[,] { { 4, 0, -2 }, { -2, 7, 6 }, { 4, 1, -1 } };
            int[,] wait = new int[,] { { 1, 0, -2 }, { -2, 1, 1 }, { 1, 1, -1 } };
            int[,] res = new int[matrix.GetLength(0), matrix.GetLength(1)];
            res = ds.Calculate(matrix);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}