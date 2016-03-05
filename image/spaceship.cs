using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace image
{
    class spaceship
    {
        public static int R = 50;
        public static double k = R * Math.Sqrt(3) / 2;
        public static Point ctr = new Point(300, 200);
        public Point[] points =
        {
            new Point(ctr.X, ctr.Y - R),
            new Point(ctr.X + (int) k, ctr.Y - R / 2),
            new Point(ctr.X + (int) k, ctr.Y + R / 2),
            new Point(ctr.X, ctr.Y + R),
            new Point(ctr.X - (int) k, ctr.Y + R / 2),
            new Point(ctr.X - (int) k, ctr.Y - R / 2)
        };
        //public Point[] points =
        //{
        //    new Point(300, 150),
        //    new Point(343, 175),
        //    new Point(343, 225),
        //    new Point(300, 250),
        //    new Point(257, 225),
        //    new Point(257, 175)
        //};
    }
}
