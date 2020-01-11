using System;
using System.Collections.Generic;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Point p1 = new Point(1,3,'*');
            
            Point p2 = new Point(3,5,'#');*/

            HorizontalLine line = new HorizontalLine(5,10,8,'+');
            line.Draw();

            VerticalLine liney = new VerticalLine(8,12,5,'+');
            liney.Draw();

            Console.ReadLine();
        }
    }
}
