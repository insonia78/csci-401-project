﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBoard
{
    class Enemy_Warrior : Enemy
    {
        public Enemy_Warrior (int movespeed)
        {
            hp = 10; 
            speed = movespeed;
        }
    }
}
