using System;

//Extensions: Here we can add some features or values to the system withod changing its behaviour.
namespace Laptop_System_Extensions
{
    public class LaptopSystem
    {
        public string Password;
        public string Brand { get; set; }
        public void MakePassword(string password)
        {
            Password = password;
            Console.WriteLine($"I am setting the password '{Password}' on the {Brand} Laptop");
        }
    }

    //Extension: here we can take static class only.
    public static class LaptopSystemExtensions
    {
        public static string AppName { get; set; }

        public static void TrackFitness(this LaptopSystem laptop)
        {
            Console.WriteLine($"This {laptop.Brand} laptop is now tracking fitness.");
        }

        public static string InstallVisualStudio(this LaptopSystem laptop, string appName)
        {
            AppName = appName;
            return $"I have installed {AppName} on the {laptop.Brand} laptop";
        }
    }

    //without modifying the source code i want to add new functionality(extensions) to the class
    public class Program
    {
        static void Main()
        {
            LaptopSystem myLaptop = new LaptopSystem() { Brand = "Dell" };
            myLaptop.MakePassword("Rushi@9493");

            myLaptop.TrackFitness();
            string installapp =  myLaptop.InstallVisualStudio("Visual Studio 2022");
            Console.WriteLine(installapp);
        }
    }
}
