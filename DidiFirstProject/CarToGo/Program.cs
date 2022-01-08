using System;

namespace CarToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string typeClass = "";
            string typeCar = "";
            double discount = 0;
            if (budget <= 100)
            {
                typeClass = "Economy class";
                if (season == "Summer")
                {
                    typeCar = "Cabrio";
                    discount = 0.35;
                }
                else if (season == "Winter")
                {
                    typeCar = "Jeep";
                    discount = 0.65;
                }
            }
            else if (budget > 100 && budget <= 500)
            {
                typeClass = "Compact class";
                if (season == "Summer")
                {
                    typeCar = "Cabrio";
                    discount = 0.45;
                }
                else if (season == "Winter")
                {
                    typeCar = "Jeep";
                    discount = 0.8;
                }
            }
            else if (budget > 500)
            {
                typeClass = "Luxury class";
                if (season == "Summer" || season == "Winter")
                {
                    typeCar = "Jeep";
                    discount = 0.9;
                }
            }
            double price = budget * discount;
            Console.WriteLine(typeClass);
            Console.WriteLine($"{typeCar} - {price:F2}");

        }
    }
}
