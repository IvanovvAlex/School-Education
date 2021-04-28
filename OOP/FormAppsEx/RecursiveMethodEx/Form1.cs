using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecursiveMethodEx
{
    public partial class Form1 : Form
    {
        private TextBox inputTextBox = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {                
                resultLabel.Text = "Result: " + ToOctal(int.Parse(inputTextBox.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Input textbox can't be empty!");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var txtBox = new TextBox();
            txtBox.Location = new Point(120, 40);           
            Controls.Add(txtBox);
            inputTextBox = txtBox;
        }
        public int ToOctal(int x)
        {
            if (x == 0)
            {
                return 0;
            }
            return x % 8 + 10 * ToOctal(x / 8);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
