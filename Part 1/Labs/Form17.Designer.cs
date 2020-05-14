namespace Labs
{
    partial class Form17
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
            this.f17_label1 = new System.Windows.Forms.Label();
            this.f17_ButtonSaveKeyword = new System.Windows.Forms.Label();
            this.f17_ButtonReadKeyword = new System.Windows.Forms.Label();
            this.f17_labelPB = new System.Windows.Forms.Label();
            this.f17_ButtonDecryptFile = new System.Windows.Forms.Button();
            this.f17_ButtonEncryptFile = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.f17_ButtonGenKeyword = new System.Windows.Forms.Label();
            this.f17_fieldKeyword = new System.Windows.Forms.TextBox();
            this.f17_label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // f17_label1
            // 
            this.f17_label1.AutoSize = true;
            this.f17_label1.Location = new System.Drawing.Point(374, 25);
            this.f17_label1.Name = "f17_label1";
            this.f17_label1.Size = new System.Drawing.Size(106, 17);
            this.f17_label1.TabIndex = 4;
            this.f17_label1.Text = "ГОСТ28147-89";
            // 
            // f17_ButtonSaveKeyword
            // 
            this.f17_ButtonSaveKeyword.AutoSize = true;
            this.f17_ButtonSaveKeyword.BackColor = System.Drawing.Color.Transparent;
            this.f17_ButtonSaveKeyword.ForeColor = System.Drawing.Color.Gray;
            this.f17_ButtonSaveKeyword.Location = new System.Drawing.Point(680, 140);
            this.f17_ButtonSaveKeyword.Name = "f17_ButtonSaveKeyword";
            this.f17_ButtonSaveKeyword.Size = new System.Drawing.Size(77, 17);
            this.f17_ButtonSaveKeyword.TabIndex = 40;
            this.f17_ButtonSaveKeyword.Text = "Сохранить";
            this.f17_ButtonSaveKeyword.Click += new System.EventHandler(this.f17_ButtonSaveKeyword_Click);
            // 
            // f17_ButtonReadKeyword
            // 
            this.f17_ButtonReadKeyword.AutoSize = true;
            this.f17_ButtonReadKeyword.BackColor = System.Drawing.Color.Transparent;
            this.f17_ButtonReadKeyword.ForeColor = System.Drawing.Color.Gray;
            this.f17_ButtonReadKeyword.Location = new System.Drawing.Point(530, 140);
            this.f17_ButtonReadKeyword.Name = "f17_ButtonReadKeyword";
            this.f17_ButtonReadKeyword.Size = new System.Drawing.Size(72, 17);
            this.f17_ButtonReadKeyword.TabIndex = 39;
            this.f17_ButtonReadKeyword.Text = "Из файла";
            this.f17_ButtonReadKeyword.Click += new System.EventHandler(this.f17_ButtonReadKeyword_Click);
            // 
            // f17_labelPB
            // 
            this.f17_labelPB.AutoSize = true;
            this.f17_labelPB.Location = new System.Drawing.Point(80, 308);
            this.f17_labelPB.Name = "f17_labelPB";
            this.f17_labelPB.Size = new System.Drawing.Size(108, 17);
            this.f17_labelPB.TabIndex = 38;
            this.f17_labelPB.Text = "Готов к работе";
            // 
            // f17_ButtonDecryptFile
            // 
            this.f17_ButtonDecryptFile.Location = new System.Drawing.Point(442, 223);
            this.f17_ButtonDecryptFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f17_ButtonDecryptFile.Name = "f17_ButtonDecryptFile";
            this.f17_ButtonDecryptFile.Size = new System.Drawing.Size(133, 52);
            this.f17_ButtonDecryptFile.TabIndex = 36;
            this.f17_ButtonDecryptFile.Text = "Расшифровать";
            this.f17_ButtonDecryptFile.UseVisualStyleBackColor = true;
            this.f17_ButtonDecryptFile.Click += new System.EventHandler(this.f17_ButtonDecryptFile_Click);
            // 
            // f17_ButtonEncryptFile
            // 
            this.f17_ButtonEncryptFile.Location = new System.Drawing.Point(287, 223);
            this.f17_ButtonEncryptFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f17_ButtonEncryptFile.Name = "f17_ButtonEncryptFile";
            this.f17_ButtonEncryptFile.Size = new System.Drawing.Size(133, 52);
            this.f17_ButtonEncryptFile.TabIndex = 35;
            this.f17_ButtonEncryptFile.Text = "Зашифровать";
            this.f17_ButtonEncryptFile.UseVisualStyleBackColor = true;
            this.f17_ButtonEncryptFile.Click += new System.EventHandler(this.f17_ButtonEncryptFile_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(83, 328);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(671, 48);
            this.progressBar.TabIndex = 37;
            // 
            // f17_ButtonGenKeyword
            // 
            this.f17_ButtonGenKeyword.AutoSize = true;
            this.f17_ButtonGenKeyword.BackColor = System.Drawing.Color.Transparent;
            this.f17_ButtonGenKeyword.ForeColor = System.Drawing.Color.Gray;
            this.f17_ButtonGenKeyword.Location = new System.Drawing.Point(601, 140);
            this.f17_ButtonGenKeyword.Name = "f17_ButtonGenKeyword";
            this.f17_ButtonGenKeyword.Size = new System.Drawing.Size(80, 17);
            this.f17_ButtonGenKeyword.TabIndex = 33;
            this.f17_ButtonGenKeyword.Text = "Генерация";
            this.f17_ButtonGenKeyword.Click += new System.EventHandler(this.f17_ButtonGenKeyword_Click);
            // 
            // f17_fieldKeyword
            // 
            this.f17_fieldKeyword.Location = new System.Drawing.Point(83, 159);
            this.f17_fieldKeyword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f17_fieldKeyword.Multiline = true;
            this.f17_fieldKeyword.Name = "f17_fieldKeyword";
            this.f17_fieldKeyword.ReadOnly = true;
            this.f17_fieldKeyword.Size = new System.Drawing.Size(671, 40);
            this.f17_fieldKeyword.TabIndex = 34;
            // 
            // f17_label2
            // 
            this.f17_label2.AutoSize = true;
            this.f17_label2.Location = new System.Drawing.Point(80, 140);
            this.f17_label2.Name = "f17_label2";
            this.f17_label2.Size = new System.Drawing.Size(43, 17);
            this.f17_label2.TabIndex = 32;
            this.f17_label2.Text = "Ключ";
            // 
            // Form17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 444);
            this.Controls.Add(this.f17_ButtonSaveKeyword);
            this.Controls.Add(this.f17_ButtonReadKeyword);
            this.Controls.Add(this.f17_labelPB);
            this.Controls.Add(this.f17_ButtonDecryptFile);
            this.Controls.Add(this.f17_ButtonEncryptFile);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.f17_ButtonGenKeyword);
            this.Controls.Add(this.f17_fieldKeyword);
            this.Controls.Add(this.f17_label2);
            this.Controls.Add(this.f17_label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(100, 100);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form17";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ГОСТ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label f17_label1;
        private System.Windows.Forms.Label f17_ButtonSaveKeyword;
        private System.Windows.Forms.Label f17_ButtonReadKeyword;
        private System.Windows.Forms.Label f17_labelPB;
        private System.Windows.Forms.Button f17_ButtonDecryptFile;
        private System.Windows.Forms.Button f17_ButtonEncryptFile;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label f17_ButtonGenKeyword;
        private System.Windows.Forms.TextBox f17_fieldKeyword;
        private System.Windows.Forms.Label f17_label2;
    }
}