using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community
{
    class CampusPolice : Enemy
    {
        public CampusPolice()
        {
            Init();
        }

        // Second constructor.
        public CampusPolice(int r, int c, int charSpeed)
        {
            //Init();
            Row = r;
            Col = c;
            CurrentSpeed = charSpeed;
        }

        private void Init()
        {
            /******************************************************************
             * stat progression unique to this job role.
             * ****************************************************************
             */
            JobRole = "Campus Police";

            HealthMulti = 3.00;
            EnergyMulti = 1.50;
            AttackMulti = 2.00;
            DefenseMulti = 3.00;
            SpeedMulti = 1;
            AgilityMulti = 1;
            AttackRangeMulti = 1.00;
            SpecialAttackMulti = 2.00;
            SpecialDefenseMulti = 2.00;

            ExperienceAmountMulti = 25.00;
            /******************************************************************
             * stats initialized after multipliers applied.
             * ****************************************************************
             */
            InstantiateLevel(1);
        }
    }
}