using System;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameArchitect = Console.ReadLine();
            int numberOfProjects = int.Parse(Console.ReadLine());
            int hours = numberOfProjects * 3;
            Console.WriteLine($"The architect {nameArchitect} will need {hours} hours to complete {numberOfProjects} project/s.");

        }
    }
}
