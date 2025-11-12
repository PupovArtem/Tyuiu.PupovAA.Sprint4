using Tyuiu.PupovAA.Sprint4.Task7.V28.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int rows = 5;
        int cols = 3;
        int[,] data = new int[rows, cols];
        string str = "623351179845632";
        DataSrervice ds = new DataSrervice();
        int res = ds.Calculate(rows, cols, str);
        Console.WriteLine(res);
    }
}