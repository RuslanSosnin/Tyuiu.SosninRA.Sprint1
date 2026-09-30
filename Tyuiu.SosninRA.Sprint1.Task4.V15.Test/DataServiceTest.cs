using Tyuiu.SosninRA.Sprint1.Task4.V15.Lib;

namespace Tyuiu.SosninRA.Sprint1.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 0.5;


            double wait = 1.25;

            var res = ds.Calculate(x, y);

            Assert.AreEqual(wait, res);
        }
    }
}
