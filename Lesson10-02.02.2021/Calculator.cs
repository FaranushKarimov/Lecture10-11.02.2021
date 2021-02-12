using System;
namespace Lesson10_02._02._2021
{
    public static class Calculator
    {
        // Operations  
        public static T minus<T>(T op1, T op2)
        {
            System.Console.Write($"{op1} - {op2} = ");
            return Math.Round((dynamic)op1 - (dynamic)op2, 2);
        }
        public static T sum<T>(T op1, T op2)
        {
            System.Console.Write($"{op1} + {op2} = ");
            return Math.Round((dynamic)op1 + (dynamic)op2, 2);
        }
        public static T mult<T>(T op1, T op2)
        {
            System.Console.Write($"{op1} * {op2} = ");
            return Math.Round((dynamic)op1 * (dynamic)op2, 2);
        }
        public static T div<T>(T op1, T op2)
        {
            if ((dynamic)op2 == 0)
            {
                System.Console.Write("Error Division by Zero: ");
                return (dynamic)0;
            }
            else
            {
                System.Console.Write($"{op1} / {op2} = ");
                return Math.Round((dynamic)op1 / (dynamic)op2, 2);
            }
        }
    }
}
