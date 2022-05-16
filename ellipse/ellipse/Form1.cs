using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ellipse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void EllipsPoint(int xc, int yc, int x, int y)
        {
            var aBrush = Brushes.Black;
            var g = panel1.CreateGraphics();
            g.FillRectangle(aBrush, (xc + x), (yc + y), 1, 1);
            g.FillRectangle(aBrush, (xc - x), (yc + y), 1, 1);
            g.FillRectangle(aBrush, (xc + x), (yc - y), 1, 1);
            g.FillRectangle(aBrush, (xc - x), (yc - y), 1, 1);
        }

        private void DrawEllipse(int xc, int yc, int rx, int ry)
        {
            double x = 0;
            double y = ry;
            double pk = (ry * ry) - (rx * rx * ry) + (0.25 * rx * rx);
            EllipsPoint(xc, yc, (int) x, (int) y);
            Debug.WriteLine("first one");
            Debug.WriteLine("x=" + x + "\t" + "y=" + y + "\t" + "pk="+pk);
            
            while ((ry * ry * x) < (rx * rx * y))
            {
                x++;
                if (pk < 0)
                {
                    pk += (2 * ry * ry * x) + (ry * ry);
                }
                else
                {
                    y--;
                    pk += (2 * ry * ry * x) + (ry * ry) - (2 * rx * rx * y);
                }
                EllipsPoint(xc, yc, (int)x, (int)y);
                Debug.WriteLine("x=" + x + "\t" + "y=" + y + "\t" + "pk=" + pk);
            }
            Debug.WriteLine("second one");
            pk = (((ry * ry) * ((x + 0.5) * (x + 0.5))) + ((rx * rx) * ((y - 1) * (y - 1))) - (rx * rx * ry * ry));
            Debug.WriteLine("x=" + x + "\t" + "y=" + y + "\t" + "pk=" + pk);
            while (y > 0)
            {
                y--;
                if (pk > 0)
                {
                    pk += (rx * rx) - (2 * rx * rx * y);
                }
                else
                {
                    x++;
                    pk += (rx * rx) - (2 * rx * rx * y) + (2 * ry * ry * x);
                }
                EllipsPoint(xc, yc, (int)x, (int)y);
                Debug.WriteLine("x=" + x + "\t" + "y=" + y + "\t" + "pk=" + pk);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x_center = Convert.ToInt32(textBox1.Text);
                int y_center = Convert.ToInt32(textBox2.Text);
                int rx = Convert.ToInt32(textBox4.Text);
                int ry = Convert.ToInt32(textBox3.Text);
                DrawEllipse(x_center, y_center, rx, ry);
            }
            catch (Exception)
            {
                MessageBox.Show("You did't enter all text boxs or you didn't enter an int numbers");
            }
        }
    }
}
