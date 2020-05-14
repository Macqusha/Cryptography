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
            this.label10 = new System.Windows.Forms.Label();
            this.f6_textBox_original = new System.Windows.Forms.TextBox();
            this.f6_buttonCountHashFromTextbox = new System.Windows.Forms.Button();
            this.f6_buttonCountHashFromFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.f6_TextBox_Hash = new System.Windows.Forms.TextBox();
            this.f6_label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 17);
            this.label10.TabIndex = 84;
            this.label10.Text = "Исходный текст";
            // 
            // f6_textBox_original
            // 
            this.f6_textBox_original.Location = new System.Drawing.Point(12, 41);
            this.f6_textBox_original.Multiline = true;
            this.f6_textBox_original.Name = "f6_textBox_original";
            this.f6_textBox_original.Size = new System.Drawing.Size(535, 68);
            this.f6_textBox_original.TabIndex = 83;
            // 
            // f6_buttonCountHashFromTextbox
            // 
            this.f6_buttonCountHashFromTextbox.Location = new System.Drawing.Point(568, 53);
            this.f6_buttonCountHashFromTextbox.Name = "f6_buttonCountHashFromTextbox";
            this.f6_buttonCountHashFromTextbox.Size = new System.Drawing.Size(195, 41);
            this.f6_buttonCountHashFromTextbox.TabIndex = 87;
            this.f6_buttonCountHashFromTextbox.Text = "Рассчитать";
            this.f6_buttonCountHashFromTextbox.UseVisualStyleBackColor = true;
            this.f6_buttonCountHashFromTextbox.Click += new System.EventHandler(this.f6_buttonCountHashFromTextbox_Click);
            // 
            // f6_buttonCountHashFromFile
            // 
            this.f6_buttonCountHashFromFile.Location = new System.Drawing.Point(289, 21);
            this.f6_buttonCountHashFromFile.Name = "f6_buttonCountHashFromFile";
            this.f6_buttonCountHashFromFile.Size = new System.Drawing.Size(195, 41);
            this.f6_buttonCountHashFromFile.TabIndex = 88;
            this.f6_buttonCountHashFromFile.Text = "Рассчитать";
            this.f6_buttonCountHashFromFile.UseVisualStyleBackColor = true;
            this.f6_buttonCountHashFromFile.Click += new System.EventHandler(this.f6_buttonCountHashFromFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.f6_buttonCountHashFromTextbox);
            this.groupBox1.Controls.Add(this.f6_textBox_original);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(36, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 120);
            this.groupBox1.TabIndex = 89;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "С клавиатуры";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.f6_buttonCountHashFromFile);
            this.groupBox2.Location = new System.Drawing.Point(36, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(787, 75);
            this.groupBox2.TabIndex = 90;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Из файла";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 17);
            this.label2.TabIndex = 90;
            this.label2.Text = "Результат хэширования";
            // 
            // f6_TextBox_Hash
            // 
            this.f6_TextBox_Hash.Location = new System.Drawing.Point(48, 329);
            this.f6_TextBox_Hash.Multiline = true;
            this.f6_TextBox_Hash.Name = "f6_TextBox_Hash";
            this.f6_TextBox_Hash.ReadOnly = true;
            this.f6_TextBox_Hash.Size = new System.Drawing.Size(751, 30);
            this.f6_TextBox_Hash.TabIndex = 89;
            // 
            // f6_label1
            // 
            this.f6_label1.AutoSize = true;
            this.f6_label1.Location = new System.Drawing.Point(360, 9);
            this.f6_label1.Name = "f6_label1";
            this.f6_label1.Size = new System.Drawing.Size(37, 17);
            this.f6_label1.TabIndex = 91;
            this.f6_label1.Text = "MD5";
            // 
            // Form06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 444);
            this.Controls.Add(this.f6_label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.f6_TextBox_Hash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "Form06";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MD5";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox f6_textBox_original;
        private System.Windows.Forms.Button f6_buttonCountHashFromTextbox;
        private System.Windows.Forms.Button f6_buttonCountHashFromFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox f6_TextBox_Hash;
        private System.Windows.Forms.Label f6_label1;
    }
}