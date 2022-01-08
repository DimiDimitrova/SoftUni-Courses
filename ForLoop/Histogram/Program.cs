using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int group1 = 0;
            int group2 = 0;
            int group3 = 0;
            int group4 = 0;
            int group5 = 0;
            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 200)
                {
                    group1++;
                }
                if (number >= 200 && number <= 399)
                {
                    group2++;
                }
                if (number >= 400 && number <= 599)
                {
                    group3++;
                }
                if (number >= 600 && number <= 799)
                {
                    group4++;
                }
                if (number >= 800)
                {
                    group5++;
                }

            }
            double p1 = (group1 * 1.00 / n) * 100;
            double p2 = (group2 * 1.00 / n) * 100;
            double p3 = (group3 * 1.00 / n) * 100;
            double p4 = (group4 * 1.00 / n) * 100;
            double p5 = (group5 * 1.00 / n) * 100;
            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
            Console.WriteLine($"{p4:F2}%");
            Console.WriteLine($"{p5:F2}%");
        }
    }
}
