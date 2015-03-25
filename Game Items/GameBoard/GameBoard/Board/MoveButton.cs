using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace GameBoard
{
    public partial class MainWindow
    {
        Tile[,] swampTile = new Tile[boardRow, boardCol];
        Brush colorTemp;
        Brush imageTemp;
        
        private void Move_Click(object sender, RoutedEventArgs e)
        {
            
            status.Text = null;
            
            this.swampTile[firstRow,firstCol] = this.terrain[firstRow, firstCol];
           
            status.Text += "swampTile first " + this.swampTile[firstRow, firstCol];
            this.swampTile[secondRow,secondCol] = this.terrain[secondRow, secondCol];
            status.Text += "\nswampTile second " + this.swampTile[secondRow, secondCol];
            imageTemp = this.terrain[firstRow, firstCol].Background;
            colorTemp = this.terrain[secondRow, secondCol].Background;
            this.terrain[firstRow, firstCol].Background = null;
            this.terrain[secondRow, secondCol].Background = null;
            //status.Text += "first  b " + this.imageTemp.ToString() + "\n";
           // this.swampTile[secondRow, secondCol].Background = this.terrain[secondRow, secondCol].Background;
           // this.terrain[secondRow, secondCol] = null;
            //this.terrain[firstRow, firstCol] = null;
            this.terrain[secondRow, secondCol].Background = imageTemp;
            this.terrain[secondRow, secondCol] = swampTile[firstRow, firstCol];
            status.Text += "\nterain second  " + this.terrain[secondRow, secondCol].ToString() + "\n";
            
            //this.terrain[firstRow, firstCol] = null;
            //this.terrain[firstRow, firstCol] = this.swampTile[secondRow, secondCol];
            //this.terrain[firstRow, firstCol].Background = null; //swampTile[secondRow, secondCol].Background;
            //this.swampTile[firstRow, firstCol] = null;
            //this.swampTile[secondRow, secondCol] = null;             
           
          //  this.terrain[secondRow, secondCol].Click += new RoutedEventHandler(moveCharacter);
          //  this.terrain[firstRow, firstCol].Click += new RoutedEventHandler(moveCharacter);

            
                       
                        
            
 
           // terrain[firstRow, firstCol].Background = grass; 
            //this.terrain[secondRow, secondCol].Background = imageTemp;
            //this.terrain[firstRow, firstCol].Background = colorTemp;
        //   status.Text += "\nfirst  " + this.terrain[firstRow, firstCol].ToString() + "\n";
       //    status.Text += "\nsecond  " + this.terrain[secondRow, secondCol].ToString() + "\n";
          //  status.Text += "first  b " + this.terrain[firstRow, firstCol].Background.ToString() + "\n";
          //  status.Text += "second b " + this.terrain[secondRow, secondCol].Background.ToString() + "\n";

            colorTemp = null;
            imageTemp = null;
            
            Move.IsEnabled = false;
        }
        
    }
}
