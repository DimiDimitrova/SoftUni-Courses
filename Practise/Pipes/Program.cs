using System;

namespace Pipes
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double pipe1 = p1 * h;
            double pipe2 = p2 * h;
            double sum = pipe1 + pipe2;
            
            if (sum < v)
            {
                double resultPipe1 = ((pipe1 / sum) * 100);
                double resultPipe2 = ((pipe2 / sum) * 100);
                Console.WriteLine($"The pool is {((sum / v)*100):F2}% full. Pipe 1: {resultPipe1:F2}%. Pipe 2: {resultPipe2:F2}%.");
            }
            else 
            {
                Console.WriteLine($"For {h} hours the pool overflows with {(sum-v):F2} liters.");
            }
        }
        
    }
}
