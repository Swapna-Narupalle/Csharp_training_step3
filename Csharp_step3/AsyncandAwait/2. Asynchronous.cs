using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncCalculatorExample
{
    class Calculator
    {
        // Synchronous Addition Method
        public int Add(int a, int b)
        {
            Console.WriteLine("Synchronous Add started...");
            Thread.Sleep(3000);  // Simulates a 3-second blocking task
            Console.WriteLine("Synchronous Add completed.");
            return a + b;
        }

        // Asynchronous Addition Method
        public async Task<int> AddAsync(int a, int b)
        {
            Console.WriteLine("Asynchronous Add started...");
            await Task.Delay(3000); // Simulates a 3-second non-blocking task
            Console.WriteLine("Asynchronous Add completed.");
            return a + b;
        }
    }

    class Program
    {
        static async Task Main()
        {
            Calculator calc = new Calculator();

            // Call Synchronous Method
            Console.WriteLine("Calling synchronous Add...");
            int syncResult = calc.Add(5, 7);
            Console.WriteLine($"Synchronous Result: {syncResult}\n");

            // Call Asynchronous Method
            Console.WriteLine("Calling asynchronous AddAsync...");
            Task<int> asyncResultTask = calc.AddAsync(10, 20);

            Console.WriteLine("Main is free to do other work while waiting...\n");

            int asyncResult = await asyncResultTask;
            Console.WriteLine($"Asynchronous Result: {asyncResult}");
        }
    }
}
