using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Booter_UI
{
    public partial class attackhub : Form
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
        public attackhub()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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
            home home1 = new home();

            this.Hide();

            home1.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (guna2TextBox4.Text != "")
            {






               

                Properties.Settings.Default.ping = guna2TextBox4.Text;
                Properties.Settings.Default.Save();

                ProcessStartInfo ps = new ProcessStartInfo();

                ps.FileName = "cmd.exe";
                ps.WindowStyle = ProcessWindowStyle.Normal;
                ps.Arguments = @"/k color b";
                ps.Arguments = @"/k ping " + Properties.Settings.Default.ping + " -t";
                Process.Start(ps);

            }

            else
            {


                MessageBox.Show("Please Insert a Target to Ping");


            }


        }

        private void attackhub_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
