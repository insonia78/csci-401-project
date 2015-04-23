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
using Community;

namespace CharacterCreation
{
    /// <summary>
    /// Interaction logic for CharacterCreationPage.xaml
    /// </summary>
    public partial class CharacterCreationPage : Page
    {
        // fields
        Window main;    // reference titleScreen components.
        MediaElement music; // to be passed to the world map.


        int[] heroType = new int[5];
        String[] name_female = new String[20] { "Sally", "Sammy", "Erica", "Amanda", "Caitlyn", "Sandy", 
                                                "Ashley", "Serena", "Catherine", "Gabby", "Angie", "Lori", 
                                                "Anna", "Stephanie", "Rachel", "Monica", "Nina", "Rose", 
                                                "Emily", "LaraCroft" };
        bool[] gender = new bool[5];
        String[] name_male = new String[20] { "Evan", "Christian", "Joseph", "Bob", "Dylan", "Aaron", "Bill", 
                                              "Chandler", "Joey", "Mark", "Tyler", "Malane", "Thomas", "Cedric", 
                                              "William", "Devin", "Randy", "Travis", "Leon", "MasterChief" };
        String[] hero_name = new String[5];
        String[] hero_type = new String[5];

        string name, name2;

        public bool hero1WasClicked = false;
        public bool hero2WasClicked = false;
        public bool hero3WasClicked = false;
        public bool hero4WasClicked = false;
        public bool hero5WasClicked = false;

        public CharacterCreationPage(Window title, MediaElement bgM)
        {
            main = title;
            music = bgM;
            InitializeComponent();
        }

        //allows the array to be accessed in individual heros class
        public String[] heroTypeArray
        {
            get
            {
                return hero_type;
            }
            set
            {
                hero_type = value;
            }
        }

        //allows the array to be accessed in individual heros class
        public String[] heroNameArray
        {
            get
            {
                return hero_name;
            }
            set
            {
                hero_name = value;
            }
        }

        //allows the array to be accessed in individual heros class
        public bool[] heroGenderArray
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        private void EnterLeaveGame()
        {
            BlackOut.Visibility = Visibility.Visible;
            LeaveGameGrid.Visibility = Visibility.Visible;
            //bgm.Volume = 0.2;
        }

        private void CustomAppear()
        {
            BlackOut.Visibility = Visibility.Visible;
            CustomizeWindowGrid.Visibility = Visibility.Visible;
        }

        /// <the Boolean Gender() creates a random number generator that determines if the  heros are male or female. it puts them into the array
        public void Gender()
        {
            Random random = new Random();
            int num;    // represents job role
            int numba;  // represents gender

            for (int i = 0; i < 5; i++)
            {
                num = random.Next(0, 5);
                heroType[i] = num;

                numba = random.Next(1, 3);

                if (numba == 1)
                {
                    gender[i] = true;
                    ///<here is where I am having issues with the picture. I tried to save it to resources like a few pages suggested.
                    ///it saved it to a new folder, not the resources section I need and i cant get it to go to the right resources.
                    ///<Hero1.Background = Properties.Resources.deadladybug2.jpg;
                }
                else
                {
                    gender[i] = false;
                }
            }
        }

        //sets the hero classes for the randomize button
        public void Herocharacter()
        {
            Random random = new Random();

            int num;
            int nums;

            int i = 0;
            num = random.Next(0, 5);
            heroType[i] = num;

            nums = random.Next(0, 5);

            if (nums == 0)
            {
                hero_type[i] = "Warrior";
                hero_type[i + 1] = "Healer";
                hero_type[i + 2] = "Mage";
                hero_type[i + 3] = "Hunter";
                hero_type[i + 4] = "Rogue";
            }
            else if (nums == 1)
            {
                hero_type[i] = "Rogue";
                hero_type[i + 1] = "Warrior";
                hero_type[i + 2] = "Healer";
                hero_type[i + 3] = "Mage";
                hero_type[i + 4] = "Hunter";
            }
            else if (nums == 2)
            {
                hero_type[i] = "Hunter";
                hero_type[i + 1] = "Rogue";
                hero_type[i + 2] = "Warrior";
                hero_type[i + 3] = "Healer";
                hero_type[i + 4] = "Mage";
            }
            else if (nums == 3)
            {
                hero_type[i] = "Mage";
                hero_type[i + 1] = "Hunter";
                hero_type[i + 2] = "Rogue";
                hero_type[i + 3] = "Warrior";
                hero_type[i + 4] = "Healer";
            }
            else
            {
                hero_type[i] = "Healer";
                hero_type[i + 1] = "Mage";
                hero_type[i + 2] = "Hunter";
                hero_type[i + 3] = "Rogue";
                hero_type[i + 4] = "Warrior";
            }
        }

        private void TitleBarTip_MouseDown(object sender, MouseButtonEventArgs e)
        {
            main.DragMove();
        }

