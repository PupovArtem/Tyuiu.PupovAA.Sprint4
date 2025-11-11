using Tyuiu.PupovAA.Sprint4.Task3.V29.Lib;
namespace Tyuiu.PupovAA.Sprint4.Task3.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] data = new int[,] { { 9, 9, 8, 6, 9 }, { 5, 8, 8, 8, 7 }, { 6, 5, 9, 7, 9 }, { 7, 7, 9, 7, 8 }, { 8, 5, 8, 5, 5 } };
            var res = ds.Calculate(data);
            Assert.AreEqual(15120, res );
        }
    }
}
