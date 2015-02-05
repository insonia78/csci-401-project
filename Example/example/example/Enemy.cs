using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ConsoleApplication1
{
    public class Enemy : Board
    {
       private int life;
       private int state;
       private int job;
       private int arrow;
       private Image image;
       private int row;
       private int col;
        public Enemy()
        {
            life = 10;
            state = 20;
            job = 20;
            arrow = 40;
            image = System.Drawing.Image.FromFile("Image\\enemy.jpg");
        }
        public Enemy(int i, int j)
        {
            row = 1;
            col = 1;

            life = 10;
            state = 20;
            job = 20;
            arrow = 40;
            image = System.Drawing.Image.FromFile("Image\\enemy.jpg");

        }
        public int Row
        {
            get { return row; }
            set{row = value;}
        }
        public int Col
        {
            get { return col; }
            set { col = value; }
        }
        public int Life
        {
            get { return life; }
            set { life = value; }
        }
        public int Arrow
        {
            get { return arrow;}
            set { arrow = value;}
        }
        public int State
        {
            get { return state; }
            set { state = value; }
        }
        public int Job
        {
            get { return job; }
            set { arrow = value; }
        }
        public Image Image
        {
            get { return image; }
            set { image = value; }
        }
        public Image getImage()
        {
            return image;
        }

    }
}
