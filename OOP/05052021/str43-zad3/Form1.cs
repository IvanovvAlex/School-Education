using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace str43_zad3
{
    public partial class Form1 : Form
    {
        int num;
        int counter;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Random rndNum = new Random();
            num = rndNum.Next(1, 100);
            startButton.Enabled = false;
            enterNumTextbox.Enabled = true;
        }

        private void enterNumLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tryButton_Click(object sender, EventArgs e)
        {
            try
            {
                int enteredNum = int.Parse(enterNumTextbox.Text);
                if (enteredNum < 1 || enteredNum > 100)
                {
                    throw new Exception();
                }
                if (enteredNum > num)
                {
                    label1.Text = "Надолу";
                    counter++;
                }
                else if (enteredNum < num)
                {
                    label1.Text = "Нагоре";
                    counter++;
                }
                else if (enteredNum == num)
                {
                    label1.Text = "Браво!";
                    counter++;
                    enterNumTextbox.Enabled = false;
                    tryButton.Enabled = false;
                }
                label2.Text = counter.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("ГРЕШКА! Невалидни входни данни!");
            }
        }
    }
}
