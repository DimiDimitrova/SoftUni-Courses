using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            int fine = 0;
            for (int i = 1; i <= n; i++)
            {
                string nameWeb = Console.ReadLine();
                switch (nameWeb)
                {
                    case "Facebook":
                        fine = 150;
                        salary -= fine;
                        break;
                    case "Instagram":
                        fine = 100;
                        salary -= fine;
                        break;
                    case "Reddit":
                        fine = 50;
                        salary -= fine;
                        break;

                }
            }
            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary);
            }
        }
    }
}
