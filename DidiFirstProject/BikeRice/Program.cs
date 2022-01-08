using System;

namespace BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string way = Console.ReadLine();
            double taxJunior = 0;
            double taxSeniors = 0;
            switch (way)
            {
                case "trail":
                    taxJunior = 5.50;
                    taxSeniors = 7;
                    break;
                case "cross-country":
                    taxJunior = 8;
                    taxSeniors = 9.50;
                    if ((juniors+seniors)>=50)
                    {
                        taxJunior = taxJunior - taxJunior * 0.25;
                        taxSeniors = taxSeniors - taxSeniors * 0.25;
                    }
                    break;
                case "downhill":
                    taxJunior = 12.25;
                    taxSeniors = 13.75;
                    break;
                case "road":
                    taxJunior = 20;
                    taxSeniors = 21.50;
                    break;
              
            }
            double sum = juniors * taxJunior + seniors * taxSeniors;
            double expense = 0.05 * sum;
            Console.WriteLine($"{(sum-expense):F2}");

        }
    }
}
