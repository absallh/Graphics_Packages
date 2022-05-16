using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BresenHam
{
    public partial class Form1 : Form
    {

        static int GetOctant(int x1, int y1, int x2, int y2)
        {
            // check slope 
            float slope = (float)(y2 - y1) / (x2 - x1);
            Console.WriteLine("slope is " + slope);

            int Octant;
            // get the Octant
            if (slope >= 0) // 1st , 2nd , 5th , 6th
            {
                if (slope <= 1) //1st , 5th
                {
                    if (x1 < x2) Octant = 1;
                    else Octant = 5;
                }
                else // 2nd , 6th
                {
                    if (y1 < y2) Octant = 2;
                    else Octant = 6;
                }
            }
            else // 3rd , 4th , 7th , 8th
            {
                if (slope < -1) //3rd , 7th
                {
                    if (y1 < y2) Octant = 3;
                    else Octant = 7;
                }
                else // 4th , 8th
                {
                    if (x1 > x2) Octant = 4;
                    else Octant = 8;
                }
            }
            return Octant;
        }
        static int[] Swap(int x, int y)
        {
            int[] temp = new int[2];
            temp[0] = y;
            temp[1] = x;
            return temp;
        }

            public Form1()
        {
            InitializeComponent();
            chart1.Titles.Add("DDA and Bresenham's line algorith");
  
            //chart1.Series["P1"].Points.AddXY("-10", "-10");
            //chart1.Series["P1"].Points.AddXY("0", "0");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(X1.Text);
            int y1 = Convert.ToInt32(Y1.Text);
            int x2 = Convert.ToInt32(X2.Text);
            int y2 = Convert.ToInt32(Y2.Text);
            if (radioButton1.Checked == true)
            {
                int Octant = GetOctant(x1, y1, x2, y2);
                Console.WriteLine("Octant is " + Octant);

                // Get dx, dy, p0
                int dx, dy, p0, Dc, Xk, Yk, Pk;
                switch (Octant)
                {
                    case 1: //Without Changes
                        dx = x2 - x1;
                        dy = y2 - y1;
                        p0 = 2 * dy - dx;
                        Dc = 2 * dy - 2 * dx;
                        Xk = x1; Yk = y1; Pk = p0;
                        while ((Xk != x2))
                        {
                            chart1.Series["Bresenham"].Points.AddXY(Xk, Yk);
                            if (Pk > 0)
                            { Xk++; Yk++; Pk += Dc; }
                            else
                            { Xk++; Pk += 2 * dy; }
                            Console.WriteLine("(" + Xk + "," + Yk + ")");
                        }
                        break;
                    case 2://Swap(x1,y1) & Swap(x2,y2)
                        int[] Point1 = Swap(x1, y1);
                        int[] Point2 = Swap(x2, y2);
                        x1 = Point1[0]; y1 = Point1[1];
                        x2 = Point2[0]; y2 = Point2[1];
                        dx = x2 - x1;
                        dy = y2 - y1;
                        p0 = 2 * dy - dx;
                        Dc = 2 * dy - 2 * dx;
                        Xk = x1; Yk = y1; Pk = p0;
                        while ((Xk != x2))
                        {
                            chart1.Series["Bresenham"].Points.AddXY(Yk, Xk);
                            if (Pk > 0)
                            { Xk++; Yk++; Pk += Dc; }
                            else
                            { Xk++; Pk += 2 * dy; }
                            Console.WriteLine("(" + Xk + "," + Yk + ")"); 
                        }
                        break;

                    case 3://Swap(x1,y1) , Swap(x2,y2) , Set dy = -dy & Dectrment Y
                        Point1 = Swap(x1, y1);
                        Point2 = Swap(x2, y2);
                        x1 = Point1[0]; y1 = Point1[1];
                        x2 = Point2[0]; y2 = Point2[1];
                        dx = x2 - x1;
                        dy = (y2 - y1) * (-1);
                        p0 = 2 * dy - dx;
                        Dc = 2 * dy - 2 * dx;
                        Xk = x1; Yk = y1; Pk = p0;
                        while ((Xk != x2))
                        {
                            chart1.Series["Bresenham"].Points.AddXY(Yk, Xk);
                            if (Pk > 0)
                            { Xk++; Yk--; Pk += Dc; }
                            else
                            { Xk++; Pk += 2 * dy; }
                            Console.WriteLine("(" + Xk + "," + Yk + ")");
                        }
                        break;
                    case 4://Set dx = -dx & Decrement X
                        dx = (x2 - x1) * (-1);
                        dy = y2 - y1;
                        p0 = 2 * dy - dx;
                        Dc = 2 * dy - 2 * dx;
                        Xk = x1; Yk = y1; Pk = p0;
                        while ((Xk != x2))
                        {
                            chart1.Series["Bresenham"].Points.AddXY(Xk, Yk);
                            if (Pk > 0)
                            { Xk--; Yk++; Pk += Dc; }
                            else
                            { Xk--; Pk += 2 * dy; }
                            Console.WriteLine("(" + Xk + "," + Yk + ")");
                        }
                        break;
                    case 5://Set dx = -dx , Set dy = -dy , Decrement x & Decrement y
                        dx = (x2 - x1) * (-1);
                        dy = (y2 - y1) * (-1);
                        p0 = 2 * dy - dx;
                        Dc = 2 * dy - 2 * dx;
                        Xk = x1; Yk = y1; Pk = p0;
                        while ((Xk != x2))
                        {
                            chart1.Series["Bresenham"].Points.AddXY(Xk, Yk);
                            if (Pk > 0)
                            { Xk--; Yk--; Pk += Dc; }
                            else
                            { Xk--; Pk += 2 * dy; }
                            Console.WriteLine("(" + Xk + "," + Yk + ")");
                        }
                        break;
                    case 6://Swap(x1,y1) , Swap(x2,y2) , Set dx = -dx , Set dy = -dy , Dectrment x & Dectrment Y
                        Point1 = Swap(x1, y1);
                        Point2 = Swap(x2, y2);
                        x1 = Point1[0]; y1 = Point1[1];
                        x2 = Point2[0]; y2 = Point2[1];
                        dx = (x2 - x1) * (-1);
                        dy = (y2 - y1) * (-1);
                        p0 = 2 * dy - dx;
                        Dc = 2 * dy - 2 * dx;
                        Xk = x1; Yk = y1; Pk = p0;
                        while ((Xk != x2))
                        {
                            chart1.Series["Bresenham"].Points.AddXY(Yk, Xk);
                            if (Pk > 0)
                            { Xk--; Yk--; Pk += Dc; }
                            else
                            { Xk--; Pk += 2 * dy; }
                            Console.WriteLine("(" + Xk + "," + Yk + ")");
                        }
                        break;
                    case 7://Swap(x1,y1) , Swap(x2,y2) , Set dx = -dx & Dectrment x 
                        Point1 = Swap(x1, y1);
                        Point2 = Swap(x2, y2);
                        x1 = Point1[0]; y1 = Point1[1];
                        x2 = Point2[0]; y2 = Point2[1];
                        dx = (x2 - x1) * (-1);
                        dy = y2 - y1;
                        p0 = 2 * dy - dx;
                        Dc = 2 * dy - 2 * dx;
                        Xk = x1; Yk = y1; Pk = p0;
                        while ((Xk != x2))
                        {
                            chart1.Series["Bresenham"].Points.AddXY(Yk, Xk);
                            if (Pk > 0)
                            { Xk--; Yk++; Pk += Dc; }
                            else
                            { Xk--; Pk += 2 * dy; }
                            Console.WriteLine("(" + Xk + "," + Yk + ")");
                        }
                        break;
                    case 8://Set dy = -dy & Dectrment Y
                        dx = x2 - x1;
                        dy = (y2 - y1) * (-1);
                        p0 = 2 * dy - dx;
                        Dc = 2 * dy - 2 * dx;
                        Xk = x1; Yk = y1; Pk = p0;
                        while ((Xk != x2))
                        {
                            chart1.Series["Bresenham"].Points.AddXY(Xk, Yk);
                            if (Pk > 0)
                            { Xk++; Yk--; Pk += Dc; }
                            else
                            { Xk++; Pk += 2 * dy; }
                            Console.WriteLine("(" + Xk + "," + Yk + ")");
                        }
                        break;
                }
            }
            if(radioButton2.Checked == true)
            {
                int dx = x2 - x1, dy = y2 - y1, steps;
                float x_increment, y_increment, x = x1, y = y1;

                steps = Math.Max(Math.Abs(dx), Math.Abs(dy));

                x_increment = (float)dx / (float)steps;
                y_increment = (float)dy / (float)steps;
                chart1.Series["DDA"].Points.AddXY((int)Math.Round(x), (int)Math.Round(y));
                for (int k = 0; k < steps; k++)
                {
                    x += x_increment;
                    y += y_increment;
                    chart1.Series["DDA"].Points.AddXY((int)Math.Round(x), (int)Math.Round(y));
                }
            }

            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true) chart1.Series["Bresenham"].Points.Clear();
            if (radioButton2.Checked == true) chart1.Series["DDA"].Points.Clear();
        }
    }
}
