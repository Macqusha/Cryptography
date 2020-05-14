namespace Labs
{
    partial class Form08
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
            this.f8_fieldKey = new System.Windows.Forms.TextBox();
            this.f8_label2 = new System.Windows.Forms.Label();
            this.f8_ButtonDecrypt = new System.Windows.Forms.Button();
            this.f8_fieldCiphertext = new System.Windows.Forms.TextBox();
            this.f8_ButtonEncrypt = new System.Windows.Forms.Button();
            this.f8_fieldOriginal = new System.Windows.Forms.TextBox();
            this.f8_label1 = new System.Windows.Forms.Label();
            this.f8_label4 = new System.Windows.Forms.Label();
            this.f8_label3 = new System.Windows.Forms.Label();
            this.f8_ButtonClearOriginal = new System.Windows.Forms.Label();
            this.f8_ButtonClearKey = new System.Windows.Forms.Label();
            this.f8_ButtonClearCiphertext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // f8_fieldKey
            // 
            this.f8_fieldKey.Location = new System.Drawing.Point(40, 80);
            this.f8_fieldKey.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f8_fieldKey.Name = "f8_fieldKey";
            this.f8_fieldKey.Size = new System.Drawing.Size(555, 20);
            this.f8_fieldKey.TabIndex = 7;
            this.f8_fieldKey.Enter += new System.EventHandler(this.f8_fieldKey_Enter);
            this.f8_fieldKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f8_fieldKey_KeyPress);
            // 
            // f8_label2
            // 
            this.f8_label2.AutoSize = true;
            this.f8_label2.Location = new System.Drawing.Point(40, 60);
            this.f8_label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f8_label2.Name = "f8_label2";
            this.f8_label2.Size = new System.Drawing.Size(80, 13);
            this.f8_label2.TabIndex = 6;
            this.f8_label2.Text = "Введите ключ:";
            // 
            // f8_ButtonDecrypt
            // 
            this.f8_ButtonDecrypt.Location = new System.Drawing.Point(345, 320);
            this.f8_ButtonDecrypt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f8_ButtonDecrypt.Name = "f8_ButtonDecrypt";
            this.f8_ButtonDecrypt.Size = new System.Drawing.Size(250, 25);
            this.f8_ButtonDecrypt.TabIndex = 5;
            this.f8_ButtonDecrypt.Text = "Расшифровать";
            this.f8_ButtonDecrypt.UseVisualStyleBackColor = true;
            this.f8_ButtonDecrypt.Click += new System.EventHandler(this.f8_ButtonDecrypt_Click);
            // 
            // f8_fieldCiphertext
            // 
            this.f8_fieldCiphertext.Location = new System.Drawing.Point(345, 140);
            this.f8_fieldCiphertext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f8_fieldCiphertext.Multiline = true;
            this.f8_fieldCiphertext.Name = "f8_fieldCiphertext";
            this.f8_fieldCiphertext.Size = new System.Drawing.Size(250, 170);
            this.f8_fieldCiphertext.TabIndex = 4;
            // 
            // f8_ButtonEncrypt
            // 
            this.f8_ButtonEncrypt.Location = new System.Drawing.Point(40, 320);
            this.f8_ButtonEncrypt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f8_ButtonEncrypt.Name = "f8_ButtonEncrypt";
            this.f8_ButtonEncrypt.Size = new System.Drawing.Size(250, 25);
            this.f8_ButtonEncrypt.TabIndex = 3;
            this.f8_ButtonEncrypt.Text = "Зашифровать";
            this.f8_ButtonEncrypt.UseVisualStyleBackColor = true;
            this.f8_ButtonEncrypt.Click += new System.EventHandler(this.f8_ButtonEncrypt_Click);
            // 
            // f8_fieldOriginal
            // 
            this.f8_fieldOriginal.Location = new System.Drawing.Point(40, 140);
            this.f8_fieldOriginal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f8_fieldOriginal.Multiline = true;
            this.f8_fieldOriginal.Name = "f8_fieldOriginal";
            this.f8_fieldOriginal.Size = new System.Drawing.Size(250, 170);
            this.f8_fieldOriginal.TabIndex = 2;
            // 
            // f8_label1
            // 
            this.f8_label1.AutoSize = true;
            this.f8_label1.Location = new System.Drawing.Point(264, 20);
            this.f8_label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f8_label1.Name = "f8_label1";
            this.f8_label1.Size = new System.Drawing.Size(107, 13);
            this.f8_label1.TabIndex = 1;
            this.f8_label1.Text = "Шифр Гронсфельда";
            // 
            // f8_label4
            // 
            this.f8_label4.AutoSize = true;
            this.f8_label4.Location = new System.Drawing.Point(345, 120);
            this.f8_label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f8_label4.Name = "f8_label4";
            this.f8_label4.Size = new System.Drawing.Size(64, 13);
            this.f8_label4.TabIndex = 9;
            this.f8_label4.Text = "Шифртекст";
            // 
            // f8_label3
            // 
            this.f8_label3.AutoSize = true;
            this.f8_label3.Location = new System.Drawing.Point(40, 120);
            this.f8_label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f8_label3.Name = "f8_label3";
            this.f8_label3.Size = new System.Drawing.Size(89, 13);
            this.f8_label3.TabIndex = 8;
            this.f8_label3.Text = "Исходный текст";
            // 
            // f8_ButtonClearOriginal
            // 
            this.f8_ButtonClearOriginal.AutoSize = true;
            this.f8_ButtonClearOriginal.ForeColor = System.Drawing.Color.Gray;
            this.f8_ButtonClearOriginal.Location = new System.Drawing.Point(236, 125);
            this.f8_ButtonClearOriginal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f8_ButtonClearOriginal.Name = "f8_ButtonClearOriginal";
            this.f8_ButtonClearOriginal.Size = new System.Drawing.Size(54, 13);
            this.f8_ButtonClearOriginal.TabIndex = 14;
            this.f8_ButtonClearOriginal.Text = "Очистить";
            this.f8_ButtonClearOriginal.Click += new System.EventHandler(this.f8_ButtonClearOriginal_Click);
            // 
            // f8_ButtonClearKey
            // 
            this.f8_ButtonClearKey.AutoSize = true;
            this.f8_ButtonClearKey.BackColor = System.Drawing.Color.Transparent;
            this.f8_ButtonClearKey.ForeColor = System.Drawing.Color.Gray;
            this.f8_ButtonClearKey.Location = new System.Drawing.Point(541, 65);
            this.f8_ButtonClearKey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f8_ButtonClearKey.Name = "f8_ButtonClearKey";
            this.f8_ButtonClearKey.Size = new System.Drawing.Size(54, 13);
            this.f8_ButtonClearKey.TabIndex = 15;
            this.f8_ButtonClearKey.Text = "Очистить";
            this.f8_ButtonClearKey.Click += new System.EventHandler(this.f8_ButtonClearKey_Click);
            // 
            // f8_ButtonClearCiphertext
            // 
            this.f8_ButtonClearCiphertext.AutoSize = true;
            this.f8_ButtonClearCiphertext.ForeColor = System.Drawing.Color.Gray;
            this.f8_ButtonClearCiphertext.Location = new System.Drawing.Point(541, 125);
            this.f8_ButtonClearCiphertext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f8_ButtonClearCiphertext.Name = "f8_ButtonClearCiphertext";
            this.f8_ButtonClearCiphertext.Size = new System.Drawing.Size(54, 13);
            this.f8_ButtonClearCiphertext.TabIndex = 16;
            this.f8_ButtonClearCiphertext.Text = "Очистить";
            this.f8_ButtonClearCiphertext.Click += new System.EventHandler(this.f8_ButtonClearCiphertext_Click);
            // 
            // Form08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.f8_ButtonClearOriginal);
            this.Controls.Add(this.f8_ButtonClearKey);
            this.Controls.Add(this.f8_ButtonClearCiphertext);
            this.Controls.Add(this.f8_label4);
            this.Controls.Add(this.f8_label3);
            this.Controls.Add(this.f8_fieldKey);
            this.Controls.Add(this.f8_label2);
            this.Controls.Add(this.f8_ButtonDecrypt);
            this.Controls.Add(this.f8_fieldCiphertext);
            this.Controls.Add(this.f8_ButtonEncrypt);
            this.Controls.Add(this.f8_fieldOriginal);
            this.Controls.Add(this.f8_label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(100, 100);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form08";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Шифр Гронсфельда";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox f8_fieldKey;
        private System.Windows.Forms.Label f8_label2;
        private System.Windows.Forms.Button f8_ButtonDecrypt;
        private System.Windows.Forms.TextBox f8_fieldCiphertext;
        private System.Windows.Forms.Button f8_ButtonEncrypt;
        private System.Windows.Forms.TextBox f8_fieldOriginal;
        private System.Windows.Forms.Label f8_label1;
        private System.Windows.Forms.Label f8_label4;
        private System.Windows.Forms.Label f8_label3;
        private System.Windows.Forms.Label f8_ButtonClearOriginal;
        private System.Windows.Forms.Label f8_ButtonClearKey;
        private System.Windows.Forms.Label f8_ButtonClearCiphertext;
    }
}