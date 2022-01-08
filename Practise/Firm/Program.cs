using System;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededHours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int workOvertime = int.Parse(Console.ReadLine());
            double workHours = (days - (days * 0.1)) * 8;
            double workesInOvertime = workOvertime * (2 * days);
            double sumHours = Math.Floor(workHours + workesInOvertime);
            double n = Math.Abs(sumHours - neededHours);
            if (workOvertime == 0)
            {
                sumHours = workHours + 0;
            }
            else
            {
                sumHours = Math.Floor(workHours + workesInOvertime);

            }
            if (sumHours > neededHours)
            {
                Console.WriteLine($"Yes!{Math.Floor(n)} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{Math.Floor(n)} hours needed.");
            }
        }
    }
}
