using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometric_Transformation
{
    public partial class FormOf2d : Form
    {
        private double Dx=0 ,Dy=0;
        private double[,] Points = new double[3,2];
        private double[,] Translation;
        private double[] Scalling;
        private double[] Reflection;
        private double[] Shearing;
        private double angle;
        public FormOf2d()
        {
            InitializeComponent();
            chart1.Titles.Add("2D Geometric Transformation");
            Translation = new double[3,3]{ {1,0,Dx},{0,1,Dy},{0,0,1 } };
            Scalling = new double[2];
            Reflection = new double[2];
            Shearing = new double[2];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DrawButton1_Click(object sender, EventArgs e)
        {
            Points[0, 0] = Convert.ToDouble(X1.Text);
            Points[0, 1] = Convert.ToDouble(Y1.Text);
            Points[1, 0] = Convert.ToDouble(X2.Text);
            Points[1, 1] = Convert.ToDouble(Y2.Text);
            Points[2, 0] = Convert.ToDouble(X3.Text);
            Points[2, 1] = Convert.ToDouble(Y3.Text);
            for(int i =0; i<3;i++)
            {
                chart1.Series["Shape1"].Points.AddXY(Points[i, 0], Points[i, 1]);
            }
            chart1.Series["Shape1"].Points.AddXY(Points[0, 0], Points[0, 1]);

        }

        private void X1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Y1_TextChanged(object sender, EventArgs e)
        {

        }

        private void X2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Y2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series["TranslationShap"].Points.Clear();
            chart1.Series["ScalingShap"].Points.Clear();
            chart1.Series["RotationShap"].Points.Clear();
            chart1.Series["ReflictionShap"].Points.Clear();
            chart1.Series["ShearingShap"].Points.Clear();
            Tx.Text = "";
            Ty.Text = "";
            Sx.Text = "";
            Sy.Text = "";
            Angle.Text = "";
            ShearingX.Text = "";
            ShearingY.Text = "";


        }

        private void X3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Y3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series["Shape1"].Points.Clear();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void FinalDraw_Click(object sender, EventArgs e)
        {
            if(TranslationRa.Checked == true)
            {
                Translation[0,2] = Convert.ToDouble(Tx.Text);
                Translation[1,2] = Convert.ToDouble(Ty.Text);
                for(int i=0 ; i<3 ; i++)
                {
                    Points[i, 0] += Translation[0, 2];
                    Points[i, 1] += Translation[1, 2];
                    chart1.Series["TranslationShap"].Points.AddXY(Points[i, 0], Points[i, 1]);
                }
                chart1.Series["TranslationShap"].Points.AddXY(Points[0,0], Points[0, 1]);
            }
            if (ScallingRa.Checked == true)
            {
                Scalling[0] = Convert.ToDouble(Sx.Text);
                Scalling[1] = Convert.ToDouble(Sy.Text);
                for (int i = 0; i < 3; i++)
                {
                    Points[i, 0] *= Scalling[0];
                    Points[i, 1] *= Scalling[1];
                    chart1.Series["ScalingShap"].Points.AddXY(Points[i, 0], Points[i, 1]);
                }
                chart1.Series["ScalingShap"].Points.AddXY(Points[0, 0], Points[0, 1]);
            }
            if (RotationRa.Checked == true)
            {
                angle = Convert.ToDouble(Angle.Text);
                for (int i = 0; i < 3; i++)
                {
                    double x = Points[i, 0] ;
                    double y = Points[i, 1] ;
                    x = Points[i, 0] * Math.Cos(angle) - Points[i, 1] * Math.Sin(angle);
                    y = Points[i, 0] * Math.Sin(angle) + Points[i, 1] * Math.Cos(angle);
                    chart1.Series["RotationShap"].Points.AddXY(x, y);
                    Points[i, 0] = x;
                    Points[i, 1] = y;
                }
                chart1.Series["RotationShap"].Points.AddXY(Points[0, 0], Points[0, 1]);
            }
            if (ReflectioRa.Checked == true)
            {
                Reflection[0] = Convert.ToDouble(RefX.Text);
                Reflection[1] = Convert.ToDouble(RefY.Text);
                for (int i = 0; i < 3; i++)
                {
                    Points[i, 0] *= Reflection[0];
                    Points[i, 1] *= Reflection[1];
                    chart1.Series["ReflictionShap"].Points.AddXY(Points[i, 0], Points[i, 1]);
                }
                chart1.Series["ReflictionShap"].Points.AddXY(Points[0, 0], Points[0, 1]);
            }
            if (ShearingRa.Checked == true)
            {
                Shearing[0] = Convert.ToDouble(ShearingX.Text);
                Shearing[1] = Convert.ToDouble(ShearingY.Text);
                for (int i = 0; i < 3; i++)
                {
                    Points[i, 0] += Shearing[0]* Points[i, 1];
                    Points[i, 1] += Shearing[1]* Points[i, 0];
                    chart1.Series["ShearingShap"].Points.AddXY(Points[i, 0], Points[i, 1]);
                }
                chart1.Series["ShearingShap"].Points.AddXY(Points[0, 0], Points[0, 1]);
            }
        }
    }
}


//ShearingShap