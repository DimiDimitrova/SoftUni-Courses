using System;

namespace LeftOrRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            // Да се напише програма, която чете 2 * n - на брой цели числа, подадени от потребителя,
            //и проверява дали сумата на първите n числа(лява сума) е равна на сумата на вторите n числа(дясна сума).
            //При равенство печата " Yes, sum = " + сумата; иначе печата " No, diff = " + разликата.
            //Разликата се изчислява като положително число(по абсолютна стойност).

            for (int i = 0; i < num; i++)
            {
                leftSum = leftSum + int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < num; i++)
            {
                rightSum = rightSum + int.Parse(Console.ReadLine());

            }

            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = " + leftSum);
            }
            else
            {
                double diff = Math.Abs(rightSum - leftSum);
                Console.WriteLine("No, diff = " + diff);
            }
        }
    }
}
