using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace str59_zad2
{
    public partial class Form1 : Form
    {
     

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(textBox1.Text);
                int m = int.Parse(textBox2.Text);
                int counter = 0;
                TextBox[] MatrixNodes = new TextBox[n * m];

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        var tb = new TextBox();
                        Random r = new Random();
                        int num = r.Next(1, 1000);
                        MatrixNodes[counter] = tb;
                        tb.Name = "Node_" + MatrixNodes[counter];
                        tb.Text = num.ToString();
                        tb.Location = new Point(50 + (j * 150), 150 + (i * 50));
                        tb.Visible = true;
                        this.Controls.Add(tb);
                        counter++;
                    }

                    counter = 0;
                }
                //if (int.Parse(textBox1.Text) > 0 && int.Parse(textBox2.Text) > 0)
                //{
                //    int y = 225;
                //    for (int n = 0; n < 5; n++)
                //    {
                //        var txtBox = new TextBox();                        
                //        var txtBox2 = new TextBox();
                //        txtBox.Location = new Point(50, y);
                //        txtBox2.Location = new Point(50, y + 25);
                //        y += 50;
                //        Controls.Add(txtBox);
                //        Controls.Add(txtBox2);
                //        list.Add(txtBox);
                //        list.Add(txtBox2);
                //    }
           
               
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid input");
            }
            
        }
    }
}
