namespace Labs
{
    partial class Form10
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
            this.f10_fieldKeyword = new System.Windows.Forms.TextBox();
            this.f10_label2 = new System.Windows.Forms.Label();
            this.f10_ButtonDecrypt = new System.Windows.Forms.Button();
            this.f10_fieldCiphertext = new System.Windows.Forms.TextBox();
            this.f10_ButtonEncrypt = new System.Windows.Forms.Button();
            this.f10_fieldOriginal = new System.Windows.Forms.TextBox();
            this.f10_label1 = new System.Windows.Forms.Label();
            this.f10_label4 = new System.Windows.Forms.Label();
            this.f10_label3 = new System.Windows.Forms.Label();
            this.f10_ButtonClearCiphertext = new System.Windows.Forms.Label();
            this.f10_ButtonClearOriginal = new System.Windows.Forms.Label();
            this.f10_ButtonClearKeyword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // f10_fieldKeyword
            // 
            this.f10_fieldKeyword.Location = new System.Drawing.Point(40, 80);
            this.f10_fieldKeyword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f10_fieldKeyword.Name = "f10_fieldKeyword";
            this.f10_fieldKeyword.Size = new System.Drawing.Size(555, 20);
            this.f10_fieldKeyword.TabIndex = 7;
            this.f10_fieldKeyword.Enter += new System.EventHandler(this.f10_fieldKeyword_Enter);
            this.f10_fieldKeyword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f10_fieldKeyword_KeyPress);
            // 
            // f10_label2
            // 
            this.f10_label2.AutoSize = true;
            this.f10_label2.Location = new System.Drawing.Point(40, 60);
            this.f10_label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f10_label2.Name = "f10_label2";
            this.f10_label2.Size = new System.Drawing.Size(80, 13);
            this.f10_label2.TabIndex = 6;
            this.f10_label2.Text = "Введите ключ:";
            // 
            // f10_ButtonDecrypt
            // 
            this.f10_ButtonDecrypt.Location = new System.Drawing.Point(345, 320);
            this.f10_ButtonDecrypt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f10_ButtonDecrypt.Name = "f10_ButtonDecrypt";
            this.f10_ButtonDecrypt.Size = new System.Drawing.Size(250, 25);
            this.f10_ButtonDecrypt.TabIndex = 5;
            this.f10_ButtonDecrypt.Text = "Расшифровать";
            this.f10_ButtonDecrypt.UseVisualStyleBackColor = true;
            this.f10_ButtonDecrypt.Click += new System.EventHandler(this.f10_ButtonDecrypt_Click);
            // 
            // f10_fieldCiphertext
            // 
            this.f10_fieldCiphertext.Location = new System.Drawing.Point(345, 140);
            this.f10_fieldCiphertext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f10_fieldCiphertext.Multiline = true;
            this.f10_fieldCiphertext.Name = "f10_fieldCiphertext";
            this.f10_fieldCiphertext.Size = new System.Drawing.Size(250, 170);
            this.f10_fieldCiphertext.TabIndex = 4;
            // 
            // f10_ButtonEncrypt
            // 
            this.f10_ButtonEncrypt.Location = new System.Drawing.Point(40, 320);
            this.f10_ButtonEncrypt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f10_ButtonEncrypt.Name = "f10_ButtonEncrypt";
            this.f10_ButtonEncrypt.Size = new System.Drawing.Size(250, 25);
            this.f10_ButtonEncrypt.TabIndex = 3;
            this.f10_ButtonEncrypt.Text = "Зашифровать";
            this.f10_ButtonEncrypt.UseVisualStyleBackColor = true;
            this.f10_ButtonEncrypt.Click += new System.EventHandler(this.f10_ButtonEncrypt_Click);
            // 
            // f10_fieldOriginal
            // 
            this.f10_fieldOriginal.Location = new System.Drawing.Point(40, 140);
            this.f10_fieldOriginal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f10_fieldOriginal.Multiline = true;
            this.f10_fieldOriginal.Name = "f10_fieldOriginal";
            this.f10_fieldOriginal.Size = new System.Drawing.Size(250, 170);
            this.f10_fieldOriginal.TabIndex = 2;
            // 
            // f10_label1
            // 
            this.f10_label1.AutoSize = true;
            this.f10_label1.Location = new System.Drawing.Point(272, 20);
            this.f10_label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f10_label1.Name = "f10_label1";
            this.f10_label1.Size = new System.Drawing.Size(91, 13);
            this.f10_label1.TabIndex = 1;
            this.f10_label1.Text = "Шифр Плейфера";
            // 
            // f10_label4
            // 
            this.f10_label4.AutoSize = true;
            this.f10_label4.Location = new System.Drawing.Point(345, 120);
            this.f10_label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f10_label4.Name = "f10_label4";
            this.f10_label4.Size = new System.Drawing.Size(64, 13);
            this.f10_label4.TabIndex = 11;
            this.f10_label4.Text = "Шифртекст";
            // 
            // f10_label3
            // 
            this.f10_label3.AutoSize = true;
            this.f10_label3.Location = new System.Drawing.Point(40, 120);
            this.f10_label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f10_label3.Name = "f10_label3";
            this.f10_label3.Size = new System.Drawing.Size(89, 13);
            this.f10_label3.TabIndex = 10;
            this.f10_label3.Text = "Исходный текст";
            // 
            // f10_ButtonClearCiphertext
            // 
            this.f10_ButtonClearCiphertext.AutoSize = true;
            this.f10_ButtonClearCiphertext.ForeColor = System.Drawing.Color.Gray;
            this.f10_ButtonClearCiphertext.Location = new System.Drawing.Point(541, 125);
            this.f10_ButtonClearCiphertext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f10_ButtonClearCiphertext.Name = "f10_ButtonClearCiphertext";
            this.f10_ButtonClearCiphertext.Size = new System.Drawing.Size(54, 13);
            this.f10_ButtonClearCiphertext.TabIndex = 18;
            this.f10_ButtonClearCiphertext.Text = "Очистить";
            this.f10_ButtonClearCiphertext.Click += new System.EventHandler(this.f10_ButtonClearCiphertext_Click);
            // 
            // f10_ButtonClearOriginal
            // 
            this.f10_ButtonClearOriginal.AutoSize = true;
            this.f10_ButtonClearOriginal.ForeColor = System.Drawing.Color.Gray;
            this.f10_ButtonClearOriginal.Location = new System.Drawing.Point(236, 125);
            this.f10_ButtonClearOriginal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f10_ButtonClearOriginal.Name = "f10_ButtonClearOriginal";
            this.f10_ButtonClearOriginal.Size = new System.Drawing.Size(54, 13);
            this.f10_ButtonClearOriginal.TabIndex = 19;
            this.f10_ButtonClearOriginal.Text = "Очистить";
            this.f10_ButtonClearOriginal.Click += new System.EventHandler(this.f10_ButtonClearOriginal_Click);
            // 
            // f10_ButtonClearKeyword
            // 
            this.f10_ButtonClearKeyword.AutoSize = true;
            this.f10_ButtonClearKeyword.ForeColor = System.Drawing.Color.Gray;
            this.f10_ButtonClearKeyword.Location = new System.Drawing.Point(541, 65);
            this.f10_ButtonClearKeyword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f10_ButtonClearKeyword.Name = "f10_ButtonClearKeyword";
            this.f10_ButtonClearKeyword.Size = new System.Drawing.Size(54, 13);
            this.f10_ButtonClearKeyword.TabIndex = 20;
            this.f10_ButtonClearKeyword.Text = "Очистить";
            this.f10_ButtonClearKeyword.Click += new System.EventHandler(this.f10_ButtonClearKeyword_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.f10_ButtonClearKeyword);
            this.Controls.Add(this.f10_ButtonClearOriginal);
            this.Controls.Add(this.f10_ButtonClearCiphertext);
            this.Controls.Add(this.f10_label4);
            this.Controls.Add(this.f10_label3);
            this.Controls.Add(this.f10_fieldKeyword);
            this.Controls.Add(this.f10_label2);
            this.Controls.Add(this.f10_ButtonDecrypt);
            this.Controls.Add(this.f10_fieldCiphertext);
            this.Controls.Add(this.f10_ButtonEncrypt);
            this.Controls.Add(this.f10_fieldOriginal);
            this.Controls.Add(this.f10_label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(100, 100);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Шифр Плейфера";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox f10_fieldKeyword;
        private System.Windows.Forms.Label f10_label2;
        private System.Windows.Forms.Button f10_ButtonDecrypt;
        private System.Windows.Forms.TextBox f10_fieldCiphertext;
        private System.Windows.Forms.Button f10_ButtonEncrypt;
        private System.Windows.Forms.TextBox f10_fieldOriginal;
        private System.Windows.Forms.Label f10_label1;
        private System.Windows.Forms.Label f10_label4;
        private System.Windows.Forms.Label f10_label3;
        private System.Windows.Forms.Label f10_ButtonClearCiphertext;
        private System.Windows.Forms.Label f10_ButtonClearOriginal;
        private System.Windows.Forms.Label f10_ButtonClearKeyword;
    }
}