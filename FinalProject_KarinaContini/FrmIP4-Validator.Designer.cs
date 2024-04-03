namespace FinalProject_KarinaContini
{
    partial class FrmIP4_Validator
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
            this.lblDay = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIP_Address = new System.Windows.Forms.TextBox();
            this.btnValidateIP = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(126, 43);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(43, 15);
            this.lblDay.TabIndex = 1;
            this.lblDay.Text = "Today:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter IP address:";
            // 
            // txtIP_Address
            // 
            this.txtIP_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP_Address.Location = new System.Drawing.Point(150, 133);
            this.txtIP_Address.Name = "txtIP_Address";
            this.txtIP_Address.Size = new System.Drawing.Size(261, 21);
            this.txtIP_Address.TabIndex = 3;
            // 
            // btnValidateIP
            // 
            this.btnValidateIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidateIP.Location = new System.Drawing.Point(54, 231);
            this.btnValidateIP.Name = "btnValidateIP";
            this.btnValidateIP.Size = new System.Drawing.Size(94, 23);
            this.btnValidateIP.TabIndex = 4;
            this.btnValidateIP.Text = "&Validate IP";
            this.btnValidateIP.UseVisualStyleBackColor = true;
            this.btnValidateIP.Click += new System.EventHandler(this.btnValidateIP_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(185, 231);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(316, 231);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmIP4_Validator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 329);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnValidateIP);
            this.Controls.Add(this.txtIP_Address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDay);
            this.Name = "FrmIP4_Validator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP4 Validator - Karina Contini";
            this.Load += new System.EventHandler(this.FrmIP4_Validator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIP_Address;
        private System.Windows.Forms.Button btnValidateIP;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
    }
}