using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_3450_Assignment07_NDA
{
    public class Point : Shape
    {
        public void Display()
        {
            Console.WriteLine("Point being displayed.");
        }

        public void Fill()
        {
            Console.WriteLine("Point being filled.");
        }

        public void Undisplay()
        {
            Console.WriteLine("Point being undisplayed.");
        }

        public void RunAllMethods()
        {
            this.Display();
            this.Fill();
            this.Undisplay();
        }
    }
}