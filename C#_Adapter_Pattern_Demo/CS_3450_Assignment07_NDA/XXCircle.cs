using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_3450_Assignment07_NDA
{
    public class XXCircle
    {
        private int x = 0, y = 0;

        public void SetLocation(int x, int y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine("Circle location has been set.");
        }

        public void GetLocation()
        {
            Console.WriteLine("The location of the circle is x: {0}, y: {1}.", this.x, this.y);
        }

        public void DisplayIt()
        {
            Console.WriteLine("Circle is being displayed.");
        }

        public void FillIt()
        {
            Console.WriteLine("Circle has been filled.");
        }

        public void SetItsColor()
        {
            Console.WriteLine("Circle's color has been set.");
        }

        public void UndisplayIt()
        {
            Console.WriteLine("Circle is being undisplayed.");
        }
    }
}