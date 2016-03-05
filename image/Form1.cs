using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace image
{
    public partial class Form1 : Form
    {
        circles c = new circles();
        spaceship sp = new spaceship();
        arrow ar = new arrow();
        stars st = new stars();

        SolidBrush black = new SolidBrush(Color.Black);
        SolidBrush blue = new SolidBrush(Color.RoyalBlue);
        SolidBrush yellow = new SolidBrush(Color.Yellow);
        SolidBrush green = new SolidBrush(Color.ForestGreen);
        SolidBrush red = new SolidBrush(Color.Red);

        Rectangle rect1 = new Rectangle(0, 0, 627, 418);
        Rectangle rect2 = new Rectangle(10, 10, 607, 398);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(black, rect1);
            e.Graphics.FillRectangle(blue, rect2);

            e.Graphics.FillPolygon(yellow, sp.points);
            e.Graphics.FillPolygon(green, ar.points);
            e.Graphics.FillPolygon(red, st.points1);
            e.Graphics.FillPolygon(red, st.points2);
            e.Graphics.FillPolygon(red, st.points3);
            e.Graphics.FillPolygon(red, st.points4);

            e.Graphics.FillEllipse(c.circle, 30, 50, c.r, c.r);
            e.Graphics.FillEllipse(c.circle, 40, 270, c.r, c.r);
            e.Graphics.FillEllipse(c.circle, 200, 30, c.r, c.r);
            e.Graphics.FillEllipse(c.circle, 200, 250, c.r, c.r);
            e.Graphics.FillEllipse(c.circle, 350, 70, c.r, c.r);
            e.Graphics.FillEllipse(c.circle, 450, 200, c.r, c.r);
            e.Graphics.FillEllipse(c.circle, 530, 150, c.r, c.r);
            e.Graphics.FillEllipse(c.circle, 530, 350, c.r, c.r);

            e.Graphics.FillEllipse(green, 250, 150, 10, 20);
            e.Graphics.FillEllipse(green, 245, 155, 20, 10);
            
        }
    }
}
