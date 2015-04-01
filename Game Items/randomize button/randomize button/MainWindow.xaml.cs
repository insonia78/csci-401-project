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
            String[] name_female = new String[5]{"Sally", "Sammy", "Erica", "Amanda", "Caitlyn"};
            bool[] gender = new bool[5];
            String[] name_male = new String[5] { "Evan", "Christian", "Joseph", "Bob", "Dylan" };
            String[] hero_name = new String[5];
            String[] hero_type = new String[5];
            string name;
        public MainWindow()
        {
            InitializeComponent();

            
        }
        /// <the Boolean Gender() creates a random number generator that determines if the  heros are male or female. it puts them into the array
        public void Gender()
        {
            Random random = new Random();

            
           
            int num ;
            for (int i = 0; i < 5; i++)
            {
                num = random.Next(1, 6);
                heroType[i] = num;
               
                    
                    num = random.Next(1, 3);
                    if (num == 1)
                    {
                        
                        gender[i] = true;
                            name = name_male[i];
                        
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



        public void Herocharacter()
        {
            Random random = new Random();



            int num;
            int nums;
           
            for (int i = 0; i < 5; i++)
            {
                num = random.Next(1, 6);
                heroType[i] = num;


                nums = random.Next(1, 6);
                
                if (nums == 1)
                {
                    hero_type[i] = "warrior";
                    hero_type[i + 1] = "healer";
                    hero_type[i + 2]="mage";
                    hero_type[i + 3]="hunter";
                    hero_type[i + 4] = "rogue";
                }
                else if (nums == 2)
                {
                    hero_type[i] = "rogue";
                    hero_type[i + 1] = "warrior";
                    hero_type[i + 2] = "healer";
                    hero_type[i + 3] = "mage";
                    hero_type[i + 4] = "hunter";


                }
                else if (nums == 3)
                {
                    hero_type[i] = "hunter";
                    hero_type[i + 1] = "rogue";
                    hero_type[i + 2] = "warrior";
                    hero_type[i + 3] = "healer";
                    hero_type[i + 4] = "mage";
                }
                else if (nums == 4)
                {
                    hero_type[i] = "mage";
                    hero_type[i + 1] =  "hunter";
                    hero_type[i + 2] = "rogue";
                    hero_type[i + 3] =  "warrior";
                    hero_type[i + 4] =  "healer";
                }
                else 
                {
                    hero_type[i] = "healer";
                    hero_type[i + 1] =  "mage";
                    hero_type[i + 2] = "hunter";
                    hero_type[i + 3] = "rogue";
                    hero_type[i + 4] =  "warrior";
                }
            }

        }

        /// <this sets the names for the randomization button
        /// <it sends the names into a common array so they can be accessed for the heros.
        /// <false are girls.
        /// <true are guys.
        public void Name()
        {
            Random random = new Random();



            int num;
            int numnum;
            for (int i = 0; i < 5; i++)
            {
                num = random.Next(1, 6);
                heroType[i] = num;


                numnum = random.Next(0, 5);
                if (gender[i] == true)
                {

                    name = name_male[numnum];
                    hero_name[i] = name;
                  

                }
                else
                {
                    name = name_female[numnum];
                    hero_name[i] = name;
                    

                }
                
            }

        }

        ///<this is the start of the randomize button. when you click it, it will call the gender one.
        /// once it calls the gender it will call the hero one. 
        /// after it calls the hero one, it calls the name.
        private void GenRan_Click(object sender, RoutedEventArgs e)
        {
            this.Gender();
            this.Herocharacter();
            this.Name();
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
                            ///<getting an error at the line below this one, for every case. any help?
                            characters[i].Herocharacter = hero_type[i];
                            characters[i].Name = hero_name[i];
                            break;
                        }
                    case 1 :
                        {
                            characters[i] = new Character();
                            characters[i].Gender = gender[i];
                            characters[i].Herocharacter = hero_type[i];
                            characters[i].Name = hero_name[i];
                            break;
                        }
                    case 2 :
                        {
                            characters[i] = new Character();
                            characters[i].Gender = gender[i];
                            characters[i].Herocharacter = hero_type[i];
                            characters[i].Name = hero_name[i];
                            break;
                        }
                    case 3 :
                        {
                            characters[i] = new Character();
                            characters[i].Gender = gender[i];
                            characters[i].Herocharacter = hero_type[i];
                            characters[i].Name = hero_name[i];
                            break;
                        }
                    case 4 :
                        {
                            characters[i] = new Character();
                            characters[i].Gender = gender[i];
                            characters[i].Herocharacter = hero_type[i];
                            characters[i].Name = hero_name[i];
                            break;
                        }
                  
                    default:
                            {
                                characters[i] = new Character();
                                characters[i] .Gender = gender[i];
                                characters[i].Herocharacter = hero_type[i];
                                characters[i].Name = hero_name[i];
                                break;
                            }
                       
                }
                MessageBox.Show("this is gender in index " + i +" "+ gender[i].ToString());
               MessageBox.Show("this is character in index " + i +" "+characters[i].Gender.ToString());
               MessageBox.Show("this name is in index " + i + " " + characters[i].Name.ToString());
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

