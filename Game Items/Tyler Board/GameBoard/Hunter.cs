using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBoard
{
    class Hunter : Hero
    {
        public Hunter (int movespeed)
        {
            hp = 10; 
            speed = movespeed;
        }
    }
}
