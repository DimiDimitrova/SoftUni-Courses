using System;

namespace EvenPowersOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = int.Parse(Console.ReadLine());
            //int n = 1;
            //for (int i = 0; i <= number; i += 2)
            //{
            //    Console.WriteLine(n);
            //    n = n * 2 * 2;
            //}
            //
            //Console.WriteLine("--------------");

            int nn = int.Parse(Console.ReadLine());
            for (int i = 0; i <= nn; i += 2)
            {
                double result = Math.Pow(2, i);
                Console.WriteLine(result);
            }
        }
    }
}
