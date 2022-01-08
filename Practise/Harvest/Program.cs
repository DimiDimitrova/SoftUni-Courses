using System;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            double sumGrape = x * y;
            double wine = (0.40 * sumGrape )/ 2.5;
            if (wine<z)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(z-wine)} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(wine-z)} liters left -> {Math.Ceiling((wine-z)/workers)} liters per person.");
            }

        }
    }
}
