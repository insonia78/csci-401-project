using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBoard
{
    /*
     * Represents an individual space in a board of tiles, able to contain characters, has terrain values.
     */
    class Tile
    {
        //instance variables
        private Boolean canMoveTo; //is only true when calculating/displaying a player's move options
        private readonly int terrainType;  //0 for field, 1 for mountain, 2 for water, ...
        private Character aCharacter;

        //accessors/mutators
        public int tileTerrain
        {
            get
            {
                return terrainType;
            }
            set { }
        }
        public Character tileCharacter
        {
            get
            {
                return aCharacter;
            }
            set
            {
                aCharacter = value;
            }
        }
        public Boolean isMoveOption
        {
            get
            {
                return canMoveTo;
            }
            set
            {
                canMoveTo = value;
            }
        }
        
        //Constructors
        /*
         * Makes a "blank" tile, default is grass, no character on it. Initializes canMoveTo  to false, is only true when calculating/displaying a player's move options
         * Does not add a character, sets to null
         */
        public Tile()
        {
            canMoveTo = false;
            terrainType = 0;
            aCharacter = null;
        }

        /*
         * Makes a tile with the terrain that corresponds to the input type.  Initializes canMoveTo  to false, is only true when calculating/displaying a player's move options
         * Does not add a character, sets to null
         * 
         * int terrain = the number corresponding to the desired type of terrain. 0 for grass, 1 for mountain, 2 for water, 3 for swamp.
         */
        public Tile(int terrain)
        {
            canMoveTo = false;
            terrainType = terrain;
            aCharacter = null;
        }

        /*
         * Checks if the tile contains a character by seeing if aCharacter is null or not.
         * 
         * returns true if there's a character in the tile, false if it's null.
         */
        public Boolean containsCharacter()
        {
            if (aCharacter == null)
                return false;
            else
                return true;
        }

    }
}
