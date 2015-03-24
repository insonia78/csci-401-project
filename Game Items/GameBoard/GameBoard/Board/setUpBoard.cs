﻿using System;
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
        Tile[,] terrain = new Tile[boardRow, boardCol];
        
        
        public void setUpBoard()
        {
            
            for (int r = 0; r < boardRow; r++)
            {
                for (int c = 0; c < boardCol; c++)
                {
                   
                    switch (table[r, c])
                    {
                         case 1:
                             Image img = new Image();
                            BitmapImage myBitmapImage = new BitmapImage();

// BitmapImage.UriSource must be in a BeginInit/EndInit block
                            ImageBrush myBrush = new ImageBrush();
                            myBrush.ImageSource =
                            new BitmapImage(new Uri("hero.png", UriKind.Relative));
                            
                            
                            terrain[r, c] = new Mage();
                            terrain[r, c].Background = terrain[r, c].Image;
                            
                            
                            terrain[r, c].BorderThickness = new Thickness(1);
                           

                            break;
                        default:
                                   terrain[r, c] = new Tile();
                                   terrain[r, c].Background = grass;
                                   terrain[r, c].BorderThickness = new Thickness();
                                   
                                   
                                   break;

                    }
                    terrain[r, c].Row = r;
                    terrain[r, c].Col = c;
                    terrain[r, c].Click += new RoutedEventHandler(moveCharacter);
                    Board.Children.Add(terrain[r, c]);
                    
                    
                }

            }
        }
    }
}
        
    

