using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZubkovaMG.Sprint1.Task7.V17.Lib
{
    public class DataService : ISprint1Task7V17
    {
        public double Calculate(double x, double y)
        {
            double numerator = 1.0 + Math.Sin(Math.Sqrt(x * x + 1.0));
            double denominator = Math.Cos(12.0 * y - 4.0);

            double z = numerator / denominator;

            return Math.Round(z, 3);
        }
    }
}