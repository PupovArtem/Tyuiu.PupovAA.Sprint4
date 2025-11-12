using Tyuiu.PupovAA.Sprint4.Task7.V28.Lib;
namespace Tyuiu.PupovAA.Sprint4.Task7.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int rows = 5;
            int cols = 3;
            int[,] data = new int[rows, cols];
            string str = "623351179845632";
            DataSrervice ds = new DataSrervice();
            int res =ds.Calculate(rows, cols,str);
            Assert.AreEqual(4608,res);
        }
    }
}
