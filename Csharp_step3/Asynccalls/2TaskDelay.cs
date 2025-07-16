using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskDelayNamespace
{
    class TaskDelayClass
    {
        static async Task Method1()
        {
            Console.WriteLine("Task1 started...");
            await Task.Delay(5000);//5 sec
            Console.WriteLine("Task1 name is Method1");
        }

        static async Task Method2()
        {
            Console.WriteLine("Task2 started...");
            await Task.Delay(3000);//5 sec
            Console.WriteLine("Task2 name is Method1");
        }
        static async Task Main()
        {
            //synchronous call-it takes 8 sec for completion.
            //await Method1();
            //Console.WriteLine("Method1 is completed..");

            //await Method2();
            //Console.WriteLine("Method2 is completed..");

            //Asynchronous call- It takes 5sec for completion.
            Console.WriteLine("Tasks are started");

            Task method1 = Method1();
            Task method2 = Method2();
            await Task.WhenAll(method1, method2);

            Console.WriteLine("Tasks are completed");

        }
    }
}
