using Tyuiu.ZubkovaMG.Sprint1.Task2.V16.Lib;

namespace Tyuiu.ZubkovaMG.Sprint1.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int r = 5;
            var res = ds.CalculatePerimetrCircle(r);
            Assert.AreEqual(31.416, res);
        }
    }
}