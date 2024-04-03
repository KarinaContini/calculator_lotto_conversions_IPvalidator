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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject_KarinaContini
{
    public partial class FrmIP4_Validator : Form
    {
        public FrmIP4_Validator()
        {
            InitializeComponent();
        }

        string pathBin = @".\IP_binary";

        DateTime initialDateTime;
        private void FrmIP4_Validator_Load(object sender, EventArgs e)
        {
            initialDateTime = DateTime.Now;
            string initial = initialDateTime.ToLongDateString();
            lblDay.Text = "Today: "+initial;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit the application?", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                DateTime finalTime = DateTime.Now;
                TimeSpan difference = finalTime.Subtract(initialDateTime);
                
                MessageBox.Show("Form usage time: "+difference.Minutes+" minutes and "+difference.Seconds+" seconds.", "Form Usage Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //+difference.Hours+" hours, "
                this.Close();
            }
            else
            {
                txtIP_Address.Focus();
            }
        }

        private void btnValidateIP_Click(object sender, EventArgs e)
        {
            txtIP_Address.Text = txtIP_Address.Text.Trim();
            try
            {

                Regex myRegex = new Regex(@"^(25[0-5]|2[0-4]\d|[0-1]?\d?\d)(\.(25[0-5]|2[0-4]\d|[0-1]?\d?\d)){3}$");

                if (myRegex.IsMatch(txtIP_Address.Text) == true)
                {
                    DateTime currentDateTime = DateTime.Now;
                    string current = currentDateTime.ToShortDateString() + " " + currentDateTime.ToLongTimeString();

                    FileStream fs3 = new FileStream(pathBin, FileMode.Append, FileAccess.Write);
                    BinaryWriter binaryOut = new BinaryWriter(fs3);
                    // write the fields into text file
                    binaryOut.Write(txtIP_Address.Text);
                    binaryOut.Write(current);
                    // close the output stream for the text file
                    binaryOut.Close();
                    fs3.Close();

                    MessageBox.Show(txtIP_Address.Text + "\nThe IP is correct.", "Valid", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(txtIP_Address.Text + "\nThe IP must have 4 bytes\ninteger number between 0 to 255\nsepareted by a dot (255.255.255.255).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtIP_Address.Clear();
            txtIP_Address.Focus();
        }
    }
}
