using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic_Function_Calculator
{
    internal class OutputClass
    {
        public static void Output(double a, double b, double c)
        {
            double delta = Math.Pow(b, 2) - 4 * a * c;
            double p = -b / (2 * a);
            double q = -delta / (4 * a);
            double x1 = 0;
            double x2 = 0;

            if (q == -0) q = 0;
            if (p == -0) p = 0;

            if (delta > 0)
            {
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Delta = {delta} \n" +
                    $"x1 = {x1} \n" +
                    $"x2 = {x2} \n" +
                    $"p = {p} \n" +
                    $"q = {q}");
            }
            else if(delta == 0)
            {
                x1 = (-b) / (2 * a);
                Console.WriteLine($"Delta = {delta} \n" +
                    $"x1 = {x1} \n" +
                    $"x2 = Brak drugiego miejsca zerowego \n" +
                    $"p = {p} \n" +
                    $"q = {q}");
            }
            else
            {
                Console.WriteLine($"Delta = {delta} \n" +
                    $"Brak miejsc zerowych \n" +
                    $"p = {p} \n" +
                    $"q = {q}");
            }
        }
    }
}
