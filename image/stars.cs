using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace image
{
    class stars
    {
        public static int R = 30;
        public static double k = R * Math.Sqrt(3) / 2;
        public static double k1 = R * Math.Sqrt(3) / 6;
        public static Point p1 = new Point(170, 150);
        public static Point p2 = new Point(200, 320);
        public static Point p3 = new Point(500, 150);
        public static Point p4 = new Point(400, 300);

        public Point[] points1 =
        {
            new Point(p1.X, p1.Y - R),
            new Point(p1.X + (int) k1, p1.Y - R / 2),
            new Point(p1.X + (int) k, p1.Y - R / 2),
            new Point(p1.X + 2*(int) k1, p1.Y),
            new Point(p1.X + (int) k, p1.Y + R / 2),
            new Point(p1.X + (int) k1, p1.Y + R / 2),
            new Point(p1.X, p1.Y + R),
            new Point(p1.X - (int) k1, p1.Y + R / 2),
            new Point(p1.X - (int) k, p1.Y + R / 2),
            new Point(p1.X - 2*(int) k1, p1.Y),
            new Point(p1.X - (int) k, p1.Y - R / 2),
            new Point(p1.X - (int) k1, p1.Y - R / 2)
        };

        public Point[] points2 =
        {
            new Point(p2.X, p2.Y - R),
            new Point(p2.X + (int) k1, p2.Y - R / 2),
            new Point(p2.X + (int) k, p2.Y - R / 2),
            new Point(p2.X + 2*(int) k1, p2.Y),
            new Point(p2.X + (int) k, p2.Y + R / 2),
            new Point(p2.X + (int) k1, p2.Y + R / 2),
            new Point(p2.X, p2.Y + R),
            new Point(p2.X - (int) k1, p2.Y + R / 2),
            new Point(p2.X - (int) k, p2.Y + R / 2),
            new Point(p2.X - 2*(int) k1, p2.Y),
            new Point(p2.X - (int) k, p2.Y - R / 2),
            new Point(p2.X - (int) k1, p2.Y - R / 2)
        };

        public Point[] points3 =
        {
            new Point(p3.X, p3.Y - R),
            new Point(p3.X + (int) k1, p3.Y - R / 2),
            new Point(p3.X + (int) k, p3.Y - R / 2),
            new Point(p3.X + 2*(int) k1, p3.Y),
            new Point(p3.X + (int) k, p3.Y + R / 2),
            new Point(p3.X + (int) k1, p3.Y + R / 2),
            new Point(p3.X, p3.Y + R),
            new Point(p3.X - (int) k1, p3.Y + R / 2),
            new Point(p3.X - (int) k, p3.Y + R / 2),
            new Point(p3.X - 2*(int) k1, p3.Y),
            new Point(p3.X - (int) k, p3.Y - R / 2),
            new Point(p3.X - (int) k1, p3.Y - R / 2)
        };

        public Point[] points4 =
        {
            new Point(p4.X, p4.Y - R),
            new Point(p4.X + (int) k1, p4.Y - R / 2),
            new Point(p4.X + (int) k, p4.Y - R / 2),
            new Point(p4.X + 2*(int) k1, p4.Y),
            new Point(p4.X + (int) k, p4.Y + R / 2),
            new Point(p4.X + (int) k1, p4.Y + R / 2),
            new Point(p4.X, p4.Y + R),
            new Point(p4.X - (int) k1, p4.Y + R / 2),
            new Point(p4.X - (int) k, p4.Y + R / 2),
            new Point(p4.X - 2*(int) k1, p4.Y),
            new Point(p4.X - (int) k, p4.Y - R / 2),
            new Point(p4.X - (int) k1, p4.Y - R / 2)
        };
    }
}
