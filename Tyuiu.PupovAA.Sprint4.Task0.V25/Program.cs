using Tyuiu.PupovAA.Sprint4.Task0.V25.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнил: Пупов А. А. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                            *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #25                                                              *");
        Console.WriteLine("* Выполнил: Пупов Артём Андреевич  | ИБКСб-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный статическими    *");
        Console.WriteLine("* значениями в диапазоне от 0 до 9 подсчитать сумму четных элементов массива.   *");
        Console.WriteLine("*     {1, 4, 2, 6, 4, 8, 6, 7, 8, 4}                                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int[] array = { 1, 4, 2, 6, 4, 8, 6, 7, 8, 4 };
        Console.WriteLine("Исходный массив");
        for (int i = 0; i <+ array.Length-1; i++)
        {
            Console.WriteLine(array[i]);
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                        *");
        Console.WriteLine("***************************************************************************");
        int narray = ds.GetSumEvenArrEl(array);
        Console.WriteLine("результат сложения четных элементов массива = "+narray);
        Console.ReadLine();

    }
}