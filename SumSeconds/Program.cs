using System;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirthTime = int.Parse(Console.ReadLine());
            int totalTime = firstTime + secondTime + thirthTime;
            double totalTimeMinute = totalTime / 60;
            double totalTimeSec = totalTime % 60;
            if (totalTimeSec < 10)
            {
                Console.WriteLine($"{ totalTimeMinute}:0{ totalTimeSec}");
            }
            else
            {
                Console.WriteLine($"{totalTimeMinute}:{totalTimeSec}");
            }
        }
    }
}
