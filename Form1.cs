using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Triangles.Model;

namespace Triangles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0 ||
                textBox2.Text.Trim().Length == 0)
            {
                label1.Text = "Поля не можуть бути пустими";
                label1.Visible = true;
                return;
            }
            else if (!int.TryParse(textBox1.Text, out int n) ||
                !int.TryParse(textBox2.Text, out int m))
            {
                label1.Text = "Вводити можна тільки числа";
                label1.Visible = true;
                return;
            }
            else if (int.Parse(textBox1.Text.Trim()) < 1)
            {
                label1.Text = "Загальна кількість трикутників не може бути меншою за 1";
                label1.Visible = true;
                return;
            }
            else if (int.Parse(textBox2.Text.Trim()) < 2)
            {
                label1.Text = "Максимальна довжина не може бути меншою за 2";
                label1.Visible = true;
                return;
            }
            label1.Visible = false;
            Print print = new Print(int.Parse(textBox1.Text),
                int.Parse(textBox2.Text));
            print.Show();

        }

        private void check(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num) && !Char.IsControl(num))
            {
                e.Handled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
