using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public class My_calculator
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public int Counter1 { get; set; }
        public string Op { set; get; }

        public string calculation()
        {
            if (Op == "**") return (Num1 * Num1).ToString();
            else if (Op == "+") return (Num1 + Num2).ToString();
            else if (Op == "1/")
            {
                if (Num1 == 0) return "Cannot divide by zero";
                else return (1 / Num1).ToString();
            }
            else if (Op == "-") return (Num1 - Num2).ToString();
            else if (Op == "÷")
            {
                if (Num2 == 0) return "Cannot divide by zero";
                else return (Num1 / Num2).ToString();
            }
            else return (Num1 * Num2).ToString();
        }
        public override string ToString()
        {
            if (Num1 != 0 && Op == "1/")
                return "1 ÷ (" + Num1.ToString() + ")";
            else if (Num1 != 0 && Op == "**")
                return "sqr(" + Num1.ToString() + ")";
            else if (Num1 != 0 && Op == "√")
                return "√(" + Num1.ToString() + ")";
            else if (Num1 != 0 && Num2 == 0 && !string.IsNullOrEmpty(Op))
                return Num1.ToString() + " " + Op;
            else if (Num1 != 0 && Num2 != 0 && !string.IsNullOrEmpty(Op))
                return Num1.ToString() + " " + Op + " " + Num2.ToString() + " =";
            else return "";
        }
    }
}