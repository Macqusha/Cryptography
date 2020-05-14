namespace Labs
{
    partial class Form02
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
            this.f2_label1 = new System.Windows.Forms.Label();
            this.f2_label3 = new System.Windows.Forms.Label();
            this.f2_label2 = new System.Windows.Forms.Label();
            this.f2_ButtonEncrypt = new System.Windows.Forms.Button();
            this.f2_fieldOriginal = new System.Windows.Forms.TextBox();
            this.f2_fieldCiphertext = new System.Windows.Forms.TextBox();
            this.f2_ButtonDecrypt = new System.Windows.Forms.Button();
            this.f2_fieldDiametr = new System.Windows.Forms.TextBox();
            this.f2_label4 = new System.Windows.Forms.Label();
            this.f2_label5 = new System.Windows.Forms.Label();
            this.f2_fieldLength = new System.Windows.Forms.TextBox();
            this.f2_ButtonClearOriginal = new System.Windows.Forms.Label();
            this.f2_ButtonClearCiphertext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // f2_label1
            // 
            this.f2_label1.AutoSize = true;
            this.f2_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f2_label1.Location = new System.Drawing.Point(265, 20);
            this.f2_label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f2_label1.Name = "f2_label1";
            this.f2_label1.Size = new System.Drawing.Size(104, 15);
            this.f2_label1.TabIndex = 1;
            this.f2_label1.Text = "Шифр \"Сцитала\"";
            this.f2_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // f2_label3
            // 
            this.f2_label3.AutoSize = true;
            this.f2_label3.Location = new System.Drawing.Point(375, 60);
            this.f2_label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f2_label3.Name = "f2_label3";
            this.f2_label3.Size = new System.Drawing.Size(64, 13);
            this.f2_label3.TabIndex = 3;
            this.f2_label3.Text = "Шифртекст";
            // 
            // f2_label2
            // 
            this.f2_label2.AutoSize = true;
            this.f2_label2.Location = new System.Drawing.Point(20, 60);
            this.f2_label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f2_label2.Name = "f2_label2";
            this.f2_label2.Size = new System.Drawing.Size(89, 13);
            this.f2_label2.TabIndex = 2;
            this.f2_label2.Text = "Исходный текст";
            // 
            // f2_ButtonEncrypt
            // 
            this.f2_ButtonEncrypt.Location = new System.Drawing.Point(20, 320);
            this.f2_ButtonEncrypt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f2_ButtonEncrypt.Name = "f2_ButtonEncrypt";
            this.f2_ButtonEncrypt.Size = new System.Drawing.Size(240, 25);
            this.f2_ButtonEncrypt.TabIndex = 6;
            this.f2_ButtonEncrypt.Text = "Зашифровать";
            this.f2_ButtonEncrypt.UseVisualStyleBackColor = true;
            this.f2_ButtonEncrypt.Click += new System.EventHandler(this.f2_ButtonEncrypt_Click);
            // 
            // f2_fieldOriginal
            // 
            this.f2_fieldOriginal.Location = new System.Drawing.Point(20, 80);
            this.f2_fieldOriginal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f2_fieldOriginal.Multiline = true;
            this.f2_fieldOriginal.Name = "f2_fieldOriginal";
            this.f2_fieldOriginal.Size = new System.Drawing.Size(240, 230);
            this.f2_fieldOriginal.TabIndex = 4;
            // 
            // f2_fieldCiphertext
            // 
            this.f2_fieldCiphertext.Location = new System.Drawing.Point(375, 80);
            this.f2_fieldCiphertext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f2_fieldCiphertext.Multiline = true;
            this.f2_fieldCiphertext.Name = "f2_fieldCiphertext";
            this.f2_fieldCiphertext.Size = new System.Drawing.Size(240, 230);
            this.f2_fieldCiphertext.TabIndex = 7;
            // 
            // f2_ButtonDecrypt
            // 
            this.f2_ButtonDecrypt.Location = new System.Drawing.Point(375, 320);
            this.f2_ButtonDecrypt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f2_ButtonDecrypt.Name = "f2_ButtonDecrypt";
            this.f2_ButtonDecrypt.Size = new System.Drawing.Size(240, 25);
            this.f2_ButtonDecrypt.TabIndex = 8;
            this.f2_ButtonDecrypt.Text = "Расшифровать";
            this.f2_ButtonDecrypt.UseVisualStyleBackColor = true;
            this.f2_ButtonDecrypt.Click += new System.EventHandler(this.f2_ButtonDecrypt_Click);
            // 
            // f2_fieldDiametr
            // 
            this.f2_fieldDiametr.Location = new System.Drawing.Point(280, 120);
            this.f2_fieldDiametr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f2_fieldDiametr.Name = "f2_fieldDiametr";
            this.f2_fieldDiametr.Size = new System.Drawing.Size(75, 20);
            this.f2_fieldDiametr.TabIndex = 5;
            this.f2_fieldDiametr.Enter += new System.EventHandler(this.f2_fieldDiametr_Enter);
            this.f2_fieldDiametr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f2_fieldDiametr_KeyPress);
            this.f2_fieldDiametr.MouseEnter += new System.EventHandler(this.f2_fieldDiametr_MouseEnter);
            // 
            // f2_label4
            // 
            this.f2_label4.AutoSize = true;
            this.f2_label4.Location = new System.Drawing.Point(280, 100);
            this.f2_label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f2_label4.Name = "f2_label4";
            this.f2_label4.Size = new System.Drawing.Size(53, 13);
            this.f2_label4.TabIndex = 20;
            this.f2_label4.Text = "Диаметр";
            // 
            // f2_label5
            // 
            this.f2_label5.AutoSize = true;
            this.f2_label5.Location = new System.Drawing.Point(280, 160);
            this.f2_label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f2_label5.Name = "f2_label5";
            this.f2_label5.Size = new System.Drawing.Size(40, 13);
            this.f2_label5.TabIndex = 22;
            this.f2_label5.Text = "Длина";
            // 
            // f2_fieldLength
            // 
            this.f2_fieldLength.Enabled = false;
            this.f2_fieldLength.Location = new System.Drawing.Point(280, 180);
            this.f2_fieldLength.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f2_fieldLength.Name = "f2_fieldLength";
            this.f2_fieldLength.Size = new System.Drawing.Size(75, 20);
            this.f2_fieldLength.TabIndex = 9;
            this.f2_fieldLength.MouseEnter += new System.EventHandler(this.f2_fieldLength_MouseEnter);
            // 
            // f2_ButtonClearOriginal
            // 
            this.f2_ButtonClearOriginal.AutoSize = true;
            this.f2_ButtonClearOriginal.ForeColor = System.Drawing.Color.Gray;
            this.f2_ButtonClearOriginal.Location = new System.Drawing.Point(206, 65);
            this.f2_ButtonClearOriginal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f2_ButtonClearOriginal.Name = "f2_ButtonClearOriginal";
            this.f2_ButtonClearOriginal.Size = new System.Drawing.Size(54, 13);
            this.f2_ButtonClearOriginal.TabIndex = 23;
            this.f2_ButtonClearOriginal.Text = "Очистить";
            this.f2_ButtonClearOriginal.Click += new System.EventHandler(this.f2_ButtonClearOriginal_Click);
            // 
            // f2_ButtonClearCiphertext
            // 
            this.f2_ButtonClearCiphertext.AutoSize = true;
            this.f2_ButtonClearCiphertext.ForeColor = System.Drawing.Color.Gray;
            this.f2_ButtonClearCiphertext.Location = new System.Drawing.Point(561, 65);
            this.f2_ButtonClearCiphertext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f2_ButtonClearCiphertext.Name = "f2_ButtonClearCiphertext";
            this.f2_ButtonClearCiphertext.Size = new System.Drawing.Size(54, 13);
            this.f2_ButtonClearCiphertext.TabIndex = 24;
            this.f2_ButtonClearCiphertext.Text = "Очистить";
            this.f2_ButtonClearCiphertext.Click += new System.EventHandler(this.f2_ButtonClearCiphertext_Click);
            // 
            // Form02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.f2_ButtonClearOriginal);
            this.Controls.Add(this.f2_ButtonClearCiphertext);
            this.Controls.Add(this.f2_label5);
            this.Controls.Add(this.f2_fieldLength);
            this.Controls.Add(this.f2_label4);
            this.Controls.Add(this.f2_ButtonDecrypt);
            this.Controls.Add(this.f2_fieldCiphertext);
            this.Controls.Add(this.f2_fieldDiametr);
            this.Controls.Add(this.f2_label1);
            this.Controls.Add(this.f2_label3);
            this.Controls.Add(this.f2_label2);
            this.Controls.Add(this.f2_ButtonEncrypt);
            this.Controls.Add(this.f2_fieldOriginal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(100, 100);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Шифр \"Сцитала\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label f2_label1;
        private System.Windows.Forms.Label f2_label3;
        private System.Windows.Forms.Label f2_label2;
        private System.Windows.Forms.Button f2_ButtonEncrypt;
        private System.Windows.Forms.TextBox f2_fieldOriginal;
        private System.Windows.Forms.TextBox f2_fieldCiphertext;
        private System.Windows.Forms.Button f2_ButtonDecrypt;
        private System.Windows.Forms.TextBox f2_fieldDiametr;
        private System.Windows.Forms.Label f2_label4;
        private System.Windows.Forms.Label f2_label5;
        private System.Windows.Forms.TextBox f2_fieldLength;
        private System.Windows.Forms.Label f2_ButtonClearOriginal;
        private System.Windows.Forms.Label f2_ButtonClearCiphertext;
    }
}