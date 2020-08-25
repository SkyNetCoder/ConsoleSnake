using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleSnake
{
    class Program
    {
        const int MINCHAR = 33;
        const int MAXCHAR = 44;
        const int POINTS = 8;
        static void Main(string[] args)
        {
            Point p1 = new Point(8,3,'~');
            p1.Draw();

            Point p2 = new Point(5,5, '#');
            p2.Draw();

            //Отрисовка рамки
            HorizontalLine upLine = new HorizontalLine(1, 0, 80, '-');
            upLine.Draw();
            HorizontalLine downLine = new HorizontalLine(1, 24, 80, '-');
            downLine.Draw();
            VerticalLine leftLine = new VerticalLine(0, 1, 23, '|');
            leftLine.Draw();
            VerticalLine rightLine = new VerticalLine(81, 1, 23, '|');
            rightLine.Draw();

            //Отрисовка углов
            Point leftTop = new Point(0, 0, '+');
            leftTop.Draw();
            Point leftBot = new Point(0, 24, '+');
            leftBot.Draw();
            Point rightTop = new Point(81, 0, '+');
            rightTop.Draw();
            Point rightBot = new Point(81, 24, '+');
            rightBot.Draw();

            VerticalLine vLine = new VerticalLine(3, 3, 6, 'o');
            vLine.Draw();

            Snake snake = new Snake(p1, 5, Direction.RIGHT);
            snake.Draw();
            
            while (true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.LeftArrow)
                        snake.direction = Direction.LEFT;
                    if (key.Key == ConsoleKey.RightArrow)
                        snake.direction = Direction.RIGHT;
                    if (key.Key == ConsoleKey.UpArrow)
                        snake.direction = Direction.UP;
                    if (key.Key == ConsoleKey.DownArrow)
                        snake.direction = Direction.DOWN;
                }
                Thread.Sleep(200);
                snake.Move();
            }
            
            Console.SetCursorPosition(0, 24);
        }

        public static void Move(Point p, int dx, int dy)
        {
            p.x += dx;
            p.y += dy;
        }

    }
}
