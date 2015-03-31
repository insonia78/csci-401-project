using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community
{
    class Program
    {
        static void Main(string[] args)
        {
            // fields
            Character test = new Character();   // variable to test the character object.

            // test content of the character object.
            Console.WriteLine("\n" + test.toString());

            // hold the terminal open to view the stats.
            Console.ReadLine();
        }
    }
}
