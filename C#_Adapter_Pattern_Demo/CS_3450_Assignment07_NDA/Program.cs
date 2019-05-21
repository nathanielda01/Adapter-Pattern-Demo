/*
 * Purpose: Program demostrates the Adapter Pattern.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_3450_Assignment07_NDA
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            Line line = new Line();
            Rectangle rectangle = new Rectangle();
            CircleAdapter circle = new CircleAdapter(new XXCircle());
            circle.SetLocation(1, 1);
            Console.WriteLine("\nPoint");
            point.RunAllMethods();
            Console.WriteLine("\nLine");
            line.RunAllMethods();
            Console.WriteLine("\nRectangle");
            rectangle.RunAllMethods();
            Console.WriteLine("\nCircle");
            circle.RunAllMethods();

            Console.ReadKey();
        }
    }
}
