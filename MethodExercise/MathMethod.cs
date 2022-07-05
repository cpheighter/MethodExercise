using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercise
{
    internal class MathMethod
    {
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }
        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
        //-----------------------------------------------------------
        public static double AddAnything(params double[] allnum)
        {
            double total = 0;

            foreach (double num in allnum)
            {
                total += num;
            }
            return total;
        }
    }
}
