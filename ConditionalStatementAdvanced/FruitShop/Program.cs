using System;

namespace FruitShop
{
    class Program
    {
        //Магазин за плодове през работните дни работи на следните цени:
        //плод   banana  apple   orange  grapefruit kiwi    pineapple grapes
        //цена    2.50    1.20    0.85    1.45      2.70    5.50      3.85
        //Събота и неделя магазинът работи на по - високи цени:
        //плод banana  apple orange  grapefruit kiwi    pineapple grapes
        //цена  2.70   1.25    0.90    1.60    3.00      5.60      4.20

        static void Main()
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;

            bool isDayValid =
                day == "Monday"
                || day == "Tuesday"
                || day == "Wednesday"
                || day == "Thursday"
                || day == "Friday"
                || day == "Saturday"
                || day == "Sunday";

            bool isFruitValid =
                fruit == "apple"
                || fruit == "banana"
                || fruit == "orange"
                || fruit == "grapefruit"
                || fruit == "kiwi"
                || fruit == "pineapple"
                || fruit == "grapes";


            if (!isDayValid || !isFruitValid)
            {
                Console.WriteLine("error");
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                if (fruit == "banana")
                {
                    price = 2.70;
                }
                else if (fruit == "apple")
                {
                    price = 1.25;
                }
                else if (fruit == "orange")
                {
                    price = 0.90;
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.60;
                }
                else if (fruit == "kiwi")
                {
                    price = 3.00;
                }
                else if (fruit == "pineapple")
                {
                    price = 5.60;
                }
                else if (fruit == "grapes")
                {
                    price = 4.20;
                }

                double totalSum = price * quantity;
                Console.WriteLine($"{totalSum:F2}");
            }
            else
            {
                if (fruit == "banana")
                {
                    price = 2.50;
                }
                else if (fruit == "apple")
                {
                    price = 1.20;
                }
                else if (fruit == "orange")
                {
                    price = 0.85;
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.45;
                }
                else if (fruit == "kiwi")
                {
                    price = 2.70;
                }
                else if (fruit == "pineapple")
                {
                    price = 5.50;
                }
                else if (fruit == "grapes")
                {
                    price = 3.85;
                }

                double totalSum = price * quantity;
                Console.WriteLine($"{totalSum:F2}");
            }
        }
    }
}
