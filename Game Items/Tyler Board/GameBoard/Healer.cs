﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBoard
{
    class Healer : Hero
    {
        public Healer (int movespeed)
        {
            hp = 10; 
            speed = movespeed;
        }
    }
}