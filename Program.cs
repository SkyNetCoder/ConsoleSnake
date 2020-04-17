using System;

namespace ConsoleSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(8,3,'*');
            p1.Draw();

            Point p2 = new Point(5,5, '#');
            p2.Draw();
        }
    }
}
