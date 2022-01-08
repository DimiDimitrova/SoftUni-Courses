using System;
using System.ComponentModel.DataAnnotations;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double evenSum = 0;
            double oddSum = 0;
            double eMin = 1000000000.0;
            double eMax = -1000000000.0;
            double oMin = 1000000000.0;
            double oMax = -1000000000.0;
            for (double i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += number;
                    if (number > eMax)
                    {
                       eMax = number;
                    }
                    if (number < eMin)
                    {
                        eMin = number;
                    }
                }
                else
                {
                    oddSum += number;
                    if (number > oMax)
                    {
                        oMax = number;
                    }
                    if (number < oMin)
                    {
                        oMin = number;
                    }
                }
            }
            Console.WriteLine($"OddSum={oddSum:F2},");
            if (oMin==1000000000.0)
            {
                Console.WriteLine("OddMin=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={oMin:F2},");

            }

            if (oMax==-1000000000.0)
            {
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMax={oMax:F2},");
            }
            Console.WriteLine($"EvenSum={evenSum:F2},");
            if (eMin==1000000000.0)
            {
                Console.WriteLine("EvenMin=No,");
            }
            else
            {
                Console.WriteLine($"EvenMin={eMin:F2},");
            }

            if (eMax==-1000000000.0)
            {
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMax={eMax:F2}");
            }
        }
    }
}
