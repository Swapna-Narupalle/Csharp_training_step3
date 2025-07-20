using System;
using System.Diagnostics;
using System.Threading.Tasks;

//Sequential Asynchronous Program
// Here we run tasks sequentially using async because each task depends on the previous one.

namespace Sequential_Asynchronous_OnlineShopping
{
    public static class OnlineShoppingTasks
    {
        public static async Task<string> BrowsingProductsAsync()
        {
            Console.WriteLine("Browsing Started...");
            var sw = Stopwatch.StartNew();
            await Task.Delay(4000);
            sw.Stop();
            return $"Browsing Completed in {sw.ElapsedMilliseconds}ms";
        }

        public static async Task<string> AddingToCartAsync()
        {
            Console.WriteLine("Adding to cart...");
            var sw = Stopwatch.StartNew();
            await Task.Delay(3000);
            sw.Stop();
            return $"Added to cart in {sw.ElapsedMilliseconds}ms";
        }

        public static async Task<string> PaymentProcessAsync()
        {
            Console.WriteLine("Payment Processing...");
            var sw = Stopwatch.StartNew();
            await Task.Delay(4000);
            sw.Stop();
            return $"Payment Completed within {sw.ElapsedMilliseconds}ms";
        }

    }
    public static class OnlineShopping
    {
        public static async Task<string> OnlineshoppingAsync()
        {
            Console.WriteLine("Online shopping Started");

            var sw = Stopwatch.StartNew();

            Console.WriteLine(await OnlineShoppingTasks.BrowsingProductsAsync());
            Console.WriteLine(await OnlineShoppingTasks.AddingToCartAsync());
            Console.WriteLine(await OnlineShoppingTasks.PaymentProcessAsync());

            sw.Stop();

            return $"Online shopping Completed Within {sw.ElapsedMilliseconds}ms";
        }
    }
    public static class Program
    {
        static async Task Main()
        {
            Console.WriteLine(await OnlineShopping.OnlineshoppingAsync());
        }
    }
}
