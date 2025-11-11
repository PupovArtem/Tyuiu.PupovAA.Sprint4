using Tyuiu.PupovAA.Sprint4.Task1.V29.Lib;
namespace Tyuiu.PupovAA.Sprint4.Task1.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numbers;
            numbers = new int[] { 5, 3, 3, 4, 1, 3, 3, 5, 6, 2, 7, 2, 1, 8 };
            var res = ds.Calculate(numbers);
            Assert.AreEqual(31, res);
        }
    }
}
