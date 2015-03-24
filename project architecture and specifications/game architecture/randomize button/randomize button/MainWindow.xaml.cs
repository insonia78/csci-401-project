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

        public Boolean Gender()
        {
            Random random = new Random();
            bool[] gender;
            gender = new bool[5];
            int[] heros;
            heros = new int[5];
            bool male;

            for (int i = 0; i < 5; i++)
            {
                if (i == 0)
                {
                    int num;
                    num = random.Next(1, 3);
                    if (num == 1)
                    {
                        male = true;
                        ///<gender[0] = male;
                        ///<System.Console.WriteLine(gender[0]);
                        ///<return gender[0];
                        return male;
                    }
                    else
                    {
                        male = false;
                        ///<gender[0] = male;
                        ///<System.Console.WriteLine(gender[0]);
                        ///<return gender[0];
                        return male;
                    }
                }
                if (i == 1)
                {
                    int num;
                    num = random.Next(1, 3);
                    if (num == 1)
                    {
                        male = true;
                        ///<gender[1] = male;
                        ///<System.Console.WriteLine(gender[1]);
                        ///<return gender[1];
                        return male;
                    }
                    else
                    {
                        male = false;
                        ///<gender[1] = male;
                        ///<System.Console.WriteLine(gender[1]);
                        ///<return gender[1];
                        return male;
                    }
                }
                if (i == 2)
                {
                    int num;
                    num = random.Next(1, 3);
                    if (num == 1)
                    {
                        male = true;
                        ///<gender[2] = male;
                        ///<System.Console.WriteLine(gender[2]);
                        ///<return gender[2];
                        return male;
                    }
                    else
                    {
                        male = false;
                        ///<gender[2] = male;
                        ///<System.Console.WriteLine(gender[2]);
                        ///<return gender[2];
                        return male;
                    }
                }
                if (i == 3)
                {
                    int num;
                    num = random.Next(1, 3);
                    if (num == 1)
                    {
                        male = true;
                        ///<gender[3] = male;
                        ///<System.Console.WriteLine(gender[3]);
                        ///<return gender[3];
                        return male;
                    }
                    else
                    {
                        male = false;
                        ///<gender[3] = male;
                        ///<System.Console.WriteLine(gender[3]);
                        ///<return gender[3];
                        return male;
                    }
                }
                if (i == 4)
                {
                    int num;
                    num = random.Next(1, 3);
                    if (num == 1)
                    {
                        male = true;
                        ///<gender[4] = male;
                        ///<System.Console.WriteLine(gender[4]);
                        ///<return gender[4];
                        return male;
                    }
                    else
                    {
                        male = false;
                        ///<gender[4] = male;
                        ///,System.Console.WriteLine(gender[4]);
                        ///<return gender[4];
                        return male;
                    }
                }
            }
            return false;
        }

        public String Thing()
        {
            bool middle;
            bool[] sex;
            sex = new bool[5];
            for (int m = 0; m < 5; m++)
            {

                middle = this.Gender();
                sex[m] = middle;
                System.Console.WriteLine(middle);
            }
            System.Console.WriteLine();
        }

        private void GenRan_Click(object sender, RoutedEventArgs e)
        {
            System.Console.WriteLine(this.Thing());
        }
    }
}

