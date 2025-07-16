using System;
using System.Threading;

//Thread sleep
namespace ThreadSleepNamespace
{
    class ThreadSleepClass
    {
        static void Main()
        {
            Console.WriteLine("Start");
            Thread.Sleep(7000);//7secs
            Console.WriteLine("Resume");
            Thread.Sleep(4000);//4sec
            Console.WriteLine("End");

        }
    }
}
