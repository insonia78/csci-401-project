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
        int[] heroType = new int[5];
            String[] name = new String[5];
            bool[] gender = new bool[5];
          
        public MainWindow()
        {
            InitializeComponent();

            
        }
        /// <the Boolean Gender() creates a random number generator that determines if the  heros are male or female. it puts them into the array
        public void Gender()
        {
            Random random = new Random();

            
            bool male;
            int num ;
            for (int i = 0; i < 5; i++)
            {
                num = random.Next(1, 6);
                heroType[i] = num;
               
                    
                    num = random.Next(1, 3);
                    if (num == 1)
                    {
                        
                        gender[i] = true;
                      ///<here is where I am having issues with the picture. I tried to save it to resources like a few pages suggested.
                      ///it saved it to a new folder, not the resources section I need and i cant get it to go to the right resources.
                        ///<Hero1.Background = Properties.Resources.deadladybug2.jpg;
                        
                        
                    }
                    else
                    {
                        
                        gender[i] = false;
                        ///<same issue here as the one up above
                        ///<Hero1.Background =  Properties.Resources.frog.jpg;
                       
                        
                    }
                    name[i] = "Bob";
                    name[i] = getName.Text; 
                }    
           
        }

        ///<this is the start of the randomize button. when you click it, it will call the gender one.
        /// once it calls the gender it will call the hero one. i havent created the hero one yet.
        private void GenRan_Click(object sender, RoutedEventArgs e)
        {
            this.Gender();
            placeCharacter();
        }
        public  void placeCharacter()
        {
            Character[] characters = new Character[5];
            for (int i = 0; i < 5; i++)
            {
                switch(heroType[i])
                {
                    case 0 :
                        {
                            characters[i] = new Character();
                            characters[i].Gender = gender[i];

                            break;
                        }
                    default:
                            {
                                characters[i] = new Character();
                                characters[i] .Gender = gender[i];
                                break;
                            }
                       
                }
                MessageBox.Show("this is gender in index " + i +" "+ gender[i].ToString());
               MessageBox.Show("this is characeer in index " + i +" "+characters[i].Gender.ToString());
               MessageBox.Show("this is in index " + i + " " + characters[i].ToString());
               
            }

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

        private void getName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

