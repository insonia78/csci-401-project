using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBoard
{
    class Enemy : Character
    {
        private int health;

        public Enemy()
        {
            hp = 1;
        }

        public Enemy (int movespeed)
        {
            hp = 1; 
            speed = movespeed;
        }
    }
}
