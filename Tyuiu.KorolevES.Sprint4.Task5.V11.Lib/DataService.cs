using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KorolevES.Sprint4.Task5.V11.Lib
{
    public class DataService : ISprint4Task5V11
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[,] res = new int[matrix.GetLength(0), matrix.GetLength(1)];
            res = matrix;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (res[i, j] > 0) res[i, j] = 1;
                }
            }
            return res;
        }
    }
}
