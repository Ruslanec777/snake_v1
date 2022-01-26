using System;
using System.Threading;
using static snake_v1.Models.Direction;
//TODO вернуть 
//using static snake_v1.Models.Snake;
using static snake_v1.Models.GameSpeedController;
using System.Collections.Generic;
using snake_v1.Infrastructure;
using System.Drawing;
using snake_v1.Models.Map;
using snake_v1.Models.BaseItems;

namespace snake_v1.Models
{
    static class Game
    {
        //TODO вернуть 
       // private static Snake snake;

        public static IMap map;

        private const byte WINDOWHIGHT = 30;
        private const byte WINDOWWIDTH = 100;




        public static void Stert()
        {

            initGame();

            while (true)
            {
                Console.CursorVisible = false;
                //TODO вернуть 
                //snake.Move();

                //Console.Clear();
                if (Console.KeyAvailable)
                {
                    //TODO вернуть 
                    //snake.ChangeDirection(Console.ReadKey(true).Key);
                }
                ControlledPause();

            }
        }

        private static void initGame()
        {
            Console.Clear();
            Console.CursorVisible = false;
            currentDirection = Enums.MoveDirection.Right;
            Console.SetWindowSize(WINDOWWIDTH, WINDOWHIGHT);
            initSnake();
            map = MapGenerator.Generate(Enums.MapType.Box, 1, 10, WINDOWHIGHT, WINDOWWIDTH, ConsoleColor.Yellow);
            //_map.Add(_snake);
            // Level1.initLevel(_map);

        }

        private static void initSnake()
        {
            var teil = new RigidPoint(20, 20, '*', ConsoleColor.Green);
            //TODO вернуть 
            //snake = new Snake(teil, 5, Enums.MoveDirection.Right);
            //snake.Draw();
        }
    }
}
