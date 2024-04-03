using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 Karina Contini - 2230591
 
 4/18/2023
 Final project 
 Form Dashboard with 4 tabs calling 6 applications:
 - Lotto Max
 - Lotto 649
 - Money Exchange
 - Temperature Conversion
 - Simple Calculator
 - IP Validator. 
 
 */

namespace FinalProject_KarinaContini
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to close the application?", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                Application.Exit();
            }
            
        }

        private void pbxLottoMax_Click(object sender, EventArgs e)
        {
            FrmLottoMax obj = new FrmLottoMax();
            obj.ShowDialog();
        }

        private void pbxLotto649_Click(object sender, EventArgs e)
        {
            FrmLotto649 obj = new FrmLotto649();
            obj.ShowDialog();
        }

        private void pbxTempConversion_Click(object sender, EventArgs e)
        {

            FrmTempConversions obj = new FrmTempConversions();
            obj.ShowDialog();
        }

        private void pbxIP_Validator_Click(object sender, EventArgs e)
        {
            FrmIP4_Validator obj = new FrmIP4_Validator();
            obj.ShowDialog();
        }

        private void pbxMoneyConversion_Click(object sender, EventArgs e)
        {
            FrmMoneyConversions obj = new FrmMoneyConversions();
            obj.ShowDialog();
        }

        private void pbxCalculator_Click(object sender, EventArgs e)
        {
            FrmCalculator obj = new FrmCalculator();
            obj.ShowDialog();
        }
    }
}
