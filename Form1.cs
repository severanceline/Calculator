using System;
using System.Data;
using System.Diagnostics.Contracts;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public My_calculator cal1;
        public Form1()
        {
            InitializeComponent();
            cal1 = new My_calculator();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            txt1.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            My_calculator cal = new My_calculator();
        }
        private void Btton_Click(object sender, EventArgs e)
        {
        }
        private void button17_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "Nan" || txt1.Text == "Cannot divide by zero" || txt1.Text == "∞")
            {
                txt1.Text = "0";
                txt2.Text = "";
                cal1.Num1 = 0;
                cal1.Num2 = 0;
                cal1.Op = string.Empty;
                txt1.Font = new Font(txt1.Font.FontFamily, 32);
            }
            else
            {
                if (button21.Enabled == false || button20.Enabled == false || button16.Enabled == false || button12.Enabled == false)
                {
                    txt1.Text = "1";
                }
                else
                {
                    if (txt1.Text == "0") { txt1.Text = "1"; }
                    else { txt1.Text += "1"; }
                }
                txt2.Text = cal1.ToString();
            }
            button21.Enabled = true;
            button20.Enabled = true;
            button16.Enabled = true;
            button12.Enabled = true;
        }
        private void but2_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "Nan" || txt1.Text == "Cannot divide by zero" || txt1.Text == "∞")
            {
                txt1.Text = "2";
                txt2.Text = "";
                cal1.Num1 = 0;
                cal1.Num2 = 0;
                cal1.Op = string.Empty;
                txt1.Font = new Font(txt1.Font.FontFamily, 32);
            }
            else
            {
                if (button21.Enabled == false || button20.Enabled == false || button16.Enabled == false || button12.Enabled == false)
                {
                    txt1.Text = "2";
                }
                else
                {
                    if (txt1.Text == "0") { txt1.Text = "2"; }
                    else { txt1.Text += "2"; }
                }
                txt2.Text = cal1.ToString();
            }
            button21.Enabled = true;
            button20.Enabled = true;
            button16.Enabled = true;
            button12.Enabled = true;
        }
        private void but3_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "Nan" || txt1.Text == "Cannot divide by zero" || txt1.Text == "∞")
            {
                txt1.Text = "3";
                txt2.Text = "";
                cal1.Num1 = 0;
                cal1.Num2 = 0;
                cal1.Op = string.Empty;
                txt1.Font = new Font(txt1.Font.FontFamily, 32);
            }
            else
            {
                if (button21.Enabled == false || button20.Enabled == false || button16.Enabled == false || button12.Enabled == false)
                {
                    txt1.Text = "3";
                }
                else
                {
                    if (txt1.Text == "0") { txt1.Text = "3"; }
                    else { txt1.Text += "3"; }
                }
                txt2.Text = cal1.ToString();
            }
            button21.Enabled = true;
            button20.Enabled = true;
            button16.Enabled = true;
            button12.Enabled = true;
        }
        private void but4_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "Nan" || txt1.Text == "Cannot divide by zero" || txt1.Text == "∞")
            {
                txt1.Text = "4";
                txt2.Text = "";
                cal1.Num1 = 0;
                cal1.Num2 = 0;
                cal1.Op = string.Empty;
                txt1.Font = new Font(txt1.Font.FontFamily, 32);

            }
            else
            {
                if (button21.Enabled == false || button20.Enabled == false || button16.Enabled == false || button12.Enabled == false)
                {
                    txt1.Text = "4";
                }
                else
                {
                    if (txt1.Text == "0") { txt1.Text = "4"; }
                    else { txt1.Text += "4"; }
                }
                txt2.Text = cal1.ToString();
            }
            button21.Enabled = true;
            button20.Enabled = true;
            button16.Enabled = true;
            button12.Enabled = true;
        }
        private void but5_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "Nan" || txt1.Text == "Cannot divide by zero" || txt1.Text == "∞")
            {
                txt1.Text = "5";
                txt2.Text = "";
                cal1.Num1 = 0;
                cal1.Num2 = 0;
                cal1.Op = string.Empty;
                txt1.Font = new Font(txt1.Font.FontFamily, 32);
            }
            else
            {
                if (button21.Enabled == false || button20.Enabled == false || button16.Enabled == false || button12.Enabled == false)
                {
                    txt1.Text = "5";
                }
                else
                {
                    if (txt1.Text == "0") { txt1.Text = "5"; }
                    else { txt1.Text += "5"; }
                }
                txt2.Text = cal1.ToString();
            }
            button21.Enabled = true;
            button20.Enabled = true;
            button16.Enabled = true;
            button12.Enabled = true;
        }
        private void but6_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "Nan" || txt1.Text == "Cannot divide by zero" || txt1.Text == "∞")
            {
                txt1.Text = "6";
                txt2.Text = "";
                cal1.Num1 = 0;
                cal1.Num2 = 0;
                cal1.Op = string.Empty;
                txt1.Font = new Font(txt1.Font.FontFamily, 32);
            }
            else
            {
                if (button21.Enabled == false || button20.Enabled == false || button16.Enabled == false || button12.Enabled == false)
                {
                    txt1.Text = "6";
                }
                else
                {
                    if (txt1.Text == "0") { txt1.Text = "6"; }
                    else { txt1.Text += "6"; }
                }
                txt2.Text = cal1.ToString();
            }
            button21.Enabled = true;
            button20.Enabled = true;
            button16.Enabled = true;
            button12.Enabled = true;
        }
        private void but7_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "Nan" || txt1.Text == "Cannot divide by zero" || txt1.Text == "∞")
            {
                txt1.Text = "7";
                txt2.Text = "";
                cal1.Num1 = 0;
                cal1.Num2 = 0;
                cal1.Op = string.Empty;
                txt1.Font = new Font(txt1.Font.FontFamily, 32);
            }
            else
            {
                if (button21.Enabled == false || button20.Enabled == false || button16.Enabled == false || button12.Enabled == false)
                {
                    txt1.Text = "7";
                }
                else
                {
                    if (txt1.Text == "0") { txt1.Text = "7"; }
                    else { txt1.Text += "7"; }
                }
                txt2.Text = cal1.ToString();
            }
            button21.Enabled = true;
            button20.Enabled = true;
            button16.Enabled = true;
            button12.Enabled = true;
        }
        private void but8_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "Nan" || txt1.Text == "Cannot divide by zero" || txt1.Text == "∞")
            {
                txt1.Text = "8";
                txt2.Text = "";
                cal1.Num1 = 0;
                cal1.Num2 = 0;
                cal1.Op = string.Empty;
                txt1.Font = new Font(txt1.Font.FontFamily, 32);
            }
            else
            {
                if (button21.Enabled == false || button20.Enabled == false || button16.Enabled == false || button12.Enabled == false)
                {
                    txt1.Text = "8";
                }
                else
                {
                    if (txt1.Text == "0") { txt1.Text = "8"; }
                    else { txt1.Text += "8"; }
                }
                txt2.Text = cal1.ToString();
            }
            button21.Enabled = true;
            button20.Enabled = true;
            button16.Enabled = true;
            button12.Enabled = true;
        }
        private void but9_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "Nan" || txt1.Text == "Cannot divide by zero" || txt1.Text == "∞")
            {
                txt1.Text = "9";
                txt2.Text = "";
                cal1.Num1 = 0;
                cal1.Num2 = 0;
                cal1.Op = string.Empty;
                txt1.Font = new Font(txt1.Font.FontFamily, 32);
            }
            else
            {
                if (button21.Enabled == false || button20.Enabled == false || button16.Enabled == false || button12.Enabled == false)
                {
                    txt1.Text = "9";
                }
                else
                {
                    if (txt1.Text == "0") { txt1.Text = "9"; }
                    else { txt1.Text += "9"; }
                }
                txt2.Text = cal1.ToString();
            }
            button21.Enabled = true;
            button20.Enabled = true;
            button16.Enabled = true;
            button12.Enabled = true;
        }
        private void button23_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "Nan" || txt1.Text == "Cannot divide by zero" || txt1.Text == "∞")
            {
                txt1.Text = "0";
                txt2.Text = "";
                cal1.Num1 = 0;
                cal1.Num2 = 0;
                cal1.Op = string.Empty;
                txt1.Font = new Font(txt1.Font.FontFamily, 32);
            }
            else
            {
                if (button21.Enabled == false || button20.Enabled == false || button16.Enabled == false || button12.Enabled == false)
                {
                    txt1.Text = "0";
                }
                else
                {
                    if (txt1.Text == "0") { }
                    else { txt1.Text += "0"; }
                }
            }
            button21.Enabled = true;
            button20.Enabled = true;
            button16.Enabled = true;
            button12.Enabled = true;
        }
        private void button22_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "Nan" || txt1.Text == "Cannot divide by zero" || txt1.Text == "∞")
            {
                txt1.Text = "0";
                txt2.Text = "";
                cal1.Num1 = 0;
                cal1.Num2 = 0;
                cal1.Op = string.Empty;
                txt1.Font = new Font(txt1.Font.FontFamily, 32);
            }
            else
            {
                if (button21.Enabled == false || button20.Enabled == false || button16.Enabled == false || button12.Enabled == false)
                {
                    txt1.Text = "0.";
                }
                else
                {
                    string text = txt1.Text;
                    string decimalpoint = ".";
                    if (text.Contains(decimalpoint) || text.EndsWith(decimalpoint))
                    {
                    }
                    else
                    {
                        txt1.Text += ".";
                    }
                }
                txt2.Text = cal1.ToString();
            }
            button21.Enabled = true;
            button20.Enabled = true;
            button16.Enabled = true;
            button12.Enabled = true;
        }
        private void button21_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "Nan" || txt1.Text == "Cannot divide by zero" || txt1.Text == "∞")
            {
                txt1.Text = "0";
                txt2.Text = "";
                cal1.Num1 = 0;
                cal1.Num2 = 0;
                cal1.Op = string.Empty;
                txt1.Font = new Font(txt1.Font.FontFamily, 32);
                button21.Enabled = true;
                button20.Enabled = true;
                button16.Enabled = true;
                button12.Enabled = true;
            }
            else
            {
                cal1 = new My_calculator();
                cal1.Op = "+";
                cal1.Num1 = Convert.ToDouble(txt1.Text);
                button21.Enabled = false;
                txt2.Text = cal1.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "Nan" || txt1.Text == "Cannot divide by zero" || txt1.Text == "∞")
            {
                txt1.Text = "0";
                txt2.Text = "";
                cal1.Num1 = 0;
                cal1.Num2 = 0;
                cal1.Op = string.Empty;
                txt1.Font = new Font(txt1.Font.FontFamily, 32);
            }
            else
            {
                if (cal1.Op == "√" || cal1.Op == "1/" || cal1.Op == "**") { }
                else
                {
                    cal1.Counter1 += 1;
                    if (cal1.Counter1 > 1 && cal1.Op == "-")
                    {
                        cal1.Num1 = Convert.ToDouble(txt1.Text);
                        txt1.Text = cal1.calculation().ToString();
                    }
                    else if (cal1.Counter1 > 1 && cal1.Op != "-")
                    {
                        cal1.Num1 = Convert.ToDouble(txt1.Text);
                        txt1.Text = cal1.calculation().ToString();
                    }
                    else
                    {
                        cal1.Num2 = Convert.ToDouble(txt1.Text);
                        txt1.Text = cal1.calculation();
                    }
                    txt2.Text = cal1.ToString();
                }
            }
            button21.Enabled = true;
            button20.Enabled = true;
            button16.Enabled = true;
            button12.Enabled = true;
        }
        public void button16_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "Nan" || txt1.Text == "Cannot divide by zero" || txt1.Text == "∞")
            {
                txt1.Text = "0";
                txt2.Text = "";
                cal1.Num1 = 0;
                cal1.Num2 = 0;
                cal1.Op = string.Empty;
                txt1.Font = new Font(txt1.Font.FontFamily, 32);
                button21.Enabled = true;
                button20.Enabled = true;
                button16.Enabled = true;
                button12.Enabled = true;
            }
            else
            {
                cal1 = new My_calculator();
                cal1.Op = "×";
                cal1.Num1 = Convert.ToDouble(txt1.Text);
                button16.Enabled = false;
                txt2.Text = cal1.ToString();
            }
        }
        private void button20_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "Nan" || txt1.Text == "Cannot divide by zero" || txt1.Text == "∞")
            {
                txt1.Text = "0";
                txt2.Text = "";
                cal1.Num1 = 0;
                cal1.Num2 = 0;
                cal1.Op = string.Empty;
                txt1.Font = new Font(txt1.Font.FontFamily, 32);
                button21.Enabled = true;
                button20.Enabled = true;
                button16.Enabled = true;
                button12.Enabled = true;
            }
            else
            {
                cal1 = new My_calculator();
                cal1.Op = "-";
                cal1.Num1 = Convert.ToDouble(txt1.Text);
                button20.Enabled = false;
                txt2.Text = cal1.ToString();
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "Nan" || txt1.Text == "Cannot divide by zero" || txt1.Text == "∞")
            {
                txt1.Text = "0";
                txt2.Text = "";
                cal1.Num1 = 0;
                cal1.Num2 = 0;
                cal1.Op = string.Empty;
                txt1.Font = new Font(txt1.Font.FontFamily, 32);
                button21.Enabled = true;
                button20.Enabled = true;
                button16.Enabled = true;
                button12.Enabled = true;
            }
            else
            {
                cal1 = new My_calculator();
                cal1.Op = "÷";
                cal1.Num1 = Convert.ToDouble(txt1.Text);
                button12.Enabled = false;
                txt2.Text = cal1.ToString();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            txt1.Text = "0";
            txt2.Text = "";
            cal1.Num1 = 0;
            cal1.Num2 = 0;
            cal1.Op = string.Empty;
            txt1.Font = new Font(txt1.Font.FontFamily,32);
            button21.Enabled = true;
            button20.Enabled = true;
            button16.Enabled = true;
            button12.Enabled = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void button9_Click(object sender, EventArgs e)
        {
            txt1.Text = "rngj";
        }
        private void button9_Click_1(object sender, EventArgs e)
        {
            txt1.Text = "rnmkg";
        }
        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "Nan" || txt1.Text == "Cannot divide by zero" || txt1.Text == "∞")
            {
                txt1.Text = "0";
                txt2.Text = "";
                cal1.Num1 = 0;
                cal1.Num2 = 0;
                cal1.Op = string.Empty;
                txt1.Font = new Font(txt1.Font.FontFamily, 32);
                button21.Enabled = true;
                button20.Enabled = true;
                button16.Enabled = true;
                button12.Enabled = true;
            }
            else
            {
                if (txt1.Text.Length == 1)
                {
                    txt1.Text = "0";
                }
                else
                {
                    txt1.Text = txt1.Text.Substring(0, txt1.Text.Length - 1);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "Nan" || txt1.Text == "Cannot divide by zero" || txt1.Text == "∞")
            {
                txt1.Text = "0";
                txt2.Text = "";
                cal1.Num1 = 0;
                cal1.Num2 = 0;
                cal1.Op = string.Empty;
                txt1.Font = new Font(txt1.Font.FontFamily, 32);
                button21.Enabled = true;
                button20.Enabled = true;
                button16.Enabled = true;
                button12.Enabled = true;
            }
            else
            {
                cal1 = new My_calculator();
                cal1.Op = "**";
                cal1.Num1 = Convert.ToDouble(txt1.Text);
                txt1.Text = cal1.calculation().ToString();
                txt2.Text = cal1.ToString();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "Nan" || txt1.Text == "Cannot divide by zero" || txt1.Text == "∞")
            {
                txt1.Text = "0";
                txt2.Text = "";
                cal1.Num1 = 0;
                cal1.Num2 = 0;
                cal1.Op = string.Empty;
                txt1.Font = new Font(txt1.Font.FontFamily, 32);
                button21.Enabled = true;
                button20.Enabled = true;
                button16.Enabled = true;
                button12.Enabled = true;
            }
            else
            {
                cal1 = new My_calculator();
                cal1.Num1 = Convert.ToDouble(txt1.Text);
                cal1.Op = "1/";
                txt1.Text = cal1.calculation();
                txt2.Text = cal1.ToString();
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (txt1.Text == "Nan" || txt1.Text == "Cannot divide by zero" || txt1.Text == "∞")
            {
                txt1.Text = "0";
                txt2.Text = "";
                cal1.Num1 = 0;
                cal1.Num2 = 0;
                cal1.Op = string.Empty;
                txt1.Font = new Font(txt1.Font.FontFamily, 32);
            }
            else
            {
                if (txt1.Text == "0") { }
                else txt1.Text = Convert.ToString(-Convert.ToDouble(txt1.Text));
                txt2.Text = cal1.ToString();
            }
            button21.Enabled = true;
            button20.Enabled = true;
            button16.Enabled = true;
            button12.Enabled = true;
        }
        private void txt1_TextChanged(object sender, EventArgs e)
        {
            if (txt1.Text.Length < 12) { txt1.Font = new Font(txt1.Font.FontFamily, 32); }
            else
            {
               if (txt1.Text.Length > 12)
               {
                    txt1.Font = new Font(txt1.Font.FontFamily, 28);
                    if (txt1.Text.Length > 14)
                    {
                        txt1.Font = new Font(txt1.Font.FontFamily, 24);
                        if (txt1.Text.Length > 16)
                        {
                            txt1.Font = new Font(txt1.Font.FontFamily, 20);
                            if (txt1.Text.Length > 19)
                            {
                                txt1.Font = new Font(txt1.Font.FontFamily, 16);
                                if (txt1.Text.Length > 24) txt1.Text = txt1.Text.Substring(0, 24);
                            }
                        }
                    }
               }
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "Nan" || txt1.Text == "Cannot divide by zero" || txt1.Text == "∞")
            {
                txt1.Text = "0";
                txt2.Text = "";
                cal1.Num1 = 0;
                cal1.Num2 = 0;
                cal1.Op = string.Empty;
                txt1.Font = new Font(txt1.Font.FontFamily, 32);
                button21.Enabled = true;
                button20.Enabled = true;
                button16.Enabled = true;
                button12.Enabled = true;
            }
            else
            {
                cal1.Num1 = Convert.ToDouble(txt1.Text);
                cal1.Op = "√";
                txt1.Text = Math.Sqrt(Convert.ToDouble(txt1.Text)).ToString();
                txt2.Text = cal1.ToString();
            }
        }

        private void button9_Click_2(object sender, EventArgs e)
        {
            if (txt1.Text == "Nan" || txt1.Text == "Cannot divide by zero" || txt1.Text == "∞")
            {
                txt1.Text = "0";
                txt2.Text = "";
                cal1.Num1 = 0;
                cal1.Num2 = 0;
                cal1.Op = string.Empty;
                txt1.Font = new Font(txt1.Font.FontFamily, 32);
                button21.Enabled = true;
                button20.Enabled = true;
                button16.Enabled = true;
                button12.Enabled = true;
            }
            else
            {
                if (cal1.Num1 == 0) { }
                else if (cal1.Num1 != 0)
                {
                    cal1.Num2 = Convert.ToDouble(txt1.Text);
                    if (cal1.Op == "×") { txt1.Text = (cal1.Num2 / 100).ToString(); }
                    if (cal1.Op == "+") { txt1.Text = (cal1.Num1 * (cal1.Num2 / 100)).ToString(); }
                    if (cal1.Op == "-") { txt1.Text = (cal1.Num1 * (cal1.Num2 / 100)).ToString(); }
                    if (cal1.Op == "÷") { txt1.Text = (cal1.Num2 / 100).ToString(); }
                }
            }
        }
        private void txt2_TextChanged(object sender, EventArgs e)
        {
            if (txt2.Text.Length > 27)
            {
                txt2.Text += "...";
                txt2.Text = txt2.Text.Substring(0, 30);
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "Nan" || txt1.Text == "Cannot divide by zero" || txt1.Text == "∞")
            {
                txt1.Text = "0";
                txt2.Text = "";
                cal1.Num1 = 0;
                cal1.Num2 = 0;
                cal1.Op = string.Empty;
                txt1.Font = new Font(txt1.Font.FontFamily, 32);
                button21.Enabled = true;
                button20.Enabled = true;
                button16.Enabled = true;
                button12.Enabled = true;
            }
            else
            {
                txt1.Text = "0";
            }
        }
    }
}

