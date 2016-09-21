using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            // Нарисуем рамку
            HorizontalLine lineHup = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine lineHdown = new HorizontalLine(0, 78, 24, '+');
            VerticalLine lineVr = new VerticalLine(0, 24, 0, '+');
            VerticalLine lineVl = new VerticalLine(0, 24, 78, '+');
            lineHup.Drow();
            lineHdown.Drow();
            lineVr.Drow();
            lineVl.Drow();

            Point p = new Point(4, 5, '@');
            p.Draw();

            Console.ReadLine();
        }        
    }
}
