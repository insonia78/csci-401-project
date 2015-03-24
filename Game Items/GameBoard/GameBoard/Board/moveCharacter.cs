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
    partial class MainWindow
    {
         int row;
         int col;
        private void moveCharacter(object sender, RoutedEventArgs e)
        {
            try
            {
                row = (sender as Tile).Row;
                col = (sender as Tile).Col;
            }
            catch
            {

            }
                    speed = terrain[row, col].Speed;
                    moveOptions(); 
                    if(terrain[row,col].GetType() == typeof(GameBoard.Character)) 
                    {
                                                
                    }
                }
        }
    }

