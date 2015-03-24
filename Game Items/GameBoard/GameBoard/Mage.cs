using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBoard
{
    class Mage : Enemy
    {
        public Mage (int row,int col):base(10,row,col)
        {
           
            hp = 10; 
          //  speed = movespeed;
        }
    }
}
