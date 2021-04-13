using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SickCountInRuseEx
{
    public partial class sickk : Form
    {
        static List<TextBox> bolni = new List<TextBox>();
        public sickk()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> info = new List<int>();
            try
            {
                foreach (var item in bolni)
                {
                    if (int.Parse(item.Text) < 0)
                    {
                        throw new Exception();
                    }
                    info.Add(int.Parse(item.Text));
                }
            }
            catch (Exception)
            {
                CleanAll();
                MessageBox.Show("Invalid input!");
                
            }
            if (radioButton1.Checked == true)
            {
                label3.Text = (string.Join(" - ", info.OrderByDescending(x => x)));
                //BUBBLE SORTING
                //bubbleSortDescending(info, info.Count);
                //label3.Text = (string.Join(" - ", info));

            }
            if (radioButton2.Checked == true)
            {
                label3.Text = (string.Join(" - ", info.OrderBy(x => x)));
                //BUBBLE SORTING
                //bubbleSort(info, info.Count);
                //label3.Text = (string.Join(" - ", info));
            }
            if(radioButton1.Checked == false && radioButton2.Checked == false)
            { MessageBox.Show("There is no chosen option. Try again..."); }
        }

        private void sickk_Load(object sender, EventArgs e)
        {
            int y = 40;
            for (int n = 0; n < 7; n++)
            {
                var txtBox = new TextBox();               
                txtBox.Location = new Point(30, y);                
                y += 30;
                Controls.Add(txtBox);              
                bolni.Add(txtBox);                
            } 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CleanAll();
            //label3.Text = "";
            //radioButton1.Checked = false;
            //radioButton2.Checked = false;
            //for (int i = 0; i < bolni.Count; i++)
            //{
            //    bolni[i].Text = "";
            //}
        }
        private void CleanAll()
        {
            label3.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            for (int i = 0; i < bolni.Count; i++)
            {
                bolni[i].Text = "";
            }
        }
        static void bubbleSort(List<int> list, int listsCount)
        {            
            bool swapped;
            for (int i = 0; i < listsCount - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < listsCount - i - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {                        
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                        swapped = true;
                    }
                }              
                if (swapped == false)
                    break;
            }
        }
        static void bubbleSortDescending(List<int> list, int listsCount)
        {
            bool swapped;
            for (int i = 0; i < listsCount - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < listsCount - i - 1; j++)
                {
                    if (list[j] < list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (swapped == false)
                    break;
            }
        }
    }
}
