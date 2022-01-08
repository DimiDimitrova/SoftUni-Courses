using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typePro = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double income = 0;
            //            •	Premiere – премиерна прожекция, на цена 12.00 лева.
            //•	Normal – стандартна прожекция, на цена 7.50 лева.
            //•	Discount – прожекция за деца, ученици и студенти на намалена цена от 5.00 лева.

            if (typePro=="Premiere")
            {
                income = r * c * 12;
            }
            else if (typePro=="Normal")
            {
                income = r * c * 7.50;
            }
            else if (typePro=="Discount")
            {
                income = r * c * 5;
            }
            Console.WriteLine($"{income:F2} leva");

        }
    }
}
