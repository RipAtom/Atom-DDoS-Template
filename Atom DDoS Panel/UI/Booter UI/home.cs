using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Booter_UI
{
    public partial class home : Form
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
        public home()
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

        private void home_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome: " + Properties.Settings.Default.user;

            WebClient client = new WebClient();
            string reply = client.DownloadString("https://pastebin.com/raw/uMcbUVCu");
            label2.Text = reply;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString("https://pastebin.com/raw/uMcbUVCu");
            label2.Text = reply;
        }

        private void guna2VSeparator2_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Process.Start("https://pastebin.com/raw/MGgjtdP6");
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (guna2CheckBox1.Checked == true)
            {
                guna2ProgressBar2.Value += 1;

                if (guna2ProgressBar2.Value == 100)
                {

                    guna2ProgressBar2.Value = 0;

                    WebClient client = new WebClient();
                    string reply = client.DownloadString("https://pastebin.com/raw/uMcbUVCu");
                    label2.Text = reply;
                }

              

            }
            
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString("https://pastebin.com/raw/uMcbUVCu");
            label2.Text = reply;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.checkbox = false;

            login form1 = new login();

            this.Hide();

            form1.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(guna2CheckBox1.Checked == false )
            {

                guna2ProgressBar2.Value = 0;


            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Atom#1337");
            Process.Start("https://discord.gg/zKEMfB3UQC");
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Official Panel Designer: Atom#1337");
            MessageBox.Show("Atom Launcher Owner: Atom#1337 ");

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            

            geo geo1 = new geo();

            this.Hide();

            geo1.Show();

                

           
            
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            attackhub attackhub1 = new attackhub();

            this.Hide();

            attackhub1.Show();
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            pinger pinger1 = new pinger();

            this.Hide();

            pinger1.Show();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            resolver resolver1 = new resolver();

            this.Hide();

            resolver1.Show();
        }

        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (guna2CheckBox1.Checked == false)
                {

                    guna2ProgressBar2.Value = 0;


                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            while(true)
            {
                if (guna2CheckBox1.Checked == true)
                {
                    guna2ProgressBar2.Value += 1;

                    if (guna2ProgressBar2.Value == 100)
                    {

                        guna2ProgressBar2.Value = 0;

                        WebClient client = new WebClient();
                        string reply = client.DownloadString("https://pastebin.com/raw/uMcbUVCu");
                        label2.Text = reply;
                    }


                }
            }
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Official UI Designer: Atom#1337");
            MessageBox.Show("Atom Launcher Owner: Atom#1337 ");
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Please contact Atom#1337, for further support and create a ticket!");
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            account account1 = new account();


            this.Hide();


            account1.Show();


            
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            otherpingerscs otherpingerscs1 = new otherpingerscs();

            this.Hide();

            otherpingerscs1.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\skate\source\repos\Booter UI\pScan.exe");
        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ProgressBar2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
