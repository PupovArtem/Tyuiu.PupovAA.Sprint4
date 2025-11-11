using Tyuiu.PupovAA.Sprint4.Task4.V21.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнил: Пупов А. А. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                          *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #21                                                              *");
        Console.WriteLine("* Выполнил: Пупов Артём Андреевич  | ИБКСб-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*                                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        
        Console.WriteLine("Впишите число строк массива:");
        int len = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Впишите число столбцов массива:");
        int nel = Convert.ToInt32(Console.ReadLine());
        int[,] nums = new int[len,nel];
        

        for (int i = 0; i < len; i++)
        {
            for (int j = 0; j < nel; j++)
            {
                Console.WriteLine("Впишите элемент массива");
                nums[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("Массив");
        for (int i = 0; i < len; i++)
        {
            for (int j = 0; j < nel; j++)
            {
                Console.WriteLine($"{nums[i, j]} \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                        *");
        Console.WriteLine("***************************************************************************");
        int narray = ds.Calculate(nums);
        Console.WriteLine("результат сложения четных элементов массива = " + narray);
        Console.ReadLine();
    }
}