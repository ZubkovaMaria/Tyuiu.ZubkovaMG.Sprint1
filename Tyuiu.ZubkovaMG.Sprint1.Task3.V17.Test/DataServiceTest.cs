using Tyuiu.ZubkovaMG.Sprint1.Task3.V17.Lib;
namespace Tyuiu.ZubkovaMG.Sprint1.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double number = 15.405;
            bool res = ds.ZeroCheck(number);
            Assert.AreEqual(true, res);
        }
    }
}