using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBoard
{
    class Mage : Player
    {
        public Mage (int movespeed)
        {
            hp = 10; 
            speed = movespeed;
        }
    }
}
