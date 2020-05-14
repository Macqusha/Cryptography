namespace Labs
{
    partial class Form09
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
            this.f9_fieldKeyword = new System.Windows.Forms.TextBox();
            this.f9_label2 = new System.Windows.Forms.Label();
            this.f9_ButtonDecrypt = new System.Windows.Forms.Button();
            this.f9_fieldCiphertext = new System.Windows.Forms.TextBox();
            this.f9_ButtonEncrypt = new System.Windows.Forms.Button();
            this.f9_fieldOriginal = new System.Windows.Forms.TextBox();
            this.f9_label1 = new System.Windows.Forms.Label();
            this.f9_label4 = new System.Windows.Forms.Label();
            this.f9_label3 = new System.Windows.Forms.Label();
            this.f9_ButtonClearOriginal = new System.Windows.Forms.Label();
            this.f9_ButtonClearKeyword = new System.Windows.Forms.Label();
            this.f9_ButtonClearCiphertext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // f9_fieldKeyword
            // 
            this.f9_fieldKeyword.Location = new System.Drawing.Point(40, 80);
            this.f9_fieldKeyword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f9_fieldKeyword.Name = "f9_fieldKeyword";
            this.f9_fieldKeyword.Size = new System.Drawing.Size(555, 20);
            this.f9_fieldKeyword.TabIndex = 7;
            this.f9_fieldKeyword.Enter += new System.EventHandler(this.f9_fieldKeyword_Enter);
            this.f9_fieldKeyword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f9_fieldKeyword_KeyPress);
            // 
            // f9_label2
            // 
            this.f9_label2.AutoSize = true;
            this.f9_label2.Location = new System.Drawing.Point(40, 60);
            this.f9_label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f9_label2.Name = "f9_label2";
            this.f9_label2.Size = new System.Drawing.Size(80, 13);
            this.f9_label2.TabIndex = 6;
            this.f9_label2.Text = "Введите ключ:";
            // 
            // f9_ButtonDecrypt
            // 
            this.f9_ButtonDecrypt.Location = new System.Drawing.Point(345, 320);
            this.f9_ButtonDecrypt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f9_ButtonDecrypt.Name = "f9_ButtonDecrypt";
            this.f9_ButtonDecrypt.Size = new System.Drawing.Size(250, 25);
            this.f9_ButtonDecrypt.TabIndex = 5;
            this.f9_ButtonDecrypt.Text = "Расшифровать";
            this.f9_ButtonDecrypt.UseVisualStyleBackColor = true;
            this.f9_ButtonDecrypt.Click += new System.EventHandler(this.f9_ButtonDecrypt_Click);
            // 
            // f9_fieldCiphertext
            // 
            this.f9_fieldCiphertext.Location = new System.Drawing.Point(345, 140);
            this.f9_fieldCiphertext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f9_fieldCiphertext.Multiline = true;
            this.f9_fieldCiphertext.Name = "f9_fieldCiphertext";
            this.f9_fieldCiphertext.Size = new System.Drawing.Size(250, 170);
            this.f9_fieldCiphertext.TabIndex = 4;
            // 
            // f9_ButtonEncrypt
            // 
            this.f9_ButtonEncrypt.Location = new System.Drawing.Point(40, 320);
            this.f9_ButtonEncrypt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f9_ButtonEncrypt.Name = "f9_ButtonEncrypt";
            this.f9_ButtonEncrypt.Size = new System.Drawing.Size(250, 25);
            this.f9_ButtonEncrypt.TabIndex = 3;
            this.f9_ButtonEncrypt.Text = "Зашифровать";
            this.f9_ButtonEncrypt.UseVisualStyleBackColor = true;
            this.f9_ButtonEncrypt.Click += new System.EventHandler(this.f9_ButtonEncrypt_Click);
            // 
            // f9_fieldOriginal
            // 
            this.f9_fieldOriginal.Location = new System.Drawing.Point(40, 140);
            this.f9_fieldOriginal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f9_fieldOriginal.Multiline = true;
            this.f9_fieldOriginal.Name = "f9_fieldOriginal";
            this.f9_fieldOriginal.Size = new System.Drawing.Size(250, 170);
            this.f9_fieldOriginal.TabIndex = 2;
            // 
            // f9_label1
            // 
            this.f9_label1.AutoSize = true;
            this.f9_label1.Location = new System.Drawing.Point(272, 20);
            this.f9_label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f9_label1.Name = "f9_label1";
            this.f9_label1.Size = new System.Drawing.Size(90, 13);
            this.f9_label1.TabIndex = 1;
            this.f9_label1.Text = "Шифр Виженера";
            // 
            // f9_label4
            // 
            this.f9_label4.AutoSize = true;
            this.f9_label4.Location = new System.Drawing.Point(345, 120);
            this.f9_label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f9_label4.Name = "f9_label4";
            this.f9_label4.Size = new System.Drawing.Size(64, 13);
            this.f9_label4.TabIndex = 11;
            this.f9_label4.Text = "Шифртекст";
            // 
            // f9_label3
            // 
            this.f9_label3.AutoSize = true;
            this.f9_label3.Location = new System.Drawing.Point(40, 120);
            this.f9_label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f9_label3.Name = "f9_label3";
            this.f9_label3.Size = new System.Drawing.Size(89, 13);
            this.f9_label3.TabIndex = 10;
            this.f9_label3.Text = "Исходный текст";
            // 
            // f9_ButtonClearOriginal
            // 
            this.f9_ButtonClearOriginal.AutoSize = true;
            this.f9_ButtonClearOriginal.ForeColor = System.Drawing.Color.Gray;
            this.f9_ButtonClearOriginal.Location = new System.Drawing.Point(236, 125);
            this.f9_ButtonClearOriginal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f9_ButtonClearOriginal.Name = "f9_ButtonClearOriginal";
            this.f9_ButtonClearOriginal.Size = new System.Drawing.Size(54, 13);
            this.f9_ButtonClearOriginal.TabIndex = 14;
            this.f9_ButtonClearOriginal.Text = "Очистить";
            this.f9_ButtonClearOriginal.Click += new System.EventHandler(this.f9_ButtonClearOriginal_Click);
            // 
            // f9_ButtonClearKeyword
            // 
            this.f9_ButtonClearKeyword.AutoSize = true;
            this.f9_ButtonClearKeyword.BackColor = System.Drawing.Color.Transparent;
            this.f9_ButtonClearKeyword.ForeColor = System.Drawing.Color.Gray;
            this.f9_ButtonClearKeyword.Location = new System.Drawing.Point(541, 65);
            this.f9_ButtonClearKeyword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f9_ButtonClearKeyword.Name = "f9_ButtonClearKeyword";
            this.f9_ButtonClearKeyword.Size = new System.Drawing.Size(54, 13);
            this.f9_ButtonClearKeyword.TabIndex = 15;
            this.f9_ButtonClearKeyword.Text = "Очистить";
            this.f9_ButtonClearKeyword.Click += new System.EventHandler(this.f9_ButtonClearKeyword_Click);
            // 
            // f9_ButtonClearCiphertext
            // 
            this.f9_ButtonClearCiphertext.AutoSize = true;
            this.f9_ButtonClearCiphertext.ForeColor = System.Drawing.Color.Gray;
            this.f9_ButtonClearCiphertext.Location = new System.Drawing.Point(541, 125);
            this.f9_ButtonClearCiphertext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f9_ButtonClearCiphertext.Name = "f9_ButtonClearCiphertext";
            this.f9_ButtonClearCiphertext.Size = new System.Drawing.Size(54, 13);
            this.f9_ButtonClearCiphertext.TabIndex = 16;
            this.f9_ButtonClearCiphertext.Text = "Очистить";
            this.f9_ButtonClearCiphertext.Click += new System.EventHandler(this.f9_ButtonClearCiphertext_Click);
            // 
            // Form09
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.f9_ButtonClearOriginal);
            this.Controls.Add(this.f9_ButtonClearKeyword);
            this.Controls.Add(this.f9_ButtonClearCiphertext);
            this.Controls.Add(this.f9_label4);
            this.Controls.Add(this.f9_label3);
            this.Controls.Add(this.f9_fieldKeyword);
            this.Controls.Add(this.f9_label2);
            this.Controls.Add(this.f9_ButtonDecrypt);
            this.Controls.Add(this.f9_fieldCiphertext);
            this.Controls.Add(this.f9_ButtonEncrypt);
            this.Controls.Add(this.f9_fieldOriginal);
            this.Controls.Add(this.f9_label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(100, 100);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form09";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Шифр Виженера";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox f9_fieldKeyword;
        private System.Windows.Forms.Label f9_label2;
        private System.Windows.Forms.Button f9_ButtonDecrypt;
        private System.Windows.Forms.TextBox f9_fieldCiphertext;
        private System.Windows.Forms.Button f9_ButtonEncrypt;
        private System.Windows.Forms.TextBox f9_fieldOriginal;
        private System.Windows.Forms.Label f9_label1;
        private System.Windows.Forms.Label f9_label4;
        private System.Windows.Forms.Label f9_label3;
        private System.Windows.Forms.Label f9_ButtonClearOriginal;
        private System.Windows.Forms.Label f9_ButtonClearKeyword;
        private System.Windows.Forms.Label f9_ButtonClearCiphertext;
    }
}