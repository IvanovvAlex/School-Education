using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksStoreForms
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3U20D3B;Initial Catalog=BookStoreDB;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        //ID variable used in Updating and Deleting Record  
        int ID = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) // readButton
        {
            if (AuthorsRadioButton.Checked == true)
            {
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("select * from Authors", con);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (GenresRadioButton.Checked == true)
            {
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("select * from Genres", con);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (BooksRadioButton.Checked == true)
            {
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("select * from Books", con);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Please select table to read");
            }
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
            if (AuthorsRadioButton.Checked == true)
            {
                if (txt_ID.Text != "" && txt_Name.Text != "")
                {
                    cmd = new SqlCommand("insert into Authors(AuthorsID,AuthorsName) values(@id,@name)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", int.Parse(txt_ID.Text));
                    cmd.Parameters.AddWithValue("@name", txt_Name.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Inserted Successfully");
                    
                }
                else
                {
                    MessageBox.Show("Please Provide Details!");
                }
                                         
            }
            else if (GenresRadioButton.Checked == true)
            {
                if (txt_ID.Text != "" && txt_Name.Text != "")
                {
                    cmd = new SqlCommand("insert into Genres(GenresID,GenresName) values(@id,@name)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", int.Parse(txt_ID.Text));
                    cmd.Parameters.AddWithValue("@name", txt_Name.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Inserted Successfully");

                }
                else
                {
                    MessageBox.Show("Please Provide Details!");
                }
            }
            else if (BooksRadioButton.Checked == true)
            {
                if (txt_ID.Text != "" && txt_Name.Text != "" && txt_ISBN.Text != "" && txt_GenreID.Text != "")
                {
                    cmd = new SqlCommand("insert into Books(BooksID,BooksName,BooksISBN,GenresID) values(@id,@name,@isbn, @genreId)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", int.Parse(txt_ID.Text));
                    cmd.Parameters.AddWithValue("@name", txt_Name.Text);
                    cmd.Parameters.AddWithValue("@isbn", int.Parse(txt_ISBN.Text));
                    cmd.Parameters.AddWithValue("@genreId", int.Parse(txt_GenreID.Text));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Inserted Successfully");

                }
                else
                {
                    MessageBox.Show("Please Provide Details!");
                }
            }
            else
            {
                MessageBox.Show("Please choose table!");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (AuthorsRadioButton.Checked == true)
            {
                if (txt_Name.Text != "" && txt_ID.Text != "")
                {
                    cmd = new SqlCommand("update Authors set AuthorsName=@name where AuthorsID=@id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", int.Parse(txt_ID.Text));
                    cmd.Parameters.AddWithValue("@name", txt_Name.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully");
                    con.Close();
                    
                }
                else
                {
                    MessageBox.Show("Please Select Record to Update");
                }
            }
            else if (GenresRadioButton.Checked == true)
            {
                if (txt_Name.Text != "" && txt_ID.Text != "")
                {
                    cmd = new SqlCommand("update Genres set GenresName=@name where GenresID=@id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", int.Parse(txt_ID.Text));
                    cmd.Parameters.AddWithValue("@name", txt_Name.Text);                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully");
                    con.Close();
                   
                }
                else
                {
                    MessageBox.Show("Please Select Record to Update");
                }
            }
            else if (BooksRadioButton.Checked == true)
            {
                if (txt_Name.Text != "" && txt_ID.Text != "")
                {
                    cmd = new SqlCommand("update Genres set GenresName=@name where GenresID=@id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", int.Parse(txt_ID.Text));
                    cmd.Parameters.AddWithValue("@name", txt_Name.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully");
                    con.Close();

                }
                else
                {
                    MessageBox.Show("Please Select Record to Update");
                }
            }
            else
            {
                MessageBox.Show("Please choose table!");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (AuthorsRadioButton.Checked == true)
            {

            }
            else if (GenresRadioButton.Checked == true)
            {

            }
            else
            {

            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            
        }
    }
}
