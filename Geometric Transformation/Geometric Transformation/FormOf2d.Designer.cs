
namespace Geometric_Transformation
{
    partial class FormOf2d
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.X1 = new System.Windows.Forms.TextBox();
            this.Y1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.X2 = new System.Windows.Forms.TextBox();
            this.Y2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.X3 = new System.Windows.Forms.TextBox();
            this.Y3 = new System.Windows.Forms.TextBox();
            this.DrawButton1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TranslationRa = new System.Windows.Forms.RadioButton();
            this.ScallingRa = new System.Windows.Forms.RadioButton();
            this.RotationRa = new System.Windows.Forms.RadioButton();
            this.ReflectioRa = new System.Windows.Forms.RadioButton();
            this.ShearingRa = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Tx = new System.Windows.Forms.TextBox();
            this.Ty = new System.Windows.Forms.TextBox();
            this.FinalDraw = new System.Windows.Forms.Button();
            this.FinalClear = new System.Windows.Forms.Button();
            this.Sx = new System.Windows.Forms.TextBox();
            this.Sy = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Angle = new System.Windows.Forms.TextBox();
            this.RefX = new System.Windows.Forms.TextBox();
            this.RefY = new System.Windows.Forms.TextBox();
            this.ShearingX = new System.Windows.Forms.TextBox();
            this.ShearingY = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "We works on triangle";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.Window;
            chartArea1.BorderWidth = 10;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(222, 77);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.MarkerSize = 50;
            series1.Name = "Shape1";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "TranslationShap";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "ScalingShap";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "RotationShap";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "ReflictionShap";
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "ShearingShap";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(850, 494);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Point 1";
            // 
            // X1
            // 
            this.X1.Location = new System.Drawing.Point(93, 98);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(29, 22);
            this.X1.TabIndex = 3;
            this.X1.TextChanged += new System.EventHandler(this.X1_TextChanged);
            // 
            // Y1
            // 
            this.Y1.Location = new System.Drawing.Point(147, 97);
            this.Y1.Name = "Y1";
            this.Y1.Size = new System.Drawing.Size(29, 22);
            this.Y1.TabIndex = 3;
            this.Y1.TextChanged += new System.EventHandler(this.Y1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Y";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Point 2";
            // 
            // X2
            // 
            this.X2.Location = new System.Drawing.Point(93, 132);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(29, 22);
            this.X2.TabIndex = 3;
            this.X2.TextChanged += new System.EventHandler(this.X2_TextChanged);
            // 
            // Y2
            // 
            this.Y2.Location = new System.Drawing.Point(147, 131);
            this.Y2.Name = "Y2";
            this.Y2.Size = new System.Drawing.Size(29, 22);
            this.Y2.TabIndex = 3;
            this.Y2.TextChanged += new System.EventHandler(this.Y2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Point 3";
            // 
            // X3
            // 
            this.X3.Location = new System.Drawing.Point(93, 165);
            this.X3.Name = "X3";
            this.X3.Size = new System.Drawing.Size(29, 22);
            this.X3.TabIndex = 3;
            this.X3.TextChanged += new System.EventHandler(this.X3_TextChanged);
            // 
            // Y3
            // 
            this.Y3.Location = new System.Drawing.Point(147, 164);
            this.Y3.Name = "Y3";
            this.Y3.Size = new System.Drawing.Size(29, 22);
            this.Y3.TabIndex = 3;
            this.Y3.TextChanged += new System.EventHandler(this.Y3_TextChanged);
            // 
            // DrawButton1
            // 
            this.DrawButton1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DrawButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DrawButton1.Location = new System.Drawing.Point(16, 202);
            this.DrawButton1.Name = "DrawButton1";
            this.DrawButton1.Size = new System.Drawing.Size(75, 27);
            this.DrawButton1.TabIndex = 4;
            this.DrawButton1.Text = "Draw";
            this.DrawButton1.UseVisualStyleBackColor = false;
            this.DrawButton1.Click += new System.EventHandler(this.DrawButton1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Choose Your operations";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // TranslationRa
            // 
            this.TranslationRa.AutoSize = true;
            this.TranslationRa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TranslationRa.Location = new System.Drawing.Point(9, 307);
            this.TranslationRa.Name = "TranslationRa";
            this.TranslationRa.Size = new System.Drawing.Size(113, 22);
            this.TranslationRa.TabIndex = 6;
            this.TranslationRa.TabStop = true;
            this.TranslationRa.Text = "Translation";
            this.TranslationRa.UseVisualStyleBackColor = true;
            // 
            // ScallingRa
            // 
            this.ScallingRa.AutoSize = true;
            this.ScallingRa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScallingRa.Location = new System.Drawing.Point(9, 352);
            this.ScallingRa.Name = "ScallingRa";
            this.ScallingRa.Size = new System.Drawing.Size(84, 22);
            this.ScallingRa.TabIndex = 6;
            this.ScallingRa.TabStop = true;
            this.ScallingRa.Text = "Scaling";
            this.ScallingRa.UseVisualStyleBackColor = true;
            // 
            // RotationRa
            // 
            this.RotationRa.AutoSize = true;
            this.RotationRa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RotationRa.Location = new System.Drawing.Point(9, 510);
            this.RotationRa.Name = "RotationRa";
            this.RotationRa.Size = new System.Drawing.Size(93, 22);
            this.RotationRa.TabIndex = 6;
            this.RotationRa.TabStop = true;
            this.RotationRa.Text = "Rotation";
            this.RotationRa.UseVisualStyleBackColor = true;
            // 
            // ReflectioRa
            // 
            this.ReflectioRa.AutoSize = true;
            this.ReflectioRa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReflectioRa.Location = new System.Drawing.Point(9, 395);
            this.ReflectioRa.Name = "ReflectioRa";
            this.ReflectioRa.Size = new System.Drawing.Size(105, 22);
            this.ReflectioRa.TabIndex = 6;
            this.ReflectioRa.TabStop = true;
            this.ReflectioRa.Text = "Reflection";
            this.ReflectioRa.UseVisualStyleBackColor = true;
            // 
            // ShearingRa
            // 
            this.ShearingRa.AutoSize = true;
            this.ShearingRa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShearingRa.Location = new System.Drawing.Point(9, 442);
            this.ShearingRa.Name = "ShearingRa";
            this.ShearingRa.Size = new System.Drawing.Size(95, 22);
            this.ShearingRa.TabIndex = 6;
            this.ShearingRa.TabStop = true;
            this.ShearingRa.Text = "Shearing";
            this.ShearingRa.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(137, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 22);
            this.label8.TabIndex = 2;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.label3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(183, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 22);
            this.label9.TabIndex = 2;
            this.label9.Text = "Y";
            this.label9.Click += new System.EventHandler(this.label3_Click);
            // 
            // Tx
            // 
            this.Tx.Location = new System.Drawing.Point(134, 308);
            this.Tx.Name = "Tx";
            this.Tx.Size = new System.Drawing.Size(29, 22);
            this.Tx.TabIndex = 3;
            this.Tx.TextChanged += new System.EventHandler(this.X1_TextChanged);
            // 
            // Ty
            // 
            this.Ty.Location = new System.Drawing.Point(180, 308);
            this.Ty.Name = "Ty";
            this.Ty.Size = new System.Drawing.Size(29, 22);
            this.Ty.TabIndex = 3;
            this.Ty.TextChanged += new System.EventHandler(this.Y1_TextChanged);
            // 
            // FinalDraw
            // 
            this.FinalDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalDraw.Location = new System.Drawing.Point(254, 602);
            this.FinalDraw.Name = "FinalDraw";
            this.FinalDraw.Size = new System.Drawing.Size(87, 40);
            this.FinalDraw.TabIndex = 7;
            this.FinalDraw.Text = "Draw";
            this.FinalDraw.UseVisualStyleBackColor = true;
            this.FinalDraw.Click += new System.EventHandler(this.FinalDraw_Click);
            // 
            // FinalClear
            // 
            this.FinalClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalClear.Location = new System.Drawing.Point(382, 602);
            this.FinalClear.Name = "FinalClear";
            this.FinalClear.Size = new System.Drawing.Size(89, 40);
            this.FinalClear.TabIndex = 8;
            this.FinalClear.Text = "Clear";
            this.FinalClear.UseVisualStyleBackColor = true;
            this.FinalClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // Sx
            // 
            this.Sx.Location = new System.Drawing.Point(134, 352);
            this.Sx.Name = "Sx";
            this.Sx.Size = new System.Drawing.Size(29, 22);
            this.Sx.TabIndex = 3;
            this.Sx.TextChanged += new System.EventHandler(this.X1_TextChanged);
            // 
            // Sy
            // 
            this.Sy.Location = new System.Drawing.Point(180, 352);
            this.Sy.Name = "Sy";
            this.Sy.Size = new System.Drawing.Size(29, 22);
            this.Sy.TabIndex = 3;
            this.Sy.TextChanged += new System.EventHandler(this.Y1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(139, 488);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 19);
            this.label10.TabIndex = 2;
            this.label10.Text = "Angle";
            this.label10.Click += new System.EventHandler(this.label3_Click);
            // 
            // Angle
            // 
            this.Angle.Location = new System.Drawing.Point(141, 511);
            this.Angle.Name = "Angle";
            this.Angle.Size = new System.Drawing.Size(46, 22);
            this.Angle.TabIndex = 3;
            this.Angle.TextChanged += new System.EventHandler(this.X1_TextChanged);
            // 
            // RefX
            // 
            this.RefX.Location = new System.Drawing.Point(134, 395);
            this.RefX.Name = "RefX";
            this.RefX.Size = new System.Drawing.Size(29, 22);
            this.RefX.TabIndex = 3;
            this.RefX.TextChanged += new System.EventHandler(this.X1_TextChanged);
            // 
            // RefY
            // 
            this.RefY.Location = new System.Drawing.Point(180, 395);
            this.RefY.Name = "RefY";
            this.RefY.Size = new System.Drawing.Size(29, 22);
            this.RefY.TabIndex = 3;
            this.RefY.TextChanged += new System.EventHandler(this.Y1_TextChanged);
            // 
            // ShearingX
            // 
            this.ShearingX.Location = new System.Drawing.Point(134, 442);
            this.ShearingX.Name = "ShearingX";
            this.ShearingX.Size = new System.Drawing.Size(29, 22);
            this.ShearingX.TabIndex = 3;
            this.ShearingX.TextChanged += new System.EventHandler(this.X1_TextChanged);
            // 
            // ShearingY
            // 
            this.ShearingY.Location = new System.Drawing.Point(180, 442);
            this.ShearingY.Name = "ShearingY";
            this.ShearingY.Size = new System.Drawing.Size(29, 22);
            this.ShearingY.TabIndex = 3;
            this.ShearingY.TextChanged += new System.EventHandler(this.Y1_TextChanged);
            // 
            // FormOf2d
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1084, 668);
            this.Controls.Add(this.FinalClear);
            this.Controls.Add(this.FinalDraw);
            this.Controls.Add(this.ShearingRa);
            this.Controls.Add(this.ReflectioRa);
            this.Controls.Add(this.ScallingRa);
            this.Controls.Add(this.RotationRa);
            this.Controls.Add(this.TranslationRa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DrawButton1);
            this.Controls.Add(this.Y3);
            this.Controls.Add(this.Y2);
            this.Controls.Add(this.ShearingY);
            this.Controls.Add(this.RefY);
            this.Controls.Add(this.Sy);
            this.Controls.Add(this.Ty);
            this.Controls.Add(this.Y1);
            this.Controls.Add(this.ShearingX);
            this.Controls.Add(this.X3);
            this.Controls.Add(this.RefX);
            this.Controls.Add(this.X2);
            this.Controls.Add(this.Sx);
            this.Controls.Add(this.Angle);
            this.Controls.Add(this.Tx);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.X1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.Name = "FormOf2d";
            this.Text = "FormOf2d";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox X1;
        private System.Windows.Forms.TextBox Y1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox X2;
        private System.Windows.Forms.TextBox Y2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox X3;
        private System.Windows.Forms.TextBox Y3;
        private System.Windows.Forms.Button DrawButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton TranslationRa;
        private System.Windows.Forms.RadioButton ScallingRa;
        private System.Windows.Forms.RadioButton RotationRa;
        private System.Windows.Forms.RadioButton ReflectioRa;
        private System.Windows.Forms.RadioButton ShearingRa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Tx;
        private System.Windows.Forms.TextBox Ty;
        private System.Windows.Forms.Button FinalDraw;
        private System.Windows.Forms.Button FinalClear;
        private System.Windows.Forms.TextBox Sx;
        private System.Windows.Forms.TextBox Sy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Angle;
        private System.Windows.Forms.TextBox RefX;
        private System.Windows.Forms.TextBox RefY;
        private System.Windows.Forms.TextBox ShearingX;
        private System.Windows.Forms.TextBox ShearingY;
    }
}