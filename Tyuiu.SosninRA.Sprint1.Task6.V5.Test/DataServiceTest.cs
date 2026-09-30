using Tyuiu.SosninRA.Sprint1.Task6.V5.Lib;

namespace Tyuiu.SosninRA.Sprint1.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();

            string strTest = "привет казак машина шалаш";
            string res = ds.CheckSymmetricalWords(strTest);
            string wait = "казак шалаш";

            Assert.AreEqual(wait, res);
        }
    }
}
