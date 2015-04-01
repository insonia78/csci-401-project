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
            Character characterTest = new Character();  // variable to test the character class.
            Hero heroTest = new Hero();                 // variable to test the hero class.

            Hero hero1 = new SoftwareEngineer();        // variable to test the S.E. class as a Hero.

            // test content of the Character and hero object.
            //Console.WriteLine("\n" + heroTest.toString());

            // test content of the software engineer as a hero.
            Console.WriteLine(hero1.toString());

            // hold the terminal open to view the stats.
            Console.ReadLine();
        }
    }
}
