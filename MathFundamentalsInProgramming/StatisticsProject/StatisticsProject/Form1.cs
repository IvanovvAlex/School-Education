using StatisticsProject.Models;

namespace StatisticsProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void AnalyseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Statistics stats = new Statistics(InputTextBox.Text);

                this.NMV_TextBox.Text = stats.NMV.ToString();
                this.ChNMV_TextBox.Text = stats.ChNMV.ToString();
                this.NGV_TextBox.Text = stats.NGV.ToString();
                this.ChNGV_TextBox.Text = stats.ChNGV.ToString();
                this.AVG_TextBox.Text = stats.AVG.ToString();
                this.Mediana_TextBox.Text = stats.Mediana.ToString();
                this.Moda_TextBox.Text = stats.Moda.ToString();
                this.SA0_TextBox.Text = stats.SAO.ToString();
                this.SKO_TextBox.Text = stats.SKO.ToString();
                this.Dispersia_TextBox.Text = stats.Disperia.ToString();
                this.Obem_TextBox.Text = stats.Obem.ToString();
                this.SortedOutput.Text = string.Join("\r\n", stats.Output);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Input!");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                e.Cancel = MessageBox.Show(@"Do you really want to close the form?",
                                           Application.ProductName,
                                           MessageBoxButtons.YesNo) == DialogResult.No;
        }
    }
}