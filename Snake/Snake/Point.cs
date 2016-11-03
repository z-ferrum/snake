using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point //новый класс. Класс хранит данные точки
    {
        public int x;
        public int y;
        public char sym;

        public void Draw() //функцию можно убирать в класс, вызывается через .draw
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
