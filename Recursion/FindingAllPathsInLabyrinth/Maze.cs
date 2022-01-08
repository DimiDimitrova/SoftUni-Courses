using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FindingAllPathsInLabyrinth
{
    public class Maze
    {
        private char[,] maze;
        private int size;
        private Cell startCell = null;
        public void ReadFromFile(string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                this.size = int.Parse(reader.ReadLine());
                this.maze = new char[this.size, this.size];

                //Read the maze cells from the file
                for (int row = 0; row < this.size; row++)
                {
                    string line = reader.ReadLine();
                    for (int col = 0; col < this.size; col++)
                    {
                        this.maze[row, col] = line[col];
                        if (line[col] == '*')
                        {
                            this.startCell = new Cell(row, col, 0);
                        }
                    }
                }
            }
        }
    }
}
