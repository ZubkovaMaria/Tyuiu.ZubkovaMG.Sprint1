using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ZubkovaMG.Sprint1.Task4.V8.Lib
{
    public class DataService : ISprint1Task4V8
    {
        public double Calculate(double x, double y)
        {
            double numerator = Math.Sqrt(Math.Abs(x - y)) + 3 * x;
            double denominator = 3 + Math.Abs(x);
            return Math.Round(numerator / denominator, 3);
        }
    }
}