using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBoard
{
    class Character
    {
        private int health;
        private int moveSpeed;
        private Boolean canMoveOnTurn = false;

        public int hp
        {
            get
            {
                return health;
            }
            set
            {
                health = value;
            }
        }

        public int speed
        {
            get
            {
                return moveSpeed;
            }
            set
            {
                moveSpeed = value;
            }
        }

        public Boolean hasMoved
        {
            get
            {
                return canMoveOnTurn;
            }
            set
            {
                canMoveOnTurn = value;
            }
        }

        public Character()
        {
            health = 10;
        }

    }
}
