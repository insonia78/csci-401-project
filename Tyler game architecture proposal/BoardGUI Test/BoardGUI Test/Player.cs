using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBoard
{
    class Player : Character
    {
        public Player()
        {
            hp = 10;

        }

        public Player (int movespeed)
        {
            hp = 10; 
            speed = movespeed;
        }
    }
}
