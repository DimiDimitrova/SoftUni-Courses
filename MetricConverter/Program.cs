using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string enter = Console.ReadLine();
            string exit = Console.ReadLine();
            if (enter == "m")
            {
                num = num / 1;
            }
            else if (enter == "mm")
            {
                num = num / 1000;
            }
            else if (enter == "cm")

            {
                num = num / 100;
            }
            if (exit == "m")
            {
                num = num * 1;
            }
            else if (exit == "mm")
            {
                num = num * 1000;
            }
            else if (exit == "cm")
            {
                num = num * 100;
            }

            Console.WriteLine($"{num:f3}");

            // double dist = double.Parse(Console.ReadLine());
            //  string inType = Console.ReadLine();
            //  string outType = Console.ReadLine();

            // DEFINITIONS
            //  double a = 0;
            //  double b = 0;

            //// if (inType == "m") a = 1;
            //if (inType == "mm") a = 1000;
            // if (inType == "cm") a = 100;


            // if (outType == "m") b = 1;
            //if (outType == "mm") b = 1000;
            //if (outType == "cm") b = 100;


            // OUTPUT
            //double result = dist / a * b;
            //Console.WriteLine($"{result:F3}");
        }
    }
}