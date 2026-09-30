using Tyuiu.SosninRA.Sprint1.Task7.V6.Lib;

namespace Tyuiu.SosninRA.Sprint1.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 2;

            // При x = 1, y = 2:
            // (1 + 1/1)^1 - 12 * 1^2 * 2 = 2 - 24 = -22
            double wait = -22;

            var res = ds.Calculate(x, y);

            Assert.AreEqual(wait, res);
        }
    }
}
