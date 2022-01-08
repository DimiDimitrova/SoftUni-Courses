using System;

namespace Vector
{
    class Program
    {
        static void Generate(int index, int[] vector)
        {
            if (index == vector.Length)
            {
                Console.WriteLine(string.Join(" ",vector));
            }
            else
            {
                for (int i = 0; i <= 1; i++)
                {
                     vector[index] = i;
                    Generate(index + 1, vector);
                }
            }
        }
        static void Main(string[] args)
        {
            int n = 8;
            int[] vector = new int[n];
            Generate(0, vector);
        }
    }
}
