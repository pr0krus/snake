using System;
using System.Collections.Generic;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3,'*');
            
            Point p2 = new Point(3,5,'#');
            
            Point p3 = new Point(7, 10, '@');
            
            Point p4 = new Point(11, 15, '%');

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);

            foreach (Point i in pList)
            {
                i.Draw(i);

            }
            

          
            


            Console.ReadLine();
        }
    }
}
