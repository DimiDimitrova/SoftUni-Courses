using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double percentL = percent * 0.01;
            double volumeOfTank = lenght * width * height;
            double sumOfLiters = volumeOfTank * 0.001;
            double needLiters = sumOfLiters * (1-percentL);
            Console.WriteLine($"{needLiters:F3}");
        }
    }
}
