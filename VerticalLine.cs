using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSnake
{
    class VerticalLine : Line
    {
        public VerticalLine(int xPos, int yPos, int length, char sym)
        {
            pList = new List<Point>();
            for (int y = yPos; y < (yPos + length); y++)
            {
                Point p = new Point(xPos, y, sym);
                pList.Add(p);
            }
        }

        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            base.Draw();
            Console.ResetColor();
        }
    }
}
