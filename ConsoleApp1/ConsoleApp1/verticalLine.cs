using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class verticalLine: Figure
    {
            


        public verticalLine(int yTop, int yBottom, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yTop; y <= yBottom; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

       
    }

}

