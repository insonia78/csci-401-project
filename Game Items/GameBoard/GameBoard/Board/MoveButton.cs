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
        private void Move_Click(object sender, RoutedEventArgs e)
        {
            
            terrain[secondRow, secondCol].Background = terrain[firstRow, firstCol].Image;
            terrain[firstRow, firstCol].Background = grass;
        }
    }
}
