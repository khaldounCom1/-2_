using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtR.BackColor = Color.Red;
            enabled(false);
        }
        public void isnumber(KeyPressEventArgs e)
        {
            if ((e.KeyChar < 45 || e.KeyChar > 57 || e.KeyChar == 47)  && (e.KeyChar != 8) )
            {
                e.Handled = true;
            }
        }
        public void enabled(bool f)
        {
            butDiv.Enabled = f;
            butMult.Enabled = f;
            butSub.Enabled = f;
            butAdd.Enabled = f;
        }

        public void operation(double n1, double n2, string op)
        {
            switch (op)
            {
                case "+":
                    txtR.Text = (n1 + n2).ToString();
                    txtR.BackColor = Color.White;
                    break;
                case "-":
                    txtR.Text = (n1 - n2).ToString(); txtR.BackColor =
               Color.White; break;
                case "*":
                    txtR.Text = (n1 * n2).ToString(); txtR.BackColor =
               Color.White; break;
                case "/":
                    if (n2 != 0)
                    {
                        txtR.Text = (n1 / n2).ToString(); txtR.BackColor =
                       Color.White;
                    }
                    else
                        MessageBox.Show("تحذير لايمكن القسمة على صفر.");
                      break;
                default:
                    txtR.BackColor = Color.Black;
                    MessageBox.Show("تحذير العملية المدخلة غير صحيحة");
                    break;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            txt1.TextChanged += txt2_TextChanged;
            txt1.KeyPress += txt2_KeyPress;
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            operation(double.Parse(txt1.Text), double.Parse(txt2.Text), "+");
        }

        private void butSub_Click(object sender, EventArgs e)
        {
            operation(double.Parse(txt1.Text), double.Parse(txt2.Text), "-");
        }

        private void butMult_Click(object sender, EventArgs e)
        {
            operation(double.Parse(txt1.Text), double.Parse(txt2.Text), "*");
        }

        private void butDiv_Click(object sender, EventArgs e)
        {
            operation(double.Parse(txt1.Text), double.Parse(txt2.Text), "/");
        }

        private void butCLo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            txtR.Clear();
        }
        //تم تضعيفة 
       /* private void txt1_TextChanged(object sender, EventArgs e)
        {
            bool f = (txt1.Text.Trim() != "" && txt2.Text.Trim() != "");
            enabled(f);
        }*/

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            bool f = (txt1.Text.Trim() != "" && txt2.Text.Trim() != "");
            enabled(f);
        }

        //تم تضعيفة 
        /* private void txt1_KeyPress(object sender, KeyPressEventArgs e)
         {
             isnumber(e);
         }*/

        private void txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            isnumber(e);
        }

       
    }
}
