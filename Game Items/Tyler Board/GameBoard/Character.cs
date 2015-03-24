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
        private int maxHealth;
        private int level;
        private int experience;
        private int attack;
        private int specialAttack;
        private int defense;
        private int specialDefense;
        private int moveSpeed;
        private Effect[] statEffects;
        private String name;
        private bool canMoveOnTurn = false;

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

        public bool hasMoved
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



        public void damage(int attack, int specialAttack, int attackPower)
        {

        }
    }
}
