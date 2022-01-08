using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string months = Console.ReadLine();
            int countNight = int.Parse(Console.ReadLine());
            double priceS = 0;
            double priceA = 0;
            double discount = 0;

            switch (months)
            {
                case "May":
                case "Octomber":
                    priceS = 50;
                    priceA = 65;
                    break;
                case "June":
                case "September":
                    priceS = 75.20;
                    priceA = 68.70;
                    break;
                case "July":
                case "August":
                    priceS = 76;
                    priceA = 77;
                    break;

            }
            if (countNight > 7 && countNight <= 14 && (months == "May" || months == "Octomber"))
            {
                discount = 0.05;
                priceS -= priceS * discount;

            }
            else if (countNight >= 14)
            {
                if (months == "May" || months == "Octomber")
                {

                    discount = 0.3;

                    priceS -= priceS * discount;

                }
                else if (months == "June" || months == "September")
                {
                    discount = 0.2;

                    priceS -= priceS * discount;

                }
            }

                
                double discountA = 0;
            bool isTrue = countNight > 14 && (months == "May" || months == "Octomber" || months == "June" || months == "September" || months == "July" || months == "August");
            
                if (isTrue)
            {
                discountA = 0.1;
                priceA -= priceA * discountA;
            }
            double totalS = 0;
            double totalA = 0;
            totalS = countNight * priceS;
            totalA = countNight * priceA;
            Console.WriteLine($"Apartment: {totalA:F2} lv.");
            Console.WriteLine($"Studio: {totalS:F2} lv.");


        }
    }
}
//if (nights > 7)                                                                             //Check for discount for a studio.
//                {
//                    if (nights <= 14)
//                    {
//                        discountStudio = (priceStudio / 100) * 5;                          //Calculates the discount 5% for a stdio.
//                    }
//                    else
//                    {
//                        discountStudio = (priceStudio / 100) * 30;                        //Calculates the discount 30% for a stdio.
//                    }
//                }
