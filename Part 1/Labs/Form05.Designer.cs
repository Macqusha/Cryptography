namespace Labs
{
    partial class Form05
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
            this.f5_label1 = new System.Windows.Forms.Label();
            this.f5_ButtonDecrypt = new System.Windows.Forms.Button();
            this.f5_fieldCiphertext = new System.Windows.Forms.TextBox();
            this.f5_ButtonEncrypt = new System.Windows.Forms.Button();
            this.f5_fieldOriginal = new System.Windows.Forms.TextBox();
            this.f5_label5 = new System.Windows.Forms.Label();
            this.f5_label4 = new System.Windows.Forms.Label();
            this.f5_ButtonClearOriginal = new System.Windows.Forms.Label();
            this.f5_ButtonClearCiphertext = new System.Windows.Forms.Label();
            this.f5_label3 = new System.Windows.Forms.Label();
            this.f5_ButtonGenKey = new System.Windows.Forms.Label();
            this.f5_ButtonClearKey = new System.Windows.Forms.Label();
            this.f5_fieldKey = new System.Windows.Forms.TextBox();
            this.f5_label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // f5_label1
            // 
            this.f5_label1.AutoSize = true;
            this.f5_label1.Location = new System.Drawing.Point(368, 25);
            this.f5_label1.Name = "f5_label1";
            this.f5_label1.Size = new System.Drawing.Size(107, 17);
            this.f5_label1.TabIndex = 1;
            this.f5_label1.Text = "Шифр Кардано";
            // 
            // f5_ButtonDecrypt
            // 
            this.f5_ButtonDecrypt.Location = new System.Drawing.Point(460, 394);
            this.f5_ButtonDecrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f5_ButtonDecrypt.Name = "f5_ButtonDecrypt";
            this.f5_ButtonDecrypt.Size = new System.Drawing.Size(333, 31);
            this.f5_ButtonDecrypt.TabIndex = 8;
            this.f5_ButtonDecrypt.Text = "Расшифровать";
            this.f5_ButtonDecrypt.UseVisualStyleBackColor = true;
            this.f5_ButtonDecrypt.Click += new System.EventHandler(this.f5_ButtonDecrypt_Click);
            // 
            // f5_fieldCiphertext
            // 
            this.f5_fieldCiphertext.Location = new System.Drawing.Point(460, 135);
            this.f5_fieldCiphertext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f5_fieldCiphertext.Multiline = true;
            this.f5_fieldCiphertext.Name = "f5_fieldCiphertext";
            this.f5_fieldCiphertext.Size = new System.Drawing.Size(332, 245);
            this.f5_fieldCiphertext.TabIndex = 7;
            this.f5_fieldCiphertext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f5_textBox_KeyPress);
            // 
            // f5_ButtonEncrypt
            // 
            this.f5_ButtonEncrypt.Location = new System.Drawing.Point(53, 394);
            this.f5_ButtonEncrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f5_ButtonEncrypt.Name = "f5_ButtonEncrypt";
            this.f5_ButtonEncrypt.Size = new System.Drawing.Size(333, 31);
            this.f5_ButtonEncrypt.TabIndex = 5;
            this.f5_ButtonEncrypt.Text = "Зашифровать";
            this.f5_ButtonEncrypt.UseVisualStyleBackColor = true;
            this.f5_ButtonEncrypt.Click += new System.EventHandler(this.f5_ButtonEncrypt_Click);
            // 
            // f5_fieldOriginal
            // 
            this.f5_fieldOriginal.Location = new System.Drawing.Point(53, 135);
            this.f5_fieldOriginal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f5_fieldOriginal.Multiline = true;
            this.f5_fieldOriginal.Name = "f5_fieldOriginal";
            this.f5_fieldOriginal.Size = new System.Drawing.Size(332, 245);
            this.f5_fieldOriginal.TabIndex = 4;
            this.f5_fieldOriginal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f5_textBox_KeyPress);
            // 
            // f5_label5
            // 
            this.f5_label5.AutoSize = true;
            this.f5_label5.Location = new System.Drawing.Point(460, 111);
            this.f5_label5.Name = "f5_label5";
            this.f5_label5.Size = new System.Drawing.Size(82, 17);
            this.f5_label5.TabIndex = 6;
            this.f5_label5.Text = "Шифртекст";
            // 
            // f5_label4
            // 
            this.f5_label4.AutoSize = true;
            this.f5_label4.Location = new System.Drawing.Point(53, 111);
            this.f5_label4.Name = "f5_label4";
            this.f5_label4.Size = new System.Drawing.Size(113, 17);
            this.f5_label4.TabIndex = 3;
            this.f5_label4.Text = "Исходный текст";
            // 
            // f5_ButtonClearOriginal
            // 
            this.f5_ButtonClearOriginal.AutoSize = true;
            this.f5_ButtonClearOriginal.ForeColor = System.Drawing.Color.Gray;
            this.f5_ButtonClearOriginal.Location = new System.Drawing.Point(315, 117);
            this.f5_ButtonClearOriginal.Name = "f5_ButtonClearOriginal";
            this.f5_ButtonClearOriginal.Size = new System.Drawing.Size(71, 17);
            this.f5_ButtonClearOriginal.TabIndex = 14;
            this.f5_ButtonClearOriginal.Text = "Очистить";
            this.f5_ButtonClearOriginal.Click += new System.EventHandler(this.f5_ButtonClearOriginal_Click);
            // 
            // f5_ButtonClearCiphertext
            // 
            this.f5_ButtonClearCiphertext.AutoSize = true;
            this.f5_ButtonClearCiphertext.ForeColor = System.Drawing.Color.Gray;
            this.f5_ButtonClearCiphertext.Location = new System.Drawing.Point(721, 117);
            this.f5_ButtonClearCiphertext.Name = "f5_ButtonClearCiphertext";
            this.f5_ButtonClearCiphertext.Size = new System.Drawing.Size(71, 17);
            this.f5_ButtonClearCiphertext.TabIndex = 15;
            this.f5_ButtonClearCiphertext.Text = "Очистить";
            this.f5_ButtonClearCiphertext.Click += new System.EventHandler(this.f5_ButtonClearCiphertext_Click);
            // 
            // f5_label3
            // 
            this.f5_label3.AutoSize = true;
            this.f5_label3.Location = new System.Drawing.Point(697, 57);
            this.f5_label3.Name = "f5_label3";
            this.f5_label3.Size = new System.Drawing.Size(57, 17);
            this.f5_label3.TabIndex = 31;
            this.f5_label3.Text = "Размер";
            // 
            // f5_ButtonGenKey
            // 
            this.f5_ButtonGenKey.AutoSize = true;
            this.f5_ButtonGenKey.BackColor = System.Drawing.Color.Transparent;
            this.f5_ButtonGenKey.ForeColor = System.Drawing.Color.Gray;
            this.f5_ButtonGenKey.Location = new System.Drawing.Point(479, 62);
            this.f5_ButtonGenKey.Name = "f5_ButtonGenKey";
            this.f5_ButtonGenKey.Size = new System.Drawing.Size(107, 17);
            this.f5_ButtonGenKey.TabIndex = 29;
            this.f5_ButtonGenKey.Text = "Сгенерировать";
            this.f5_ButtonGenKey.Click += new System.EventHandler(this.f5_ButtonGenKey_Click);
            // 
            // f5_ButtonClearKey
            // 
            this.f5_ButtonClearKey.AutoSize = true;
            this.f5_ButtonClearKey.BackColor = System.Drawing.Color.Transparent;
            this.f5_ButtonClearKey.ForeColor = System.Drawing.Color.Gray;
            this.f5_ButtonClearKey.Location = new System.Drawing.Point(590, 62);
            this.f5_ButtonClearKey.Name = "f5_ButtonClearKey";
            this.f5_ButtonClearKey.Size = new System.Drawing.Size(71, 17);
            this.f5_ButtonClearKey.TabIndex = 28;
            this.f5_ButtonClearKey.Text = "Очистить";
            this.f5_ButtonClearKey.Click += new System.EventHandler(this.f5_ButtonClearKey_Click);
            // 
            // f5_fieldKey
            // 
            this.f5_fieldKey.Location = new System.Drawing.Point(53, 81);
            this.f5_fieldKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f5_fieldKey.Name = "f5_fieldKey";
            this.f5_fieldKey.Size = new System.Drawing.Size(608, 22);
            this.f5_fieldKey.TabIndex = 27;
            this.f5_fieldKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f5_fieldKey_KeyPress);
            // 
            // f5_label2
            // 
            this.f5_label2.AutoSize = true;
            this.f5_label2.Location = new System.Drawing.Point(53, 57);
            this.f5_label2.Name = "f5_label2";
            this.f5_label2.Size = new System.Drawing.Size(104, 17);
            this.f5_label2.TabIndex = 26;
            this.f5_label2.Text = "Введите ключ:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(697, 81);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(95, 22);
            this.numericUpDown1.TabIndex = 33;
            this.numericUpDown1.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // Form05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 444);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.f5_label3);
            this.Controls.Add(this.f5_ButtonGenKey);
            this.Controls.Add(this.f5_ButtonClearKey);
            this.Controls.Add(this.f5_fieldKey);
            this.Controls.Add(this.f5_label2);
            this.Controls.Add(this.f5_ButtonClearOriginal);
            this.Controls.Add(this.f5_ButtonClearCiphertext);
            this.Controls.Add(this.f5_label5);
            this.Controls.Add(this.f5_label4);
            this.Controls.Add(this.f5_label1);
            this.Controls.Add(this.f5_ButtonDecrypt);
            this.Controls.Add(this.f5_fieldCiphertext);
            this.Controls.Add(this.f5_ButtonEncrypt);
            this.Controls.Add(this.f5_fieldOriginal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(100, 100);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form05";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Шифр Кардано";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label f5_label1;
        private System.Windows.Forms.Button f5_ButtonDecrypt;
        private System.Windows.Forms.TextBox f5_fieldCiphertext;
        private System.Windows.Forms.Button f5_ButtonEncrypt;
        private System.Windows.Forms.TextBox f5_fieldOriginal;
        private System.Windows.Forms.Label f5_label5;
        private System.Windows.Forms.Label f5_label4;
        private System.Windows.Forms.Label f5_ButtonClearOriginal;
        private System.Windows.Forms.Label f5_ButtonClearCiphertext;
        private System.Windows.Forms.Label f5_label3;
        private System.Windows.Forms.Label f5_ButtonGenKey;
        private System.Windows.Forms.Label f5_ButtonClearKey;
        private System.Windows.Forms.TextBox f5_fieldKey;
        private System.Windows.Forms.Label f5_label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}