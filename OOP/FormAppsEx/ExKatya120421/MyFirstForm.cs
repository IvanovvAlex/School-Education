using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExKatya120421
{
    public partial class MyFirstForm : Form
    {
        static List<TextBox> prices = new List<TextBox>();
        public MyFirstForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int y = 25;
            for (int n = 0; n < 5; n++)
            {
                var txtBox = new TextBox();
                var txtBox2 = new TextBox();
                txtBox.Location = new Point(20, y);
                txtBox2.Location = new Point(20, y + 25);
                y += 50;
                Controls.Add(txtBox);
                Controls.Add(txtBox2);
                prices.Add(txtBox);
                prices.Add(txtBox2);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label3.Text = "";
            
            for (int i = 0; i < prices.Count; i++)
            {
                prices[i].Text = "";
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double min = double.MaxValue;
                double max = double.MinValue;
                foreach (var price in prices)
                {
                    var value = double.Parse(price.Text);
                    if (value > max)
                    {
                        max = value;
                    }
                    if (value < min)
                    {
                        min = value;
                    }
                } 

                //for (int n = 0; n < prices.Count; n++)
                //{
                //    if (double.Parse(prices[n].Text) < min)
                //    { min = double.Parse(prices[n].Text); }
                //}
                //for (int n = 0; n < prices.Count; n++)
                //{
                //    if (double.Parse(prices[n].Text) > max)
                //    { max = double.Parse(prices[n].Text); }
                //}
                label1.Text = "Най-ниската цена е: " + min.ToString();
                label3.Text = "Най-високата цена е: " + max.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error");
                //throw new ArgumentException(ex.Message);
            }
        }



        private void exitButton_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
    
}
