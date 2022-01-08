using System;

namespace FindingAllPathsInLabyrinth
{
    class Program
    {
        static void Main(string[] args)
        {
            Maze maze = new Maze();
            maze.ReadFromFile("TextFile.txt");
        }

    }

}
