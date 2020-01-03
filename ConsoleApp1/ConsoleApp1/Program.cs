using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.SetBufferSize(90, 35);
            
            HorizontalLine Topline = new HorizontalLine(0,78,0,'+');
            verticalLine Rightline = new verticalLine(0,24,0,'+');
            verticalLine Leftline = new verticalLine(0,24,78,'+');
            HorizontalLine Bottomline = new HorizontalLine(0,78,24,'+');
            Topline.Draw();
            Leftline.Draw();
            Bottomline.Draw();
            Rightline.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 10, Direction.right);
            snake.Draw();

            /*for(int i = 0; i<10; i++)
            {
                snake.Move();
                Thread.Sleep(300);
            }*/

            while (true)
            {
                if (Console.KeyAvailable)
                {

                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandKey(key.Key);
                   
                }
                snake.Move();
                Thread.Sleep(100);
            }
            

            Console.ReadLine();
        }

        
    }
}
