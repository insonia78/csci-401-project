using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community
{
    class Hero : Character
    {
        // fields
        private Boolean male;                       // true for male and false for female.
        private String profileImage;                // image of the hero for the UI.
        
        // base stats for experience.
        private int baseExperience = 0;             // experience earned.
        private int baseMaxExperience = 100;        // experience needed to earn a new level.
        private double baseExperienceRate = 10.0;   // rate at which the hero earns experience.

        // current stats.
        private int currentExperience;              // current amount of experience.

        // TODO: 
        // fields, objects and classes to be created.
        // image variable
        // helmet
        // chest
        // legs
        // arms

        public Hero()
        {
            base.Init();
            Init();
        }

        public void Init()
        {
            male = false;
            profileImage = "no image chosen.png";

            currentExperience = baseExperience;
        }

        /**********************************************************************
         * Get and sets for the variables.
         **********************************************************************
         */
        // get and set for the male variable.
        public Boolean Male
        {
            get
            {
                return male;
            }
            set
            {
                male = value;
            }
        }

        // get and set for the profileImage variable.
        public String ProfileImage
        {
            get
            {
                return profileImage;
            }
            set
            {
                profileImage = value;
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

        // Prints out the variables for testing purposes.
        public String toString()
        {
            String text;

            text = (base.toString() + 
                "\n\nThis hero is male: " + male +
                "\nProfile image: " + profileImage +
                "\n\nExperience Stats:\n\n" +
                "Experience at the beginning of this level: " + baseExperience + "\n" +
                "Experience needed to level: " + baseMaxExperience + "\n" +
                "Current Experience: " + currentExperience);

            return text;
        }
    }
}