using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSnake
{
    class Room
    {
        List<Line> lineList = new List<Line>();
        List<Point> cornerList = new List<Point>();

        public Room (int roomWidth, int roomHeight)
        {
            //Отрисовка рамки
            HorizontalLine upLine = new HorizontalLine(1, 0, roomWidth, '-');
            HorizontalLine downLine = new HorizontalLine(1, roomHeight, roomWidth, '-');
            VerticalLine leftLine = new VerticalLine(0, 1, roomHeight-1, '|');
            VerticalLine rightLine = new VerticalLine(roomWidth, 1, roomHeight-1, '|');

            lineList.Add(upLine);
            lineList.Add(downLine);
            lineList.Add(leftLine);
            lineList.Add(rightLine);

            //Отрисовка углов
            Point leftTop = new Point(0, 0, '+');
            Point leftBot = new Point(0, roomHeight, '+');
            Point rightTop = new Point(roomWidth, 0, '+');
            Point rightBot = new Point(roomWidth, roomHeight, '+');

            cornerList.Add(leftTop);
            cornerList.Add(leftBot);
            cornerList.Add(rightTop);
            cornerList.Add(rightBot);
        }

        public void Draw()
        {
            foreach(var line in lineList)
            {
                line.Draw();
            }

            foreach(var corner in cornerList)
            {
                corner.Draw();
            }
        }

        internal bool IsHit(Line line)
        {
            foreach(var roomLine in lineList)
            {
                if (roomLine.IsHit(line))
                    return true;
            }
            return false;
        }
    }
}
