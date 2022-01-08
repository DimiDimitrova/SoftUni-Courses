using System;
using System.Diagnostics.Tracing;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherman = int.Parse(Console.ReadLine());
            decimal price = 0;
            decimal totalSum = 0;


            //  В зависимост от броя си групата ползва отстъпка:
            //•	Ако групата е до 6 човека включително  –  отстъпка от 10 %.
            //•	Ако групата е от 7 до 11 човека включително  –  отстъпка от 15 %.
            //•	Ако групата е от 12 нагоре  –  отстъпка от 25 %.
            decimal discount = 0m;
            decimal extraDiscount = 0.05m;

            switch (season)
            {
                case "Spring":
                    price = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    price = 4200;
                    break;
                case "Winter":
                    price = 2600;
                    break;
            }

            if (fisherman <= 6)
            {
                discount = 0.1m;
            }
            else if (fisherman >= 12)
            {
                discount = 0.25m;
            }
            else if (fisherman >= 7 || fisherman <= 11)
            {
                discount = 0.15m;
            }

            totalSum = price - price * discount;
            bool isValid = (fisherman % 2 == 0 && (season == "Spring" || season == "Summer" || season == "Winter"));

            if (isValid)
            {
                totalSum -= totalSum * extraDiscount;
            }

            if (budget >= totalSum)
            {
                Console.WriteLine($"Yes! You have {(budget - totalSum):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(totalSum - budget):F2} leva.");
            }
        }
    }
}
