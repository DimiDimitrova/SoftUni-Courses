using System;

namespace SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string typeGroup = Console.ReadLine();
            int children = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());

            double priceNight = 0;
            string sport = "";
            if (season == "Winter")
            {
                if (typeGroup == "boys")
                {
                    priceNight = 9.60;
                    sport = "Judo";
                }
                else if (typeGroup == "girls")
                {
                    priceNight = 9.60;
                    sport = "Gymnastics";
                }
                else if (typeGroup == "mixed")
                {
                    priceNight = 10;
                    sport = "Ski";
                }
            }
            else if (season == "Spring")
            {
                if (typeGroup == "boys")
                {
                    priceNight = 7.20;
                    sport = "Tennis";
                }
                else if (typeGroup == "girls")
                {
                    priceNight = 7.20;
                    sport = "Athletics";
                }
                else if (typeGroup == "mixed")
                {
                    priceNight = 9.50;
                    sport = "Cycling";
                }
            }
            else if (season == "Summer")
            {
                if (typeGroup == "boys")
                {
                    priceNight = 15;
                    sport = "Football";
                }
                else if (typeGroup == "girls")
                {
                    priceNight = 15;
                    sport = "Volleyball";
                }
                else if (typeGroup == "mixed")
                {
                    priceNight = 20;
                    sport = "Swimming";
                }
            }
            double price = children * priceNight * nights;

            double discount = 0;
            if (children >= 50)
            {
                discount = 0.5;
            }
            else if (children >= 20 && children < 50)
            {
                discount = 0.15;
            }
            else if (children >= 10 && children < 20)
            {
                discount = 0.05;
            }
            double totalPrice = price - price * discount;
            Console.WriteLine($"{sport} {totalPrice:F2} lv.");



        }
    }
}
