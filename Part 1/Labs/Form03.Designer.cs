namespace Labs
{
    partial class Form03
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
            this.f3_ButtonDecrypt = new System.Windows.Forms.Button();
            this.f3_fieldCiphertext = new System.Windows.Forms.TextBox();
            this.f3_fieldRotate = new System.Windows.Forms.TextBox();
            this.f3_label1 = new System.Windows.Forms.Label();
            this.f3_label3 = new System.Windows.Forms.Label();
            this.f3_label2 = new System.Windows.Forms.Label();
            this.f3_ButtonEncrypt = new System.Windows.Forms.Button();
            this.f3_fieldOriginal = new System.Windows.Forms.TextBox();
            this.f3_label4 = new System.Windows.Forms.Label();
            this.f3_ButtonClearOriginal = new System.Windows.Forms.Label();
            this.f3_ButtonClearCiphertext = new System.Windows.Forms.Label();
            this.f14_ButtonSaveOriginal = new System.Windows.Forms.Label();
            this.f14_ButtonReadCiphertext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // f3_ButtonDecrypt
            // 
            this.f3_ButtonDecrypt.Location = new System.Drawing.Point(500, 394);
            this.f3_ButtonDecrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f3_ButtonDecrypt.Name = "f3_ButtonDecrypt";
            this.f3_ButtonDecrypt.Size = new System.Drawing.Size(320, 31);
            this.f3_ButtonDecrypt.TabIndex = 7;
            this.f3_ButtonDecrypt.Text = "Расшифровать";
            this.f3_ButtonDecrypt.UseVisualStyleBackColor = true;
            this.f3_ButtonDecrypt.Click += new System.EventHandler(this.f3_ButtonDecrypt_Click);
            // 
            // f3_fieldCiphertext
            // 
            this.f3_fieldCiphertext.Location = new System.Drawing.Point(500, 98);
            this.f3_fieldCiphertext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f3_fieldCiphertext.Multiline = true;
            this.f3_fieldCiphertext.Name = "f3_fieldCiphertext";
            this.f3_fieldCiphertext.Size = new System.Drawing.Size(319, 282);
            this.f3_fieldCiphertext.TabIndex = 6;
            // 
            // f3_fieldRotate
            // 
            this.f3_fieldRotate.Location = new System.Drawing.Point(373, 148);
            this.f3_fieldRotate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f3_fieldRotate.Name = "f3_fieldRotate";
            this.f3_fieldRotate.Size = new System.Drawing.Size(100, 22);
            this.f3_fieldRotate.TabIndex = 4;
            this.f3_fieldRotate.Enter += new System.EventHandler(this.f3_fieldRotate_Enter);
            this.f3_fieldRotate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f3_fieldRotate_KeyPress);
            // 
            // f3_label1
            // 
            this.f3_label1.AutoSize = true;
            this.f3_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f3_label1.Location = new System.Drawing.Point(364, 25);
            this.f3_label1.Name = "f3_label1";
            this.f3_label1.Size = new System.Drawing.Size(105, 18);
            this.f3_label1.TabIndex = 1;
            this.f3_label1.Text = "Шифр Цезаря";
            this.f3_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // f3_label3
            // 
            this.f3_label3.AutoSize = true;
            this.f3_label3.Location = new System.Drawing.Point(500, 74);
            this.f3_label3.Name = "f3_label3";
            this.f3_label3.Size = new System.Drawing.Size(82, 17);
            this.f3_label3.TabIndex = 24;
            this.f3_label3.Text = "Шифртекст";
            // 
            // f3_label2
            // 
            this.f3_label2.AutoSize = true;
            this.f3_label2.Location = new System.Drawing.Point(27, 74);
            this.f3_label2.Name = "f3_label2";
            this.f3_label2.Size = new System.Drawing.Size(113, 17);
            this.f3_label2.TabIndex = 2;
            this.f3_label2.Text = "Исходный текст";
            // 
            // f3_ButtonEncrypt
            // 
            this.f3_ButtonEncrypt.Location = new System.Drawing.Point(27, 394);
            this.f3_ButtonEncrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f3_ButtonEncrypt.Name = "f3_ButtonEncrypt";
            this.f3_ButtonEncrypt.Size = new System.Drawing.Size(320, 31);
            this.f3_ButtonEncrypt.TabIndex = 5;
            this.f3_ButtonEncrypt.Text = "Зашифровать";
            this.f3_ButtonEncrypt.UseVisualStyleBackColor = true;
            this.f3_ButtonEncrypt.Click += new System.EventHandler(this.f3_ButtonEncrypt_Click);
            // 
            // f3_fieldOriginal
            // 
            this.f3_fieldOriginal.Location = new System.Drawing.Point(27, 98);
            this.f3_fieldOriginal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f3_fieldOriginal.Multiline = true;
            this.f3_fieldOriginal.Name = "f3_fieldOriginal";
            this.f3_fieldOriginal.Size = new System.Drawing.Size(319, 282);
            this.f3_fieldOriginal.TabIndex = 3;
            // 
            // f3_label4
            // 
            this.f3_label4.AutoSize = true;
            this.f3_label4.Location = new System.Drawing.Point(373, 123);
            this.f3_label4.Name = "f3_label4";
            this.f3_label4.Size = new System.Drawing.Size(45, 17);
            this.f3_label4.TabIndex = 30;
            this.f3_label4.Text = "Сдвиг";
            // 
            // f3_ButtonClearOriginal
            // 
            this.f3_ButtonClearOriginal.AutoSize = true;
            this.f3_ButtonClearOriginal.ForeColor = System.Drawing.Color.Gray;
            this.f3_ButtonClearOriginal.Location = new System.Drawing.Point(275, 80);
            this.f3_ButtonClearOriginal.Name = "f3_ButtonClearOriginal";
            this.f3_ButtonClearOriginal.Size = new System.Drawing.Size(71, 17);
            this.f3_ButtonClearOriginal.TabIndex = 31;
            this.f3_ButtonClearOriginal.Text = "Очистить";
            this.f3_ButtonClearOriginal.Click += new System.EventHandler(this.f3_ButtonClearOriginal_Click);
            // 
            // f3_ButtonClearCiphertext
            // 
            this.f3_ButtonClearCiphertext.AutoSize = true;
            this.f3_ButtonClearCiphertext.ForeColor = System.Drawing.Color.Gray;
            this.f3_ButtonClearCiphertext.Location = new System.Drawing.Point(748, 80);
            this.f3_ButtonClearCiphertext.Name = "f3_ButtonClearCiphertext";
            this.f3_ButtonClearCiphertext.Size = new System.Drawing.Size(71, 17);
            this.f3_ButtonClearCiphertext.TabIndex = 32;
            this.f3_ButtonClearCiphertext.Text = "Очистить";
            this.f3_ButtonClearCiphertext.Click += new System.EventHandler(this.f3_ButtonClearCiphertext_Click);
            // 
            // f14_ButtonSaveOriginal
            // 
            this.f14_ButtonSaveOriginal.AutoSize = true;
            this.f14_ButtonSaveOriginal.ForeColor = System.Drawing.Color.Gray;
            this.f14_ButtonSaveOriginal.Location = new System.Drawing.Point(671, 80);
            this.f14_ButtonSaveOriginal.Name = "f14_ButtonSaveOriginal";
            this.f14_ButtonSaveOriginal.Size = new System.Drawing.Size(77, 17);
            this.f14_ButtonSaveOriginal.TabIndex = 43;
            this.f14_ButtonSaveOriginal.Text = "Сохранить";
            this.f14_ButtonSaveOriginal.Click += new System.EventHandler(this.f14_ButtonSaveOriginal_Click);
            // 
            // f14_ButtonReadCiphertext
            // 
            this.f14_ButtonReadCiphertext.AutoSize = true;
            this.f14_ButtonReadCiphertext.ForeColor = System.Drawing.Color.Gray;
            this.f14_ButtonReadCiphertext.Location = new System.Drawing.Point(213, 80);
            this.f14_ButtonReadCiphertext.Name = "f14_ButtonReadCiphertext";
            this.f14_ButtonReadCiphertext.Size = new System.Drawing.Size(62, 17);
            this.f14_ButtonReadCiphertext.TabIndex = 42;
            this.f14_ButtonReadCiphertext.Text = "Считать";
            this.f14_ButtonReadCiphertext.Click += new System.EventHandler(this.f14_ButtonReadCiphertext_Click);
            // 
            // Form03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 444);
            this.Controls.Add(this.f14_ButtonSaveOriginal);
            this.Controls.Add(this.f14_ButtonReadCiphertext);
            this.Controls.Add(this.f3_ButtonClearOriginal);
            this.Controls.Add(this.f3_ButtonClearCiphertext);
            this.Controls.Add(this.f3_label4);
            this.Controls.Add(this.f3_ButtonDecrypt);
            this.Controls.Add(this.f3_fieldCiphertext);
            this.Controls.Add(this.f3_fieldRotate);
            this.Controls.Add(this.f3_label1);
            this.Controls.Add(this.f3_label3);
            this.Controls.Add(this.f3_label2);
            this.Controls.Add(this.f3_ButtonEncrypt);
            this.Controls.Add(this.f3_fieldOriginal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(100, 100);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Шифр Цезаря";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button f3_ButtonDecrypt;
        private System.Windows.Forms.TextBox f3_fieldCiphertext;
        private System.Windows.Forms.TextBox f3_fieldRotate;
        private System.Windows.Forms.Label f3_label1;
        private System.Windows.Forms.Label f3_label3;
        private System.Windows.Forms.Label f3_label2;
        private System.Windows.Forms.Button f3_ButtonEncrypt;
        private System.Windows.Forms.TextBox f3_fieldOriginal;
        private System.Windows.Forms.Label f3_label4;
        private System.Windows.Forms.Label f3_ButtonClearOriginal;
        private System.Windows.Forms.Label f3_ButtonClearCiphertext;
        private System.Windows.Forms.Label f14_ButtonSaveOriginal;
        private System.Windows.Forms.Label f14_ButtonReadCiphertext;
    }
}