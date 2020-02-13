using System;

namespace Addition
{
    public class Add
    {
        static void Main(string[] args)
        {

        }
        public static double Operartion(double num1, double num2, string opp)
        {
            double result = double.NaN;
            switch (opp)
            {
                case "1" :
                result = num1 + num2;
                    break;
            }
            return result;
        }
    }
}
