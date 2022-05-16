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

namespace circle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void circlePoint(int xc, int yc, int x, int y)
        {
            var aBrush = Brushes.Black;
            var g = panel1.CreateGraphics();
            g.FillRectangle(aBrush, (xc+x), (yc+y), 1, 1);
            g.FillRectangle(aBrush, (xc-x), (yc+y), 1, 1);
            g.FillRectangle(aBrush, (xc+x), (yc-y), 1, 1);
            g.FillRectangle(aBrush, (xc-x), (yc-y), 1, 1);
            g.FillRectangle(aBrush, (xc+y), (yc+x), 1, 1);
            g.FillRectangle(aBrush, (xc-y), (yc+x), 1, 1);
            g.FillRectangle(aBrush, (xc+y), (yc-x), 1, 1);
            g.FillRectangle(aBrush, (xc-y), (yc-x), 1, 1);
        }

        private void Circle_draw (int r, int xc, int yc)
        {
            int x = 0;
            int y = r;
            double pk = (1.25 - r);
            circlePoint(xc, yc, x, y);
            Debug.WriteLine("x=" + x + "\t" + "y=" + y + "\t" + "pk=" + pk);
            while (x < y)
            {
                if(pk < 0)
                {
                    x++;
                    pk = pk + (2 * x) + 1;
                }
                else
                {
                    x++;
                    y--;
                    pk = pk + (2 * x) + 1 - (2 * y);
                }
                circlePoint(xc, yc, x, y);
                Debug.WriteLine("x=" + x + "\t" + "y=" + y + "\t" + "pk="+pk);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x_center = Convert.ToInt32(textBox1.Text);
                int y_center = Convert.ToInt32(textBox2.Text);
                int r = Convert.ToInt32(textBox3.Text);
                Circle_draw(r, x_center, y_center);
            }
            catch (Exception ex)
            {
                MessageBox.Show("You did't enter all text boxs or you didn't enter an int numbers");
            }
        }
    }
}
