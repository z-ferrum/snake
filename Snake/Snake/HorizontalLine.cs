﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine
    {
        List<Point> pList;

        /* Конструктор для горизонтальной линии с определенной длинной и координатами 
        public HorizontalLine()
        {
            pList = new List<Point>();
            Point p1 = new Point(4, 4, '*');
            Point p2 = new Point(5, 4, '*');
            Point p3 = new Point(6, 4, '*');
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
        }
        */

        public HorizontalLine(int xLeft, int xRight, int y, char sym) //4 параметра линии (начало, конец, коорд. y, символ)
        {
            pList = new List<Point>();
            for(int x = xLeft; x <= xRight; x++) //на каждой итерации х получает значения начиная от хLeft и заканчивая xRight
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void Draw()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }
        }
  
    }
}
