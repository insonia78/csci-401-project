using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ConsoleApplication1
{
    public interface Board 
    {
        int Arrow { get; set; }
        int State { get; set; }
        int Job { get; set; }
        Image Image { get; set; }
        Image getImage();
        int Life { get; set; }
         
    }
}
