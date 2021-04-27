using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booter_UI
{
    public partial class create : Form
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
        public create()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            login form1 = new login();

            this.Hide();

            form1.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {


            if (guna2TextBox3.Text == Properties.Settings.Default.user && guna2TextBox4.Text == Properties.Settings.Default.user)

            {


                MessageBox.Show("Nothing Changed");



            }

            else
            {
                if (Properties.Settings.Default.user == "0" || Properties.Settings.Default.user == "0")
                {

                    MessageBox.Show("Account Created Succesfully");

                }

                else
                {

                    MessageBox.Show("Username or Password was Changed");


                }


                Properties.Settings.Default.user = guna2TextBox3.Text;
                Properties.Settings.Default.pass = guna2TextBox4.Text;
                Properties.Settings.Default.Save();

                if (guna2CheckBox1.Checked == true)
                {


                    loading form2 = new loading();

                    this.Hide();

                    form2.Show();


                }
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
           
        }



        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
