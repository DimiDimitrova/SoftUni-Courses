using System;

namespace EvenPowersOf2
{
    class Program
    {
        static void Main(string[] args)
        {
         

            int nn = int.Parse(Console.ReadLine());
            for (int i = 0; i <= nn; i += 2)
            {
                double result = Math.Pow(2, i);
                Console.WriteLine(result);
            }
        }
    }
}
