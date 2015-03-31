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




namespace randomize_button
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
        }
        /// <the Boolean Gender() creates a random number generator that determines if the  heros are male or female. it puts them into the array
        public Boolean Gender()
        {
            Random random = new Random();
            bool[] gender;
            gender = new bool[5];
            bool male;

            for (int i = 0; i < 5; i++)
            {
               
                    int num;
                    num = random.Next(1, 3);
                    if (num == 1)
                    {
                        male = true;
                        gender[i] = male;
                      ///<here is where I am having issues with the picture. I tried to save it to resources like a few pages suggested.
                      ///it saved it to a new folder, not the resources section I need and i cant get it to go to the right resources.
                        ///<Hero1.Background = Properties.Resources.deadladybug2.jpg;
                        
                        return gender[i];
                    }
                    else
                    {
                        male = false;
                        gender[i] = male;
                        ///<same issue here as the one up above
                        ///<Hero1.Background =  Properties.Resources.frog.jpg;
                       
                        return gender[i];
                    }
                }    
            return false;
        }

        ///<this is the start of the randomize button. when you click it, it will call the gender one.
        /// once it calls the gender it will call the hero one. i havent created the hero one yet.
        private void GenRan_Click(object sender, RoutedEventArgs e)
        {
            this.Gender();
        }

        /// <this is what will happen if you dont want to randomize the heros.
        /// it is supposed to make the buttons and text boxes below the hero visible.
        /// once they are visible i want to make them clickable.
        /// from there the person will be able to do their choices.
        private void Hero1_Click(object sender, RoutedEventArgs e)
        {
            Hero_Name.Visibility = System.Windows.Visibility.Visible;
            Gender_Choices.Visibility = System.Windows.Visibility.Visible;
            Female.Visibility = System.Windows.Visibility.Visible;
            Male.Visibility = System.Windows.Visibility.Visible;
        }

        private void Female_Click(object sender, RoutedEventArgs e)
        {
            ///<change the image to a female image
            ///set the array spot to female
        }
    }
}

