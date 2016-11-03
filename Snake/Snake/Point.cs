using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
        //новый класс. Класс хранит данные точки
    {
        /* Класс состоит из трех составляющих: данные, конструкторы, методы
        */
        
    //ДАННЫЕ КЛАССА

        public int x;
        public int y;
        public char sym;

    //КОНСТРУКТОРЫ КЛАССА

        /* public Point()
        {
            Console.WriteLine("Создается новая точка");
        }*/

        public Point(int _x, int _y, char _sym) //конструктор (вызывается при создании новой точки)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }
        //такой способ позволяет скрыть все операции из основного кода в класс (инкапсуляция)

    //МЕТОДЫ КЛАССА

        public void Draw() //функцию можно убирать в класс, вызывается через .draw
            // void означает что функция ничего не возвращает (никакого значения)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
