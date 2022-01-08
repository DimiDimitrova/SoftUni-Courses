using System;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {

            //Да се напише програма, която чете n-на брой цели числа, подадени от потребителя,
            //и проверява дали сумата от числата на четни позиции!!! е равна на сумата на числата на нечетни позиции. 
            //При равенство да се отпечатат два реда: "Yes" и на нов ред "Sum = " + сумата;
            //иначе да се отпечата "No" и на нов ред "Diff = " + разликата.
            //Разликата се изчислява по абсолютна стойност.

            int n = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;
            for (int i = 0; i < n; i++)
            {
                int element = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += element;
                }
                else
                {
                    oddSum += element;
                }

            }
            if (evenSum==oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " +evenSum);
            }
            else
            {
                double diff = Math.Abs(oddSum - evenSum);
                Console.WriteLine("No");
                Console.WriteLine("Diff = "+diff);
            }





        }
    }
}
