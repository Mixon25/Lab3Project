using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class Point
    {
        int x;
        int y;
        string pic;
        public void Draw()
        {
            Console.Write("Введите значение х:");
            int x = int.Parse(Console.ReadLine());
            if (x >= 0)
                this.x = x;
            else
                throw new Exception("Пожалуйста, введите целое положительное значение координаты х");
            Console.Write("Введите значение у:");
            int y = int.Parse(Console.ReadLine());
            if (y >= 0)
                this.y = y;
            else
                throw new Exception("Пожалуйста, введите целое положительное значение координаты y");
            Console.SetCursorPosition(x,y);
            pic = "|++";
            Console.Write(pic);
            Console.SetCursorPosition(x,y+1);
            pic = "|  +";
            Console.Write(pic);
            Console.SetCursorPosition(x, y + 2);
            pic = "|++";
            Console.Write(pic);
            Console.SetCursorPosition(x, y + 3);
            pic = "|";
            Console.Write(pic);
        }
    
    }
}
