namespace Labs
{
    partial class Form06
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
            this.f6_label1 = new System.Windows.Forms.Label();
            this.f6_ButtonDecrypt = new System.Windows.Forms.Button();
            this.f6_fieldCiphertext = new System.Windows.Forms.TextBox();
            this.f6_ButtonEncrypt = new System.Windows.Forms.Button();
            this.f6_fieldOriginal = new System.Windows.Forms.TextBox();
            this.f6_label2 = new System.Windows.Forms.Label();
            this.f6_fieldKey = new System.Windows.Forms.TextBox();
            this.f6_ButtonClearOriginal = new System.Windows.Forms.Label();
            this.f6_ButtonClearKey = new System.Windows.Forms.Label();
            this.f6_ButtonClearCiphertext = new System.Windows.Forms.Label();
            this.f6_label4 = new System.Windows.Forms.Label();
            this.f6_label3 = new System.Windows.Forms.Label();
            this.f6_ButtonExampleKey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // f6_label1
            // 
            this.f6_label1.AutoSize = true;
            this.f6_label1.Location = new System.Drawing.Point(275, 20);
            this.f6_label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f6_label1.Name = "f6_label1";
            this.f6_label1.Size = new System.Drawing.Size(84, 13);
            this.f6_label1.TabIndex = 1;
            this.f6_label1.Text = "Шифр Ришелье";
            // 
            // f6_ButtonDecrypt
            // 
            this.f6_ButtonDecrypt.Location = new System.Drawing.Point(345, 320);
            this.f6_ButtonDecrypt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f6_ButtonDecrypt.Name = "f6_ButtonDecrypt";
            this.f6_ButtonDecrypt.Size = new System.Drawing.Size(250, 25);
            this.f6_ButtonDecrypt.TabIndex = 7;
            this.f6_ButtonDecrypt.Text = "Расшифровать";
            this.f6_ButtonDecrypt.UseVisualStyleBackColor = true;
            this.f6_ButtonDecrypt.Click += new System.EventHandler(this.f6_ButtonDecrypt_Click);
            // 
            // f6_fieldCiphertext
            // 
            this.f6_fieldCiphertext.Location = new System.Drawing.Point(345, 140);
            this.f6_fieldCiphertext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f6_fieldCiphertext.Multiline = true;
            this.f6_fieldCiphertext.Name = "f6_fieldCiphertext";
            this.f6_fieldCiphertext.Size = new System.Drawing.Size(250, 170);
            this.f6_fieldCiphertext.TabIndex = 6;
            // 
            // f6_ButtonEncrypt
            // 
            this.f6_ButtonEncrypt.Location = new System.Drawing.Point(40, 320);
            this.f6_ButtonEncrypt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f6_ButtonEncrypt.Name = "f6_ButtonEncrypt";
            this.f6_ButtonEncrypt.Size = new System.Drawing.Size(250, 25);
            this.f6_ButtonEncrypt.TabIndex = 5;
            this.f6_ButtonEncrypt.Text = "Зашифровать";
            this.f6_ButtonEncrypt.UseVisualStyleBackColor = true;
            this.f6_ButtonEncrypt.Click += new System.EventHandler(this.f6_ButtonEncrypt_Click);
            // 
            // f6_fieldOriginal
            // 
            this.f6_fieldOriginal.Location = new System.Drawing.Point(40, 140);
            this.f6_fieldOriginal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f6_fieldOriginal.Multiline = true;
            this.f6_fieldOriginal.Name = "f6_fieldOriginal";
            this.f6_fieldOriginal.Size = new System.Drawing.Size(250, 170);
            this.f6_fieldOriginal.TabIndex = 4;
            // 
            // f6_label2
            // 
            this.f6_label2.AutoSize = true;
            this.f6_label2.Location = new System.Drawing.Point(40, 60);
            this.f6_label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f6_label2.Name = "f6_label2";
            this.f6_label2.Size = new System.Drawing.Size(80, 13);
            this.f6_label2.TabIndex = 2;
            this.f6_label2.Text = "Введите ключ:";
            // 
            // f6_fieldKey
            // 
            this.f6_fieldKey.Location = new System.Drawing.Point(40, 80);
            this.f6_fieldKey.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f6_fieldKey.Name = "f6_fieldKey";
            this.f6_fieldKey.Size = new System.Drawing.Size(555, 20);
            this.f6_fieldKey.TabIndex = 8;
            this.f6_fieldKey.Enter += new System.EventHandler(this.f6_fieldKey_Enter);
            this.f6_fieldKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f6_fieldKey_KeyPress);
            // 
            // f6_ButtonClearOriginal
            // 
            this.f6_ButtonClearOriginal.AutoSize = true;
            this.f6_ButtonClearOriginal.ForeColor = System.Drawing.Color.Gray;
            this.f6_ButtonClearOriginal.Location = new System.Drawing.Point(236, 125);
            this.f6_ButtonClearOriginal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f6_ButtonClearOriginal.Name = "f6_ButtonClearOriginal";
            this.f6_ButtonClearOriginal.Size = new System.Drawing.Size(54, 13);
            this.f6_ButtonClearOriginal.TabIndex = 16;
            this.f6_ButtonClearOriginal.Text = "Очистить";
            this.f6_ButtonClearOriginal.Click += new System.EventHandler(this.f6_ButtonClearOriginal_Click);
            // 
            // f6_ButtonClearKey
            // 
            this.f6_ButtonClearKey.AutoSize = true;
            this.f6_ButtonClearKey.BackColor = System.Drawing.Color.Transparent;
            this.f6_ButtonClearKey.ForeColor = System.Drawing.Color.Gray;
            this.f6_ButtonClearKey.Location = new System.Drawing.Point(541, 65);
            this.f6_ButtonClearKey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f6_ButtonClearKey.Name = "f6_ButtonClearKey";
            this.f6_ButtonClearKey.Size = new System.Drawing.Size(54, 13);
            this.f6_ButtonClearKey.TabIndex = 17;
            this.f6_ButtonClearKey.Text = "Очистить";
            this.f6_ButtonClearKey.Click += new System.EventHandler(this.f6_ButtonClearKey_Click);
            // 
            // f6_ButtonClearCiphertext
            // 
            this.f6_ButtonClearCiphertext.AutoSize = true;
            this.f6_ButtonClearCiphertext.ForeColor = System.Drawing.Color.Gray;
            this.f6_ButtonClearCiphertext.Location = new System.Drawing.Point(541, 125);
            this.f6_ButtonClearCiphertext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f6_ButtonClearCiphertext.Name = "f6_ButtonClearCiphertext";
            this.f6_ButtonClearCiphertext.Size = new System.Drawing.Size(54, 13);
            this.f6_ButtonClearCiphertext.TabIndex = 18;
            this.f6_ButtonClearCiphertext.Text = "Очистить";
            this.f6_ButtonClearCiphertext.Click += new System.EventHandler(this.f6_ButtonClearCiphertext_Click);
            // 
            // f6_label4
            // 
            this.f6_label4.AutoSize = true;
            this.f6_label4.Location = new System.Drawing.Point(345, 120);
            this.f6_label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f6_label4.Name = "f6_label4";
            this.f6_label4.Size = new System.Drawing.Size(64, 13);
            this.f6_label4.TabIndex = 15;
            this.f6_label4.Text = "Шифртекст";
            // 
            // f6_label3
            // 
            this.f6_label3.AutoSize = true;
            this.f6_label3.Location = new System.Drawing.Point(40, 120);
            this.f6_label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f6_label3.Name = "f6_label3";
            this.f6_label3.Size = new System.Drawing.Size(89, 13);
            this.f6_label3.TabIndex = 14;
            this.f6_label3.Text = "Исходный текст";
            // 
            // f6_ButtonExampleKey
            // 
            this.f6_ButtonExampleKey.AutoSize = true;
            this.f6_ButtonExampleKey.BackColor = System.Drawing.Color.Transparent;
            this.f6_ButtonExampleKey.ForeColor = System.Drawing.Color.Gray;
            this.f6_ButtonExampleKey.Location = new System.Drawing.Point(490, 65);
            this.f6_ButtonExampleKey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f6_ButtonExampleKey.Name = "f6_ButtonExampleKey";
            this.f6_ButtonExampleKey.Size = new System.Drawing.Size(47, 13);
            this.f6_ButtonExampleKey.TabIndex = 19;
            this.f6_ButtonExampleKey.Text = "Пример";
            this.f6_ButtonExampleKey.Click += new System.EventHandler(this.f6_ButtonExampleKey_Click);
            // 
            // Form06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.f6_ButtonExampleKey);
            this.Controls.Add(this.f6_ButtonClearOriginal);
            this.Controls.Add(this.f6_ButtonClearKey);
            this.Controls.Add(this.f6_ButtonClearCiphertext);
            this.Controls.Add(this.f6_label4);
            this.Controls.Add(this.f6_label3);
            this.Controls.Add(this.f6_fieldKey);
            this.Controls.Add(this.f6_label2);
            this.Controls.Add(this.f6_ButtonDecrypt);
            this.Controls.Add(this.f6_fieldCiphertext);
            this.Controls.Add(this.f6_ButtonEncrypt);
            this.Controls.Add(this.f6_fieldOriginal);
            this.Controls.Add(this.f6_label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(100, 100);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form06";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Шифр Ришелье";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label f6_label1;
        private System.Windows.Forms.Button f6_ButtonDecrypt;
        private System.Windows.Forms.TextBox f6_fieldCiphertext;
        private System.Windows.Forms.Button f6_ButtonEncrypt;
        private System.Windows.Forms.TextBox f6_fieldOriginal;
        private System.Windows.Forms.Label f6_label2;
        private System.Windows.Forms.TextBox f6_fieldKey;
        private System.Windows.Forms.Label f6_ButtonClearOriginal;
        private System.Windows.Forms.Label f6_ButtonClearKey;
        private System.Windows.Forms.Label f6_ButtonClearCiphertext;
        private System.Windows.Forms.Label f6_label4;
        private System.Windows.Forms.Label f6_label3;
        private System.Windows.Forms.Label f6_ButtonExampleKey;
    }
}