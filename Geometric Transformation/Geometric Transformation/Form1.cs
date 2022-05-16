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
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Random ra;
        private int tempIndex;
        private Form activeForm;
        public Form1()
        {
            InitializeComponent();
            ra = new Random();
        }
        private Color SelectThemeColor()
        {
            int index = ra.Next(ThemeColor.ColorList.Count);
            while(tempIndex == index)
            {
                index = ra.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActiveButton (object btnSender)
        {
            if(btnSender !=null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    
                }
            }
        }
        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType()==typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.White;
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm !=null)
            {
                activeForm.Close();
            }
            ActiveButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            this.panelDesktopPage.Controls.Add(childForm);
            this.panelDesktopPage.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormOf2d() , sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormOf3d(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActiveButton(sender); 
            if (activeForm != null)
                activeForm.Close();
        }
    }
}
