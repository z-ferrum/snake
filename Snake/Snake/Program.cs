using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args) //Все что внутри этого блока - основной код программы
        {
            /* Это деревенский способ вывести точку на консоль
            int x1 = 1;
            int y1 = 3;
            char sym1 = '*';

            Console.SetCursorPosition(x1, y1);
            Console.Write(sym1);
            */

            /* Колхозный способ задать точку
             int x1 = 1;
             int y1 = 3;
             char sym1 = '*';

             Draw(x1, y1, '*'); //но уже вывод через функцию
             */

            Point p1 = new Point(1, 3, '*'); //new пишется так как это класс
            /* p1.x = 1;
            p1.y = 3;
            p1.sym = '*'; */
            p1.Draw();

            Point p2 = new Point(1, 3, '*'); //new пишется так как это класс
            /* p2.x = 4;
            p2.y = 5;
            p2.sym = '#'; */
            p2.Draw();
                    
            Console.ReadLine();
        }

        /* 
        static void Draw(int x, int y, char sym) //функция вывода точки на консоль
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }*/
    }
}
