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

            Console.WriteLine("Start game - S\n-------------\nStop game - Q");
            key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.S)
            {
                valik = 1;
            }
            else if (key.Key == ConsoleKey.Q)
            {
                valik = 2;
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
