using Tyuiu.ZubkovaMG.Sprint1.Task5.V2.Lib;

namespace Tyuiu.ZubkovaMG.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double fahrenheit = 86;
            int res = ds.FahrenheitToСelsius(fahrenheit);
            Assert.AreEqual(30, res);
        }
    }
}