        private void TitleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            main.DragMove();
        }

        private void TitleBarButt_MouseDown(object sender, MouseButtonEventArgs e)
        {
            main.DragMove();
        }

        private void LeftTitleBarPatch_MouseDown(object sender, MouseButtonEventArgs e)
        {
            main.DragMove();
        }

        private void RightTitleBarPatch_MouseDown(object sender, MouseButtonEventArgs e)
        {
            main.DragMove();
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            main.WindowState = WindowState.Minimized;
        }

        private void XButton_Click(object sender, RoutedEventArgs e)
        {
            EnterLeaveGame();
        }

        private void LeaveGameOkButton_Click(object sender, RoutedEventArgs e)
        {
            // shuts down the instance of the wpf application.
            Application.Current.Shutdown();
        }

        private void LeaveGameCancelButton_Click(object sender, RoutedEventArgs e)
        {
            //bgm.Volume = 0.5;
            LeaveGameGrid.Visibility = Visibility.Hidden;
            BlackOut.Visibility = Visibility.Hidden;
        }

        private void HeroOneHighlight_MouseEnter(object sender, MouseEventArgs e)
        {
            HeroOneHighlight.Opacity = .15;
        }

        private void HeroOneHighlight_MouseLeave(object sender, MouseEventArgs e)
        {
            HeroOneHighlight.Opacity = 1;
        }

        private void HeroOneAura_MouseEnter(object sender, MouseEventArgs e)
        {
            HeroOneHighlight.Opacity = .15;
        }

        private void HeroOneAura_MouseLeave(object sender, MouseEventArgs e)
        {
            HeroOneHighlight.Opacity = 1;
        }

        private void HeroOneFrame_MouseEnter(object sender, MouseEventArgs e)
        {
            HeroOneHighlight.Opacity = .15;
        }

        private void HeroOneFrame_MouseLeave(object sender, MouseEventArgs e)
        {
            HeroOneHighlight.Opacity = 1;
        }

        private void HeroOneSlot_MouseEnter(object sender, MouseEventArgs e)
        {
            HeroOneHighlight.Opacity = .15;
        }

        private void HeroOneSlot_MouseLeave(object sender, MouseEventArgs e)
        {
            HeroOneHighlight.Opacity = 1;
        }

        private void HeroTwoAura_MouseEnter(object sender, MouseEventArgs e)
        {
            HeroTwoHighlight.Opacity = .15;
        }

        private void HeroTwoAura_MouseLeave(object sender, MouseEventArgs e)
        {
            HeroTwoHighlight.Opacity = 1;
        }

        private void HeroTwoFrame_MouseEnter(object sender, MouseEventArgs e)
        {
            HeroTwoHighlight.Opacity = .15;
        }

        private void HeroTwoFrame_MouseLeave(object sender, MouseEventArgs e)
        {
            HeroTwoHighlight.Opacity = 1;
        }

        private void HeroTwoSlot_MouseEnter(object sender, MouseEventArgs e)
        {
            HeroTwoHighlight.Opacity = .15;
        }

        private void HeroTwoSlot_MouseLeave(object sender, MouseEventArgs e)
        {
            HeroTwoHighlight.Opacity = 1;
        }

        private void HeroThreeHighlight_MouseEnter(object sender, MouseEventArgs e)
        {
            HeroThreeHighlight.Opacity = .15;
        }

        private void HeroThreeHighlight_MouseLeave(object sender, MouseEventArgs e)
        {
            HeroThreeHighlight.Opacity = 1;
        }

        private void HeroThreeAura_MouseEnter(object sender, MouseEventArgs e)
        {
            HeroThreeHighlight.Opacity = .15;
        }

        private void HeroThreeAura_MouseLeave(object sender, MouseEventArgs e)
        {
            HeroThreeHighlight.Opacity = 1;
        }

        private void HeroThreeFrame_MouseEnter(object sender, MouseEventArgs e)
        {
            HeroThreeHighlight.Opacity = .15;
        }

        private void HeroThreeFrame_MouseLeave(object sender, MouseEventArgs e)
        {
            HeroThreeHighlight.Opacity = 1;
        }

        private void HeroThreeSlot_MouseEnter(object sender, MouseEventArgs e)
        {
            HeroThreeHighlight.Opacity = .15;
        }

        private void HeroThreeSlot_MouseLeave(object sender, MouseEventArgs e)
        {
            HeroThreeHighlight.Opacity = 1;
        }

        private void HeroFourHighlight_MouseEnter(object sender, MouseEventArgs e)
        {
            HeroFourHighlight.Opacity = .15;
        }

        private void HeroFourHighlight_MouseLeave(object sender, MouseEventArgs e)
        {
            HeroFourHighlight.Opacity = 1;
        }

        private void HeroFourAura_MouseEnter(object sender, MouseEventArgs e)
        {
            HeroFourHighlight.Opacity = .15;
        }

