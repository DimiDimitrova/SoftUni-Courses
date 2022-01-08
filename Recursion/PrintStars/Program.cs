using System;

namespace PrintStars
{
    class Program
    {

        static void Print(int index)
        {
            if (index == 0)
            {
                return;
            }
            else
            {
               
                Console.WriteLine(new string('*',index));

                Print(index - 1);

                Console.WriteLine(new string('*',index));
            }
        }
        static void Main(string[] args)
        {
            Print(9);
        }
    }
}
