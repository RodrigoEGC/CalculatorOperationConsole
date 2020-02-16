using System;

namespace Multiplication
{
    public class Mut
    {
        static void Main(string[] args)
        {
        
        }
        public static double Operation(double num1, double num2, string option)
        {

            double result = double.NaN;
            if (option == "3")
            { 
                result = num1 * num2;
            }
            return result;
        }
    }
}
