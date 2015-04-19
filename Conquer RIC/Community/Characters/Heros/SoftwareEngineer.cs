using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Community
{
    /**************************************************************************
         * TODO:
         * Job-specific abilities
         * ********************************************************************
         */
    class SoftwareEngineer : Hero
    {
        public SoftwareEngineer(String nam, bool sex)
        {
            Init(nam, sex);
        }

        // Second constructor.
        public SoftwareEngineer(int r, int c, int charSpeed)
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
            JobRole = "Software Engineer";

            // Picture will be generated depending on the sex.
            if(Male)
            {
                PortraitFile = "MaleSoftwareEngineer.png";
                //CharacterPicture = " "; 
            }
            else
            {
                PortraitFile = "FemaleSoftwareEngineer.png";
                //CharacterPicture = " "; 
            }
            CharacterPortrait = Image.FromFile(PortraitFile);

            /******************************************************************
             * stat progression unique to this job role.
             * ****************************************************************
             */
            HealthMulti = 3.00;
            EnergyMulti = 1.50;
            AttackMulti = 2.00;
            DefenseMulti = 3.00;
            SpeedMulti = 1;
            AgilityMulti = 1;
            AttackRangeMulti = 1.00;
            SpecialAttackMulti = 2.00;
            SpecialDefenseMulti = 2.00;

            /******************************************************************
             * stats initialized after multipliers applied.
             * ****************************************************************
             */
            InstantiateLevel(1);
        }
    }
}