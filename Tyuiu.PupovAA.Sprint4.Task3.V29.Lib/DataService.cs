using System.Numerics;
using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PupovAA.Sprint4.Task3.V29.Lib
{
    public class DataService : ISprint4Task3V29
    {
        public int Calculate(int[,] array)
        {
            int product = 1;
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                product *= array[i, 0];
            }
            return product;
        }
    }
}
