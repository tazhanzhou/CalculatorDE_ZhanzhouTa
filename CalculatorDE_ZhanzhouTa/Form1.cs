using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorDE_ZhanzhouTa
{
    public delegate int Calculate(int x, int y);
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Calculate handler;

        class MyMath
        {
            public int Add(int x, int y)
            {
                return x + y;
            }
            public int Mul(int x, int y)
            {
                return x * y;
            }
            public int Sub(int x, int y)
            {
                return x - y;
            }
            public int Div(int x, int y)
            {
                return x / y;
            }
        }

        MyMath math = new MyMath();

        int op1;
        int op2;
        bool isContinue = true;

        private void btnNum_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button btn = (Button)sender;
                if (isContinue)
                    textBox1.Text += btn.Text;
                else
                {
                    isContinue = true;
                    textBox1.Text = btn.Text;
                }
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            isContinue = false;
            if (handler == null)
            {
                op1 = Convert.ToInt32(textBox1.Text);
            }
            else
            {
                op2 = Convert.ToInt32(textBox1.Text);
                op1 = handler(op1, op2);
                textBox1.Text = op1.ToString();
            }
            if (sender is Button)
            {
                Button btn = (Button)sender;
                switch (btn.Text)
                {
                    case "+":
                        handler += new Calculate(math.Add); break;
                    case "-":
                        handler += new Calculate(math.Sub); break;
                    case "x":
                        handler += new Calculate(math.Mul); break;
                    case "/":
                        handler += new Calculate(math.Div); break;
                    case "=":
                        handler = null; break;
                }
            }
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            op1 = 0;
            op2 = 0;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            btnNum_Click(sender, e);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btnNum_Click(sender, e);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btnNum_Click(sender, e);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btnNum_Click(sender, e);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            btnNum_Click(sender, e);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            btnNum_Click(sender, e);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            btnNum_Click(sender, e);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            btnNum_Click(sender, e);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            btnNum_Click(sender, e);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            btnNum_Click(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnCalc_Click(sender, e);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            btnCalc_Click(sender, e);
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            btnCalc_Click(sender, e);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            btnCalc_Click(sender, e);
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            btnCalc_Click(sender, e);
        }
    }
}


