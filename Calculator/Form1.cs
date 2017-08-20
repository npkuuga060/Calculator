using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class From1 : Form
    {
        Double value = 0;
        String op = "";
        bool op_click = false;

        public From1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if((textBox1.Text == "0") || (op_click))
            {
                textBox1.Clear();
            }
            op_click = false;
            Button a = (Button)sender;
            textBox1.Text = textBox1.Text + a.Text;
        }

        private void operation_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            op = a.Text;
            value = Double.Parse(textBox1.Text);
            op_click = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch(op)
            {
                case "+":
                    textBox1.Text = (value + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (value - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (value * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (value / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
            op_click = false;
        }
    }
}
