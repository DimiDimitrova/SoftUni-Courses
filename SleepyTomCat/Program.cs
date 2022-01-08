using System;

namespace SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int restDays= int.Parse(Console.ReadLine());
            int workDays = 365 - restDays;
            int timeForGame = workDays * 63 + restDays * 127;
            int diff = Math.Abs(30000 - timeForGame);
            int hours = diff / 60;

            int minutes = diff % 60;

            if (timeForGame>30000)
            {
                
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
        }
    }
}
