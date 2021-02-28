using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zmeika_Csharp
{
    class Program
    {
        public void game_draw()
        {
            Console.Clear();
            Console.Title = "Snake";
            Walls walls = new Walls(80, 25);
            walls.Draw();

            // Отрисовка точек			
            Point p = new Point(4, 5, '*', ConsoleColor.Red);
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '@', ConsoleColor.Green);
            Stenka stenka = new Stenka(80, 25, '@', ConsoleColor.Green);
            Point food = foodCreator.CreateFood();
            Point stenk = stenka.CreateStenka();
            food.Draw();
            Score score = new Score(0, 1);//score=0, level=1
            score.speed = 200;
            score.ScoreWrite();
            Parametrs settings = new Parametrs();
            Sounds sound = new Sounds(settings.GetResourceFolder());
            sound.Play("game.mp3");
            Sounds soundeat = new Sounds(settings.GetResourceFolder());
            while (true)
            {
                if (snake.Eat(food))
                {
                    score.ScoreUp();
                    score.ScoreWrite();
                    food = foodCreator.CreateFood();
                    food.Draw();
                    //sound.Stop("stardust.mp3");
                    if (score.ScoreUp())
                    {
                        score.speed -= 20;
                        for (int i = 0; i < 2; i++)
                        {
                            stenk.Draw();
                        }
                    }
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(score.speed);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    snake.HandleKey(key.Key);
                }
            }
            WriteGameOver();
        }

        static void Main(string[] args)
        {
            Start start = new Start();
            if (start.choice() == 1)
            {
                Program prog = new Program();
                prog.game_draw();
            }
            else
            {
                start.Game_stop();
            }


            Console.ReadLine();

        }
        static void WriteGameOver()
        {
            int xOffset = 25;
            int yOffset = 8;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(xOffset, yOffset++);
            WriteText("=========", xOffset, yOffset++);
            WriteText("Game Over", xOffset + 1, yOffset++);
            WriteText("=========", xOffset, yOffset++);
        }

        static void WriteText(String text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }


    }
}
