﻿using System;

namespace Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишете програма, която чете от конзолата име на човек и отпечатва "Hello, <name>!",
            //където<name> е въведеното име от конзолата.
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
