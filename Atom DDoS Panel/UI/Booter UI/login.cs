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
    public partial class login : Form
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
        public login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));



        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

           


            guna2CheckBox1.Checked = Properties.Settings.Default.checkbox;
            
            if(guna2CheckBox1.Checked == true)
            {
                

                guna2TextBox4.Text = Properties.Settings.Default.user;

                guna2TextBox3.Text = Properties.Settings.Default.pass;


            }
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox4.Text == Properties.Settings.Default.user && guna2TextBox3.Text == Properties.Settings.Default.pass)
            {

                
            
                loading form2 = new loading();

                this.Show();

                form2.Show();
            


            }

        
            else
            {


                MessageBox.Show("Atom Launcher - You've entered an incorrect username or password.");
            }
           

        }
            


          
    

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

            

            if(guna2TextBox3.PasswordChar == '-')
            {
                guna2TextBox3.PasswordChar = '\0';

            }

            else
            {
                guna2TextBox3.PasswordChar = '-';



            }
        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_Enter(object sender, EventArgs e)
        {

            

        }

        private void guna2TextBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged_3(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2TextBox1_Enter_1(object sender, EventArgs e)
        {
            
        }

        

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            create form3 = new create();

            this.Show();

            form3.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.checkbox = guna2CheckBox1.Checked;
            Properties.Settings.Default.Save();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            loading form2 = new loading();

            this.Hide();

            form2.Show();
        }
    }
}
