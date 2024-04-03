namespace FinalProject_KarinaContini
{
    partial class FrmTempConversions
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
            this.rdBtnCtoF = new System.Windows.Forms.RadioButton();
            this.rdBtnFtoC = new System.Windows.Forms.RadioButton();
            this.txtInputTemp = new System.Windows.Forms.TextBox();
            this.txtConvertedTemp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInputTemp = new System.Windows.Forms.Label();
            this.lblConvertedTemp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rdBtnCtoF
            // 
            this.rdBtnCtoF.AutoSize = true;
            this.rdBtnCtoF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnCtoF.Location = new System.Drawing.Point(204, 34);
            this.rdBtnCtoF.Name = "rdBtnCtoF";
            this.rdBtnCtoF.Size = new System.Drawing.Size(111, 21);
            this.rdBtnCtoF.TabIndex = 0;
            this.rdBtnCtoF.TabStop = true;
            this.rdBtnCtoF.Text = "From °C to °F";
            this.rdBtnCtoF.UseVisualStyleBackColor = true;
            this.rdBtnCtoF.CheckedChanged += new System.EventHandler(this.rdBtnCtoF_CheckedChanged);
            // 
            // rdBtnFtoC
            // 
            this.rdBtnFtoC.AutoSize = true;
            this.rdBtnFtoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnFtoC.Location = new System.Drawing.Point(204, 69);
            this.rdBtnFtoC.Name = "rdBtnFtoC";
            this.rdBtnFtoC.Size = new System.Drawing.Size(111, 21);
            this.rdBtnFtoC.TabIndex = 1;
            this.rdBtnFtoC.TabStop = true;
            this.rdBtnFtoC.Text = "From °F to °C";
            this.rdBtnFtoC.UseVisualStyleBackColor = true;
            this.rdBtnFtoC.CheckedChanged += new System.EventHandler(this.rdBtnFtoC_CheckedChanged);
            // 
            // txtInputTemp
            // 
            this.txtInputTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtInputTemp.Location = new System.Drawing.Point(87, 145);
            this.txtInputTemp.Name = "txtInputTemp";
            this.txtInputTemp.Size = new System.Drawing.Size(120, 23);
            this.txtInputTemp.TabIndex = 2;
            this.txtInputTemp.TextChanged += new System.EventHandler(this.txtInputTemp_TextChanged);
            // 
            // txtConvertedTemp
            // 
            this.txtConvertedTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtConvertedTemp.Location = new System.Drawing.Point(291, 145);
            this.txtConvertedTemp.Name = "txtConvertedTemp";
            this.txtConvertedTemp.ReadOnly = true;
            this.txtConvertedTemp.Size = new System.Drawing.Size(120, 23);
            this.txtConvertedTemp.TabIndex = 3;
            this.txtConvertedTemp.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "to";
            // 
            // lblInputTemp
            // 
            this.lblInputTemp.AutoSize = true;
            this.lblInputTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputTemp.Location = new System.Drawing.Point(143, 176);
            this.lblInputTemp.Name = "lblInputTemp";
            this.lblInputTemp.Size = new System.Drawing.Size(27, 18);
            this.lblInputTemp.TabIndex = 5;
            this.lblInputTemp.Text = "°C";
            // 
            // lblConvertedTemp
            // 
            this.lblConvertedTemp.AutoSize = true;
            this.lblConvertedTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvertedTemp.Location = new System.Drawing.Point(342, 176);
            this.lblConvertedTemp.Name = "lblConvertedTemp";
            this.lblConvertedTemp.Size = new System.Drawing.Size(25, 18);
            this.lblConvertedTemp.TabIndex = 6;
            this.lblConvertedTemp.Text = "°F";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Message:";
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(37, 372);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(114, 23);
            this.btnConvert.TabIndex = 9;
            this.btnConvert.Text = "&Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnReadFile
            // 
            this.btnReadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadFile.Location = new System.Drawing.Point(194, 372);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(114, 23);
            this.btnReadFile.TabIndex = 10;
            this.btnReadFile.Text = "&Read File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(351, 372);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(37, 259);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.Size = new System.Drawing.Size(428, 91);
            this.txtMessage.TabIndex = 12;
            this.txtMessage.TabStop = false;
            this.txtMessage.Text = "";
            // 
            // FrmTempConversions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 426);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblConvertedTemp);
            this.Controls.Add(this.lblInputTemp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConvertedTemp);
            this.Controls.Add(this.txtInputTemp);
            this.Controls.Add(this.rdBtnFtoC);
            this.Controls.Add(this.rdBtnCtoF);
            this.Name = "FrmTempConversions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature Conversion - Karina Contini";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdBtnCtoF;
        private System.Windows.Forms.RadioButton rdBtnFtoC;
        private System.Windows.Forms.TextBox txtInputTemp;
        private System.Windows.Forms.TextBox txtConvertedTemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInputTemp;
        private System.Windows.Forms.Label lblConvertedTemp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RichTextBox txtMessage;
    }
}