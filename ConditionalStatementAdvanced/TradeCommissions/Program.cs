using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;
            bool isTownValid =
                town == "Sofia"
                || town == "Varna"
                || town == "Plovdiv";
            bool isQuantityValid = (0 <= quantity && quantity <= 500)
                || (500 < quantity && quantity <= 1000)
                || (1000 < quantity && quantity <= 10000)
                || (quantity > 10000);




            //  Град    0 ≤ s ≤ 500  500 < s ≤ 1 000  1 000 < s ≤ 10 000  s > 10 000
            //  Sofia     5 %             7 %                  8 %            12 %
            //  Varna     4.5 %           7.5 %                10 %           13 %
            //  Plovdiv   5.5 %           8 %                  12 %           14.5 %
            if (!isTownValid || !isQuantityValid)
            {
                Console.WriteLine("error");
            }
            else
            {



                switch (town)
                {
                    case "Sofia":
                        if (0 <= quantity && quantity <= 500)
                        {
                            price = 0.05;
                        }
                        else if (500 < quantity && quantity <= 1000)
                        {
                            price = 0.07;
                        }
                        else if (1000 < quantity && quantity <= 10000)
                        {
                            price = 0.08;
                        }
                        else if (quantity > 10000)
                        {
                            price = 0.12;
                        }
                        double totalSum = price * quantity;
                        Console.WriteLine($"{totalSum:F2}");
                        break;
                    case "Varna":
                        if (0 <= quantity && quantity <= 500)
                        {
                            price = 0.045;
                        }
                        else if (500 < quantity && quantity <= 1000)
                        {
                            price = 0.075;
                        }
                        else if (1000 < quantity && quantity <= 10000)
                        {
                            price = 0.1;
                        }
                        else if (quantity > 10000)
                        {
                            price = 0.13;
                        }
                        double total = price * quantity;
                        Console.WriteLine($"{total:F2}");

                        break;
                    case "Plovdiv":
                        if (0 <= quantity && quantity <= 500)
                        {
                            price = 0.055;
                        }
                        else if (500 < quantity && quantity <= 1000)
                        {
                            price = 0.08;
                        }
                        else if (1000 < quantity && quantity <= 10000)
                        {
                            price = 0.12;
                        }
                        else if (quantity > 10000)
                        {
                            price = 0.145;
                        }
                        double tSum = price * quantity;
                        Console.WriteLine($"{tSum:F2}");
                        break;


                }
            }

        }
    }
}
