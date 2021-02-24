using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeika_Csharp
{
    class HorizontalLine : Figure
    {

        public HorizontalLine(int xLeft, int xReight, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xLeft; x < xReight; x++)
            {
                Point p = new Point(x, y, sym, ConsoleColor.White);
                pList.Add(p);
            }
        }

    }
}
