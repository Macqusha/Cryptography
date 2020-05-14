namespace Labs
{
    partial class Form07
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
            this.f7_label4 = new System.Windows.Forms.Label();
            this.f7_fieldCiphertext = new System.Windows.Forms.TextBox();
            this.f7_fieldRotate = new System.Windows.Forms.TextBox();
            this.f7_label1 = new System.Windows.Forms.Label();
            this.f7_label3 = new System.Windows.Forms.Label();
            this.f7_label2 = new System.Windows.Forms.Label();
            this.f7_fieldOriginal = new System.Windows.Forms.TextBox();
            this.f7_ButtonDecrypt = new System.Windows.Forms.Button();
            this.f7_ButtonEncrypt = new System.Windows.Forms.Button();
            this.f7_ButtonClearOriginal = new System.Windows.Forms.Label();
            this.f7_ButtonClearCiphertext = new System.Windows.Forms.Label();
            this.f7_label5 = new System.Windows.Forms.Label();
            this.f7_fieldLength = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // f7_label4
            // 
            this.f7_label4.AutoSize = true;
            this.f7_label4.Location = new System.Drawing.Point(373, 123);
            this.f7_label4.Name = "f7_label4";
            this.f7_label4.Size = new System.Drawing.Size(64, 17);
            this.f7_label4.TabIndex = 4;
            this.f7_label4.Text = "Поворот";
            // 
            // f7_fieldCiphertext
            // 
            this.f7_fieldCiphertext.Location = new System.Drawing.Point(500, 98);
            this.f7_fieldCiphertext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f7_fieldCiphertext.Multiline = true;
            this.f7_fieldCiphertext.Name = "f7_fieldCiphertext";
            this.f7_fieldCiphertext.Size = new System.Drawing.Size(319, 282);
            this.f7_fieldCiphertext.TabIndex = 8;
            this.f7_fieldCiphertext.TextChanged += new System.EventHandler(this.f7_fieldCiphertext_TextChanged);
            // 
            // f7_fieldRotate
            // 
            this.f7_fieldRotate.Location = new System.Drawing.Point(373, 148);
            this.f7_fieldRotate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f7_fieldRotate.Name = "f7_fieldRotate";
            this.f7_fieldRotate.Size = new System.Drawing.Size(99, 22);
            this.f7_fieldRotate.TabIndex = 5;
            this.f7_fieldRotate.TextChanged += new System.EventHandler(this.f7_fieldRotate_TextChanged);
            this.f7_fieldRotate.Enter += new System.EventHandler(this.f7_fieldRotate_Enter);
            // 
            // f7_label1
            // 
            this.f7_label1.AutoSize = true;
            this.f7_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f7_label1.Location = new System.Drawing.Point(360, 25);
            this.f7_label1.Name = "f7_label1";
            this.f7_label1.Size = new System.Drawing.Size(114, 18);
            this.f7_label1.TabIndex = 1;
            this.f7_label1.Text = "Диск Альберти";
            this.f7_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // f7_label3
            // 
            this.f7_label3.AutoSize = true;
            this.f7_label3.Location = new System.Drawing.Point(500, 74);
            this.f7_label3.Name = "f7_label3";
            this.f7_label3.Size = new System.Drawing.Size(82, 17);
            this.f7_label3.TabIndex = 7;
            this.f7_label3.Text = "Шифртекст";
            // 
            // f7_label2
            // 
            this.f7_label2.AutoSize = true;
            this.f7_label2.Location = new System.Drawing.Point(27, 74);
            this.f7_label2.Name = "f7_label2";
            this.f7_label2.Size = new System.Drawing.Size(113, 17);
            this.f7_label2.TabIndex = 2;
            this.f7_label2.Text = "Исходный текст";
            // 
            // f7_fieldOriginal
            // 
            this.f7_fieldOriginal.Location = new System.Drawing.Point(27, 98);
            this.f7_fieldOriginal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f7_fieldOriginal.Multiline = true;
            this.f7_fieldOriginal.Name = "f7_fieldOriginal";
            this.f7_fieldOriginal.Size = new System.Drawing.Size(319, 282);
            this.f7_fieldOriginal.TabIndex = 3;
            this.f7_fieldOriginal.TextChanged += new System.EventHandler(this.f7_fieldOriginal_TextChanged);
            // 
            // f7_ButtonDecrypt
            // 
            this.f7_ButtonDecrypt.Location = new System.Drawing.Point(500, 394);
            this.f7_ButtonDecrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f7_ButtonDecrypt.Name = "f7_ButtonDecrypt";
            this.f7_ButtonDecrypt.Size = new System.Drawing.Size(320, 31);
            this.f7_ButtonDecrypt.TabIndex = 9;
            this.f7_ButtonDecrypt.Text = "Расшифровать";
            this.f7_ButtonDecrypt.UseVisualStyleBackColor = true;
            this.f7_ButtonDecrypt.Click += new System.EventHandler(this.f7_ButtonDecrypt_Click);
            // 
            // f7_ButtonEncrypt
            // 
            this.f7_ButtonEncrypt.Location = new System.Drawing.Point(27, 394);
            this.f7_ButtonEncrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f7_ButtonEncrypt.Name = "f7_ButtonEncrypt";
            this.f7_ButtonEncrypt.Size = new System.Drawing.Size(320, 31);
            this.f7_ButtonEncrypt.TabIndex = 6;
            this.f7_ButtonEncrypt.Text = "Зашифровать";
            this.f7_ButtonEncrypt.UseVisualStyleBackColor = true;
            this.f7_ButtonEncrypt.Click += new System.EventHandler(this.f7_ButtonEncrypt_Click);
            // 
            // f7_ButtonClearOriginal
            // 
            this.f7_ButtonClearOriginal.AutoSize = true;
            this.f7_ButtonClearOriginal.ForeColor = System.Drawing.Color.Gray;
            this.f7_ButtonClearOriginal.Location = new System.Drawing.Point(275, 80);
            this.f7_ButtonClearOriginal.Name = "f7_ButtonClearOriginal";
            this.f7_ButtonClearOriginal.Size = new System.Drawing.Size(71, 17);
            this.f7_ButtonClearOriginal.TabIndex = 14;
            this.f7_ButtonClearOriginal.Text = "Очистить";
            this.f7_ButtonClearOriginal.Click += new System.EventHandler(this.f7_ButtonClearOriginal_Click);
            // 
            // f7_ButtonClearCiphertext
            // 
            this.f7_ButtonClearCiphertext.AutoSize = true;
            this.f7_ButtonClearCiphertext.ForeColor = System.Drawing.Color.Gray;
            this.f7_ButtonClearCiphertext.Location = new System.Drawing.Point(748, 80);
            this.f7_ButtonClearCiphertext.Name = "f7_ButtonClearCiphertext";
            this.f7_ButtonClearCiphertext.Size = new System.Drawing.Size(71, 17);
            this.f7_ButtonClearCiphertext.TabIndex = 15;
            this.f7_ButtonClearCiphertext.Text = "Очистить";
            this.f7_ButtonClearCiphertext.Click += new System.EventHandler(this.f7_ButtonClearCiphertext_Click);
            // 
            // f7_label5
            // 
            this.f7_label5.AutoSize = true;
            this.f7_label5.Location = new System.Drawing.Point(373, 197);
            this.f7_label5.Name = "f7_label5";
            this.f7_label5.Size = new System.Drawing.Size(94, 17);
            this.f7_label5.TabIndex = 16;
            this.f7_label5.Text = "Длина блока";
            // 
            // f7_fieldLength
            // 
            this.f7_fieldLength.Location = new System.Drawing.Point(373, 222);
            this.f7_fieldLength.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f7_fieldLength.Name = "f7_fieldLength";
            this.f7_fieldLength.Size = new System.Drawing.Size(99, 22);
            this.f7_fieldLength.TabIndex = 17;
            this.f7_fieldLength.TextChanged += new System.EventHandler(this.f7_fieldLength_TextChanged);
            this.f7_fieldLength.Enter += new System.EventHandler(this.f7_fieldLength_Enter);
            // 
            // Form07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 444);
            this.Controls.Add(this.f7_fieldLength);
            this.Controls.Add(this.f7_label5);
            this.Controls.Add(this.f7_ButtonClearOriginal);
            this.Controls.Add(this.f7_ButtonClearCiphertext);
            this.Controls.Add(this.f7_ButtonDecrypt);
            this.Controls.Add(this.f7_ButtonEncrypt);
            this.Controls.Add(this.f7_label4);
            this.Controls.Add(this.f7_fieldCiphertext);
            this.Controls.Add(this.f7_fieldRotate);
            this.Controls.Add(this.f7_label1);
            this.Controls.Add(this.f7_label3);
            this.Controls.Add(this.f7_label2);
            this.Controls.Add(this.f7_fieldOriginal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(100, 100);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form07";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Диск Альберти";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label f7_label4;
        private System.Windows.Forms.TextBox f7_fieldCiphertext;
        private System.Windows.Forms.TextBox f7_fieldRotate;
        private System.Windows.Forms.Label f7_label1;
        private System.Windows.Forms.Label f7_label3;
        private System.Windows.Forms.Label f7_label2;
        private System.Windows.Forms.TextBox f7_fieldOriginal;
        private System.Windows.Forms.Button f7_ButtonDecrypt;
        private System.Windows.Forms.Button f7_ButtonEncrypt;
        private System.Windows.Forms.Label f7_ButtonClearOriginal;
        private System.Windows.Forms.Label f7_ButtonClearCiphertext;
        private System.Windows.Forms.Label f7_label5;
        private System.Windows.Forms.TextBox f7_fieldLength;
    }
}