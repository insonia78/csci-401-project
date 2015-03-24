using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBoard
{
    /*
     * Represents an individual space in a board of tiles, able to contain characters, has terrain values, contains a terrain object.
     */
    class Tile
    {
        //instance variables
        private bool canMoveTo; //is only true when calculating/displaying a player's move options
        private readonly bool isSolid;
        private readonly int terrainType;  //0 for field, 1 for mountain, 2 for water, ...
        private readonly int speedToMoveThrough;
        private readonly Terrain tileTerrain_obj;
        private Character aCharacter;

        //accessors/mutators

        public bool isUnpassable
        {
            get 
            {
                return isSolid;
            }
            set { }
        }

        public Terrain terrainImage
        {
            get
            {
                return tileTerrain_obj;
            }
            set { }
        }

        public int tileTerrain
        {
            get
            {
                return terrainType;
            }
            set { }
        }

        public int requiredMoveSpeed
        {
            get
            {
                return speedToMoveThrough;
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
        public bool isMoveOption
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
            speedToMoveThrough = 1;
            aCharacter = null;
            isSolid = false;
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
            tileTerrain_obj = new Terrain(terrain);
            aCharacter = null;

            if (terrain == 1 || terrain == 2) //will probably be changed later depending on actual tiles/tile file format system used later.
                isSolid = true;
            else
                isSolid = false;

            if (terrain == 3) //will probably be changed later
                speedToMoveThrough = 2;
            else
                speedToMoveThrough = 1;
        }

        /*
         * Checks if the tile contains a character by seeing if aCharacter is null or not.
         * 
         * returns true if there's a character in the tile, false if it's null.
         */
        public bool containsCharacter()
        {
            if (aCharacter == null)
                return false;
            else
                return true;
        }

    }
}
