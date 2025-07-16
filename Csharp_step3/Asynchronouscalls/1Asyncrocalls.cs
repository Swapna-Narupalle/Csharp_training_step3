using System;
using System.Threading;
using System.Threading.Tasks;

//Asynchronous calls: run all tasks simultaniously or parallel manner
namespace Asynchronous_calls
{
    class UsingMobileSystemAsync
    {
        public static async Task MovieDownload()
        {
            var StartTime = DateTime.Now;
            await Task.Delay(10000);
            var EndTime = DateTime.Now;
            var elapsedTime = EndTime - StartTime;//10ms
            Console.WriteLine($"The movie has been downloaded. Elapsed Time: {elapsedTime.TotalMilliseconds}ms");
        }

        public static async Task ChattingWithFriend()
        {
            var StartTime = DateTime.Now;
            await Task.Delay(5000);
            var EndTime = DateTime.Now;
            var elapsedTime = EndTime - StartTime;//5ms
            Console.WriteLine($"Chatting with my friend is over. Elapsed Time: {elapsedTime.TotalMilliseconds}ms");
        }

        public static async Task PhonecallWithFamily()
        {
            var StartTime = DateTime.Now;
            await Task.Delay(3000);
            var EndTime = DateTime.Now;
            var elapsedTime = EndTime - StartTime;//3ms
            Console.WriteLine($"The Call has ended. Elapsed Time: {elapsedTime.TotalMilliseconds}ms");
        }

    }
    class MobileUsage
    {
        public static async Task UsingMobile()
        {
            Console.WriteLine("Concurrent works-Running all tasks simultaneously");
            var StartTime = DateTime.Now;

            //For synchronous//18 ms
            //await UsingMobileSystemAsync.MovieDownload();
            //await UsingMobileSystemAsync.ChattingWithFriend();
            //await UsingMobileSystemAsync.PhonecallWithFamily();


            //for asynchronous - 10 ms
            Task movieDownload = UsingMobileSystemAsync.MovieDownload();
            Task chatwithFriend = UsingMobileSystemAsync.ChattingWithFriend();
            Task phonecallwithFamily = UsingMobileSystemAsync.PhonecallWithFamily();
            await Task.WhenAll(movieDownload, chatwithFriend, phonecallwithFamily);


            var EndTime = DateTime.Now;
            var TotalTime = EndTime - StartTime;//10 ms
            Console.WriteLine($"Now my tasks are completed. Total Time: {TotalTime.TotalMilliseconds}");
        }
    }
    class Program
    {
        static async Task Main()
        {
            await MobileUsage.UsingMobile();
        }
    }
}
