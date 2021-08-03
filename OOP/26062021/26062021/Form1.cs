using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26062021
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MTextbox.Enabled = true;
            NTextbox.Enabled = true;
            NLabel.Text = "n";
            MLabel.Text = "m";
            ResultLabel.Text = "";
            MTextbox.Text = string.Empty;
            NTextbox.Text = string.Empty;
            pictureBox1.Image = Properties.Resources.stepen;
        }

        private void FactorielRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MTextbox.Enabled = true;
            NTextbox.Enabled = false;
            NLabel.Text = "";
            MLabel.Text = "m";
            ResultLabel.Text = "";
            MTextbox.Text = string.Empty;
            NTextbox.Text = string.Empty;
            pictureBox1.Image = Properties.Resources.faktoriel;
        }

        private void BinomRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MTextbox.Enabled = true;
            NTextbox.Enabled = true;
            NLabel.Text = "n";
            MLabel.Text = "m";
            ResultLabel.Text = "";
            MTextbox.Text = string.Empty;
            NTextbox.Text = string.Empty;
            pictureBox1.Image = Properties.Resources.komb;
        }

        private void VariaciiRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MTextbox.Enabled = true;
            NTextbox.Enabled = true;
            NLabel.Text = "n";
            MLabel.Text = "m";
            ResultLabel.Text = "";
            MTextbox.Text = string.Empty;
            NTextbox.Text = string.Empty;
            pictureBox1.Image = Properties.Resources.var;
        }

        private void CombWithoutRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MTextbox.Enabled = true;
            NTextbox.Enabled = true;
            NLabel.Text = "n";
            MLabel.Text = "m";
            ResultLabel.Text = "";
            MTextbox.Text = string.Empty;
            NTextbox.Text = string.Empty;
            pictureBox1.Image = Properties.Resources.komb;
        }

        private void CombWithRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MTextbox.Enabled = true;
            NTextbox.Enabled = true;
            NLabel.Text = "n";
            MLabel.Text = "m";
            ResultLabel.Text = "";
            MTextbox.Text = string.Empty;
            NTextbox.Text = string.Empty;
            pictureBox1.Image = Properties.Resources.komb;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (PowRadioButton.Checked)
                {
                    ResultLabel.Visible = true;
                    ResultLabel.Text = "Резултат: " + Operations.Pow(int.Parse(MTextbox.Text), int.Parse(NTextbox.Text));
                }
                else if (FactorielRadioButton.Checked)
                {
                    ResultLabel.Visible = true;
                    ResultLabel.Text = "Резултат: " + Operations.Factoriel(int.Parse(MTextbox.Text));
                }
                else if (BinomRadioButton.Checked)
                {
                    ResultLabel.Visible = true;
                    ResultLabel.Text = "Резултат: " + Operations.BinomenKoef(int.Parse(MTextbox.Text), int.Parse(NTextbox.Text));
                }
                else if (VariaciiRadioButton.Checked)
                {
                    ResultLabel.Visible = true;
                    ResultLabel.Text = "Резултат: " + Operations.Variacii(BigInteger.Parse(MTextbox.Text), BigInteger.Parse(NTextbox.Text));

                }
                else if (CombWithoutRadioButton.Checked)
                {
                    ResultLabel.Visible = true;
                    ResultLabel.Text = "Резултат: " + Operations.CombWithout(BigInteger.Parse(MTextbox.Text), BigInteger.Parse(NTextbox.Text));
                }
                else if (CombWithRadioButton.Checked)
                {
                    ResultLabel.Visible = true;
                    ResultLabel.Text = "Резултат: " + Operations.CombWith(BigInteger.Parse(MTextbox.Text), BigInteger.Parse(NTextbox.Text));
                }
               
            }
            catch (Exception)
            {
                MessageBox.Show("Грешка!");
              
            }           
        }
    }
}
