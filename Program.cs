﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zmeika_Csharp
{
    class Program
    {
		static void Main(string[] args)
		{
			//Console.SetBufferSize(80, 25);

			Walls walls = new Walls(80, 25);
			walls.Draw();

			// Отрисовка точек			
			Point p = new Point(4, 5, '*', ConsoleColor.Red);
			Snake snake = new Snake(p, 4, Direction.RIGHT);
			snake.Draw();

			FoodCreator foodCreator = new FoodCreator(80, 25, '$', ConsoleColor.Green);
			Point food = foodCreator.CreateFood();
			food.Draw();
			Score score = new Score(0, 1);//score=0, level=1
			score.speed = 400;
			score.ScoreWrite();

			while (true)
			{
				if (walls.IsHit(snake) || snake.IsHitTail())
				{
					break;
				}
				if (snake.Eat(food))
				{
					score.ScoreUp();
					score.ScoreWrite();
					food = foodCreator.CreateFood();
					food.Draw();
					if (score.ScoreUp())
					{
						score.speed -= 10;
					}
				}
				else
				{
					snake.Move();
				}
				Thread.Sleep(score.speed);

				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.HandleKey(key.Key);
				}


			}
			Console.ReadLine();
        }
			

    }
}
