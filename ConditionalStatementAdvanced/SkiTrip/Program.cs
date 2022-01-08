using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string estimate = Console.ReadLine();
            double price = 0;
            double discount = 0;
            //                     по - малко от 10 дни     между 10 и 15 дни        повече от 15 дни
            //room for one person  не ползва намаление      не ползва намаление      не ползва намаление
            //apartment            30 % от крайната цена    35 % от крайната цена    50 % от крайната цена
            //president apartment  10 % от крайната цена    15 % от крайната цена    20 % от крайната цена

            switch (room)
            {
                case "room for one person":
                    price = 18;

                    break;
                case "apartment":
                    price = 25;
                    if (days < 10)
                    {
                       discount= 0.3;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        discount= 0.35;
                    }
                    else if (days > 15)
                    {
                        discount= 0.5;
                    }
                    break;
                case "president apartment":
                    price = 35;
                    if (days < 10)
                    {
                        discount= 0.1;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                       discount= 0.15;
                    }
                    else if (days > 15)
                    {
                       discount= 0.2;
                    }
                    break;

                default:
                    break;
                    
            }
            double totalPrice = (days - 1) * price;
            totalPrice = totalPrice - discount * totalPrice;

            if (estimate=="positive")
            {
                totalPrice += totalPrice * 0.25;
            }
            else 
            {
                totalPrice -= totalPrice * 0.1;
            }
            Console.WriteLine($"{totalPrice:F2}");

        }
    }
}
