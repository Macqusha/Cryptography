namespace Labs
{
    partial class Form11
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
            this.f11_ButtonClearCiphertext = new System.Windows.Forms.Label();
            this.f11_radioButtonEn = new System.Windows.Forms.RadioButton();
            this.f11_radioButtonRus = new System.Windows.Forms.RadioButton();
            this.f11_label4 = new System.Windows.Forms.Label();
            this.f11_label3 = new System.Windows.Forms.Label();
            this.f11_fieldKeyword = new System.Windows.Forms.TextBox();
            this.f11_label2 = new System.Windows.Forms.Label();
            this.f11_ButtonDecrypt = new System.Windows.Forms.Button();
            this.f11_fieldCiphertext = new System.Windows.Forms.TextBox();
            this.f11_ButtonEncrypt = new System.Windows.Forms.Button();
            this.f11_fieldOriginal = new System.Windows.Forms.TextBox();
            this.f11_label1 = new System.Windows.Forms.Label();
            this.f11_ButtonClearOriginal = new System.Windows.Forms.Label();
            this.f11_ButtonClearKeyword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // f11_ButtonClearCiphertext
            // 
            this.f11_ButtonClearCiphertext.AutoSize = true;
            this.f11_ButtonClearCiphertext.ForeColor = System.Drawing.Color.Gray;
            this.f11_ButtonClearCiphertext.Location = new System.Drawing.Point(541, 125);
            this.f11_ButtonClearCiphertext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f11_ButtonClearCiphertext.Name = "f11_ButtonClearCiphertext";
            this.f11_ButtonClearCiphertext.Size = new System.Drawing.Size(54, 13);
            this.f11_ButtonClearCiphertext.TabIndex = 12;
            this.f11_ButtonClearCiphertext.Text = "Очистить";
            this.f11_ButtonClearCiphertext.Click += new System.EventHandler(this.f11_ButtonClearCiphertext_Click);
            // 
            // f11_radioButtonEn
            // 
            this.f11_radioButtonEn.AutoSize = true;
            this.f11_radioButtonEn.Location = new System.Drawing.Point(555, 30);
            this.f11_radioButtonEn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f11_radioButtonEn.Name = "f11_radioButtonEn";
            this.f11_radioButtonEn.Size = new System.Drawing.Size(59, 17);
            this.f11_radioButtonEn.TabIndex = 14;
            this.f11_radioButtonEn.Text = "English";
            this.f11_radioButtonEn.UseVisualStyleBackColor = true;
            this.f11_radioButtonEn.CheckedChanged += new System.EventHandler(this.f11_radioButton_CheckedChanged);
            // 
            // f11_radioButtonRus
            // 
            this.f11_radioButtonRus.AutoSize = true;
            this.f11_radioButtonRus.Checked = true;
            this.f11_radioButtonRus.Location = new System.Drawing.Point(555, 10);
            this.f11_radioButtonRus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f11_radioButtonRus.Name = "f11_radioButtonRus";
            this.f11_radioButtonRus.Size = new System.Drawing.Size(67, 17);
            this.f11_radioButtonRus.TabIndex = 13;
            this.f11_radioButtonRus.TabStop = true;
            this.f11_radioButtonRus.Text = "Русский";
            this.f11_radioButtonRus.UseVisualStyleBackColor = true;
            this.f11_radioButtonRus.CheckedChanged += new System.EventHandler(this.f11_radioButton_CheckedChanged);
            // 
            // f11_label4
            // 
            this.f11_label4.AutoSize = true;
            this.f11_label4.Location = new System.Drawing.Point(345, 120);
            this.f11_label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f11_label4.Name = "f11_label4";
            this.f11_label4.Size = new System.Drawing.Size(64, 13);
            this.f11_label4.TabIndex = 5;
            this.f11_label4.Text = "Шифртекст";
            // 
            // f11_label3
            // 
            this.f11_label3.AutoSize = true;
            this.f11_label3.Location = new System.Drawing.Point(40, 120);
            this.f11_label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f11_label3.Name = "f11_label3";
            this.f11_label3.Size = new System.Drawing.Size(89, 13);
            this.f11_label3.TabIndex = 2;
            this.f11_label3.Text = "Исходный текст";
            // 
            // f11_fieldKeyword
            // 
            this.f11_fieldKeyword.Location = new System.Drawing.Point(40, 80);
            this.f11_fieldKeyword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f11_fieldKeyword.Name = "f11_fieldKeyword";
            this.f11_fieldKeyword.Size = new System.Drawing.Size(555, 20);
            this.f11_fieldKeyword.TabIndex = 9;
            this.f11_fieldKeyword.Enter += new System.EventHandler(this.f11_fieldKeyword_Enter);
            this.f11_fieldKeyword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f11_field_KeyPress);
            // 
            // f11_label2
            // 
            this.f11_label2.AutoSize = true;
            this.f11_label2.Location = new System.Drawing.Point(40, 60);
            this.f11_label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f11_label2.Name = "f11_label2";
            this.f11_label2.Size = new System.Drawing.Size(33, 13);
            this.f11_label2.TabIndex = 8;
            this.f11_label2.Text = "Ключ";
            // 
            // f11_ButtonDecrypt
            // 
            this.f11_ButtonDecrypt.Location = new System.Drawing.Point(345, 320);
            this.f11_ButtonDecrypt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f11_ButtonDecrypt.Name = "f11_ButtonDecrypt";
            this.f11_ButtonDecrypt.Size = new System.Drawing.Size(250, 25);
            this.f11_ButtonDecrypt.TabIndex = 7;
            this.f11_ButtonDecrypt.Text = "Расшифровать";
            this.f11_ButtonDecrypt.UseVisualStyleBackColor = true;
            this.f11_ButtonDecrypt.Click += new System.EventHandler(this.f11_ButtonDecrypt_Click);
            // 
            // f11_fieldCiphertext
            // 
            this.f11_fieldCiphertext.Location = new System.Drawing.Point(345, 140);
            this.f11_fieldCiphertext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f11_fieldCiphertext.Multiline = true;
            this.f11_fieldCiphertext.Name = "f11_fieldCiphertext";
            this.f11_fieldCiphertext.Size = new System.Drawing.Size(250, 170);
            this.f11_fieldCiphertext.TabIndex = 6;
            this.f11_fieldCiphertext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f11_field_KeyPress);
            // 
            // f11_ButtonEncrypt
            // 
            this.f11_ButtonEncrypt.Location = new System.Drawing.Point(40, 320);
            this.f11_ButtonEncrypt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f11_ButtonEncrypt.Name = "f11_ButtonEncrypt";
            this.f11_ButtonEncrypt.Size = new System.Drawing.Size(250, 25);
            this.f11_ButtonEncrypt.TabIndex = 4;
            this.f11_ButtonEncrypt.Text = "Зашифровать";
            this.f11_ButtonEncrypt.UseVisualStyleBackColor = true;
            this.f11_ButtonEncrypt.Click += new System.EventHandler(this.f11_ButtonEncrypt_Click);
            // 
            // f11_fieldOriginal
            // 
            this.f11_fieldOriginal.Location = new System.Drawing.Point(40, 140);
            this.f11_fieldOriginal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f11_fieldOriginal.Multiline = true;
            this.f11_fieldOriginal.Name = "f11_fieldOriginal";
            this.f11_fieldOriginal.Size = new System.Drawing.Size(250, 170);
            this.f11_fieldOriginal.TabIndex = 3;
            this.f11_fieldOriginal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f11_field_KeyPress);
            // 
            // f11_label1
            // 
            this.f11_label1.AutoSize = true;
            this.f11_label1.Location = new System.Drawing.Point(257, 20);
            this.f11_label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f11_label1.Name = "f11_label1";
            this.f11_label1.Size = new System.Drawing.Size(120, 13);
            this.f11_label1.TabIndex = 1;
            this.f11_label1.Text = "Криптосистема Хилла";
            // 
            // f11_ButtonClearOriginal
            // 
            this.f11_ButtonClearOriginal.AutoSize = true;
            this.f11_ButtonClearOriginal.ForeColor = System.Drawing.Color.Gray;
            this.f11_ButtonClearOriginal.Location = new System.Drawing.Point(236, 125);
            this.f11_ButtonClearOriginal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f11_ButtonClearOriginal.Name = "f11_ButtonClearOriginal";
            this.f11_ButtonClearOriginal.Size = new System.Drawing.Size(54, 13);
            this.f11_ButtonClearOriginal.TabIndex = 11;
            this.f11_ButtonClearOriginal.Text = "Очистить";
            this.f11_ButtonClearOriginal.Click += new System.EventHandler(this.f11_ButtonClearOriginal_Click);
            // 
            // f11_ButtonClearKeyword
            // 
            this.f11_ButtonClearKeyword.AutoSize = true;
            this.f11_ButtonClearKeyword.BackColor = System.Drawing.Color.Transparent;
            this.f11_ButtonClearKeyword.ForeColor = System.Drawing.Color.Gray;
            this.f11_ButtonClearKeyword.Location = new System.Drawing.Point(541, 65);
            this.f11_ButtonClearKeyword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f11_ButtonClearKeyword.Name = "f11_ButtonClearKeyword";
            this.f11_ButtonClearKeyword.Size = new System.Drawing.Size(54, 13);
            this.f11_ButtonClearKeyword.TabIndex = 10;
            this.f11_ButtonClearKeyword.Text = "Очистить";
            this.f11_ButtonClearKeyword.Click += new System.EventHandler(this.f11_ButtonClearKeyword_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.f11_ButtonClearOriginal);
            this.Controls.Add(this.f11_ButtonClearKeyword);
            this.Controls.Add(this.f11_ButtonClearCiphertext);
            this.Controls.Add(this.f11_radioButtonEn);
            this.Controls.Add(this.f11_radioButtonRus);
            this.Controls.Add(this.f11_label4);
            this.Controls.Add(this.f11_label3);
            this.Controls.Add(this.f11_fieldKeyword);
            this.Controls.Add(this.f11_label2);
            this.Controls.Add(this.f11_ButtonDecrypt);
            this.Controls.Add(this.f11_fieldCiphertext);
            this.Controls.Add(this.f11_ButtonEncrypt);
            this.Controls.Add(this.f11_fieldOriginal);
            this.Controls.Add(this.f11_label1);
            this.Location = new System.Drawing.Point(100, 100);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Криптосистема Хилла";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label f11_ButtonClearCiphertext;
        private System.Windows.Forms.RadioButton f11_radioButtonEn;
        private System.Windows.Forms.RadioButton f11_radioButtonRus;
        private System.Windows.Forms.Label f11_label4;
        private System.Windows.Forms.Label f11_label3;
        private System.Windows.Forms.TextBox f11_fieldKeyword;
        private System.Windows.Forms.Label f11_label2;
        private System.Windows.Forms.Button f11_ButtonDecrypt;
        private System.Windows.Forms.TextBox f11_fieldCiphertext;
        private System.Windows.Forms.Button f11_ButtonEncrypt;
        private System.Windows.Forms.TextBox f11_fieldOriginal;
        private System.Windows.Forms.Label f11_label1;
        private System.Windows.Forms.Label f11_ButtonClearOriginal;
        private System.Windows.Forms.Label f11_ButtonClearKeyword;
    }
}