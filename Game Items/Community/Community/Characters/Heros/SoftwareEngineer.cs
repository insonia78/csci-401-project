using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community
{
    class SoftwareEngineer : Hero
    {
        public SoftwareEngineer()
        {
            base.Init();
            Init();
        }

        private void Init()
        {
            /*
             * TODO:
             * initialize with custom stats,
             * pictures, and gender.
             */
            JobRole = "Software Engineer";
            AttackMulti = 1.75;
            BaseAttack = (int)(BaseAttack + (BaseAttack * AttackMulti));
        }
    }
}