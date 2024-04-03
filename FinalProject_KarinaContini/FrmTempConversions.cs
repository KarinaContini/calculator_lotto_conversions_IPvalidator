using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;



namespace FinalProject_KarinaContini
{
    public partial class FrmTempConversions : Form
    {
        
        public FrmTempConversions()
        {
            InitializeComponent();
        }

        private void rdBtnCtoF_CheckedChanged(object sender, EventArgs e)
        {
            lblInputTemp.Text = "°C";
            lblConvertedTemp.Text = "°F";
            txtConvertedTemp.Clear();
            txtInputTemp.Clear();
            txtMessage.Clear();
        }

        private void rdBtnFtoC_CheckedChanged(object sender, EventArgs e)
        {
            lblInputTemp.Text = "°F";
            lblConvertedTemp.Text = "°C";
            txtConvertedTemp.Clear();
            txtInputTemp.Clear();
            txtMessage.Clear();
        }

        string filePath = @".\TempConversions.txt";
        private void btnConvert_Click(object sender, EventArgs e)
        {

            double temp;
            double convertedTemp = 0;
            double noteNumber = 0;

            //check valid input
            try
            {
                temp = Convert.ToDouble(txtInputTemp.Text.Trim());

                Regex myRegex = new Regex(@"^-?(\d{0,3})(\.\d*)?$");  //^(|-?\d+)$


                if (myRegex.IsMatch(txtInputTemp.Text.Trim()) == true)
                {
                    //make conversion
                    if (rdBtnCtoF.Checked)
                    {
                        convertedTemp = (temp * 9) / 5 + 32;
                        noteNumber = temp;
                    }
                    else if (rdBtnFtoC.Checked)
                    {
                        convertedTemp = ((temp - 32) * 5) / 9;
                        noteNumber = convertedTemp;
                    }
                    txtConvertedTemp.Text = convertedTemp.ToString();

                    //set the message and color
                    if (noteNumber < 103 && noteNumber >= 97)
                    {
                        txtMessage.ForeColor = Color.DarkRed;
                        txtInputTemp.ForeColor = Color.DarkRed;
                        txtMessage.Text = "Water boils";
                    }
                    else if (noteNumber < 43 && noteNumber >= 38)
                    {
                        txtMessage.ForeColor = Color.Red;
                        txtInputTemp.ForeColor = Color.Red;
                        txtMessage.Text = "Hot Bath";
                    }
                    else if (noteNumber < 37.6 && noteNumber >= 36.5)
                    {
                        txtMessage.ForeColor = Color.Orange;
                        txtInputTemp.ForeColor = Color.Orange;
                        txtMessage.Text = "Body temperature";
                    }
                    else if (noteNumber < 36.5 && noteNumber >= 30)
                    {
                        txtMessage.ForeColor = Color.Orange;
                        txtInputTemp.ForeColor = Color.Orange;
                        txtMessage.Text = "Beach weather";
                    }
                    else if (noteNumber < 25 && noteNumber >= 19)
                    {
                        txtMessage.ForeColor = Color.Green;
                        txtInputTemp.ForeColor = Color.Green;
                        txtMessage.Text = "Room temperature";                 
                    }
                    else if (noteNumber <= 10 && noteNumber > 0)
                    {
                        txtMessage.ForeColor = Color.DeepSkyBlue;
                        txtInputTemp.ForeColor = Color.DeepSkyBlue;
                        txtMessage.Text = "Cold Day";
                    }
                    else if (noteNumber == 0)
                    {
                        txtMessage.ForeColor = Color.Blue;
                        txtInputTemp.ForeColor = Color.Blue;
                        txtMessage.Text = "Freezing point of water";
                    }
                    else if (noteNumber < 0 && noteNumber >= -27)
                    {
                        txtMessage.ForeColor = Color.Blue;
                        txtInputTemp.ForeColor = Color.Blue;
                        txtMessage.Text = "Very cold day";
                    }
                    else if (noteNumber < -27 && noteNumber > -40)
                    {
                        txtMessage.ForeColor = Color.MediumPurple;
                        txtInputTemp.ForeColor = Color.MediumPurple;
                        txtMessage.Text = "Extremely Cold Day";
                    }
                    else if (noteNumber == -40)
                    {
                        txtMessage.ForeColor = Color.MediumPurple;
                        txtInputTemp.ForeColor = Color.MediumPurple;
                        txtMessage.Text = "Extremely Cold Day (and the same number!)";
                    }

                    //get date and time
                    DateTime currentDateTime = DateTime.Now;
                    string current = currentDateTime.ToShortDateString() + " " + currentDateTime.ToLongTimeString();

                    //write text file
                    FileStream fs1 = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                    StreamWriter objW = new StreamWriter(fs1);
                    objW.Write(txtInputTemp.Text + " " + lblInputTemp.Text + " = " + txtConvertedTemp.Text + " " + lblConvertedTemp.Text + ",\t");
                    objW.Write(current + ",  ");
                    objW.WriteLine(txtMessage.Text);
                    objW.Close();
                    fs1.Close();
                }
                else
                {
                    MessageBox.Show("Please, enter a number < 1000 and > -1000.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtInputTemp.Focus();   
                }
            }
            catch (Exception)
            {
                lblInputTemp.ForeColor = Color.Red;
                MessageBox.Show("Please, enter a number to be converted.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close the application?", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
            else
            {
                txtInputTemp.Focus();
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
                string textToPrint = "From/To\t\t Date&Time\t\t Note\n";
                // read the data from the file and store it in the list
                string content = textIn.ReadToEnd();
                textToPrint += content;

                if (content != null && content.Trim() != null)
                {
                    MessageBox.Show(textToPrint, "Temperature Conversion - Karina Contini", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("There are no registers.", "Temperature Conversion - Karina Contini", MessageBoxButtons.OK);
                // close the input stream for the text file
                textIn.Close();
            }
            catch (IOException ex)
            { MessageBox.Show(ex.Message, "IOException"); }
            finally { if (fs2 != null) fs2.Close(); }
        }

        private void txtInputTemp_TextChanged(object sender, EventArgs e)
        {
            lblInputTemp.ForeColor = Color.Black;
            txtInputTemp.ForeColor = Color.Black;
            txtConvertedTemp.Clear();
            txtMessage.Clear();
        }
    }
}
