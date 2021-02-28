using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeika_Csharp
{
    class Stenka
    {
        private int mapWidht;
        private int mapHeight;
        private char sym;

        Random random = new Random();

        public Stenka(int mapWidth, int mapHeight, char sym, ConsoleColor color_)
        {
            this.mapWidht = mapWidth;
            this.mapHeight = mapHeight;
            this.sym = sym;
            color_ = color_;

        }

        public Point CreateStenka()
        {
            int x = random.Next(2, mapWidht - 2);
            int y = random.Next(2, mapHeight - 2);
            return new Point(x, y, sym, ConsoleColor.Green);
        }
    }
}
