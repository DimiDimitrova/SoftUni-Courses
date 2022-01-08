using System;

namespace DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int group1 = 0;
            int group2 = 0;
            int group3 = 0;
            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    group1++;
                }
                if (number % 3 == 0)
                {
                    group2++;
                }
                if (number % 4 == 0)
                {
                    group3++;
                }
            }
            double p1 = (group1 * 1.00 / n )* 100;
            double p2 = (group2 * 1.00 / n )* 100;
            double p3 = (group3 * 1.00 / n) * 100;
            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
        }
    }
}
