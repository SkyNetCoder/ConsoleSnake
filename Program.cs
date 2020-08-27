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
            Console.Title = "Console Snake";
            
            Console.CursorVisible = false;

            Room gameRoom = new Room(80, 24);
            gameRoom.Draw();

            Point p = new Point(8,3, '■');
            p.Draw();

            Snake snake = new Snake(p, 5, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 24);
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (gameRoom.IsHit(snake) || snake.IsHitTail())
                {
                    Console.Write("Game Over!");
                    Thread.Sleep(1000);
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(200);
                
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.KeyHandler(key.Key);
                }
            }
        }
    }
}
