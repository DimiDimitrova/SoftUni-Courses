using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFlower = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0;
            double discount = 0;

            //•	Ако Нели купи повече от 80 Рози - 10 % отстъпка от крайната цена
            //•	Ако Нели купи повече от 90  Далии - 15 % отстъпка от крайната цена
            //•	Ако Нели купи повече от 80 Лалета - 15 % отстъпка от крайната цена
            //•	Ако Нели купи по-малко от 120 Нарциса - цената се оскъпява с 15 %
            //•	Ако Нели Купи по-малко от 80 Гладиоли - цената се оскъпява с 20 %



            switch (typeFlower)
            {
                case "Roses":
                    price = quantity * 5;
                    if (quantity > 80)
                    {
                        price = price * 0.9;
                    }
                    break;
                case "Dahlias":
                    price = quantity * 3.80;
                    if (quantity > 90)
                    {
                        price = price * 0.85;
                    }
                    break;
                case "Tulips":
                    price = quantity * 2.80;
                    if (quantity > 80)
                    {
                        price = price * 0.85;
                    }
                    break;
                case "Narcissus":
                    price = quantity * 3;
                    if (quantity < 120)
                    {
                        //price = price + (price * 0.15);

                        price=1.15* price;

                    }
                    break;
                case "Gladiolus":
                    price = quantity * 2.50;
                    if (quantity < 80)
                    {
                       // price = price + (price * 0.20);
                         price = 1.20 * price; 
                    }
                    break;
                default:
                    break;
            }

            double difference = Math.Abs(budget - price);
            if (budget >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {quantity} and {difference:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {difference:F2} leva more.");
            }
        }
    }
}
