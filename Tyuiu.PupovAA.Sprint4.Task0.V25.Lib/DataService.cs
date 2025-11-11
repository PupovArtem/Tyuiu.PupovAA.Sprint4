using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PupovAA.Sprint4.Task0.V25.Lib
{
    public class DataService : ISprint4Task0V25

    {
        public int GetSumEvenArrEl(int[] array)
        {
            int y=0;
            for (int i= 0; i<=array.Length-1; i++)
            {
                if ((array[i] >= 0)&(array[i] <=9))
                {
                    if (array[i]%2 == 0)
                    {
                        y += array[i];
                    }
                }
                else
                {
                    continue;
                }
            }
            return y;
           
        }
    }
}
