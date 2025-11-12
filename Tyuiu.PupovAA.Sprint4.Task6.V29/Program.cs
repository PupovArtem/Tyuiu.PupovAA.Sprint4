using Tyuiu.PupovAA.Sprint4.Task6.V29.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнил: Пупов А. А. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы. (Класс Array)                          *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #29                                                              *");
        Console.WriteLine("* Выполнил: Пупов Артём Андреевич  | ИБКСб-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*                                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string[] mas = {  "Весна", "Лето", "Осень", "Зима" };

        for (int i = 0; i < mas.Length-1; i++)
        {
            Console.WriteLine(mas[i]);
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                        *");
        Console.WriteLine("***************************************************************************");
        int res = ds.Calculate(mas);
        Console.WriteLine("Количесвто элементов массива у которых болЬше 4 букв = "+res);
        Console.ReadLine();
    }
    
}