using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            var customCulture = (System.Globalization.CultureInfo)
            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            double a = GetValidatedInput("a");
            double b = GetValidatedInput("b");
            double r = CalculateExpression(a, b);

            Console.WriteLine("---------------------------");
            Console.WriteLine($"Сума: {r:F2}\n");
            Console.WriteLine("Натисніть будь-яку клавішу, щоб завершити...");
            Console.ReadKey();
        }

        static double GetValidatedInput(string variableName)
        {
            double value;
            while (true)
            {
                Console.Write($"Введіть дробове число {variableName} = ");
                if (double.TryParse(Console.ReadLine(), out value))
                    break;
                else
                {
                    Console.WriteLine("---------------------------");
                    Console.WriteLine($"Error in {variableName}! Будь ласка, повторіть введення ще раз!");
                }
            }
            return value;
        }

        static double CalculateExpression(double a, double b)
        {
            return a + b;
        }
    }
}