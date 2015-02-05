using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    public partial class Section : UserControl
    {
        
        private int row,
                    col;
        public Section()
        {
            InitializeComponent();
        }
        
        public int Row
        {
            get { return row; }
            set { row = value; }
        }
        public int Col
        {
            get { return col; }
            set { col = value;}
        }
        private void Section_Load(object sender, EventArgs e)
        {

        }
    }
}
