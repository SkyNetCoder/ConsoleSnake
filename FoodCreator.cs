using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleSnake
{
    class FoodCreator
    {
        int mapHeight, mapWidth;

        List<char> charList = new List<char>();

        Random random = new Random();

        public FoodCreator(int mapWidth, int mapHeight)
        {
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            charList.Add('$');
            charList.Add('£');
            charList.Add('¢');
            charList.Add('€');
        }

        public Point CreateFood()
        {
            int x = random.Next(1, mapWidth - 2);
            int y = random.Next(1, mapHeight - 2);
            return new Point(x, y, charList[random.Next(charList.Count)]);
        }
    }
}
