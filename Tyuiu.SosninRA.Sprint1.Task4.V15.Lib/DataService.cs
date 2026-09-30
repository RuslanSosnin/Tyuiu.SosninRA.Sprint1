using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SosninRA.Sprint1.Task4.V15.Lib
{
    public class DataService : ISprint1Task4V15
    {
        public double Calculate(double x, double y)
        {
            double res = (x + Math.Pow(y, 2)) / Math.Exp(2 - 4 * y);
            return Math.Round(res, 3);
        }
    }
}
