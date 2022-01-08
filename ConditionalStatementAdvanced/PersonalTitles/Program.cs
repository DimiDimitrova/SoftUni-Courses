using System;

namespace PersonalInfo

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your age: ");
            double age=double.Parse(Console.ReadLine());
            Console.WriteLine("Your gender: M or F");
            char gender = char.Parse(Console.ReadLine());
            if (gender=='f')
            {
                if (age<16)
                {
                    Console.WriteLine("Miss");
                }
                else
                {
                    Console.WriteLine("Ms.");
                }

            }
            else
            {
                if (age<16)
                {
                    Console.WriteLine("Master");
                }
                else
                {
                    Console.WriteLine("Mr.");
                }
            }
        }
    }
}
