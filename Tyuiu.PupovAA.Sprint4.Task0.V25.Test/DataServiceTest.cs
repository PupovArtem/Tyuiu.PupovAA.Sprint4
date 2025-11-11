using Tyuiu.PupovAA.Sprint4.Task0.V25.Lib;
namespace Tyuiu.PupovAA.Sprint4.Task0.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numbers;
            numbers = new int[] { 1, 4, 2, 6, 4, 8, 6, 7, 8, 4 };
            var res = ds.GetSumEvenArrEl(numbers);
            Assert.AreEqual(42, res);
        }
    }
}
