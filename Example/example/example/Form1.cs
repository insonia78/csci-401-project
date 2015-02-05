using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ConsoleApplication1
{
    public partial class Form1 : Form
    {


          

         Section[,] play = new Section[12,12];
         Board[,] play2 = new Board[12, 12];


         int[,] table = new int[12, 12]
             {
           {00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00},
           {00, 00, 00, 02, 00, 00, 00, 00, 00, 00, 00, 00},
           {00, 00, 00, 00, 02, 00, 00, 00, 00, 00, 00, 00},
           {00, 02, 00, 00, 00, 02, 00, 00, 00, 00, 03, 00},
           {00, 00, 00, 00, 00, 00, 02, 00, 00, 00, 00, 00},
           {00, 00, 00, 00, 00, 00, 00, 00, 00, 03, 00, 00},
           {00, 00, 00, 00, 00, 00, 00, 00, 03, 00, 00, 00},
           {00, 00, 00, 00, 00, 00, 01, 00, 00, 00, 00, 00},
           {00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00},
           {00, 00, 00, 00, 00, 01, 00, 00, 00, 00, 00, 00},
           {00, 00, 00, 00, 1, 00, 00, 00, 00, 00, 00, 00},
           {00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00, 00},
       }; 
        
        bool validate = true;
        
        int z, y;
        int i, j;
        public Form1()
        {
            InitializeComponent();
               
            Initialize();
            design_and_place();

        }
        public void Initialize()
        {
            
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    
                    play[i, j] = new Section();
                    play[i, j].Parent = this ;
                    play[i, j].Location = new Point(j * 50 + 50, i * 50 + 50);
                    play[i, j].Size = new Size(50, 50);
                    play[i, j].Row = i;
                    play[i, j].Col = j;
                    play[i, j].Move += new EventHandler(Section_Move);
                    play[i, j].DragDrop += new DragEventHandler(Section_DragDrop);
                    play[i, j].Click += new EventHandler(Section_Click);
                    play[i, j].Row = i;
                    play[i, j].MouseHover += new EventHandler(Section_MouseHover);
                    play[i, j].BackColor = Color.Transparent;
                    play[i, j].BackgroundImageLayout = ImageLayout.Center;
                    
                }
            }
        }
        public void design_and_place()
        {
            
            int i, j;

            for (i = 0; i < 12; i++)
                for (j = 0; j < 12; j++)
                {
                    string value = Convert.ToString(i, 16);
                    string value2 = Convert.ToString(j, 16);
                    string value3 = value + value2;

                     
                    
                    switch (table[i, j])
                    {

                        case 1 :   play2[i,j] =  new Enemy(i,j);
                                   play[i, j].BackgroundImage = play2[i, j].Image;                             
                                   break;

                        case 2:    play2[i, j] =  new Terrain();
                                   play[i, j].BackgroundImage = play2[i, j].Image;
                                   break;


                        
                        case 3:    play2[i,j] =  new Hero();
                                   play[i, j].BackgroundImage = play2[i,j].Image; break;
                        default: break; 
                    }
                }


            

         

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        

        private void Section_Move(object sender, EventArgs e)
        {

        }

        private void Section_DragDrop(object sender, DragEventArgs e)
        {
            
        }

        private void Section_MouseHover(object sender, EventArgs e)
        {
          
            
            
        }

        private void Section_Click(object sender, EventArgs e)
        {                       
            i = (sender as Section).Row;
            j = (sender as Section).Col;
                        
            Console.WriteLine(i + " mcv:" + j);
            if (validate == true)
            {

                z = i;
                y = j;                             
                validate = false;
            }
            else
            {

                if (table[i,j] == table[z, y])
                {
                    MessageBox.Show("invalid Operatio");
                    
                }
                else
                {
                    if (table[i, j] != 0 && table[z, y] == 1)
                    {
                        switch (table[i, j])
                        {
                            case 2: new Form2(play2[i, j], play2[z, y]).Show(); break;
                            case 3: new Form2(play2[i, j], play2[z, y]).Show(); break;
                        }
                    }
                    if (table[i, j] != 0 && table[z, y] == 2)
                    {
                        switch (table[i, j])
                        {
                            case 1: new Form2(play2[i, j], play2[z, y]).Show(); break;
                            case 3: new Form2(play2[i, j], play2[z, y]).Show(); break;
                        }
                    }
                    if (table[i, j] != 0 && table[z, y] == 3)
                    {
                        switch (table[i, j])
                        {
                            case 2: new Form2(play2[i, j], play2[z, y]).Show(); break;
                            case 1: new Form2(play2[i, j], play2[z, y]).Show(); break;
                        }
                    }
                    play[i, j].BackgroundImage = play[z, y].BackgroundImage;
                    table[i, j] = table[z, y];
                    table[z, y] = 0;
                    play2[i, j] = play2[z, y];
                    play[z, y].BackgroundImage = null;
                    
                }
                validate = true;
            }

        }

        
            
            
            
            
        }


 }

        

        
       

    




