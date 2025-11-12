using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PupovAA.Sprint4.Task7.V28.Lib
{
    public class DataSrervice : ISprint4Task7V28
    {
        public int Calculate(int n, int m, string value)
        {
            int[,]matrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value.Substring(i * m + j,1));
                }
            }
            int count = 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        count *= matrix[i, j];
                    }
                }
            }
            return count;
        }
    }
}
