using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_3450_Assignment07_NDA
{
    public class CircleAdapter : Shape
    {
        private XXCircle circle;

        public CircleAdapter(XXCircle circle)
        {
            this.circle = circle;
        }

        public void SetLocation(int x, int y)
        {
            circle.SetLocation(x, y);
        }

        public void GetLocation()
        {
            circle.GetLocation();
        }

        public void Display()
        {
            circle.DisplayIt();
        }

        public void Fill()
        {
            circle.FillIt();
        }

        public void SetColor()
        {
            circle.SetItsColor();
        }

        public void Undisplay()
        {
            circle.UndisplayIt();
        }

        public void RunAllMethods()
        {
            this.GetLocation();
            this.Display();
            this.Fill();
            this.SetColor();
            this.Undisplay();
        }
    }
}