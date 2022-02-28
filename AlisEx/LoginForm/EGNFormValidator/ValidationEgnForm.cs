using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EGNFormValidator
{
    public partial class ValidationEgnForm : Form
    {
        public ValidationEgnForm()
        {
            InitializeComponent();
        }
        public string EGN { get { return TextBoxEGN.Text; } }
        public string Year { get { return TextBoxYear.Text; } }
        private void ValidationEgnForm_Load(object sender, EventArgs e)
        {

        }

        private void TextBoxEGN_TextChanged(object sender, EventArgs e)
        {

        }


        private void TextBoxEGN_Validating(object sender, CancelEventArgs e)
        {
            ValidateEGN();
        }
        private bool ValidateEGN()
        {
            if (IsEgnValid(TextBoxEGN.Text))
            {
                ErrorProvider.SetError(TextBoxEGN, string.Empty);
                return true;
            }
            else
            {
                ErrorProvider.SetError(TextBoxEGN, "Invalid EGN!");
                return false;
            }
        }
        private bool IsEgnValid(string egn)
        {
            if (egn.Length != 10)
            {
                return false;
            }
            for (int i = 0; i < egn.Length; i++)
            {
                if (!Char.IsDigit(egn[i]))
                {
                    return false;
                }
            }
            return true;
        }

        private void TextBoxYear_Validating(object sender, CancelEventArgs e)
        {
            ValidateYear();
        }

        private bool ValidateYear()
        {
            if (IsYearValid(TextBoxEGN.Text))
            {
                ErrorProvider.SetError(TextBoxYear, string.Empty);
                return true;
            }
            else
            {
                ErrorProvider.SetError(TextBoxYear, "Invalid year!");
                return false;
            }
        }
        private bool IsYearValid(string year)
        {
            if (year.Length != 4)
            {
                return false;
            }
            for (int i = 0; i < year.Length; i++)
            {
                if (!Char.IsDigit(year[i]))
                {
                    return false;
                }
            }
            return true;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Моля въведете валидни стойности във всички полета!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidateForm()
        {
            if (! ValidateYear())
            {
                return false;
            }
            if (!ValidateEGN())
            {
                return false;
            }
            var egn = TextBoxEGN.Text;
            var year = TextBoxYear.Text;
            if (egn.Substring(0,2) == year.Substring(2,2))
            {
                ErrorProvider.SetError(ButtonOK, string.Empty);
                return true;
            }
            else
            {
                ErrorProvider.SetError(ButtonOK, "Годината на раждане не съответства на ЕГН-то!");
                return false;
            }
        }
    }
}
