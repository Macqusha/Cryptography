namespace Labs
{
    partial class Form08
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.f8_buttonCountHashFromFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.f8_buttonCountHashFromTextbox = new System.Windows.Forms.Button();
            this.f8_textBox_original = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.f8_TextBox_Hash512 = new System.Windows.Forms.TextBox();
            this.f8_TextBox_Hash256 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 17);
            this.label1.TabIndex = 94;
            this.label1.Text = "ГОСТ Р 34.11-2012  (алгоритм хеширования)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.f8_buttonCountHashFromFile);
            this.groupBox2.Location = new System.Drawing.Point(29, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(787, 75);
            this.groupBox2.TabIndex = 97;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Из файла";
            // 
            // f8_buttonCountHashFromFile
            // 
            this.f8_buttonCountHashFromFile.Location = new System.Drawing.Point(289, 21);
            this.f8_buttonCountHashFromFile.Name = "f8_buttonCountHashFromFile";
            this.f8_buttonCountHashFromFile.Size = new System.Drawing.Size(195, 41);
            this.f8_buttonCountHashFromFile.TabIndex = 88;
            this.f8_buttonCountHashFromFile.Text = "Рассчитать";
            this.f8_buttonCountHashFromFile.UseVisualStyleBackColor = true;
            this.f8_buttonCountHashFromFile.Click += new System.EventHandler(this.f8_buttonCountHashFromFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.f8_buttonCountHashFromTextbox);
            this.groupBox1.Controls.Add(this.f8_textBox_original);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(29, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 120);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "С клавиатуры";
            // 
            // f8_buttonCountHashFromTextbox
            // 
            this.f8_buttonCountHashFromTextbox.Location = new System.Drawing.Point(568, 53);
            this.f8_buttonCountHashFromTextbox.Name = "f8_buttonCountHashFromTextbox";
            this.f8_buttonCountHashFromTextbox.Size = new System.Drawing.Size(195, 41);
            this.f8_buttonCountHashFromTextbox.TabIndex = 87;
            this.f8_buttonCountHashFromTextbox.Text = "Рассчитать";
            this.f8_buttonCountHashFromTextbox.UseVisualStyleBackColor = true;
            this.f8_buttonCountHashFromTextbox.Click += new System.EventHandler(this.f8_buttonCountHashFromTextbox_Click);
            // 
            // f8_textBox_original
            // 
            this.f8_textBox_original.Location = new System.Drawing.Point(12, 41);
            this.f8_textBox_original.Multiline = true;
            this.f8_textBox_original.Name = "f8_textBox_original";
            this.f8_textBox_original.Size = new System.Drawing.Size(535, 68);
            this.f8_textBox_original.TabIndex = 83;
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
            // f8_TextBox_Hash512
            // 
            this.f8_TextBox_Hash512.Location = new System.Drawing.Point(91, 363);
            this.f8_TextBox_Hash512.Multiline = true;
            this.f8_TextBox_Hash512.Name = "f8_TextBox_Hash512";
            this.f8_TextBox_Hash512.ReadOnly = true;
            this.f8_TextBox_Hash512.Size = new System.Drawing.Size(725, 46);
            this.f8_TextBox_Hash512.TabIndex = 96;
            // 
            // f8_TextBox_Hash256
            // 
            this.f8_TextBox_Hash256.Location = new System.Drawing.Point(91, 327);
            this.f8_TextBox_Hash256.Multiline = true;
            this.f8_TextBox_Hash256.Name = "f8_TextBox_Hash256";
            this.f8_TextBox_Hash256.ReadOnly = true;
            this.f8_TextBox_Hash256.Size = new System.Drawing.Size(725, 22);
            this.f8_TextBox_Hash256.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 88;
            this.label2.Text = "256 бит";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 100;
            this.label4.Text = "512 бит";
            // 
            // Form08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 444);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.f8_TextBox_Hash256);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.f8_TextBox_Hash512);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "Form08";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ГОСТ";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button f8_buttonCountHashFromFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button f8_buttonCountHashFromTextbox;
        private System.Windows.Forms.TextBox f8_textBox_original;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox f8_TextBox_Hash512;
        private System.Windows.Forms.TextBox f8_TextBox_Hash256;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}