using System;
using System.Threading.Tasks;

namespace Asynchronouscalls_CalculateArea
{
    class Rectangle_Area
    {
        public string ShapeName { get; set; }
        private double Length { get; set; }
        private double Width { get; set; }
        public Rectangle_Area(double length, double width, string shapeName)
        {
            Length = length;
            Width = width;
            ShapeName = shapeName;
        }

        public async Task<string> GetAreaofRectangle()
        {
            Console.WriteLine($"calculation of area of the {ShapeName} is started");
            double areaofRect = Length * Width;

            var startTime = DateTime.Now;
            await Task.Delay(5000);//5 sec
            var endTime = DateTime.Now;
            var elapsedTime = endTime - startTime;

            Console.WriteLine($"calculation of area of the {ShapeName} is completed");
            return $"Area of {ShapeName} is calculated in {elapsedTime.TotalMilliseconds}ms";
        }
    }
    class Circle_Area
    {
        private const double pi = 3.14;
        private double Radius { get; set; }
        public string ShapeName { get; set; }

        public Circle_Area(double radius, string shapename)
        {
            Radius = radius;
            ShapeName = shapename;
        }

        public async Task<string> GetAreaofCircle()
        {
            Console.WriteLine($"calculation of area of the {ShapeName} is started");
            double areaofCircle = pi * Radius * Radius;

            var startTime = DateTime.Now;
            await Task.Delay(3000);//5 sec
            var endTime = DateTime.Now;
            var elapsedTime = endTime - startTime;

            Console.WriteLine($"calculation of area of the {ShapeName} is completed");
            return $"Area of {ShapeName} is calculated in {elapsedTime.TotalMilliseconds}ms";
        }
    }

    class AreaCalculation
    {
        public static async Task CalculateArea(Rectangle_Area rect, Circle_Area circle)
        {
            var startTime = DateTime.Now;

            Task<string> rectAreaTask = rect.GetAreaofRectangle();
            Task<string> circleAreaTask = circle.GetAreaofCircle();

            string[] allResults = await Task.WhenAll(rectAreaTask, circleAreaTask);

            foreach (string Result in allResults)
            {
                Console.WriteLine(Result);
            }

            var endTime = DateTime.Now;
            var TotalTime = endTime - startTime;
            Console.WriteLine($"Toatal Time for calculating the areas of Rectangle and Circle is {TotalTime.TotalMilliseconds}ms");
        }
    }

    class Program
    {
        static async Task Main()
        {
            Rectangle_Area rect = new Rectangle_Area(10, 5, "Rectangle");

            Circle_Area circle = new Circle_Area(6.4, "Circle");

            await AreaCalculation.CalculateArea(rect, circle);
            Console.WriteLine("Now my calculation is completed");
        }
    }

}
