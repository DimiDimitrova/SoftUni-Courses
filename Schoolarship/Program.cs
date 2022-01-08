using System;
using System.Security.Cryptography.X509Certificates;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double success = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());
            double socialSch = Math.Floor(minSalary * 0.35);
            double successSch = Math.Floor(success * 0.25);
            double a = 0.0;
            if (success < 4.50)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            if (success >= 4.50 && success < 5.50)
            {
                if (income>=minSalary)
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
                else
                {
                    Console.WriteLine($"You get a Social scholarship {socialSch} BGN");
                }

            }
            if (success>=5.50)
            {
                if (income<minSalary)
                {
                    a = Math.Max(socialSch, successSch);
                }
                if (a==socialSch)
                {
                    Console.WriteLine($"You get a Social scholarship {socialSch} BGN");
                }
                else if (a==successSch)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {successSch} BGN");
                    
                }
            }

            //Учениците могат да кандидатстват за социална стипендия или за стипендия за отличен успех. 
            //Изискване за социална стипендия - доход на член от семейството по-малък от минималната работна заплата и успех над 4.5. 
            //Размер на социалната стипендия - 35% от минималната работна заплата.
            //Изискване за стипендия за отличен успех - успех над 5.5, включително. 
            //Размер на стипендията за отличен успех - успехът на ученика, умножен по коефициент 25.
           // Напишете програма, която при въведени доход, успех и минимална работна заплата,
            //дава информация дали ученик има право да получава стипендия, и стойността на стипендията, която е по-висока за него.

        }
    }
}



