namespace Labs
{
    partial class Form04
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
            this.f4_fieldOriginal = new System.Windows.Forms.TextBox();
            this.f4_ButtonEncrypt = new System.Windows.Forms.Button();
            this.f4_ButtonDecrypt = new System.Windows.Forms.Button();
            this.f4_fieldCiphertext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.f4_label3 = new System.Windows.Forms.Label();
            this.f4_f4_label3 = new System.Windows.Forms.Label();
            this.f4_ButtonClearOriginal = new System.Windows.Forms.Label();
            this.f4_ButtonClearCiphertext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // f4_fieldOriginal
            // 
            this.f4_fieldOriginal.Location = new System.Drawing.Point(53, 98);
            this.f4_fieldOriginal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f4_fieldOriginal.Multiline = true;
            this.f4_fieldOriginal.Name = "f4_fieldOriginal";
            this.f4_fieldOriginal.Size = new System.Drawing.Size(332, 282);
            this.f4_fieldOriginal.TabIndex = 4;
            // 
            // f4_ButtonEncrypt
            // 
            this.f4_ButtonEncrypt.Location = new System.Drawing.Point(53, 394);
            this.f4_ButtonEncrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f4_ButtonEncrypt.Name = "f4_ButtonEncrypt";
            this.f4_ButtonEncrypt.Size = new System.Drawing.Size(333, 31);
            this.f4_ButtonEncrypt.TabIndex = 5;
            this.f4_ButtonEncrypt.Text = "Зашифровать";
            this.f4_ButtonEncrypt.UseVisualStyleBackColor = true;
            this.f4_ButtonEncrypt.Click += new System.EventHandler(this.f4_ButtonEncrypt_Click);
            // 
            // f4_ButtonDecrypt
            // 
            this.f4_ButtonDecrypt.Location = new System.Drawing.Point(460, 394);
            this.f4_ButtonDecrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f4_ButtonDecrypt.Name = "f4_ButtonDecrypt";
            this.f4_ButtonDecrypt.Size = new System.Drawing.Size(333, 31);
            this.f4_ButtonDecrypt.TabIndex = 7;
            this.f4_ButtonDecrypt.Text = "Расшифровать";
            this.f4_ButtonDecrypt.UseVisualStyleBackColor = true;
            this.f4_ButtonDecrypt.Click += new System.EventHandler(this.f4_ButtonDecrypt_Click);
            // 
            // f4_fieldCiphertext
            // 
            this.f4_fieldCiphertext.Location = new System.Drawing.Point(460, 98);
            this.f4_fieldCiphertext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f4_fieldCiphertext.Multiline = true;
            this.f4_fieldCiphertext.Name = "f4_fieldCiphertext";
            this.f4_fieldCiphertext.Size = new System.Drawing.Size(332, 282);
            this.f4_fieldCiphertext.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Квадрат Полибия";
            // 
            // f4_label3
            // 
            this.f4_label3.AutoSize = true;
            this.f4_label3.Location = new System.Drawing.Point(460, 74);
            this.f4_label3.Name = "f4_label3";
            this.f4_label3.Size = new System.Drawing.Size(82, 17);
            this.f4_label3.TabIndex = 3;
            this.f4_label3.Text = "Шифртекст";
            // 
            // f4_f4_label3
            // 
            this.f4_f4_label3.AutoSize = true;
            this.f4_f4_label3.Location = new System.Drawing.Point(53, 74);
            this.f4_f4_label3.Name = "f4_f4_label3";
            this.f4_f4_label3.Size = new System.Drawing.Size(113, 17);
            this.f4_f4_label3.TabIndex = 2;
            this.f4_f4_label3.Text = "Исходный текст";
            // 
            // f4_ButtonClearOriginal
            // 
            this.f4_ButtonClearOriginal.AutoSize = true;
            this.f4_ButtonClearOriginal.ForeColor = System.Drawing.Color.Gray;
            this.f4_ButtonClearOriginal.Location = new System.Drawing.Point(321, 80);
            this.f4_ButtonClearOriginal.Name = "f4_ButtonClearOriginal";
            this.f4_ButtonClearOriginal.Size = new System.Drawing.Size(71, 17);
            this.f4_ButtonClearOriginal.TabIndex = 16;
            this.f4_ButtonClearOriginal.Text = "Очистить";
            this.f4_ButtonClearOriginal.Click += new System.EventHandler(this.f4_ButtonClearOriginal_Click);
            // 
            // f4_ButtonClearCiphertext
            // 
            this.f4_ButtonClearCiphertext.AutoSize = true;
            this.f4_ButtonClearCiphertext.ForeColor = System.Drawing.Color.Gray;
            this.f4_ButtonClearCiphertext.Location = new System.Drawing.Point(721, 80);
            this.f4_ButtonClearCiphertext.Name = "f4_ButtonClearCiphertext";
            this.f4_ButtonClearCiphertext.Size = new System.Drawing.Size(71, 17);
            this.f4_ButtonClearCiphertext.TabIndex = 17;
            this.f4_ButtonClearCiphertext.Text = "Очистить";
            this.f4_ButtonClearCiphertext.Click += new System.EventHandler(this.f4_ButtonClearCiphertext_Click);
            // 
            // Form04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 444);
            this.Controls.Add(this.f4_ButtonClearOriginal);
            this.Controls.Add(this.f4_ButtonClearCiphertext);
            this.Controls.Add(this.f4_label3);
            this.Controls.Add(this.f4_f4_label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.f4_ButtonDecrypt);
            this.Controls.Add(this.f4_fieldCiphertext);
            this.Controls.Add(this.f4_ButtonEncrypt);
            this.Controls.Add(this.f4_fieldOriginal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(100, 100);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form04";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Квадрат Полибия";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox f4_fieldOriginal;
        private System.Windows.Forms.Button f4_ButtonEncrypt;
        private System.Windows.Forms.Button f4_ButtonDecrypt;
        private System.Windows.Forms.TextBox f4_fieldCiphertext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label f4_label3;
        private System.Windows.Forms.Label f4_f4_label3;
        private System.Windows.Forms.Label f4_ButtonClearOriginal;
        private System.Windows.Forms.Label f4_ButtonClearCiphertext;
    }
}