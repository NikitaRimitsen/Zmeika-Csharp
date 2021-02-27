using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeika_Csharp
{
    class Start
    {
        public ConsoleKeyInfo key;
        public Start()
        {
        }
        int valik = 0;
        public int choice()
        {
            Console.SetCursorPosition(50, 10);
            Console.WriteLine("Start game - S");
            Console.SetCursorPosition(49, 11);
            Console.WriteLine("________________");
            Console.SetCursorPosition(50, 13);
            Console.WriteLine("Stop game - Q");
            Console.SetCursorPosition(49, 14);
            Console.WriteLine("________________");
            Console.SetCursorPosition(50, 16);
            Console.WriteLine("Sounds=0% - A");
            key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.S)
            {
                valik = 1;
            }
            else if (key.Key == ConsoleKey.Q)
            {
                valik = 2;
            }
            else if (key.Key == ConsoleKey.A)
            {
                valik = 3;
            }
            return valik;
        }

        public void Game_stop()
        {
            Console.Clear();
            Console.WriteLine("Exit");
            Console.Beep();

        }
    }
}
