using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksStoreForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AuthorsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            txt_ID.Enabled = true;
            txt_Name.Enabled = true;
            txt_ISBN.Enabled = false;
            txt_GenreID.Enabled = false;
            label_ID_Optional.Text = "(Required)";
            label_Name_Optional.Text = "(Required)";
            label_ISBN_Optional.Text = "(Optional)";
            label_GenreID_Optional.Text = "(Optional)";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenresRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            txt_ID.Enabled = true;
            txt_Name.Enabled = true;
            txt_ISBN.Enabled = false;
            txt_GenreID.Enabled = false;
            label_ID_Optional.Text = "(Required)";
            label_Name_Optional.Text = "(Required)";
            label_ISBN_Optional.Text = "(Optional)";
            label_GenreID_Optional.Text = "(Optional)";
        }

        private void BooksRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            txt_ID.Enabled = true;
            txt_Name.Enabled = true;
            txt_ISBN.Enabled = true;
            txt_GenreID.Enabled = true;
            label_ID_Optional.Text = "(Required)";
            label_Name_Optional.Text = "(Required)";
            label_ISBN_Optional.Text = "(Required)";
            label_GenreID_Optional.Text = "(Required)";
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btn_create_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {

        }
    }
}
