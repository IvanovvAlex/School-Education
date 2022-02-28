using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        private int attempts = 2;
        public Form1()
        {
            InitializeComponent();
        }

        private void btm_exit_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
        
        private void btn_login_Click(object sender, EventArgs e)
        {
            var username = textBoxUser.Text;
            var password = textBoxPass.Text;

            if (username == "admin" && password == "admin")
            {
                pictureBox1.Image = new Bitmap(@"C:\Users\HP\Desktop\Photos\approved.jfif");
                MessageBox.Show("Login successful!");
                this.Close();
            }
            else if (attempts != 0)
            {
                pictureBox1.Image = new Bitmap(@"C:\Users\HP\Desktop\Photos\denied.png");
                label3.Text = ($"{attempts} attempts left!");
                attempts--;
            }
            else
            {
                pictureBox1.Image = new Bitmap(@"C:\Users\HP\Desktop\Photos\zero.png");
                label3.Text = ($"{attempts} attempts left!");
                MessageBox.Show("No more attempts... Access denied!");
                this.Close();
            }
        }
    }
}
