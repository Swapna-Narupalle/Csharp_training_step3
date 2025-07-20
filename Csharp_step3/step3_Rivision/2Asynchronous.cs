using System;
using System.Diagnostics;
using System.Threading.Tasks;



namespace Asynchronous_OnlineShopping
{
    public static class OnlineShoppingTasks
    {
        public static async Task<string> BrowsingProductsAsync()
        {
            Console.WriteLine("Browsing Started...");
            var sw = Stopwatch.StartNew();
            await Task.Delay(10000);
            sw.Stop();
            Console.WriteLine("Task1 Completed");
            return $"Browsing Completed in {sw.ElapsedMilliseconds}ms";
        }

        public static async Task<string> AddingToCartAsync()
        {
            Console.WriteLine("Adding to cart...");
            var sw = Stopwatch.StartNew();
            await Task.Delay(3000);
            sw.Stop();
            Console.WriteLine("Task2 Completed");
            return $"Added to cart in {sw.ElapsedMilliseconds}ms";
        }

        public static async Task<string> PaymentProcessAsync()
        {
            Console.WriteLine("Payment Processing...");
            var sw = Stopwatch.StartNew();
            await Task.Delay(1000);
            sw.Stop();
            Console.WriteLine("Task3 Completed");
            return $"Payment Completed within {sw.ElapsedMilliseconds}ms";
        }

    }
    public static class OnlineShopping
    {
        public static async Task<string> OnlineshoppingAsync()
        {
            Console.WriteLine("Online shopping Started");

            var sw = Stopwatch.StartNew();

            Task<string> BrowsingProducts = OnlineShoppingTasks.BrowsingProductsAsync();
            Task<string> AddingToCart = OnlineShoppingTasks.AddingToCartAsync();
            Task<string> ProcessingPayment = OnlineShoppingTasks.PaymentProcessAsync();

            string[] AllTasks = await Task.WhenAll(BrowsingProducts, AddingToCart, ProcessingPayment);
            foreach(string Task in AllTasks)
            {
                Console.WriteLine(Task);
            }

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
