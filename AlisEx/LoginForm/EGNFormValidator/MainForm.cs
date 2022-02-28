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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonValidateForm_Click(object sender, EventArgs e)
        {
            ValidationEgnForm validationEgnForm = new ValidationEgnForm();
            if (validationEgnForm.ShowDialog() == DialogResult.OK)
            {
                var output = String.Format($"ЕГН: { validationEgnForm.EGN}\nГодина: { validationEgnForm.Year}");
                MessageBox.Show(output, "Резултат");
            }
            validationEgnForm.Dispose();
        }
    }
}
