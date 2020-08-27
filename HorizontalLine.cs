using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSnake
{
    class HorizontalLine : Line
    {
        public HorizontalLine(int xPos, int yPos, int length, char sym)
        {
            pList = new List<Point>();
            for (int x = xPos; x < (xPos + length); x++)
            {
                Point p = new Point(x, yPos, sym);
                pList.Add(p);
            }
        }

        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            base.Draw();
            Console.ResetColor();
        }
    }
}
