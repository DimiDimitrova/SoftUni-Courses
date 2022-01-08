using System;

namespace MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string part = Console.ReadLine();
            int countP = int.Parse(Console.ReadLine());
            double discount = 0;
            double priceV = 0;
            double priceN = 0;
            double finalBudget = 0;

            switch (part)
            {
                case "VIP":
                    if (countP >= 50)
                    {
                        discount = 0.25;
                    }
                    else if (countP >= 5 && countP <= 9)
                    {
                        discount = 0.6;
                    }
                    else if (countP >= 10 && countP <= 24)
                    {
                        discount = 0.5;
                    }
                    else if (countP >= 25 && countP <= 49)
                    {
                        discount = 0.4;
                    }
                    else if (countP >= 1 && countP <= 4)
                    {
                        discount = 0.75;
                    }
                    priceV = countP * 499.99;
                    finalBudget = budget - budget * discount;
                    if (finalBudget > priceV)
                    {
                        Console.WriteLine($"Yes! You have {(finalBudget - priceV):F2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money! You need {(priceV - finalBudget):F2} leva.");
                    }
                    break;
                case "Normal":
                    if (countP >= 50)
                    {
                        discount = 0.25;
                    }
                    else if (countP >= 5 && countP <= 9)
                    {
                        discount = 0.6;
                    }
                    else if (countP >= 10 && countP <= 24)
                    {
                        discount = 0.5;
                    }
                    else if (countP >= 25 && countP <= 49)
                    {
                        discount = 0.4;
                    }
                    else if (countP >= 1 && countP <= 4)
                    {
                        discount = 0.75;
                    }
                    priceN = countP * 249.99;
                    finalBudget = budget - budget * discount;
                    if (finalBudget > priceN)
                    {
                        Console.WriteLine($"Yes! You have {(finalBudget - priceN):F2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money! You need {(priceN - finalBudget):F2} leva.");
                    }
                    break;
            }

        }
    }
}
