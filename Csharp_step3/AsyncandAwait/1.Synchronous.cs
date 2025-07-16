using System;
using System.Threading; // Needed for Thread.Sleep

namespace synchronous_calls
{
    class Calculator
    {
        // Method to perform synchronous addition
        public int Add(int a, int b)
        {
            Console.WriteLine("------Addition Started--------");
            Thread.Sleep(4000); // Simulate time-consuming operation (4 seconds)
            Console.WriteLine("------Addition Completed--------");
            return a + b;
        }

        static void Main()
        {
            Console.WriteLine("Program Started");

            Calculator calc = new Calculator();
            int result = calc.Add(10, 5); // Synchronous call - waits here for 4 seconds

            Console.WriteLine($"Result: {result}");
            Console.WriteLine("Program Ended");
        }
    }
}
