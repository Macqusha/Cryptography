namespace Labs
{
    partial class Form12
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
            this.f12_fieldKeyword = new System.Windows.Forms.TextBox();
            this.f12_label3 = new System.Windows.Forms.Label();
            this.f12_ButtonDecrypt = new System.Windows.Forms.Button();
            this.f12_fieldCiphertext = new System.Windows.Forms.TextBox();
            this.f12_ButtonEncrypt = new System.Windows.Forms.Button();
            this.f12_fieldOriginal = new System.Windows.Forms.TextBox();
            this.f12_label1 = new System.Windows.Forms.Label();
            this.f12_label4 = new System.Windows.Forms.Label();
            this.f12_label2 = new System.Windows.Forms.Label();
            this.f12_ButtonClearCiphertext = new System.Windows.Forms.Label();
            this.f12_ButtonClearKeyword = new System.Windows.Forms.Label();
            this.f12_ButtonClearOriginal = new System.Windows.Forms.Label();
            this.f12_ButtonGenKeyword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // f12_fieldKeyword
            // 
            this.f12_fieldKeyword.Location = new System.Drawing.Point(300, 134);
            this.f12_fieldKeyword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f12_fieldKeyword.Multiline = true;
            this.f12_fieldKeyword.Name = "f12_fieldKeyword";
            this.f12_fieldKeyword.Size = new System.Drawing.Size(245, 182);
            this.f12_fieldKeyword.TabIndex = 6;
            this.f12_fieldKeyword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f12_fieldKeyword_KeyPress);
            // 
            // f12_label3
            // 
            this.f12_label3.AutoSize = true;
            this.f12_label3.Location = new System.Drawing.Point(300, 111);
            this.f12_label3.Name = "f12_label3";
            this.f12_label3.Size = new System.Drawing.Size(43, 17);
            this.f12_label3.TabIndex = 4;
            this.f12_label3.Text = "Ключ";
            // 
            // f12_ButtonDecrypt
            // 
            this.f12_ButtonDecrypt.Location = new System.Drawing.Point(447, 345);
            this.f12_ButtonDecrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f12_ButtonDecrypt.Name = "f12_ButtonDecrypt";
            this.f12_ButtonDecrypt.Size = new System.Drawing.Size(267, 62);
            this.f12_ButtonDecrypt.TabIndex = 10;
            this.f12_ButtonDecrypt.Text = "Расшифровать";
            this.f12_ButtonDecrypt.UseVisualStyleBackColor = true;
            this.f12_ButtonDecrypt.Click += new System.EventHandler(this.f12_ButtonDecrypt_Click);
            // 
            // f12_fieldCiphertext
            // 
            this.f12_fieldCiphertext.Location = new System.Drawing.Point(573, 135);
            this.f12_fieldCiphertext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f12_fieldCiphertext.Multiline = true;
            this.f12_fieldCiphertext.Name = "f12_fieldCiphertext";
            this.f12_fieldCiphertext.Size = new System.Drawing.Size(245, 182);
            this.f12_fieldCiphertext.TabIndex = 9;
            this.f12_fieldCiphertext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f12_Messages_KeyPress);
            // 
            // f12_ButtonEncrypt
            // 
            this.f12_ButtonEncrypt.Location = new System.Drawing.Point(107, 345);
            this.f12_ButtonEncrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f12_ButtonEncrypt.Name = "f12_ButtonEncrypt";
            this.f12_ButtonEncrypt.Size = new System.Drawing.Size(267, 62);
            this.f12_ButtonEncrypt.TabIndex = 7;
            this.f12_ButtonEncrypt.Text = "Зашифровать";
            this.f12_ButtonEncrypt.UseVisualStyleBackColor = true;
            this.f12_ButtonEncrypt.Click += new System.EventHandler(this.f12_ButtonEncrypt_Click);
            // 
            // f12_fieldOriginal
            // 
            this.f12_fieldOriginal.Location = new System.Drawing.Point(27, 134);
            this.f12_fieldOriginal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f12_fieldOriginal.Multiline = true;
            this.f12_fieldOriginal.Name = "f12_fieldOriginal";
            this.f12_fieldOriginal.Size = new System.Drawing.Size(245, 182);
            this.f12_fieldOriginal.TabIndex = 3;
            this.f12_fieldOriginal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f12_Messages_KeyPress);
            // 
            // f12_label1
            // 
            this.f12_label1.AutoSize = true;
            this.f12_label1.Location = new System.Drawing.Point(367, 25);
            this.f12_label1.Name = "f12_label1";
            this.f12_label1.Size = new System.Drawing.Size(108, 17);
            this.f12_label1.TabIndex = 1;
            this.f12_label1.Text = "Шифр Вернама";
            // 
            // f12_label4
            // 
            this.f12_label4.AutoSize = true;
            this.f12_label4.Location = new System.Drawing.Point(573, 111);
            this.f12_label4.Name = "f12_label4";
            this.f12_label4.Size = new System.Drawing.Size(82, 17);
            this.f12_label4.TabIndex = 8;
            this.f12_label4.Text = "Шифртекст";
            // 
            // f12_label2
            // 
            this.f12_label2.AutoSize = true;
            this.f12_label2.Location = new System.Drawing.Point(27, 111);
            this.f12_label2.Name = "f12_label2";
            this.f12_label2.Size = new System.Drawing.Size(113, 17);
            this.f12_label2.TabIndex = 2;
            this.f12_label2.Text = "Исходный текст";
            // 
            // f12_ButtonClearCiphertext
            // 
            this.f12_ButtonClearCiphertext.AutoSize = true;
            this.f12_ButtonClearCiphertext.ForeColor = System.Drawing.Color.Gray;
            this.f12_ButtonClearCiphertext.Location = new System.Drawing.Point(748, 116);
            this.f12_ButtonClearCiphertext.Name = "f12_ButtonClearCiphertext";
            this.f12_ButtonClearCiphertext.Size = new System.Drawing.Size(71, 17);
            this.f12_ButtonClearCiphertext.TabIndex = 13;
            this.f12_ButtonClearCiphertext.Text = "Очистить";
            this.f12_ButtonClearCiphertext.Click += new System.EventHandler(this.f12_ButtonClearCiphertext_Click);
            // 
            // f12_ButtonClearKeyword
            // 
            this.f12_ButtonClearKeyword.AutoSize = true;
            this.f12_ButtonClearKeyword.BackColor = System.Drawing.Color.Transparent;
            this.f12_ButtonClearKeyword.ForeColor = System.Drawing.Color.Gray;
            this.f12_ButtonClearKeyword.Location = new System.Drawing.Point(475, 116);
            this.f12_ButtonClearKeyword.Name = "f12_ButtonClearKeyword";
            this.f12_ButtonClearKeyword.Size = new System.Drawing.Size(71, 17);
            this.f12_ButtonClearKeyword.TabIndex = 12;
            this.f12_ButtonClearKeyword.Text = "Очистить";
            this.f12_ButtonClearKeyword.Click += new System.EventHandler(this.f12_ButtonClearKeyword_Click);
            // 
            // f12_ButtonClearOriginal
            // 
            this.f12_ButtonClearOriginal.AutoSize = true;
            this.f12_ButtonClearOriginal.ForeColor = System.Drawing.Color.Gray;
            this.f12_ButtonClearOriginal.Location = new System.Drawing.Point(201, 116);
            this.f12_ButtonClearOriginal.Name = "f12_ButtonClearOriginal";
            this.f12_ButtonClearOriginal.Size = new System.Drawing.Size(71, 17);
            this.f12_ButtonClearOriginal.TabIndex = 11;
            this.f12_ButtonClearOriginal.Text = "Очистить";
            this.f12_ButtonClearOriginal.Click += new System.EventHandler(this.f12_ButtonClearOriginal_Click);
            // 
            // f12_ButtonGenKeyword
            // 
            this.f12_ButtonGenKeyword.AutoSize = true;
            this.f12_ButtonGenKeyword.BackColor = System.Drawing.Color.Transparent;
            this.f12_ButtonGenKeyword.ForeColor = System.Drawing.Color.Gray;
            this.f12_ButtonGenKeyword.Location = new System.Drawing.Point(396, 116);
            this.f12_ButtonGenKeyword.Name = "f12_ButtonGenKeyword";
            this.f12_ButtonGenKeyword.Size = new System.Drawing.Size(82, 17);
            this.f12_ButtonGenKeyword.TabIndex = 5;
            this.f12_ButtonGenKeyword.Text = "Случайный";
            this.f12_ButtonGenKeyword.Click += new System.EventHandler(this.f12_ButtonGenKeyword_Click);
            this.f12_ButtonGenKeyword.MouseEnter += new System.EventHandler(this.f12_ButtonGenKeyword_MouseEnter);
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 444);
            this.Controls.Add(this.f12_ButtonGenKeyword);
            this.Controls.Add(this.f12_ButtonClearOriginal);
            this.Controls.Add(this.f12_ButtonClearKeyword);
            this.Controls.Add(this.f12_ButtonClearCiphertext);
            this.Controls.Add(this.f12_label4);
            this.Controls.Add(this.f12_label2);
            this.Controls.Add(this.f12_fieldKeyword);
            this.Controls.Add(this.f12_label3);
            this.Controls.Add(this.f12_ButtonDecrypt);
            this.Controls.Add(this.f12_fieldCiphertext);
            this.Controls.Add(this.f12_ButtonEncrypt);
            this.Controls.Add(this.f12_fieldOriginal);
            this.Controls.Add(this.f12_label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(100, 100);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form12";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Шифр Вернама";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox f12_fieldKeyword;
        private System.Windows.Forms.Label f12_label3;
        private System.Windows.Forms.Button f12_ButtonDecrypt;
        private System.Windows.Forms.TextBox f12_fieldCiphertext;
        private System.Windows.Forms.Button f12_ButtonEncrypt;
        private System.Windows.Forms.TextBox f12_fieldOriginal;
        private System.Windows.Forms.Label f12_label1;
        private System.Windows.Forms.Label f12_label4;
        private System.Windows.Forms.Label f12_label2;
        private System.Windows.Forms.Label f12_ButtonClearCiphertext;
        private System.Windows.Forms.Label f12_ButtonClearKeyword;
        private System.Windows.Forms.Label f12_ButtonClearOriginal;
        private System.Windows.Forms.Label f12_ButtonGenKeyword;
    }
}