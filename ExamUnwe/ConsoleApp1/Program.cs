using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[]{ "happy", "Be" };
            for (int i = arr.Length; i-- > 0;)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
