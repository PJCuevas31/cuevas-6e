using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _6eLibrary;
using _UserRate;
namespace _6eLibrary
{
    internal class Intro
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to 6e Library");
            Console.WriteLine("The #1 ANIM-e Library " + "*ba-dum-tsss*");
            Console.WriteLine("Press Any Key to Start....");
            Console.ReadKey();
            Console.WriteLine("\n------------------");
            Home home = new Home();
            home.HomeScreen();
        }
    }
}
