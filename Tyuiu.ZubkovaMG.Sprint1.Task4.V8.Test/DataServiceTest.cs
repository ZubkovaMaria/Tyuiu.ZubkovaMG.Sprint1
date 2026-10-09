using Tyuiu.ZubkovaMG.Sprint1.Task4.V8.Lib;

namespace Tyuiu.ZubkovaMG.Sprint1.Task4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 1.0;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(1.4, res);
        }
    }
}