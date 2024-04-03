using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_KarinaContini
{
    public partial class FrmCalculator : Form
    {
        public FrmCalculator()
        {
            InitializeComponent();
        }

        Calculator calc = new Calculator();
        Boolean operatorOn = false;
        Boolean equalOn = false;
        string filePath = @".\Calculator.txt";

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close the App.?", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
            else
            {
                btnClear.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            calc.Clear();
            txtDisplay.Text = "0";
            lblRecord.Text = "";
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text=="0" || operatorOn == true)
            {
                txtDisplay.Text = "1";
                operatorOn = false;
                equalOn = false;

            }
            else
            {
                txtDisplay.Text += "1";
            }
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || operatorOn == true)
            {
                txtDisplay.Text = "2";
                operatorOn = false;
                equalOn = false;

            }
            else
            {
                txtDisplay.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || operatorOn == true)
            {
                txtDisplay.Text = "3";
                operatorOn = false;
                equalOn = false;

            }
            else
            {
                txtDisplay.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || operatorOn == true)
            {
                txtDisplay.Text = "4";
                operatorOn = false;
                equalOn = false;

            }
            else
            {
                txtDisplay.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || operatorOn == true)
            {
                txtDisplay.Text = "5";
                operatorOn = false;
                equalOn = false;

            }
            else
            {
                txtDisplay.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || operatorOn == true)
            {
                txtDisplay.Text = "6";
                operatorOn = false;
                equalOn = false;

            }
            else
            {
                txtDisplay.Text += "6";
            }
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || operatorOn == true)
            {
                txtDisplay.Text = "7";
                operatorOn = false;
                equalOn = false;

            }
            else
            {
                txtDisplay.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || operatorOn == true)
            {
                txtDisplay.Text = "8";
                operatorOn = false;
                equalOn = false;

            }
            else
            {
                txtDisplay.Text += "8";
            }
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || operatorOn == true)
            {
                txtDisplay.Text = "9";
                operatorOn = false;
                equalOn = false;

            }
            else
            {
                txtDisplay.Text += "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || operatorOn == true)
            {
                txtDisplay.Text = "0";
                operatorOn = false;
                equalOn = false;

            }
            else
            {
                txtDisplay.Text += "0";
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "" || operatorOn == true)
            {
                txtDisplay.Text = "0.";
                operatorOn = false;
                equalOn = false;

            }
            else
            {
                Regex myRegex = new Regex(@"^\d*\.\d*$");

                if (myRegex.IsMatch(txtDisplay.Text) == true)
                {
                    txtDisplay.Text = txtDisplay.Text;
                }
                else
                {
                    txtDisplay.Text += ".";
                }
            }       

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "")
            {
                MessageBox.Show("Invalid format used.");
            }
            else
            {
                lblRecord.Text = txtDisplay.Text + " + ";
                operatorOn = true;
                equalOn = false;
                calc.Add(Convert.ToDecimal(txtDisplay.Text));
           
            }
        }

        private void btnSubt_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "")
            {
                MessageBox.Show("Invalid format used.");
            }
            else
            {
                lblRecord.Text = txtDisplay.Text + " - ";
                operatorOn = true;
                equalOn = false;
                calc.Subtract(Convert.ToDecimal(txtDisplay.Text));
           
            }

        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "")
            {
                MessageBox.Show("Invalid format used.");
            }
            else
            {
                lblRecord.Text = txtDisplay.Text + " * ";
                operatorOn = true;
                equalOn = false;
                calc.Multiply(Convert.ToDecimal(txtDisplay.Text));
           
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "")
            {
                MessageBox.Show("Invalid format used.");
            }
            else
            {
                lblRecord.Text = txtDisplay.Text + " / ";
                operatorOn = true;
                equalOn = false;
                calc.Divide(Convert.ToDecimal(txtDisplay.Text));
         
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (equalOn == true)
            {
                int index = lblRecord.Text.IndexOf(" ");
                lblRecord.Text = calc.CurrentValue.ToString() + lblRecord.Text.Substring(index);
                calc.Equals();
                operatorOn = true;
                txtDisplay.Text = calc.CurrentValue.ToString();

            }
            else
            {
                calc.Equals(Convert.ToDecimal(txtDisplay.Text));
                operatorOn = true;
                lblRecord.Text += txtDisplay.Text + " =";
                txtDisplay.Text = calc.CurrentValue.ToString();
                equalOn = true;
            }

            //write text file
            FileStream fs1 = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            StreamWriter objW = new StreamWriter(fs1);
            objW.Write(lblRecord.Text + " ");
            objW.WriteLine(calc.CurrentValue.ToString());
            objW.Close();
            fs1.Close();
        }

        private void btnSignal_Click(object sender, EventArgs e)
        {

            calc.Signal(Convert.ToDecimal(txtDisplay.Text));
            txtDisplay.Text = calc.CurrentValue.ToString();
        }
    }
}
