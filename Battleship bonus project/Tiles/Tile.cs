﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship_bonus_project.Tiles
{
    internal class Tile
    {
        public bool hit = false;
        public string tile;

        public virtual void displayTile()
        {
            Console.Write(tile);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    
}
