using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSnake
{
    class Line
    {
        protected List<Point> pList;

        public virtual void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

		internal bool IsHit(Line line)
		{
			foreach (var p in pList)
			{
				if (line.IsHit(p))
					return true;
			}
			return false;
		}

		private bool IsHit(Point point)
		{
			foreach (var p in pList)
			{
				if (p.IsHit(point))
					return true;
			}
			return false;
		}
	}
}