        private void HeroFourAura_MouseLeave(object sender, MouseEventArgs e)
        {
            HeroFourHighlight.Opacity = 1;
        }

        private void HeroFourFrame_MouseEnter(object sender, MouseEventArgs e)
        {
            HeroFourHighlight.Opacity = .15;
        }

        private void HeroFourFrame_MouseLeave(object sender, MouseEventArgs e)
        {
            HeroFourHighlight.Opacity = 1;
        }

        private void HeroFourSlot_MouseEnter(object sender, MouseEventArgs e)
        {
            HeroFourHighlight.Opacity = .15;
        }

        private void HeroFourSlot_MouseLeave(object sender, MouseEventArgs e)
        {
            HeroFourHighlight.Opacity = 1;
        }

        private void HeroFiveHighlight_MouseEnter(object sender, MouseEventArgs e)
        {
            HeroFiveHighlight.Opacity = .15;
        }

        private void HeroFiveHighlight_MouseLeave(object sender, MouseEventArgs e)
        {
            HeroFiveHighlight.Opacity = 1;
        }

        private void HeroFiveAura_MouseEnter(object sender, MouseEventArgs e)
        {
            HeroFiveHighlight.Opacity = .15;
        }

        private void HeroFiveAura_MouseLeave(object sender, MouseEventArgs e)
        {
            HeroFiveHighlight.Opacity = 1;
        }

        private void HeroFiveFrame_MouseEnter(object sender, MouseEventArgs e)
        {
            HeroFiveHighlight.Opacity = .15;
        }

        private void HeroFiveFrame_MouseLeave(object sender, MouseEventArgs e)
        {
            HeroFiveHighlight.Opacity = 1;
        }

        private void HeroFiveSlot_MouseEnter(object sender, MouseEventArgs e)
        {
            HeroFiveHighlight.Opacity = .15;
        }

        private void HeroFiveSlot_MouseLeave(object sender, MouseEventArgs e)
        {
            HeroFiveHighlight.Opacity = 1;
        }

        private void HeroTwoHighlight_MouseEnter(object sender, MouseEventArgs e)
        {
            HeroTwoHighlight.Opacity = .15;
        }

        private void HeroTwoHighlight_MouseLeave(object sender, MouseEventArgs e)
        {
            HeroTwoHighlight.Opacity = 1;
        }

        private void SoftwareEngineerButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CustomizeXButton_Click(object sender, RoutedEventArgs e)
        {
            CustomizeWindowGrid.Visibility = Visibility.Hidden;
            BlackOut.Visibility = Visibility.Hidden;
        }

        private void HeroOneSlot_Click(object sender, RoutedEventArgs e)
        {
            CustomAppear();
        }

        private void HeroOneFrame_Click(object sender, RoutedEventArgs e)
        {
            CustomAppear();
        }

        private void HeroOneAura_Click(object sender, RoutedEventArgs e)
        {
            CustomAppear();
        }

        private void HeroOneHighlight_Click(object sender, RoutedEventArgs e)
        {
            CustomAppear();
        }

        private void HeroTwoHighlight_Click(object sender, RoutedEventArgs e)
        {
            CustomAppear();
        }

        private void HeroTwoAura_Click(object sender, RoutedEventArgs e)
        {
            CustomAppear();
        }

        private void HeroTwoFrame_Click(object sender, RoutedEventArgs e)
        {
            CustomAppear();
        }

        private void HeroTwoSlot_Click(object sender, RoutedEventArgs e)
        {
            CustomAppear();
        }

        private void HeroThreeHighlight_Click(object sender, RoutedEventArgs e)
        {
            CustomAppear();
        }

        private void HeroThreeAura_Click(object sender, RoutedEventArgs e)
        {
            CustomAppear();
        }

        private void HeroThreeFrame_Click(object sender, RoutedEventArgs e)
        {
            CustomAppear();
        }

        private void HeroThreeSlot_Click(object sender, RoutedEventArgs e)
        {
            CustomAppear();
        }

        private void HeroFourHighlight_Click(object sender, RoutedEventArgs e)
        {
            CustomAppear();
        }

        private void HeroFourAura_Click(object sender, RoutedEventArgs e)
        {
            CustomAppear();
        }

        private void HeroFourFrame_Click(object sender, RoutedEventArgs e)
        {
            CustomAppear();
        }

        private void HeroFourSlot_Click(object sender, RoutedEventArgs e)
        {
            CustomAppear();
        }

        private void HeroFiveHighlight_Click(object sender, RoutedEventArgs e)
        {
            CustomAppear();
        }

        private void HeroFiveAura_Click(object sender, RoutedEventArgs e)
        {
            CustomAppear();
        }

        private void HeroFiveFrame_Click(object sender, RoutedEventArgs e)
        {
            CustomAppear();
        }

        private void HeroFiveSlot_Click(object sender, RoutedEventArgs e)
        {
            CustomAppear();
        }
    }
}
