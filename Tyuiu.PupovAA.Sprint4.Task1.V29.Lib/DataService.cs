using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PupovAA.Sprint4.Task1.V29.Lib
{
    public class DataService : ISprint4Task1V29
    {
        public int Calculate(int[] array)
        {
            int y = 0;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if ((array[i] >= 1) & (array[i] <= 9))
                {
                    if (array[i] % 2 != 0)
                    {
                        y += array[i];
                    }
                }
                
            }
            return y;
        }
    }
}
