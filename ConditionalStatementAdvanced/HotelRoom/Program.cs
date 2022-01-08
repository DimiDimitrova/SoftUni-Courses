using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string months = Console.ReadLine();
            int countNight = int.Parse(Console.ReadLine());
            double priceStudio = 0;
            double priceAparthment = 0;
            double discount = 0;

            switch (months)
            {
                case "May":
                case "Octomber":
                    priceStudio = 50;
                    priceAparthment = 65;
                    break;
                case "June":
                case "September":
                    priceStudio = 75.20;
                    priceAparthment = 68.70;
                    break;
                case "July":
                case "August":
                    priceStudio = 76;
                    priceAparthment = 77;
                    break;

            }
            if (countNight > 7 && countNight <= 14 && (months == "May" || months == "Octomber"))
            {
                discount = 0.05;
                priceStudio -= priceStudio * discount;

            }
            else if (countNight >= 14)
            {
                if (months == "May" || months == "Octomber")
                {

                    discount = 0.3;

                    priceStudio -= priceStudio * discount;

                }
                else if (months == "June" || months == "September")
                {
                    discount = 0.2;

                    priceStudio -= priceStudio * discount;

                }
            }

                
                double discountA = 0;
            bool isTrue = countNight > 14 && (months == "May" || months == "Octomber" || months == "June" || months == "September" || months == "July" || months == "August");
            
                if (isTrue)
            {
                discountA = 0.1;
                priceAparthment -= priceAparthment * discountA;
            }
            double totalS = 0;
            double totalA = 0;
            totalS = countNight * priceStudio;
            totalA = countNight * priceAparthment;
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
