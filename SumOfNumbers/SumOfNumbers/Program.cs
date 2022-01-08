using System;

namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            //Четем входното число n. • 
            //Започваме първоначално със сума sum = 0. 
            //• Въртим цикъл от 1 до n. 
            //На всяка стъпка от цикъла четем число num и го добавяме към сумата sum. 
            //• Накрая отпечатваме получената сума sum

            Console.WriteLine("n = ");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the numbers :  ");
            var sum = 0;
            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sum = sum + num;

            }
            Console.WriteLine(sum);

        


            


        }
    }
}
