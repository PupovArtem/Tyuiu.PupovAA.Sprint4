using Tyuiu.PupovAA.Sprint4.Task2.V21.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd = new Random();
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнил: Пупов А. А. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                            *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #21                                                              *");
        Console.WriteLine("* Выполнил: Пупов Артём Андреевич  | ИБКСб-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("*                                                                          *");
         
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        
        
        int len;
        Console.WriteLine("Впишите число элементов массива:");
        len = Convert.ToInt32(Console.ReadLine());
        int[] nums = new int[len];
       


        Console.WriteLine("Впишите элемент массива");
        for (int i = 0; i <= nums.Length - 1; i++)
        {
            nums[i] = rnd.Next(1, 7);
        }



        Console.WriteLine("массив:");
        for (int i = 0; i <= nums.Length - 1; i++)
        {
            Console.WriteLine(nums[i] + "\t");
        }


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                        *");
        Console.WriteLine("***************************************************************************");
        int narray = ds.Calculate(nums);
        Console.WriteLine("результат умножения четных элементов массива = " + narray);
        Console.ReadLine();
    }
}