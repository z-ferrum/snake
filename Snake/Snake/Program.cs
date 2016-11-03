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

            // --- P O I N T S ---
            /* Это деревенский способ вывести точку на консоль
            int x1 = 1;
            int y1 = 3;
            char sym1 = '*';

            Console.SetCursorPosition(x1, y1);
            Console.Write(sym1);
            

            Колхозный способ задать точку

            int x1 = 1;
            int y1 = 3;
            char sym1 = '*';
            Draw(x1, y1, '*'); //но уже вывод через функцию

            Point p1 = new Point(); //point - класс, p1 - объект класса
            p1.x = 1;
            p1.y = 3;
            p1.sym = '*'; 
            p1.Draw(p1.x, p1.y, p1.sym);
            */
           
            Point p1 = new Point(1, 3, '*'); //point - класс, p1 - объект класса
            p1.Draw();

            Point p2 = new Point(4, 5, '*'); //new пишется так как это класс
            /* p2.x = 4;
            p2.y = 5;
            p2.sym = '#'; */
            p2.Draw();

            // --- L I S T S ---
            /*
            //класс стандартной библиотеки С# - список, может хранить сразу несколько элементов
            List<int> numList = new List<int>(); //создаем переменную numlist. которая является объектом класса List
            //и которая будет хранить список целочисленных переменных
            numList.Add(0); //добавляем элементы в список
            numList.Add(1);
            numList.Add(2);

            //чтобы получить доступ к элементам списка необходимо знать их порядковый номер
            int x = numList[0]; //нумерация начинается с нуля, получим значение первого элемента в списке
            int y = numList[1];
            int z = numList[2];

            //выведем значения элементов с помощью цикла
            foreach(int i in numList) 
            //в каждом витке цикла в переменную i поочередно записывались 
            //значения всех элементов данного списка
            {
                Console.WriteLine(i);
            }

            //Ещё одна функция списка: remove - удаляет элемент
            numList.RemoveAt(0); //команда удалит нулевой элемент x = 0 и в списке останутся только элементы 1 и 2

            //Создадим список содержащий несколько точек
            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            */

            /* вызов конструктора без параметров
            HorizontalLine line = new HorizontalLine(); //создаем новую линию (объект: line)
            line.Draw(); //выводим/рисуем эту самую линию */

            // вызов конструктора с параметрами
            HorizontalLine line = new HorizontalLine(5, 10, 8, '+');
            line.Draw();

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
