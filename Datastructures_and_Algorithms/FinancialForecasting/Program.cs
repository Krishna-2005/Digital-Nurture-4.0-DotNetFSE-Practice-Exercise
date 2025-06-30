using System;

namespace FinancialForecasting
{
    class Program
    {
        static double CalculateFutureValue(double currentValue, double growthRate, int years)
        {
            if (years == 0)
                return currentValue;

            return CalculateFutureValue(currentValue * (1 + growthRate), growthRate, years - 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter current value:");
            double currentValue = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter annual growth rate (e.g., 0.05 for 5%):");
            double growthRate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number of years:");
            int years = Convert.ToInt32(Console.ReadLine());

            double futureValue = CalculateFutureValue(currentValue, growthRate, years);

            Console.WriteLine($"\nFuture value after {years} years: {futureValue:F2}");
        }
    }
}


