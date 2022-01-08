using System;

namespace TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmMonth = double.Parse(Console.ReadLine());

            double salary = 0;
            if (kmMonth <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    salary = 0.75;
                }
                else if (season == "Summer")
                {
                    salary = 0.90;
                }
                else if (season == "Winter")
                {
                    salary = 1.05;
                }

            }
            else if (kmMonth > 5000 && kmMonth <= 10000)
            {

                if (season == "Spring" || season == "Autumn")
                {
                    salary = 0.95;
                }
                else if (season == "Summer")
                {
                    salary = 1.10;
                }
                else if (season == "Winter")
                {
                    salary = 1.25;
                }
            }
            else if (kmMonth > 10000 && kmMonth <= 20000)
            {

                if (season == "Spring" || season == "Autumn")
                {
                    salary = 1.45;
                }
                else if (season == "Summer")
                {
                    salary = 1.45;
                }
                else if (season == "Winter")
                {
                    salary = 1.45;
                }

            }
            double totalSalary = kmMonth * salary * 4;
            double tax = 0.1;
            Console.WriteLine($"{(totalSalary-totalSalary*tax):F2}");
        }
    }
}
