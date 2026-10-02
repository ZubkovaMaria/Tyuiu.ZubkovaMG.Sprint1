using Tyuiu.ZubkovaMG.Sprint1.Task1.V28.Lib;
namespace Tyuiu.ZubkovaMG.Sprint1.Task1.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            var res = ds.Calculate(x);
            Assert.AreEqual(1, res);
        }
    }
}