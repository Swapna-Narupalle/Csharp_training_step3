using System;

namespace IntExtensionsNameSpace
{
    public static class IntegerExtensions
    {
        //extension method for integer type
        public static bool IsEven(this int number)//it takes any int value
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class Program
    {
        static void Main()
        {
            int num1 = 3;
            int num2 = 4;

            //by using extensions method
            Console.WriteLine($"{num1} is even: {num1.IsEven()}");
            Console.WriteLine($"{num2} is even: {num2.IsEven()}");
        }
    }
}
