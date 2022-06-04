using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic_Function_Calculator
{
    internal class InputClass
    {
        private double a;
        private double b;
        private double c;

        public void Input()
        {
            Console.WriteLine("Podaj a");
            _ = double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("\nPodaj b");
            _ = double.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("\nPodaj c");
            _ = double.TryParse(Console.ReadLine(), out c);

            Console.WriteLine($"\na = {a} b = {b} c = {c}\n\nAby zatwierdzić kliknij enter\n");
            Console.ReadKey();
            OutputClass.Output(a, b, c);
        }
    }
}
