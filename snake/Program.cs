﻿using System;
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
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorizontalLine lineH = new HorizontalLine(7, 40, 8, '+');
            lineH.Drow();

            VerticalLine lineV = new VerticalLine(4, 20, 5, '#');
            lineV.Drow();

            Console.ReadLine();
        }        
    }
}
