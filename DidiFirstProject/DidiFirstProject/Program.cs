using System;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int chrysanthemum = int.Parse(Console.ReadLine());
            int rose = int.Parse(Console.ReadLine());
            int tulip = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            char day = char.Parse(Console.ReadLine());

            double priceChrysanthemum = 0;
            double priceRose = 0;
            double priceTulip = 0;

            if (season == "Spring" || season == "Summer")
            {
                priceChrysanthemum = 2;
                priceRose = 4.10;
                priceTulip = 2.50;
            }
            else if (season == "Autumn" || season == "Winter")
            {
                priceChrysanthemum = 3.75;
                priceRose = 4.50;
                priceTulip = 4.15;
            }

            double totalSum = chrysanthemum * priceChrysanthemum + rose * priceRose + tulip * priceTulip;
            double discount = 0;
            if (day == 'Y')
            {
                totalSum = totalSum + totalSum * 0.15;
            }
            if (season == "Spring" && tulip > 7)
            {
                discount = 0.05;
            }
            else if (season == "Winter" && rose >= 10)
            {
                discount = 0.1;
            }
            if ((chrysanthemum + rose + tulip) > 20)
            {
              totalSum=totalSum-totalSum* 0.2;
            }
            totalSum = totalSum - totalSum * discount;
            Console.WriteLine($"{(totalSum + 2):F2}");



        }
    }
}
