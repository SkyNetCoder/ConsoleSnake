﻿using System;

namespace ConsoleSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 2;
            p1.y = 2;
            p1.sym = '*';
            p1.Draw();

            Point p2 = new Point();
            p2.x = 5;
            p2.y = 5;
            p2.sym = '#';
            p2.Draw();
        }
    }
}