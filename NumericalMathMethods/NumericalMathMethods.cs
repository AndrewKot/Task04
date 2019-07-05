using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NumericalMathMethods
{
    public static class FindRootOfValue
    {
        private static bool Resolution(double value, double accuracy, double initialValu)
        {
            if (value >= 0 && accuracy >= 0 && initialValu > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static double GetRootOfValue(double value, float degree, double accuracy, double initialValue)
        {
            if (Resolution(value, accuracy, initialValue))
            {
                double tempValue = (1 / degree) * ((degree - 1) * initialValue + value / (Math.Pow(initialValue, degree - 1)));
                while (Math.Abs(tempValue - initialValue) > accuracy)
                {
                    initialValue = tempValue;
                    tempValue = (1 / degree) * ((degree - 1) * initialValue + value / (Math.Pow(initialValue, degree - 1)));
                }
                return tempValue;
            }
            else
            {
                throw new Exception("error input data");
            }
        }
    }
}
