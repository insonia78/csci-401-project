using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBoard
{
    class Enemy_Healer : Enemy
    {
        public Enemy_Healer (int movespeed)
        {
            hp = 10; 
            speed = movespeed;
        }
    }
}
