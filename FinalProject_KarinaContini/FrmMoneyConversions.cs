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
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Data.SqlTypes;

/*
 * Exchange factor - Apr16,2023
 * 
 * 1 CAD = 0.73973 USD 
 * 1 CAD = 0.68055 EUR 
 * 1 CAD = 0.59545 GBP 
 * 1 CAD = 1.12692 AUD;

 */

namespace FinalProject_KarinaContini
{
    public partial class FrmMoneyConversions : Form
    {
        public FrmMoneyConversions()
        {
            InitializeComponent();
        }

        string filePath = @".\MoneyConversions.txt";
        DateTime initialDateTime;

        private void btnConvert_Click(object sender, EventArgs e)
        {

            double inputMoney;
            double convertedMoney;
            string inputCode="", convertedCode="";

            const double CAD_FACTOR = 1;
            const double USD_FACTOR = 0.73973;
            const double EUR_FACTOR = 0.68055;
            const double GBP_FACTOR = 0.59545;
            const double AUD_FACTOR = 1.12692;

            double iFactor = 0;
            double oFactor = 0;


            //check valid input
            try
            {
                txtInputMoney.Text = txtInputMoney.Text.Trim();
                inputMoney = Convert.ToDouble(txtInputMoney.Text);

                Regex myRegex = new Regex(@"^(\d{0,6})(\.\d*)?$");   

                if (myRegex.IsMatch(txtInputMoney.Text) == true)
                {
                    //check input
                    if (rdBtnFromCAD.Checked)
                    {
                        iFactor = CAD_FACTOR;
                        inputCode = "CAD";
                    }
                    else if(rdBtnFromUSD.Checked)
                    {
                        iFactor = USD_FACTOR;
                        inputCode = "USD";
                    }
                    else if (rdBtnFromEUR.Checked)
                    {
                        iFactor = EUR_FACTOR;
                        inputCode = "EUR";
                    }
                    else if (rdBtnFromGBP.Checked)
                    {
                        iFactor = GBP_FACTOR;
                        inputCode = "GBP";
                    }
                    else if (rdBtnFromAUD.Checked)
                    {
                        iFactor = AUD_FACTOR;
                        inputCode = "AUD";
                    }

                    //check input
                    if (rdBtnToCAD.Checked)
                    {
                        oFactor = CAD_FACTOR;
                        convertedCode = "CAD";
                    }
                    else if (rdBtnToUSD.Checked)
                    {
                        oFactor = USD_FACTOR;
                        convertedCode = "USD";
                    }
                    else if (rdBtnToEUR.Checked)
                    {
                        oFactor = EUR_FACTOR;
                        convertedCode = "EUR";
                    }
                    else if (rdBtnToGBP.Checked)
                    {
                        oFactor = GBP_FACTOR;
                        convertedCode = "GBP";
                    }
                    else if (rdBtnToAUD.Checked)
                    {
                        oFactor = AUD_FACTOR;
                        convertedCode = "AUD";
                    }

                    // conversion
                    convertedMoney = (inputMoney * oFactor) / iFactor;

                    //round 2 decimals
                    convertedMoney = Math.Round(convertedMoney, 2);
                    txtConvertedMoney.Text = convertedMoney.ToString();
                                  
                    //get date and time
                    DateTime currentDateTime = DateTime.Now;
                    string current = currentDateTime.ToShortDateString() + " " + currentDateTime.ToLongTimeString();

                    //write text file
                    FileStream fs1 = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                    StreamWriter objW = new StreamWriter(fs1);
                    objW.Write(txtInputMoney.Text + " "+inputCode+" = " + txtConvertedMoney.Text +" " + convertedCode + ",\t");
                    objW.WriteLine(current);
                    objW.Close();
                    fs1.Close();
                }
                else
                {
                    MessageBox.Show("Please, enter a positive number < 1,000,000.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtInputMoney.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please, enter a number to be converted.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        private void btnReadFile_Click(object sender, EventArgs e)
        {
            FileStream fs2 = null;
            try
            {
                fs2 = new FileStream(filePath, FileMode.OpenOrCreate,
                    FileAccess.Read);
                // code that uses the file stream to read and write data file
                // create the object for the input stream for a text file
                StreamReader textIn = new StreamReader(fs2);
                string textToPrint = "From/to\t\t\t Date&Time\n";
                // read the data from the file and store it in the list
                string content = textIn.ReadToEnd();
                textToPrint += content;

                if (content != null && content.Trim() != null)
                {
                    MessageBox.Show(textToPrint, "Money Exchange - Karina Contini", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("There are no registers.", "Money Exchange - Karina Contini", MessageBoxButtons.OK);
                // close the input stream for the text file
                textIn.Close();
            }
            catch (IOException ex)
            { MessageBox.Show(ex.Message, "IOException"); }
            finally { if (fs2 != null) fs2.Close(); }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want\nto quit the application\nMoney Exchange?", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                DateTime finalTime = DateTime.Now;
                TimeSpan difference = finalTime.Subtract(initialDateTime);

                MessageBox.Show("Form usage time: " + difference.Minutes + " minutes and " + difference.Seconds + " seconds.", "Form Usage Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //+ difference.Hours + " hours, " 
                this.Close();
            }
            else
            {
                txtInputMoney.Focus();
            }
        }

        private void FrmMoneyConversions_Load(object sender, EventArgs e)
        {
            rdBtnFromCAD.Checked = true;
            rdBtnToUSD.Checked = true;

            initialDateTime = DateTime.Now;
            
        }

        private void grpFrom_Enter(object sender, EventArgs e)
        {
            txtInputMoney.Clear();
            txtConvertedMoney.Clear();
            txtInputMoney.Focus();
        }

        private void grpTo_Enter(object sender, EventArgs e)
        {
            txtConvertedMoney.Clear();
            txtInputMoney.Focus();
        }
    }
}
