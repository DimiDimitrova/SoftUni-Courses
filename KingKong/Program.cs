using System;

namespace KingKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budgetFilm = double.Parse(Console.ReadLine());
            int statisticians = int.Parse(Console.ReadLine());
            double priceClothes = double.Parse(Console.ReadLine());
            double decor = 0.1 * budgetFilm;
            double clothesSum = statisticians * priceClothes;
            if (statisticians>150)
            {
                clothesSum =clothesSum- clothesSum * 0.1;
            }
            
            double totalMoney = decor + clothesSum;
            
            if (totalMoney>budgetFilm)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {(totalMoney-budgetFilm):F2} leva more.");
            }
            else if(totalMoney<=budgetFilm)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {(budgetFilm - totalMoney):F2} leva left.");
            }

         
            

        }
    }
}
