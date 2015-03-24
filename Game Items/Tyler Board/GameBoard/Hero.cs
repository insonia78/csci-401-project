using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBoard
{
    class Hero : Character
    {
        public Hero()
        {
            hp = 10;

        }

        public Hero (int movespeed)
        {
            hp = 10; 
            speed = movespeed;
        }
    }
}
