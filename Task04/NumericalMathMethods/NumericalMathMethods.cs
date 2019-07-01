using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalMathMethods
{
    public static class FindRootOfNumber
    {
        private static bool Resolution(double value, double accuracy)
        {
            if (value >= 0 && accuracy >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static double Root(double value, int degree, double accuracy, double initialValue)
        {
            if (Resolution(value, accuracy))
            {
               
                //while (true)
                //{

                //}
                return 0.0d;
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
