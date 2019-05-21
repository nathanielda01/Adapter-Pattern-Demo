using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_3450_Assignment07_NDA
{
    public abstract class Shape
    {
        public void SetLocation()
        {
            Console.WriteLine("Set shape location.");
        }

        public void GetLocation()
        {
            Console.WriteLine("Get shape location.");
        }

        public void Display()
        {
            Console.WriteLine("Display shape.");
        }

        public void Fill()
        {
            Console.WriteLine("Fill shape.");
        }

        public void SetColor()
        {
            Console.WriteLine("Set shape color.");
        }

        public void Undisplay()
        {
            Console.WriteLine("Undisplay shape.");
        }
    }
}