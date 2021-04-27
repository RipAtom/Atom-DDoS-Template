using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace Booter_UI
{
    public partial class loading : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
int nLeftRect,     // x-coordinate of upper-left corner
int nTopRect,      // y-coordinate of upper-left corner
int nRightRect,    // x-coordinate of lower-right corner
int nBottomRect,   // y-coordinate of lower-right corner
int nWidthEllipse, // height of ellipse
int nHeightEllipse // width of ellipse
);
        public loading()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            guna2ProgressBar2.Value += 1;



            if (guna2ProgressBar2.Value == 100)
            {
                timer1.Stop();

                home home1 = new home();


                this.Hide();

                home1.Show();
            }
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UI Designer: gilbert#7071");
            MessageBox.Show("Panel Owner : {Your Name}");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
