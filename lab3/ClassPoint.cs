using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class Point
    {
        public int a;
        public int b;
        public char sym;
        public void Draw()
        {
            Console.SetCursorPosition(a,b);
            Console.Write(sym);
        }
    
    }
}
