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
    public partial class account : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
int nLeftRect,     // x-coordinate of upper-left corner
int nTopRect,      // y-coordinate of upper-left corner
int nRightRect,    // x-coordinate of lower-right corner
int nBottomRect,   // y-coordinate of lower-right corner
int nWidthEllipse, // height of ellipse
int nHeightEllipse); // width of ellipse

        public account()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));


        }

    

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            

            if(guna2TextBox4.Text == "0" || guna2TextBox1.Text == "" || guna2TextBox1.Text == "" || guna2TextBox4.Text == "" )

                 
            {



                MessageBox.Show("Error");


            }
            else 
            {

                
                Properties.Settings.Default.user = guna2TextBox4.Text;

                Properties.Settings.Default.pass = guna2TextBox1.Text;

                Properties.Settings.Default.Save();










                MessageBox.Show("Saved Succesfully");

            }

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

           
            
               
        }

        private void account_Load(object sender, EventArgs e)
        {
           
        }
    }
}