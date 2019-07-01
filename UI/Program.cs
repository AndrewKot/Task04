using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumericalMathMethods;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            Console.WriteLine(FindRootOfValue.GetRootOfValue(1000d, 18F, 0.01d, 1d));
            

            Console.ReadLine();
        }
    }
}
