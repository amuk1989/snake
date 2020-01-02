using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Point p1 = new Point(1,1, '*');
            p1.draw();



            Point p2 = new Point(1,2,'#');
            p2.draw();

            HorizontalLine line = new HorizontalLine(3,5,3,'+');
            line.Draw();

            verticalLine line2 = new verticalLine(3, 5, 3, '+');
            line2.Draw();

            Console.ReadLine();
        }

        
    }
}
