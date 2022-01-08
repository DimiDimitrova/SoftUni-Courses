using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double holidayPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int teddyBears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int lories = int.Parse(Console.ReadLine());
            double sumToys = puzzles + dolls + teddyBears + minions + lories;
            double totalProfit = puzzles * 2.60 + dolls * 3 + teddyBears * 4.10 + minions * 8.20 + lories * 2;
            if (sumToys >= 50)
            {
                totalProfit = totalProfit * 0.75;
            }
            totalProfit = totalProfit * 0.9;
            //double diff = Math.Abs(totalProfit-holidayPrice);
            //if (totalProfit>=holidayPrice)
            //{
            //    Console.WriteLine($"Yes! {diff:F2} lv left.");
            //}
            //else
            //{
            //    Console.WriteLine($"Not enough money! {diff:F2} lv needed.");
            //}
            if (totalProfit>=holidayPrice)
            {
                Console.WriteLine($"Yes! {(totalProfit-holidayPrice):F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(holidayPrice-totalProfit):F2} lv needed.");
            }



        }
    }
}

