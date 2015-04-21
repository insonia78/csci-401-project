using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Collections;

namespace Community
{
    /**************************************************************************
     * The heros contrast the enemy classes. Heros will be able to gain
     * experience until they hit the max experience they can earn for their 
     * current level and then they will be able to level up. Resetting their
     * max requirement of expereince to level up. For each level increase, the
     * difference from the max experience and min experience will be greater than 
     * the previous level.
     * The hero character will also be able to wear equipment that affects 
     * their stats for the better or worse. They will be able to place these
     * equipments are parts of their bodies and can interchange these items
     * during the Player's time in the world map.
     * The base and max experience do not change, after leveling up 
     * they 
     * ************************************************************************
     */
    /**********************************************************************
     * TODO:
     * helmet
     * chest
     * legs
     * arms
     * experience gain system.
     * ********************************************************************
     */
    public class Hero : Character
    {
        // fields
        private String portraitFile;
        
        // base stats for experience.
        private int baseExperience = 0;             // experience earned.
        private int baseMaxExperience = 100;        // experience needed to earn a new level.
        private double baseExperienceRate = 10.0;   // rate at which the hero earns experience.

        // current stats.
        private int currentExperience;              // current amount of experience.

        // default constructor.
        public Hero()
        {
            Init();
        }

        // Second constructor.
        public Hero(int r, int c) : base(r, c)
        {
            Init();
            base.Row = r;
            base.Col = c;
        }

        public void Init()
        {
            portraitFile = "hero_portrait.png";
            pictureFile = "hero.png";
            characterPicture = new BitmapImage(new Uri(pictureFile, UriKind.Relative));
            currentExperience = baseExperience;

            statEffects = new List<Effect>();
        }

        // get and set for the portraitFile variable.
        public String PortraitFile
        {
            get
            {
                return portraitFile;
            }
            set 
            {
                portraitFile = value;
            }
        }

        // get and set for the baseExperience variable.
        public int BaseExperience
        {
            get
            {
                return baseExperience;
            }
            set
            {
                baseExperience = value;
            }
        }

        // get and set for the baseMaxExperience variable.
        public int BaseMaxExperience
        {
            get
            {
                return baseMaxExperience;
            }
            set
            {
                baseMaxExperience = value;
            }
        }

        // get and set for the baseMaxExperienceRate variable.
        public double BaseExperienceRate
        {
            get
            {
                return baseExperienceRate;
            }
            set
            {
                baseExperienceRate = value;
            }
        }

        // get and set for the currentExperience variable.
        public int CurrentExperience
        {
            get
            {
                return currentExperience;
            }
            set
            {
                currentExperience = value;
            }
        }

        public override int[,] Ability1(int[,] boardspaces)
        {
            //TEST ATTACK ONLY, will probably be removed later
            //up
            this.selectedAttackPower = 1.0;

            if (row - 1 >= 0 && boardspaces[row - 1, col] == 0)
            {
                boardspaces[row - 1, col] = 1;
                if (row - 2 >= 0 && boardspaces[row - 2, col] == 0)
                {
                    boardspaces[row - 2, col] = 1;
                    if (col - 1 >= 0 && boardspaces[row - 2, col - 1] == 0)
                        boardspaces[row - 2, col - 1] = 1;
                    if (col + 1 >= 0 && boardspaces[row - 2, col + 1] == 0)
                        boardspaces[row - 2, col + 1] = 1;
                }
            }
            //down
            if (row + 1 < boardspaces.GetLength(0) && boardspaces[row + 1, col] == 0)
            {
                boardspaces[row + 1, col] = 2;
                if (row + 2 < boardspaces.GetLength(0) && boardspaces[row + 2, col] == 0)
                {
                    boardspaces[row + 2, col] = 2;
                    if (col - 1 >= 0 && boardspaces[row + 2, col - 1] == 0)
                        boardspaces[row + 2, col - 1] = 2;
                    if (col + 1 < boardspaces.GetLength(1) && boardspaces[row + 2, col + 1] == 0)
                        boardspaces[row + 2, col + 1] = 2;
                }
            }
            //left
            if (col - 1 >= 0 && boardspaces[row, col - 1] == 0)
            {
                boardspaces[row, col - 1] = 3;
                if (col - 2 >= 0 && boardspaces[row, col - 2] == 0)
                {
                    boardspaces[row, col - 2] = 3;
                    if (row - 1 >= 0 && boardspaces[row - 1, col - 2] == 0)
                        boardspaces[row - 1, col - 2] = 3;
                    if (row + 1 < boardspaces.GetLength(1) && boardspaces[row + 1, col - 2] == 0)
                        boardspaces[row + 1, col - 2] = 3;
                }
            }
            //right
            if (col + 1 < boardspaces.GetLength(1) && boardspaces[row, col + 1] == 0)
            {
                boardspaces[row, col + 1] = 4;
                if (col + 2 < boardspaces.GetLength(1) && boardspaces[row, col + 2] == 0)
                {
                    boardspaces[row, col + 2] = 4;
                    if (row - 1 >= 0 && boardspaces[row - 1, col + 2] == 0)
                        boardspaces[row - 1, col + 2] = 4;
                    if (row + 1 < boardspaces.GetLength(0) && boardspaces[row + 1, col + 2] == 0)
                        boardspaces[row + 1, col + 2] = 4;
                }
            }
            return boardspaces;
        }

        /**********************************************************************
         * Other methods.
         * ********************************************************************
         */
        // Prints out the variables for testing purposes.
        public String ToString()
        {
            String text;

            text = (
                base.ToString() +
                "\nProfile image: " + portraitFile +
                "\n\nExperience Stats:\n\n" +
                "Experience at the beginning of this level: " + baseExperience + "\n" +
                "Experience needed to level: " + baseMaxExperience + "\n" +
                "Current Experience: " + currentExperience);

            return text;
        }
    }
}