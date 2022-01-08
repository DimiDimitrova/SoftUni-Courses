using System;

namespace RecursiveFactorial
{
    class Program
    {

        static long Factorial(int num)
        {
            if (num==0)
            {
                return 1;
            }
            else
            {
                return num * Factorial(num - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input your number: ");
            
            int num = int.Parse(Console.ReadLine());
            long factorial = Factorial(num);
            Console.WriteLine(factorial);
        }
    }
}
