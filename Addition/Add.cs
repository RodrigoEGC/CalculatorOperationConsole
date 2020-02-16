using System;

namespace Addition
{
    public class Add
    {
        static void Main(string[] args)
        {

        }
        public static double Operartion(double num1, double num2, string option)
        {
            double result = double.NaN;
            if (option == "1")
            {
                
                result = num1 + num2;
            }
            return result;
        }
    }
}
