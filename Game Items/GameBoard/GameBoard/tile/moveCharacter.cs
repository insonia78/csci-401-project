using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBoard
{
    public partial class Tile
    {
        public void moveCharacter(int oldRow, int oldCol, int newRow, int newCol)
        {
            if (newRow >= 0 && newRow < numRows && newCol >= 0 && newCol < numCols && this.tileCharacter == null)
            {
                this.tileCharacter = this.tileCharacter;
                this.tileCharacter = null;
            }
        }
    }
}
