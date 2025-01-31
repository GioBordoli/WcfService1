using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PerformCalculation("+");
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            PerformCalculation("-");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            PerformCalculation("*");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            PerformCalculation("/");
        }

        private void PerformCalculation(string operation)
        {
            try
            {
                double num1 = double.Parse(txtNumber1.Text);
                double num2 = double.Parse(txtNumber2.Text);
                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                        {
                            MessageBox.Show("Cannot divide by zero!");
                            return;
                        }
                        break;
                }

                lblResult.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers.");
            }
        }
    }
}

