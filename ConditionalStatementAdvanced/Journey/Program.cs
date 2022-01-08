using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            double price = 0;

            switch (season)
            {
                case "summer":
                    if (budget<=100)
                    {
                        destination = "Bulgaria";
                        price = 0.3;
                    }
                    else if (budget<=1000)
                    {
                        destination = "Balkans";
                        price = 0.4;
                    }
                    else if (budget>1000)
                    {
                        destination = "Europe";
                        price = 0.9;
                    }
                    break;
                case "winter":
                    if (budget<=100)
                    {
                        destination = "Bulgaria";
                        price = 0.7;
                    }
                    else if (budget<=1000)
                    {
                        destination = "Balkans";
                        price = 0.8;
                    }
                    else if (budget>1000)
                    {
                        destination = "Europe";
                        price = 0.9;
                    }
                    break;
                
            }
            string place = "";
            if (season=="summer")
            {
                if (destination=="Europe")
                {
                    place = "Hotel";
                }
                else
                {
                    place = "Camp";
                }
               
            }
            else if(season=="winter")
            {
                
                place = "Hotel";
            }
            double totalPrice = 0;
            totalPrice = budget * price;
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {totalPrice:F2}");
      
        }
    }
}
