using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ConsoleApplication1
{
    public class Terrain : Board
    {
        private int life;
        private int state;
        private int job;
        private int arrow;
        private Image image;
        public Terrain()
        {
            life = 10;
            state = 20;
            job = 20;
            arrow = 40;
            image = System.Drawing.Image.FromFile("Image\\terrein.jpg");
        }
        public int Life
        {
            get { return life; }
            set { life = value; }
        }
        public int Arrow
        {
            get { return arrow; }
            set { arrow = value; }
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
