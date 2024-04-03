namespace FinalProject_KarinaContini
{
    partial class FrmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxLotto649 = new System.Windows.Forms.PictureBox();
            this.pbxLottoMax = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbxTempConversion = new System.Windows.Forms.PictureBox();
            this.pbxMoneyConversion = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pbxCalculator = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pbxIP_Validator = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLotto649)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLottoMax)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTempConversion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMoneyConversion)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCalculator)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIP_Validator)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(25, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(481, 345);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(473, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Generated Numbers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pbxLotto649);
            this.groupBox1.Controls.Add(this.pbxLottoMax);
            this.groupBox1.Location = new System.Drawing.Point(32, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 245);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lotto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lotto 649";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lotto Max";
            // 
            // pbxLotto649
            // 
            this.pbxLotto649.Image = ((System.Drawing.Image)(resources.GetObject("pbxLotto649.Image")));
            this.pbxLotto649.Location = new System.Drawing.Point(204, 36);
            this.pbxLotto649.Name = "pbxLotto649";
            this.pbxLotto649.Size = new System.Drawing.Size(175, 178);
            this.pbxLotto649.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLotto649.TabIndex = 1;
            this.pbxLotto649.TabStop = false;
            this.pbxLotto649.Click += new System.EventHandler(this.pbxLotto649_Click);
            // 
            // pbxLottoMax
            // 
            this.pbxLottoMax.Image = ((System.Drawing.Image)(resources.GetObject("pbxLottoMax.Image")));
            this.pbxLottoMax.Location = new System.Drawing.Point(23, 36);
            this.pbxLottoMax.Name = "pbxLottoMax";
            this.pbxLottoMax.Size = new System.Drawing.Size(175, 178);
            this.pbxLottoMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLottoMax.TabIndex = 0;
            this.pbxLottoMax.TabStop = false;
            this.pbxLottoMax.Click += new System.EventHandler(this.pbxLottoMax_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(473, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Conversions";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.pbxTempConversion);
            this.groupBox3.Controls.Add(this.pbxMoneyConversion);
            this.groupBox3.Location = new System.Drawing.Point(33, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(398, 245);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Conversions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Temperature Convert";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Money Exchange";
            // 
            // pbxTempConversion
            // 
            this.pbxTempConversion.Image = ((System.Drawing.Image)(resources.GetObject("pbxTempConversion.Image")));
            this.pbxTempConversion.Location = new System.Drawing.Point(204, 36);
            this.pbxTempConversion.Name = "pbxTempConversion";
            this.pbxTempConversion.Size = new System.Drawing.Size(175, 178);
            this.pbxTempConversion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxTempConversion.TabIndex = 1;
            this.pbxTempConversion.TabStop = false;
            this.pbxTempConversion.Click += new System.EventHandler(this.pbxTempConversion_Click);
            // 
            // pbxMoneyConversion
            // 
            this.pbxMoneyConversion.Image = ((System.Drawing.Image)(resources.GetObject("pbxMoneyConversion.Image")));
            this.pbxMoneyConversion.Location = new System.Drawing.Point(23, 36);
            this.pbxMoneyConversion.Name = "pbxMoneyConversion";
            this.pbxMoneyConversion.Size = new System.Drawing.Size(175, 178);
            this.pbxMoneyConversion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMoneyConversion.TabIndex = 0;
            this.pbxMoneyConversion.TabStop = false;
            this.pbxMoneyConversion.Click += new System.EventHandler(this.pbxMoneyConversion_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pbxCalculator);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(473, 319);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Simple Calculator";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pbxCalculator
            // 
            this.pbxCalculator.Image = ((System.Drawing.Image)(resources.GetObject("pbxCalculator.Image")));
            this.pbxCalculator.Location = new System.Drawing.Point(119, 29);
            this.pbxCalculator.Name = "pbxCalculator";
            this.pbxCalculator.Size = new System.Drawing.Size(213, 253);
            this.pbxCalculator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCalculator.TabIndex = 1;
            this.pbxCalculator.TabStop = false;
            this.pbxCalculator.Click += new System.EventHandler(this.pbxCalculator_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pbxIP_Validator);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(473, 319);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "IP v4 Validator";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pbxIP_Validator
            // 
            this.pbxIP_Validator.Image = ((System.Drawing.Image)(resources.GetObject("pbxIP_Validator.Image")));
            this.pbxIP_Validator.Location = new System.Drawing.Point(130, 33);
            this.pbxIP_Validator.Name = "pbxIP_Validator";
            this.pbxIP_Validator.Size = new System.Drawing.Size(213, 253);
            this.pbxIP_Validator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxIP_Validator.TabIndex = 2;
            this.pbxIP_Validator.TabStop = false;
            this.pbxIP_Validator.Click += new System.EventHandler(this.pbxIP_Validator_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(427, 383);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 426);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard - Karina Contini";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLotto649)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLottoMax)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTempConversion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMoneyConversion)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCalculator)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxIP_Validator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbxLotto649;
        private System.Windows.Forms.PictureBox pbxLottoMax;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pbxTempConversion;
        private System.Windows.Forms.PictureBox pbxMoneyConversion;
        private System.Windows.Forms.PictureBox pbxCalculator;
        private System.Windows.Forms.PictureBox pbxIP_Validator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

