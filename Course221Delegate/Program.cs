using System;
using Course221Delegate.Services;

namespace Course221Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 10;
            double y = 12;

            double result1 = CalculationService.Max(x, y);

            double result2 = CalculationService.Sum(x, y);

            double result3 = CalculationService.Square(x);

            Console.WriteLine(result1);

            Console.WriteLine(result2);

            Console.WriteLine(result3);

        }
    }
}


