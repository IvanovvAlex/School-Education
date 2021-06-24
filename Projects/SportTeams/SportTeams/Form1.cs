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

namespace SportTeams
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3U20D3B;Initial Catalog=Sport;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) //team rb
        {
            label1.Text = "TeamID";
            label2.Text = "TeamName";
            label3.Text = "Players count";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) //player rb
        {
            label1.Text = "PlayerID";
            label2.Text = "PlayerName";
            label3.Text = "TeamName";
        }

        private void button1_Click(object sender, EventArgs e) //create
        {
            try
            {
                if (radioButton1.Checked == true)
                {
                    if (textBox1.Text != "" && textBox2.Text != "")
                    {
                        cmd = new SqlCommand("insert into Coaches(CoachesID,CoachName,CoachTeam) values(@id,@name,@teamName)", con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
                        cmd.Parameters.AddWithValue("@name", textBox2.Text);
                        cmd.Parameters.AddWithValue("@teamName", textBox3.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record Inserted Successfully");

                    }
                    else
                    {
                        MessageBox.Show("Please Provide Details!");
                    }

                }
                else if (radioButton2.Checked == true)
                {
                    if (textBox1.Text != "" && textBox2.Text != "")
                    {
                        cmd = new SqlCommand("insert into Teams(TeamID,TeamName,PlayersID) values(@id,@name,@playersID)", con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
                        cmd.Parameters.AddWithValue("@name", textBox2.Text);
                        cmd.Parameters.AddWithValue("@playersID", int.Parse(textBox3.Text));
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record Inserted Successfully");

                    }
                    else
                    {
                        MessageBox.Show("Please Provide Details!");
                    }
                }
                else if (radioButton3.Checked == true)
                {
                    if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                    {
                        cmd = new SqlCommand("insert into Players(PlayerID,PlayerName,TeamName) values(@id,@name,@teamName)", con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
                        cmd.Parameters.AddWithValue("@name", textBox3.Text);
                        cmd.Parameters.AddWithValue("@teamName", textBox2.Text);                        
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
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e) //read
        {
            try
            {
                if (radioButton1.Checked == true)
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    adapt = new SqlDataAdapter("select * from Coaches", con);
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
                else if (radioButton2.Checked == true)
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    adapt = new SqlDataAdapter("select * from Teams", con);
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
                else if (radioButton3.Checked == true)
                {
                    con.Open();
                    DataTable dt = new DataTable();
                    adapt = new SqlDataAdapter("select * from Players", con);
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Please select table to read");
                }
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e) //update
        {
            try
            {
                if (radioButton1.Checked == true)
                {
                    if (textBox1.Text != "" && textBox2.Text != "")
                    {
                        cmd = new SqlCommand("update Coaches set CoachName=@name, CoachTeam=@team where CoachesID=@id", con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
                        cmd.Parameters.AddWithValue("@name", textBox2.Text);
                        cmd.Parameters.AddWithValue("@team", textBox3.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Updated Successfully");
                        con.Close();

                    }
                    else
                    {
                        MessageBox.Show("Please Select Record to Update");
                    }
                }
                else if (radioButton2.Checked == true)
                {
                    if (textBox1.Text != "" && textBox2.Text != "")
                    {
                        cmd = new SqlCommand("update Teams set TeamName=@name, PlayersID = @playerID where TeamID=@id", con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));                        
                        cmd.Parameters.AddWithValue("@name", textBox2.Text);
                        cmd.Parameters.AddWithValue("@playerID", int.Parse(textBox3.Text));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Updated Successfully");
                        con.Close();

                    }
                    else
                    {
                        MessageBox.Show("Please Select Record to Update");
                    }
                }
                else if (radioButton3.Checked == true)
                {
                    if (textBox1.Text != "" && textBox2.Text != "")
                    {
                        cmd = new SqlCommand("update Players set PlayerName=@playerName,TeamName=@teamName where PlayerID=@id", con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
                        cmd.Parameters.AddWithValue("@playerName", textBox3.Text);
                        cmd.Parameters.AddWithValue("@teamName", textBox2.Text);
                        
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
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e) //delete
        {
            try
            {
                if (radioButton1.Checked == true)
                {
                    if (!string.IsNullOrEmpty(textBox1.Text))
                    {
                        cmd = new SqlCommand("delete Coaches where CoachesID=@id", con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record Deleted Successfully!");

                    }
                    else
                    {
                        MessageBox.Show("Please Select Record to Delete");
                    }
                }

                else if (radioButton2.Checked == true)
                {
                    if (!string.IsNullOrEmpty(textBox1.Text))
                    {
                        cmd = new SqlCommand("delete Teams where TeamID=@id", con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record Deleted Successfully!");

                    }
                    else
                    {
                        MessageBox.Show("Please Select Record to Delete");
                    }
                }
                else if (radioButton3.Checked == true)
                {
                    if (!string.IsNullOrEmpty(textBox1.Text))
                    {
                        cmd = new SqlCommand("delete Players where PlayerID=@id", con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record Deleted Successfully!");

                    }
                    else
                    {
                        MessageBox.Show("Please Select Record to Delete");
                    }
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                }
                else
                {
                    MessageBox.Show("Please choose table!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) //coach rb
        {
            label1.Text = "CoachesID";
            label2.Text = "CoachName";
            label3.Text = "CoachTeam";
        }
    }
}
