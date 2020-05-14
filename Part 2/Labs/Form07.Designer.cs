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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.f7_buttonCountHashFromFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.f7_buttonCountHashFromTextbox = new System.Windows.Forms.Button();
            this.f7_textBox_original = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.f7_TextBox_Hash = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.f7_buttonCountHashFromFile);
            this.groupBox2.Location = new System.Drawing.Point(29, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(787, 75);
            this.groupBox2.TabIndex = 93;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Из файла";
            // 
            // f7_buttonCountHashFromFile
            // 
            this.f7_buttonCountHashFromFile.Location = new System.Drawing.Point(289, 21);
            this.f7_buttonCountHashFromFile.Name = "f7_buttonCountHashFromFile";
            this.f7_buttonCountHashFromFile.Size = new System.Drawing.Size(195, 41);
            this.f7_buttonCountHashFromFile.TabIndex = 88;
            this.f7_buttonCountHashFromFile.Text = "Рассчитать";
            this.f7_buttonCountHashFromFile.UseVisualStyleBackColor = true;
            this.f7_buttonCountHashFromFile.Click += new System.EventHandler(this.f7_buttonCountHashFromFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.f7_buttonCountHashFromTextbox);
            this.groupBox1.Controls.Add(this.f7_textBox_original);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(29, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 120);
            this.groupBox1.TabIndex = 91;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "С клавиатуры";
            // 
            // f7_buttonCountHashFromTextbox
            // 
            this.f7_buttonCountHashFromTextbox.Location = new System.Drawing.Point(568, 53);
            this.f7_buttonCountHashFromTextbox.Name = "f7_buttonCountHashFromTextbox";
            this.f7_buttonCountHashFromTextbox.Size = new System.Drawing.Size(195, 41);
            this.f7_buttonCountHashFromTextbox.TabIndex = 87;
            this.f7_buttonCountHashFromTextbox.Text = "Рассчитать";
            this.f7_buttonCountHashFromTextbox.UseVisualStyleBackColor = true;
            this.f7_buttonCountHashFromTextbox.Click += new System.EventHandler(this.f7_buttonCountHashFromTextbox_Click);
            // 
            // f7_textBox_original
            // 
            this.f7_textBox_original.Location = new System.Drawing.Point(12, 41);
            this.f7_textBox_original.Multiline = true;
            this.f7_textBox_original.Name = "f7_textBox_original";
            this.f7_textBox_original.Size = new System.Drawing.Size(535, 68);
            this.f7_textBox_original.TabIndex = 83;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 17);
            this.label2.TabIndex = 94;
            this.label2.Text = "Результат хэширования";
            // 
            // f7_TextBox_Hash
            // 
            this.f7_TextBox_Hash.Location = new System.Drawing.Point(41, 346);
            this.f7_TextBox_Hash.Multiline = true;
            this.f7_TextBox_Hash.Name = "f7_TextBox_Hash";
            this.f7_TextBox_Hash.ReadOnly = true;
            this.f7_TextBox_Hash.Size = new System.Drawing.Size(751, 30);
            this.f7_TextBox_Hash.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 88;
            this.label1.Text = "SHA-1";
            // 
            // Form07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 444);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.f7_TextBox_Hash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "Form07";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SHA-1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button f7_buttonCountHashFromFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button f7_buttonCountHashFromTextbox;
        private System.Windows.Forms.TextBox f7_textBox_original;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox f7_TextBox_Hash;
        private System.Windows.Forms.Label label1;
    }
}