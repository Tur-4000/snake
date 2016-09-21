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
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(1, 2, '#');
            p2.Draw();

            List<char> chList = new List<char>();
            chList.Add('*');
            chList.Add('#');
            chList.Add('@');
            chList.Add('*');
            chList.Add('*');

            Point p3 = new Point(2, 3, chList[2]);
            Point p4 = new Point(3, 4, chList[2]);
            Point p5 = new Point(4, 5, chList[2]);
            Point p6 = new Point(5, 6, chList[2]);

            p3.Draw();
            p4.Draw();
            p5.Draw();
            p6.Draw();

            List<Point> p1List = new List<Point>();
            p1List.Add(p3);
            p1List.Add(p4);
            p1List.Add(p5);
            p1List.Add(p6);
            
            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach(int i in numList)
            {
                Console.WriteLine(i);
            }

            numList.RemoveAt(0);

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);

            Console.ReadLine();
        }        
    }
}
