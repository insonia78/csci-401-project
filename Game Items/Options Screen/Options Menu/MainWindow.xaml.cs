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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //System.Media.SoundPlayer bgm = new System.Media.SoundPlayer(@"C:\Users\Cedric\Google Drive\School Work\Programming\Software Engineering\ConquerRIC\Options\Options Screen\Options Menu\Oranges Kiss.wav");
            System.Media.SoundPlayer bgm = new System.Media.SoundPlayer(@"C:\Users\Cedric\Google Drive\School Work\Programming\Software Engineering\ConquerRIC\Options\Options Screen\Options Menu\Ice Wizard Boss - Industrial Castle Boss.wav");

            bgm.PlayLooping();
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
            //System.Media.SoundPlayer bgm = new System.Media.SoundPlayer(@"C:\Users\Cedric\Google Drive\School Work\Programming\Software Engineering\ConquerRIC\Options\Options Screen\Options Menu\Oranges Kiss.wav");
            System.Media.SoundPlayer bgm = new System.Media.SoundPlayer(@"C:\Users\Cedric\Google Drive\School Work\Programming\Software Engineering\ConquerRIC\Options\Options Screen\Options Menu\Ice Wizard Boss - Industrial Castle Boss.wav");
            bgm.Stop();
        }

        private void Sound_On_Button_Click(object sender, RoutedEventArgs e)
        {
            //System.Media.SoundPlayer bgm = new System.Media.SoundPlayer(@"C:\Users\Cedric\Google Drive\School Work\Programming\Software Engineering\ConquerRIC\Options\Options Screen\Options Menu\Oranges Kiss.wav");
            System.Media.SoundPlayer bgm = new System.Media.SoundPlayer(@"C:\Users\Cedric\Google Drive\School Work\Programming\Software Engineering\ConquerRIC\Options\Options Screen\Options Menu\Ice Wizard Boss - Industrial Castle Boss.wav");
            bgm.PlayLooping();
        }

        private void Return_Main_Menu_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
