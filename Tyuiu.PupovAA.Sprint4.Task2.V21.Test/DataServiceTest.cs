using Tyuiu.PupovAA.Sprint4.Task2.V21.Lib;
namespace Tyuiu.PupovAA.Sprint4.Task2.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numbers;
            numbers = new int[] { 6,2,6,2,6 };
            var res = ds.Calculate(numbers);
            Assert.AreEqual(864, res);
        }
    }
}
