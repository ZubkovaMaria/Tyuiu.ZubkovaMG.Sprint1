using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZubkovaMG.Sprint1.Task3.V17.Lib
{
    public class DataService : ISprint1Task3V17
    {
        public bool ZeroCheck(double number)
        {
            double val = Math.Abs(number);
            double frac = val - Math.Truncate(val);
            int num = (int)Math.Round(frac * 1000, 0);
            int d1 = num / 100;
            int d2 = (num/10)%10;
            int d3 = num % 10;
            return d1 == 0 || d2 == 0 || d3 == 0;
        }
    }
}