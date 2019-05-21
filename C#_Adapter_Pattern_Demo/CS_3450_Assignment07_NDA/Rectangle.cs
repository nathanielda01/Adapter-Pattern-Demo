using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_3450_Assignment07_NDA
{
    public class Rectangle : Shape
    {
        public void Display()
        {
            Console.WriteLine("Rectangle being displayed.");
        }

        public void Fill()
        {
            Console.WriteLine("Rectangle being filled.");
        }

        public void Undisplay()
        {
            Console.WriteLine("Rectangle being undisplayed.");
        }

        public void RunAllMethods()
        {
            this.Display();
            this.Fill();
            this.Undisplay();
        }
    }
}