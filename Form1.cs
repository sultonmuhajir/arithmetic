using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aritmatika
{
    public partial class aritmatika : Form
    {
        public aritmatika()
        {
            InitializeComponent();
        }

        private void aritmatika_Load(object sender, EventArgs e)
        {
            num1.Clear();
            num2.Clear();
            hasil.Text = "";
        }

        private string Eval(string oprtr)
        {
            if (string.IsNullOrEmpty(num1.Text) || string.IsNullOrEmpty(num2.Text) ||
                !Regex.IsMatch(num1.Text, "^-?\\d*(\\,\\d+)?$") ||
                !Regex.IsMatch(num2.Text, "^-?\\d*(\\,\\d+)?$"))
            {
                return "Invalid Input";
            }
            else
            {
                float a = float.Parse(num1.Text);
                float b = float.Parse(num2.Text);
                float c = 0;
                switch (oprtr)
                {
                    case "sum":
                        c = a + b;
                        break;
                    case "sub":
                        c = a - b;
                        break;
                    case "mul":
                        c = a * b;
                        break;
                    case "div":
                        c = a / b;
                        break;
                }
                return c.ToString();
            }

        }

        private void sum_Click(object sender, EventArgs e)
        {
            hasil.Text = Eval("sum");
        }

        private void sub_Click(object sender, EventArgs e)
        {
            hasil.Text = Eval("sub");
        }

        private void mul_Click(object sender, EventArgs e)
        {
            hasil.Text = Eval("mul");
        }

        private void div_Click(object sender, EventArgs e)
        {
            hasil.Text = Eval("div");
        }

        private void clear_Click(object sender, EventArgs e)
        {
            num1.Clear();
            num2.Clear();
            hasil.Text = "";
        }
    }
}
