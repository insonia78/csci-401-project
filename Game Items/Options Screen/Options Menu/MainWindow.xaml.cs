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

namespace OptionsMenu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Bgm.Play();
        }

        private void Title_Bar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Title_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void Sound_Off_Button_Click(object sender, RoutedEventArgs e)
        {
            if(!Bgm.IsMuted)
            {
                Bgm.IsMuted = true;
                Style red = Sound_On_Button.Style;
                Style black = Sound_Off_Button.Style;

                if(Sound_On_Button.Style == red)
                {
                    Sound_Off_Button.Style = red;
                    Sound_On_Button.Style = black;
                }
            }
        }

        private void Sound_On_Button_Click(object sender, RoutedEventArgs e)
        {
            if(Bgm.IsMuted)
            {
                Bgm.IsMuted = false;
                Style red = Sound_Off_Button.Style;
                Style black = Sound_On_Button.Style;

                if (Sound_Off_Button.Style == red)
                {
                    Sound_On_Button.Style = red;
                    Sound_Off_Button.Style = black;
                }
            }
        }

        private void Return_Main_Menu_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
