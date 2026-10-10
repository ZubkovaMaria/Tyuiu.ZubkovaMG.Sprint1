using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZubkovaMG.Sprint1.Task6.V15.Lib;

namespace Tyuiu.ZubkovaMG.Sprint1.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckLettersCount()
        {
            DataService ds = new DataService();
            string str = "Привет, мир!";
            bool res = ds.CheckLettersCount(str);

            Assert.AreEqual(true, res);
        }
    }
}
