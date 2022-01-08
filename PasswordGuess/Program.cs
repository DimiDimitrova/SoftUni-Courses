using System;

namespace PasswordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Please input your password:);
            
            string word = Console.ReadLine();
           
            
          
            if (word == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
