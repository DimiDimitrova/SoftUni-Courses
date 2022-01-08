using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string place = "";
            string location = "";
            double discount = 0;
            if (budget <= 1000)
            {
                place = "Camp";
                if (season == "Summer")
                {
                    location = "Alaska";
                    discount = 0.65;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    discount = 0.45;
                }
            }
            else if (budget > 1000 && budget <= 3000)
            {
                place = "Hut";
                if (season=="Summer")
                {
                    location = "Alaska";
                    discount = 0.8;
                }
                else if (season=="Winter")
                {
                    location = "Morocco";
                    discount = 0.6;
                }
            }
            else if (budget>3000)
            {
                place = "Hotel";
                if (season=="Summer")
                {
                    location = "Alaska";
                    discount = 0.9;
                }
                else if (season=="Winter")
                {
                    location = "Morocco";
                    discount = 0.9;
                }
            }
            double price = discount * budget;
            Console.WriteLine($"{location} - {place} - {price:f2}");

        }
    }
}
