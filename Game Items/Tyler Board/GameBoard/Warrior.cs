﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBoard
{
    class Warrior : Hero
    {
        public Warrior (int movespeed)
        {
            hp = 5; 
            speed = movespeed;
        }
    }
}
