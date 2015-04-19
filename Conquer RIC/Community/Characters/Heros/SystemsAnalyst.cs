using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Community
{
    class SystemsAnalyst : Hero
    {
        public SystemsAnalyst(String nam, bool sex)
        {
            Init(nam, sex);
        }

        // Second constructor.
        public SystemsAnalyst(int r, int c, int charSpeed)
        {
            //Init();
            Row = r;
            Col = c;
            CurrentSpeed = charSpeed;
        }

        private void Init(String n, bool s)
        {
            Name = n;
            Male = s;
            JobRole = "Systems Analyst";

            // Picture will be generated depending on the sex.
            if(Male)
            {
                PortraitFile = "MaleSystemsAnalyst.png";
                //CharacterPicture = " "; 
            }
            else
            {
                PortraitFile = "FemaleSystemsAnalyst.png";
                //CharacterPicture = " "; 
            }
            CharacterPortrait = Image.FromFile(PortraitFile);

            /******************************************************************
             * stat progression unique to this job role.
             * ****************************************************************
             */
            HealthMulti = 1.75;
            EnergyMulti = 3.00;
            AttackMulti = 1.25;
            DefenseMulti = 1.25;
            SpeedMulti = 2;
            AgilityMulti = 2;
            AttackRangeMulti = 2.00;
            SpecialAttackMulti = 3.00;
            SpecialDefenseMulti = 2.00;

            /******************************************************************
             * stats initialized after multipliers applied.
             * ****************************************************************
             */
            InstantiateLevel(1);
        }
    }
}