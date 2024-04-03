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

namespace FinalProject_KarinaContini
{
    public partial class FrmLotto649 : Form
    {
        public FrmLotto649()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit this application?", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
            else
            {
                btnGenerate.Focus();
            }
        }

        
        string filePath = @".\LottoNbrs.txt";

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int[] randomNumber = new int[7]; // to generate from 1 to 49 range should be random.Next(1, 50);

            txtLotto649.Clear();

            DateTime currentDateTime = DateTime.Now;
            string current = currentDateTime.ToShortDateString()+" "+currentDateTime.ToLongTimeString();


            FileStream fs1 = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            StreamWriter objW = new StreamWriter(fs1);
            objW.Write("649,\t"+ current+",\t");

            for (int i = 0; i < randomNumber.Length; i++)
            {
                randomNumber[i] = random.Next(1,50);
                for (int k = 0; k < i; k++)
                {
                    while (randomNumber[k] == randomNumber[i])
                    {
                        randomNumber[i] = random.Next(1, 50);
                        k = 0;
                    }
                }
                txtLotto649.Text += randomNumber[i].ToString() + "\t";

                if(i == randomNumber.Length - 1)
                    objW.WriteLine(" Bonus "+randomNumber[i].ToString());
                else
                    objW.Write(randomNumber[i].ToString() + ",");
            }

            objW.Close();
            fs1.Close();
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
                string textToPrint = "Lotto\t Date&Time\t\t Draw Numbers\n\n";
                // read the data from the file and store it in the list
                string content = textIn.ReadToEnd();
                textToPrint += content;

                if (content != null || content.Trim() != null)
                {
                    MessageBox.Show(textToPrint,"Lotto - Karina Contini", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("There are no registers.", "Lotto - Karina Contini", MessageBoxButtons.OK);
                // close the input stream for the text file
                textIn.Close();
            }
            catch (IOException ex)
            { MessageBox.Show(ex.Message, "IOException"); }
            finally { if (fs2 != null) fs2.Close(); }
        }
    }
}
