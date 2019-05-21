using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_3450_Assignment07_NDA
{
    public class Line : Shape
    {
        public void Display()
        {
            Console.WriteLine("Line being displayed.");
        }

        public void Fill()
        {
            Console.WriteLine("Line being filled.");
        }

        public void Undisplay()
        {
            Console.WriteLine("Line being undisplayed.");
        }

        public void RunAllMethods()
        {
            this.Display();
            this.Fill();
            this.Undisplay();
        }
    }
}