using System;

namespace Recursion
{
    class Program
    {

        static int SumWithRecursion(int[] arr, int index)
        {
            if (index == arr.Length)
            {
                return 0;
            }
            return arr[index] + SumWithRecursion(arr, index + 1);
        }
        static void Main(string[] args)
        {
            var numbers = new[] { 1, 2, 3, 4, 5 };

            var sum = SumWithRecursion(numbers, 0);

            Console.WriteLine(sum);
        }
    }
}
