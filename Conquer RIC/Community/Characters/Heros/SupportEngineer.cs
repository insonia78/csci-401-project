using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Community
{
    class SupportEngineer : Hero
    {
        public SupportEngineer(String nam, bool sex)
        {
            Init(nam, sex);
        }

        // Second constructor.
        public SupportEngineer(int r, int c, int charSpeed)
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
            JobRole = "Support Engineer";

            // Picture will be generated depending on the sex.
            if(Male)
            {
                PortraitFile = "MaleSupportEngineer.png";
                //CharacterPicture = " "; 
            }
            else
            {
                PortraitFile = "FemaleSupportEngineer.png";
                //CharacterPicture = " "; 
            }
            CharacterPortrait = Image.FromFile(PortraitFile);

            /******************************************************************
             * stat progression unique to this job role.
             * ****************************************************************
             */
            HealthMulti = 2.00;
            EnergyMulti = 3.00;
            AttackMulti = 1.25;
            DefenseMulti = 2.00;
            SpeedMulti = 1;
            AgilityMulti = 1;
            AttackRangeMulti = 3.00;
            SpecialAttackMulti = 2.00;
            SpecialDefenseMulti = 3.00;

            /******************************************************************
             * stats initialized after multipliers applied.
             * ****************************************************************
             */
            InstantiateLevel(1);
        }
    }
}