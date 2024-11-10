using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KorolevES.Sprint4.Task7.V13.Lib
{
    public class DataService : ISprint4Task7V13
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] res = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++) 
                {
                    res[i,j]=int.Parse(value.Substring(i*m+j,1));
                }
            }
            int count = 0;
            for (int i = 0;i < res.GetLength(0); i++)
            {
                for(int j = 0;j < res.GetLength(1); j++)
                {
                    if (res[i, j] % 2 == 0) count++;
                }
            }
            return count;
        }
    }
}
