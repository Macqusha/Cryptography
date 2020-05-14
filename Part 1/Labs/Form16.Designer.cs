namespace Labs
{
    partial class Form16
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
            this.f16_label1 = new System.Windows.Forms.Label();
            this.f16_ButtonGenKeyword = new System.Windows.Forms.Label();
            this.f16_fieldKeyword = new System.Windows.Forms.TextBox();
            this.f16_label2 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.f16_ButtonDecryptFile = new System.Windows.Forms.Button();
            this.f16_ButtonEncryptFile = new System.Windows.Forms.Button();
            this.f16_labelPB = new System.Windows.Forms.Label();
            this.f16_ButtonReadKeyword = new System.Windows.Forms.Label();
            this.f16_ButtonSaveKeyword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // f16_label1
            // 
            this.f16_label1.AutoSize = true;
            this.f16_label1.Location = new System.Drawing.Point(404, 25);
            this.f16_label1.Name = "f16_label1";
            this.f16_label1.Size = new System.Drawing.Size(36, 17);
            this.f16_label1.TabIndex = 1;
            this.f16_label1.Text = "DES";
            // 
            // f16_ButtonGenKeyword
            // 
            this.f16_ButtonGenKeyword.AutoSize = true;
            this.f16_ButtonGenKeyword.BackColor = System.Drawing.Color.Transparent;
            this.f16_ButtonGenKeyword.ForeColor = System.Drawing.Color.Gray;
            this.f16_ButtonGenKeyword.Location = new System.Drawing.Point(601, 140);
            this.f16_ButtonGenKeyword.Name = "f16_ButtonGenKeyword";
            this.f16_ButtonGenKeyword.Size = new System.Drawing.Size(80, 17);
            this.f16_ButtonGenKeyword.TabIndex = 3;
            this.f16_ButtonGenKeyword.Text = "Генерация";
            this.f16_ButtonGenKeyword.Click += new System.EventHandler(this.f16_ButtonGenKeyword_Click);
            // 
            // f16_fieldKeyword
            // 
            this.f16_fieldKeyword.Location = new System.Drawing.Point(83, 159);
            this.f16_fieldKeyword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f16_fieldKeyword.Multiline = true;
            this.f16_fieldKeyword.Name = "f16_fieldKeyword";
            this.f16_fieldKeyword.ReadOnly = true;
            this.f16_fieldKeyword.Size = new System.Drawing.Size(671, 40);
            this.f16_fieldKeyword.TabIndex = 5;
            this.f16_fieldKeyword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f16_fieldKeyword_KeyPress);
            this.f16_fieldKeyword.Leave += new System.EventHandler(this.f16_fieldKeyword_Leave);
            // 
            // f16_label2
            // 
            this.f16_label2.AutoSize = true;
            this.f16_label2.Location = new System.Drawing.Point(80, 140);
            this.f16_label2.Name = "f16_label2";
            this.f16_label2.Size = new System.Drawing.Size(43, 17);
            this.f16_label2.TabIndex = 2;
            this.f16_label2.Text = "Ключ";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(83, 328);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(671, 48);
            this.progressBar.TabIndex = 28;
            // 
            // f16_ButtonDecryptFile
            // 
            this.f16_ButtonDecryptFile.Location = new System.Drawing.Point(442, 223);
            this.f16_ButtonDecryptFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f16_ButtonDecryptFile.Name = "f16_ButtonDecryptFile";
            this.f16_ButtonDecryptFile.Size = new System.Drawing.Size(133, 52);
            this.f16_ButtonDecryptFile.TabIndex = 27;
            this.f16_ButtonDecryptFile.Text = "Расшифровать";
            this.f16_ButtonDecryptFile.UseVisualStyleBackColor = true;
            this.f16_ButtonDecryptFile.Click += new System.EventHandler(this.f16_ButtonDecryptFile_Click);
            // 
            // f16_ButtonEncryptFile
            // 
            this.f16_ButtonEncryptFile.Location = new System.Drawing.Point(287, 223);
            this.f16_ButtonEncryptFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f16_ButtonEncryptFile.Name = "f16_ButtonEncryptFile";
            this.f16_ButtonEncryptFile.Size = new System.Drawing.Size(133, 52);
            this.f16_ButtonEncryptFile.TabIndex = 23;
            this.f16_ButtonEncryptFile.Text = "Зашифровать";
            this.f16_ButtonEncryptFile.UseVisualStyleBackColor = true;
            this.f16_ButtonEncryptFile.Click += new System.EventHandler(this.f16_ButtonEncryptFile_Click);
            // 
            // f16_labelPB
            // 
            this.f16_labelPB.AutoSize = true;
            this.f16_labelPB.Location = new System.Drawing.Point(80, 308);
            this.f16_labelPB.Name = "f16_labelPB";
            this.f16_labelPB.Size = new System.Drawing.Size(108, 17);
            this.f16_labelPB.TabIndex = 29;
            this.f16_labelPB.Text = "Готов к работе";
            // 
            // f16_ButtonReadKeyword
            // 
            this.f16_ButtonReadKeyword.AutoSize = true;
            this.f16_ButtonReadKeyword.BackColor = System.Drawing.Color.Transparent;
            this.f16_ButtonReadKeyword.ForeColor = System.Drawing.Color.Gray;
            this.f16_ButtonReadKeyword.Location = new System.Drawing.Point(530, 140);
            this.f16_ButtonReadKeyword.Name = "f16_ButtonReadKeyword";
            this.f16_ButtonReadKeyword.Size = new System.Drawing.Size(72, 17);
            this.f16_ButtonReadKeyword.TabIndex = 30;
            this.f16_ButtonReadKeyword.Text = "Из файла";
            this.f16_ButtonReadKeyword.Click += new System.EventHandler(this.f16_ButtonReadKeyword_Click);
            // 
            // f16_ButtonSaveKeyword
            // 
            this.f16_ButtonSaveKeyword.AutoSize = true;
            this.f16_ButtonSaveKeyword.BackColor = System.Drawing.Color.Transparent;
            this.f16_ButtonSaveKeyword.ForeColor = System.Drawing.Color.Gray;
            this.f16_ButtonSaveKeyword.Location = new System.Drawing.Point(680, 140);
            this.f16_ButtonSaveKeyword.Name = "f16_ButtonSaveKeyword";
            this.f16_ButtonSaveKeyword.Size = new System.Drawing.Size(77, 17);
            this.f16_ButtonSaveKeyword.TabIndex = 31;
            this.f16_ButtonSaveKeyword.Text = "Сохранить";
            this.f16_ButtonSaveKeyword.Click += new System.EventHandler(this.f16_ButtonSaveKeyword_Click);
            // 
            // Form16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 444);
            this.Controls.Add(this.f16_ButtonSaveKeyword);
            this.Controls.Add(this.f16_ButtonReadKeyword);
            this.Controls.Add(this.f16_labelPB);
            this.Controls.Add(this.f16_ButtonDecryptFile);
            this.Controls.Add(this.f16_ButtonEncryptFile);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.f16_ButtonGenKeyword);
            this.Controls.Add(this.f16_fieldKeyword);
            this.Controls.Add(this.f16_label2);
            this.Controls.Add(this.f16_label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(100, 100);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form16";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label f16_label1;
        private System.Windows.Forms.Label f16_ButtonGenKeyword;
        private System.Windows.Forms.TextBox f16_fieldKeyword;
        private System.Windows.Forms.Label f16_label2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button f16_ButtonDecryptFile;
        private System.Windows.Forms.Button f16_ButtonEncryptFile;
        private System.Windows.Forms.Label f16_labelPB;
        private System.Windows.Forms.Label f16_ButtonReadKeyword;
        private System.Windows.Forms.Label f16_ButtonSaveKeyword;
    }
}