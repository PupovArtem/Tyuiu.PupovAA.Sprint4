using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PupovAA.Sprint4.Task2.V21.Lib
{
    public class DataService : ISprint4Task2V21
    {
        public int Calculate(int[] array)
        {
            int y = 1;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if ((array[i] >= 1) & (array[i] <= 7))
                {
                    if (array[i] % 2 == 0)
                    {
                        y *= array[i];
                    }
                }

            }
            return y;
        }
    }
}
