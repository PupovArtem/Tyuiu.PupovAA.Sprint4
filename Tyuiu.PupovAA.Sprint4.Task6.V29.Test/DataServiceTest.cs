using Tyuiu.PupovAA.Sprint4.Task6.V29.Lib;
namespace Tyuiu.PupovAA.Sprint4.Task6.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] mas = { "Весна", "Лето", "Осень", "Зима" };
            var res = ds.Calculate(mas);
            Assert.AreEqual(2, res);
        }
    }
}
