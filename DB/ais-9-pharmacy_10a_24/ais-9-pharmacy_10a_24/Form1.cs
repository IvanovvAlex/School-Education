using ais_9_pharmacy_10a_24.Data.Models;
using ais_9_pharmacy_10a_24.Services.MedicamentServices;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ais_9_pharmacy_10a_24
{
    public partial class Form1 : Form
    {
        private readonly IMedicamentService medicamentService;

        public Form1(IMedicamentService medicamentService)
        {
            this.medicamentService = medicamentService;
            InitializeComponent();
        }
        private void Form1_LoadAsync(object sender, EventArgs e)
        {
            AllDataGridView.DataSource = medicamentService.GetAll();

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = NameТextBox.Text;
                decimal price = decimal.Parse(PriceТextBox.Text);
                string type = TypeComboBox.Text;
                int quantity = int.Parse(QuantityТextBox.Text);
                DateTime expireDate = DateTime.Parse(DateTimePicker.Text);

                medicamentService.Create(name, price, quantity, expireDate, type);

                AllDataGridView.DataSource = medicamentService.GetAll();

                CleanTextBoxes();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input data!");
            }
        }

        private void CleanTextBoxes()
        {
            NameТextBox.Text = null;
            PriceТextBox.Text = null;
            TypeComboBox.Text = null;
            QuantityТextBox.Text = null;
            DateTimePicker.Text = null;
            TotalTextBox.Text = null;
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            CleanTextBoxes();
            AllDataGridView.DataSource = medicamentService.GetAll();
        }

        private void SearchByNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = NameТextBox.Text.Trim();

                ICollection<Medicament> matches = medicamentService.SearchByName(name);

                if (matches.Count == 0)
                {
                    MessageBox.Show("There's no matches");
                    SampleDataGridView.DataSource = null;
                    return;
                }

                SampleDataGridView.DataSource = matches;

                CleanTextBoxes();
                AllDataGridView.DataSource = medicamentService.GetAll();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input data!");
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = NameТextBox.Text;
                decimal price = decimal.Parse(PriceТextBox.Text);
                string type = TypeComboBox.Text;
                int quantity = int.Parse(QuantityТextBox.Text);
                DateTime expireDate = DateTime.Parse(DateTimePicker.Text);

                medicamentService.Edit(name, price, quantity, expireDate, type);

                AllDataGridView.DataSource = medicamentService.GetAll();

                CleanTextBoxes();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input data!");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = NameТextBox.Text.Trim();

                medicamentService.Delete(name);

                SampleDataGridView.DataSource = null;

                CleanTextBoxes();
                AllDataGridView.DataSource = medicamentService.GetAll();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input data!");
            }
        }

        private void ExpiredDateButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = DateTimePicker.Value;

                ICollection<Medicament> matches = medicamentService.SearchByDate(date);

                if (matches.Count == 0)
                {
                    MessageBox.Show("There's no expired medicaments");
                    SampleDataGridView.DataSource = null;
                    return;
                }

                SampleDataGridView.DataSource = matches;

                CleanTextBoxes();
                AllDataGridView.DataSource = medicamentService.GetAll();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input data!");
            }
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            try
            {
                ICollection<Medicament> matches = medicamentService.Sort();

                if (matches.Count == 0)
                {
                    MessageBox.Show("There's nothing to sort");
                    SampleDataGridView.DataSource = null;
                    return;
                }

                SampleDataGridView.DataSource = matches;

                CleanTextBoxes();
                AllDataGridView.DataSource = medicamentService.GetAll();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input data!");
            }
        }

        private void TheLastDateButton_Click(object sender, EventArgs e)
        {
            try
            {
                ICollection<Medicament> matches = medicamentService.GetTheNewest();

                if (matches.Count == 0)
                {
                    MessageBox.Show("There's nothing to get");
                    SampleDataGridView.DataSource = null;
                    return;
                }

                SampleDataGridView.DataSource = matches;

                CleanTextBoxes();
                AllDataGridView.DataSource = medicamentService.GetAll();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input data!");
            }
        }

        private void MostExpensiveButton_Click(object sender, EventArgs e)
        {
            try
            {
                ICollection<Medicament> matches = medicamentService.GetTheMostExpensiveWithExpiredDate();

                if (matches.Count == 0)
                {
                    MessageBox.Show("There's nothing to get");
                    SampleDataGridView.DataSource = null;
                    return;
                }

                SampleDataGridView.DataSource = matches;

                CleanTextBoxes();
                AllDataGridView.DataSource = medicamentService.GetAll();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input data!");
            }
        }

        private void SumAllButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal sum = medicamentService.GetTotalAmountOfMoney();

                if (sum == 0m)
                {
                    MessageBox.Show("There's nothing to sum");
                    SampleDataGridView.DataSource = null;
                    return;
                }
                SampleDataGridView.DataSource = null;

                TotalTextBox.Text = sum.ToString();
                
                AllDataGridView.DataSource = medicamentService.GetAll();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input data!");
            }
        }
    }
}
