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
            Point merlokacionin = this.label.Location;// This take the location in form . We have added a label with no text just to take the location and under it to add fields.

            int a = merlokacionin.X + 80;//The coordinate X of the label we give to the int variable a

            int b = merlokacionin.Y;//The coordinate Y

            if ((textBox1.Text == "") || (textBox2.Text == ""))
                MessageBox.Show(" To create a Matrices you need to give up the numbers of columns and rows.,"opps",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
            {
                n = Convert.ToInt32(textBox1.Text);// Take the value N -Rows
                m = Convert.ToInt32(textBox2.Text);// Take the value M-Columns
            }
            int i, j;

            int[,] Matrica;

            Matrica = new int[n, m];//

            for (i = 0; i < n; i++)
            {
                a = merlokacionin.X + 10; // fields will be at coordinate X      //                                         in 10
                point at right from label1.

                                b = b + 30;// the coordinate of b is changed with adding in 30 points , so the //field will be added in  30 points under the label1.

                for (j = 0; j < m; j++)
                {

                    textbox[i, j] = new TextBox();    //  it create the new //textbox field, the creating fields will continue while as we have the //columns and rows.

                    string emriTextBox = "A" + Convert.ToString(i);//We set the name for textbox

                    this.textbox[i, j].Name = emriTextBox; //give name to textbox

                    a = a + 25;// change the coordinate of X and every 25 points will be the next field                   
                    textbox[i, j].Width = 25;
                    textbox[i, j].Height = 25;
                    textbox[i, j].Location = new Point(a, b + 30);//Now the field take the location where it will be pasted.

                    this.Controls.Add(textbox[i, j]);

                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
