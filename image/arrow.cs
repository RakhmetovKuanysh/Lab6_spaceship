using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace image
{
    class arrow
    {
        public static int R = 50;
        public static Point ctr = new Point(300, 200);
        public Point[] points =
        {
            new Point (ctr.X,ctr.Y - R / 2),
            new Point (ctr.X + 20,ctr.Y),
            new Point (ctr.X + 10,ctr.Y),
            new Point (ctr.X + 10,ctr.Y + R / 2),
            new Point (ctr.X - 10,ctr.Y + R / 2),
            new Point (ctr.X - 10,ctr.Y),
            new Point (ctr.X - 20,ctr.Y)
        };
    }
}
