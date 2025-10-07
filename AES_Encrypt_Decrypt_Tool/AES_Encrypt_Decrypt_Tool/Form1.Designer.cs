namespace AES_Encrypt_Decrypt_Tool
{
    partial class Form1
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
            this.txtInputData = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblOutPut = new System.Windows.Forms.Label();
            this.txtOutputData = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.lbIV = new System.Windows.Forms.Label();
            this.txtIV = new System.Windows.Forms.TextBox();
            this.lblKEY = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInputData
            // 
            this.txtInputData.Location = new System.Drawing.Point(331, 91);
            this.txtInputData.Name = "txtInputData";
            this.txtInputData.Size = new System.Drawing.Size(100, 20);
            this.txtInputData.TabIndex = 0;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(245, 91);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(57, 13);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Input Data";
            // 
            // lblOutPut
            // 
            this.lblOutPut.AutoSize = true;
            this.lblOutPut.Location = new System.Drawing.Point(470, 91);
            this.lblOutPut.Name = "lblOutPut";
            this.lblOutPut.Size = new System.Drawing.Size(66, 13);
            this.lblOutPut.TabIndex = 3;
            this.lblOutPut.Text = "OutPut Data";
            // 
            // txtOutputData
            // 
            this.txtOutputData.Location = new System.Drawing.Point(556, 91);
            this.txtOutputData.Name = "txtOutputData";
            this.txtOutputData.Size = new System.Drawing.Size(100, 20);
            this.txtOutputData.TabIndex = 2;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(331, 161);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 4;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(435, 161);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 5;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // lbIV
            // 
            this.lbIV.AutoSize = true;
            this.lbIV.Location = new System.Drawing.Point(245, 126);
            this.lbIV.Name = "lbIV";
            this.lbIV.Size = new System.Drawing.Size(41, 13);
            this.lbIV.TabIndex = 7;
            this.lbIV.Text = "AES IV";
            // 
            // txtIV
            // 
            this.txtIV.Location = new System.Drawing.Point(331, 126);
            this.txtIV.Name = "txtIV";
            this.txtIV.Size = new System.Drawing.Size(100, 20);
            this.txtIV.TabIndex = 6;
            // 
            // lblKEY
            // 
            this.lblKEY.AutoSize = true;
            this.lblKEY.Location = new System.Drawing.Point(470, 126);
            this.lblKEY.Name = "lblKEY";
            this.lblKEY.Size = new System.Drawing.Size(52, 13);
            this.lblKEY.TabIndex = 9;
            this.lblKEY.Text = "AES KEY";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(556, 126);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(100, 20);
            this.txtKey.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(546, 160);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblKEY);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.lbIV);
            this.Controls.Add(this.txtIV);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.lblOutPut);
            this.Controls.Add(this.txtOutputData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtInputData);
            this.Name = "Form1";
            this.Text = "AES_Encrypt_Decrypt_Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblOutPut;
        private System.Windows.Forms.TextBox txtOutputData;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label lbIV;
        private System.Windows.Forms.TextBox txtIV;
        private System.Windows.Forms.Label lblKEY;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button btnClear;
    }
}

