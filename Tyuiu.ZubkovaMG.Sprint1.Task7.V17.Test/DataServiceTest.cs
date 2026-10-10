using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZubkovaMG.Sprint1.Task7.V17.Lib;
namespace Tyuiu.ZubkovaMG.Sprint1.Task7.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 0;
            double wait = -2.817;

            double res = ds.Calculate(x, y);

            Assert.AreEqual(wait, res);
        }
    }
}