﻿using System;

namespace Multiplication
{
    public class Mut
    {
        static void Main(string[] args)
        {
        
        }
        public static double Operation(double num1, double num2, string opp)
        {

            double result = double.NaN;
            switch (opp)
            {
                case "3":
                    result = num1 * num2;
                    break;
            }
            return result;
        }
    }
}