using System;
using Course221Delegate.Services;

namespace Course221Delegate
{
    class Program
    {
        //Declaração do meu DELEGATE para uma função que recebe 2 números doubles e retorna um double
        delegate double BinaryNumericOperation(double n1, double n2);

        static void Main(string[] args)
        {
            double x = 10;
            double y = 12;

            /*sem o uso do delegate
            double result1 = CalculationService.Max(x, y);
            double result2 = CalculationService.Sum(x, y);
            double result3 = CalculationService.Square(x);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            */

            //COM o USO do delegate
            BinaryNumericOperation op = CalculationService.Max;
            double result1 = op(x, y);

            //sintaxe alternartivas

            BinaryNumericOperation op2 = new BinaryNumericOperation(CalculationService.Max);
            double result2 = op2(x, y);

            BinaryNumericOperation op3 = CalculationService.Sum;
            double result3 = op3.Invoke(x, y);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
        }
    }
}


