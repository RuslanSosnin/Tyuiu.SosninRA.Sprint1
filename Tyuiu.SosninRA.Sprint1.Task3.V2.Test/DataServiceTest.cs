using Tyuiu.SosninRA.Sprint1.Task3.V2.Lib;

namespace Tyuiu.SosninRA.Sprint1.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double priceNotebook = 2.75;
            int amountNotebook = 5;
            double pricePencil = 1.25;
            int amountPencil = 2;

            double res = ds.PurchaseAmount(priceNotebook, amountNotebook, pricePencil, amountPencil);

            Assert.AreEqual(16.25, res);
        }
    }
}
