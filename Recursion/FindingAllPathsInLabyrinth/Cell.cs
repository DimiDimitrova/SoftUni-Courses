using System;
using System.Collections.Generic;
using System.Text;

namespace FindingAllPathsInLabyrinth
{

        class Cell
        {
            // initial cell, from wich begins the searching of the path
            public int Row { get; set; }
            public int Column { get; set; }
            public int Distance { get; set; }
            public Cell(int row, int column, int distance)
            {
                this.Row = row;
                this.Column = column;
                this.Distance = distance;
            }
        }
    

}
