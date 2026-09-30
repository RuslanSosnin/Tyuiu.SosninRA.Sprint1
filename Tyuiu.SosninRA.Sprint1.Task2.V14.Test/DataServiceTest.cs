using Tyuiu.SosninRA.Sprint1.Task2.V14.Lib;

namespace Tyuiu.SosninRA.Sprint1.Task2.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 300;

            var res = ds.ConvertKelvinToCelsius(k);

            Assert.AreEqual(27, res);
        }
    }
}
