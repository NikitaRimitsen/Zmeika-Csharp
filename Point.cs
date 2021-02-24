using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeika_Csharp
{
    class Point
    {
        public int x;
        public int y;
        public char sym;
        public ConsoleColor color;

        public Point()
        {
        }


        public Point(int _x, int _y, char _sym, ConsoleColor color_)
        {
            x = _x;
            y = _y;
            sym = _sym;
            color = color_;

        }

        public Point(Point p, ConsoleColor color_)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
            color = color_;
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if (direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direction.UP)
            {
                y = y - offset;
            }
            else if (direction == Direction.DOWN)
            {
                y = y + offset;
            }
        }

        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);// выводит на экран(кординаты x1 и y1)(выводит точку на экране)
            Console.ForegroundColor = color;
            Console.Write(sym);
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }

    }
}
