using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _140421
{
    public partial class Form1 : Form
    {
        private TextBox nTextBox = null;        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var txtBox1 = new TextBox();
          
            txtBox1.Location = new Point(145, 110);           
            Controls.Add(txtBox1);            
            nTextBox = txtBox1;             
        }
      

        private void label1_Click(object sender, EventArgs e)
        {
        
        }
        
        private void resultLabel_Click(object sender, EventArgs e)
        {
        
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(nTextBox.Text) <= 0)
                {
                    MessageBox.Show("ERROR!");
                }
                else
                {
                    resultLabel.Text = "Result: \n " + Recursion(int.Parse(nTextBox.Text));
                    resultLabel.Visible = true;
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR!");
            }
           
        }
        public int Recursion(int n)
        {
            if (n == 1)
            {
                return 0;
            }
            else
            {
                return Recursion(n - 1) + n * (n - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nTextBox.Text = "";
            resultLabel.Visible = false;
        }
    }
}
