using System;

namespace VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
           // Да се напише програма, която чете текст(стринг), въведен от потребителя,
            //и изчислява и отпечатва сумата от стойностите на гласните букви според таблицата по - долу:
            string text = Console.ReadLine();
            //a e   i o   u
            //1 2   3 4   5
            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];
                if (letter=='a')
                {
                    sum +=1;
                }
                else if (letter=='e')
                {
                    sum += 2;
                }
                else if (letter=='i')
                {
                    sum += 3;
                }
                else if (letter=='o')
                {
                    sum += 4;
                }
                else if (letter=='u')
                {
                    sum += 5;
                }
            }
            Console.WriteLine(sum);


        }
    }
}
