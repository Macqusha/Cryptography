namespace Labs
{
    partial class Form13
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
            this.f13_label1 = new System.Windows.Forms.Label();
            this.f13_ButtonGenKeyword = new System.Windows.Forms.Label();
            this.f13_ButtonClearOriginal = new System.Windows.Forms.Label();
            this.f13_ButtonClearKeyword = new System.Windows.Forms.Label();
            this.f13_ButtonClearCiphertext = new System.Windows.Forms.Label();
            this.f13_label4 = new System.Windows.Forms.Label();
            this.f13_label2 = new System.Windows.Forms.Label();
            this.f13_fieldKeyword = new System.Windows.Forms.TextBox();
            this.f13_label3 = new System.Windows.Forms.Label();
            this.f13_ButtonDecrypt = new System.Windows.Forms.Button();
            this.f13_fieldCiphertext = new System.Windows.Forms.TextBox();
            this.f13_ButtonEncrypt = new System.Windows.Forms.Button();
            this.f13_fieldOriginal = new System.Windows.Forms.TextBox();
            this.f13_ButtonSaveOriginal = new System.Windows.Forms.Label();
            this.f13_ButtonReadOriginal = new System.Windows.Forms.Label();
            this.f13_ButtonReadKeyword = new System.Windows.Forms.Label();
            this.f13_ButtonSaveKeyword = new System.Windows.Forms.Label();
            this.f13_ButtonReadCiphertext = new System.Windows.Forms.Label();
            this.f13_ButtonSaveCiphertext = new System.Windows.Forms.Label();
            this.f13_paramB = new System.Windows.Forms.NumericUpDown();
            this.f13_paramA = new System.Windows.Forms.NumericUpDown();
            this.f13_paramX0 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.f13_paramB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f13_paramA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f13_paramX0)).BeginInit();
            this.SuspendLayout();
            // 
            // f13_label1
            // 
            this.f13_label1.AutoSize = true;
            this.f13_label1.Location = new System.Drawing.Point(291, 25);
            this.f13_label1.Name = "f13_label1";
            this.f13_label1.Size = new System.Drawing.Size(252, 17);
            this.f13_label1.TabIndex = 2;
            this.f13_label1.Text = "Шифрование методом гаммирования";
            // 
            // f13_ButtonGenKeyword
            // 
            this.f13_ButtonGenKeyword.AutoSize = true;
            this.f13_ButtonGenKeyword.BackColor = System.Drawing.Color.Transparent;
            this.f13_ButtonGenKeyword.ForeColor = System.Drawing.Color.Gray;
            this.f13_ButtonGenKeyword.Location = new System.Drawing.Point(396, 116);
            this.f13_ButtonGenKeyword.Name = "f13_ButtonGenKeyword";
            this.f13_ButtonGenKeyword.Size = new System.Drawing.Size(80, 17);
            this.f13_ButtonGenKeyword.TabIndex = 18;
            this.f13_ButtonGenKeyword.Text = "Генерация";
            this.f13_ButtonGenKeyword.Click += new System.EventHandler(this.f13_ButtonGenKeyword_Click);
            // 
            // f13_ButtonClearOriginal
            // 
            this.f13_ButtonClearOriginal.AutoSize = true;
            this.f13_ButtonClearOriginal.ForeColor = System.Drawing.Color.Gray;
            this.f13_ButtonClearOriginal.Location = new System.Drawing.Point(201, 116);
            this.f13_ButtonClearOriginal.Name = "f13_ButtonClearOriginal";
            this.f13_ButtonClearOriginal.Size = new System.Drawing.Size(71, 17);
            this.f13_ButtonClearOriginal.TabIndex = 24;
            this.f13_ButtonClearOriginal.Text = "Очистить";
            this.f13_ButtonClearOriginal.Click += new System.EventHandler(this.f13_ButtonClearOriginal_Click);
            // 
            // f13_ButtonClearKeyword
            // 
            this.f13_ButtonClearKeyword.AutoSize = true;
            this.f13_ButtonClearKeyword.BackColor = System.Drawing.Color.Transparent;
            this.f13_ButtonClearKeyword.ForeColor = System.Drawing.Color.Gray;
            this.f13_ButtonClearKeyword.Location = new System.Drawing.Point(475, 116);
            this.f13_ButtonClearKeyword.Name = "f13_ButtonClearKeyword";
            this.f13_ButtonClearKeyword.Size = new System.Drawing.Size(71, 17);
            this.f13_ButtonClearKeyword.TabIndex = 25;
            this.f13_ButtonClearKeyword.Text = "Очистить";
            this.f13_ButtonClearKeyword.Click += new System.EventHandler(this.f13_ButtonClearKeyword_Click);
            // 
            // f13_ButtonClearCiphertext
            // 
            this.f13_ButtonClearCiphertext.AutoSize = true;
            this.f13_ButtonClearCiphertext.ForeColor = System.Drawing.Color.Gray;
            this.f13_ButtonClearCiphertext.Location = new System.Drawing.Point(748, 116);
            this.f13_ButtonClearCiphertext.Name = "f13_ButtonClearCiphertext";
            this.f13_ButtonClearCiphertext.Size = new System.Drawing.Size(71, 17);
            this.f13_ButtonClearCiphertext.TabIndex = 26;
            this.f13_ButtonClearCiphertext.Text = "Очистить";
            this.f13_ButtonClearCiphertext.Click += new System.EventHandler(this.f13_ButtonClearCiphertext_Click);
            // 
            // f13_label4
            // 
            this.f13_label4.AutoSize = true;
            this.f13_label4.Location = new System.Drawing.Point(573, 111);
            this.f13_label4.Name = "f13_label4";
            this.f13_label4.Size = new System.Drawing.Size(82, 17);
            this.f13_label4.TabIndex = 21;
            this.f13_label4.Text = "Шифртекст";
            // 
            // f13_label2
            // 
            this.f13_label2.AutoSize = true;
            this.f13_label2.Location = new System.Drawing.Point(27, 111);
            this.f13_label2.Name = "f13_label2";
            this.f13_label2.Size = new System.Drawing.Size(113, 17);
            this.f13_label2.TabIndex = 15;
            this.f13_label2.Text = "Исходный текст";
            // 
            // f13_fieldKeyword
            // 
            this.f13_fieldKeyword.Location = new System.Drawing.Point(300, 134);
            this.f13_fieldKeyword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f13_fieldKeyword.Multiline = true;
            this.f13_fieldKeyword.Name = "f13_fieldKeyword";
            this.f13_fieldKeyword.Size = new System.Drawing.Size(245, 182);
            this.f13_fieldKeyword.TabIndex = 19;
            this.f13_fieldKeyword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f13_fieldKeyword_KeyPress);
            // 
            // f13_label3
            // 
            this.f13_label3.AutoSize = true;
            this.f13_label3.Location = new System.Drawing.Point(300, 111);
            this.f13_label3.Name = "f13_label3";
            this.f13_label3.Size = new System.Drawing.Size(43, 17);
            this.f13_label3.TabIndex = 17;
            this.f13_label3.Text = "Ключ";
            // 
            // f13_ButtonDecrypt
            // 
            this.f13_ButtonDecrypt.Location = new System.Drawing.Point(447, 345);
            this.f13_ButtonDecrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f13_ButtonDecrypt.Name = "f13_ButtonDecrypt";
            this.f13_ButtonDecrypt.Size = new System.Drawing.Size(267, 62);
            this.f13_ButtonDecrypt.TabIndex = 23;
            this.f13_ButtonDecrypt.Text = "Расшифровать";
            this.f13_ButtonDecrypt.UseVisualStyleBackColor = true;
            this.f13_ButtonDecrypt.Click += new System.EventHandler(this.f13_ButtonDecrypt_Click);
            // 
            // f13_fieldCiphertext
            // 
            this.f13_fieldCiphertext.Location = new System.Drawing.Point(573, 135);
            this.f13_fieldCiphertext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f13_fieldCiphertext.Multiline = true;
            this.f13_fieldCiphertext.Name = "f13_fieldCiphertext";
            this.f13_fieldCiphertext.Size = new System.Drawing.Size(245, 182);
            this.f13_fieldCiphertext.TabIndex = 22;
            this.f13_fieldCiphertext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f13_fieldCiphertext_KeyPress);
            // 
            // f13_ButtonEncrypt
            // 
            this.f13_ButtonEncrypt.Location = new System.Drawing.Point(107, 345);
            this.f13_ButtonEncrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f13_ButtonEncrypt.Name = "f13_ButtonEncrypt";
            this.f13_ButtonEncrypt.Size = new System.Drawing.Size(267, 62);
            this.f13_ButtonEncrypt.TabIndex = 20;
            this.f13_ButtonEncrypt.Text = "Зашифровать";
            this.f13_ButtonEncrypt.UseVisualStyleBackColor = true;
            this.f13_ButtonEncrypt.Click += new System.EventHandler(this.f13_ButtonEncrypt_Click);
            // 
            // f13_fieldOriginal
            // 
            this.f13_fieldOriginal.Location = new System.Drawing.Point(27, 134);
            this.f13_fieldOriginal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f13_fieldOriginal.Multiline = true;
            this.f13_fieldOriginal.Name = "f13_fieldOriginal";
            this.f13_fieldOriginal.Size = new System.Drawing.Size(245, 182);
            this.f13_fieldOriginal.TabIndex = 16;
            this.f13_fieldOriginal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f13_fieldOriginal_KeyPress);
            // 
            // f13_ButtonSaveOriginal
            // 
            this.f13_ButtonSaveOriginal.AutoSize = true;
            this.f13_ButtonSaveOriginal.ForeColor = System.Drawing.Color.Gray;
            this.f13_ButtonSaveOriginal.Location = new System.Drawing.Point(195, 318);
            this.f13_ButtonSaveOriginal.Name = "f13_ButtonSaveOriginal";
            this.f13_ButtonSaveOriginal.Size = new System.Drawing.Size(77, 17);
            this.f13_ButtonSaveOriginal.TabIndex = 28;
            this.f13_ButtonSaveOriginal.Text = "Сохранить";
            this.f13_ButtonSaveOriginal.Click += new System.EventHandler(this.f13_ButtonSaveOriginal_Click);
            // 
            // f13_ButtonReadOriginal
            // 
            this.f13_ButtonReadOriginal.AutoSize = true;
            this.f13_ButtonReadOriginal.ForeColor = System.Drawing.Color.Gray;
            this.f13_ButtonReadOriginal.Location = new System.Drawing.Point(133, 318);
            this.f13_ButtonReadOriginal.Name = "f13_ButtonReadOriginal";
            this.f13_ButtonReadOriginal.Size = new System.Drawing.Size(62, 17);
            this.f13_ButtonReadOriginal.TabIndex = 29;
            this.f13_ButtonReadOriginal.Text = "Считать";
            this.f13_ButtonReadOriginal.Click += new System.EventHandler(this.f13_ButtonReadOriginal_Click);
            // 
            // f13_ButtonReadKeyword
            // 
            this.f13_ButtonReadKeyword.AutoSize = true;
            this.f13_ButtonReadKeyword.ForeColor = System.Drawing.Color.Gray;
            this.f13_ButtonReadKeyword.Location = new System.Drawing.Point(407, 318);
            this.f13_ButtonReadKeyword.Name = "f13_ButtonReadKeyword";
            this.f13_ButtonReadKeyword.Size = new System.Drawing.Size(62, 17);
            this.f13_ButtonReadKeyword.TabIndex = 31;
            this.f13_ButtonReadKeyword.Text = "Считать";
            this.f13_ButtonReadKeyword.Click += new System.EventHandler(this.f13_ButtonReadKeyword_Click);
            // 
            // f13_ButtonSaveKeyword
            // 
            this.f13_ButtonSaveKeyword.AutoSize = true;
            this.f13_ButtonSaveKeyword.ForeColor = System.Drawing.Color.Gray;
            this.f13_ButtonSaveKeyword.Location = new System.Drawing.Point(469, 318);
            this.f13_ButtonSaveKeyword.Name = "f13_ButtonSaveKeyword";
            this.f13_ButtonSaveKeyword.Size = new System.Drawing.Size(77, 17);
            this.f13_ButtonSaveKeyword.TabIndex = 30;
            this.f13_ButtonSaveKeyword.Text = "Сохранить";
            this.f13_ButtonSaveKeyword.Click += new System.EventHandler(this.f13_ButtonSaveKeyword_Click);
            // 
            // f13_ButtonReadCiphertext
            // 
            this.f13_ButtonReadCiphertext.AutoSize = true;
            this.f13_ButtonReadCiphertext.ForeColor = System.Drawing.Color.Gray;
            this.f13_ButtonReadCiphertext.Location = new System.Drawing.Point(680, 319);
            this.f13_ButtonReadCiphertext.Name = "f13_ButtonReadCiphertext";
            this.f13_ButtonReadCiphertext.Size = new System.Drawing.Size(62, 17);
            this.f13_ButtonReadCiphertext.TabIndex = 33;
            this.f13_ButtonReadCiphertext.Text = "Считать";
            this.f13_ButtonReadCiphertext.Click += new System.EventHandler(this.f13_ButtonReadCiphertext_Click);
            // 
            // f13_ButtonSaveCiphertext
            // 
            this.f13_ButtonSaveCiphertext.AutoSize = true;
            this.f13_ButtonSaveCiphertext.ForeColor = System.Drawing.Color.Gray;
            this.f13_ButtonSaveCiphertext.Location = new System.Drawing.Point(742, 319);
            this.f13_ButtonSaveCiphertext.Name = "f13_ButtonSaveCiphertext";
            this.f13_ButtonSaveCiphertext.Size = new System.Drawing.Size(77, 17);
            this.f13_ButtonSaveCiphertext.TabIndex = 32;
            this.f13_ButtonSaveCiphertext.Text = "Сохранить";
            this.f13_ButtonSaveCiphertext.Click += new System.EventHandler(this.f13_ButtonSaveCiphertext_Click);
            // 
            // f13_paramB
            // 
            this.f13_paramB.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.f13_paramB.Location = new System.Drawing.Point(767, 43);
            this.f13_paramB.Margin = new System.Windows.Forms.Padding(4);
            this.f13_paramB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.f13_paramB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.f13_paramB.Name = "f13_paramB";
            this.f13_paramB.Size = new System.Drawing.Size(65, 22);
            this.f13_paramB.TabIndex = 34;
            this.f13_paramB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // f13_paramA
            // 
            this.f13_paramA.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.f13_paramA.Location = new System.Drawing.Point(767, 13);
            this.f13_paramA.Margin = new System.Windows.Forms.Padding(4);
            this.f13_paramA.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.f13_paramA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.f13_paramA.Name = "f13_paramA";
            this.f13_paramA.Size = new System.Drawing.Size(65, 22);
            this.f13_paramA.TabIndex = 35;
            this.f13_paramA.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // f13_paramX0
            // 
            this.f13_paramX0.Location = new System.Drawing.Point(767, 73);
            this.f13_paramX0.Margin = new System.Windows.Forms.Padding(4);
            this.f13_paramX0.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.f13_paramX0.Name = "f13_paramX0";
            this.f13_paramX0.Size = new System.Drawing.Size(65, 22);
            this.f13_paramX0.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(739, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(739, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(739, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Xo";
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 444);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.f13_paramX0);
            this.Controls.Add(this.f13_paramA);
            this.Controls.Add(this.f13_paramB);
            this.Controls.Add(this.f13_ButtonReadCiphertext);
            this.Controls.Add(this.f13_ButtonSaveCiphertext);
            this.Controls.Add(this.f13_ButtonReadKeyword);
            this.Controls.Add(this.f13_ButtonSaveKeyword);
            this.Controls.Add(this.f13_ButtonReadOriginal);
            this.Controls.Add(this.f13_ButtonSaveOriginal);
            this.Controls.Add(this.f13_ButtonGenKeyword);
            this.Controls.Add(this.f13_ButtonClearOriginal);
            this.Controls.Add(this.f13_ButtonClearKeyword);
            this.Controls.Add(this.f13_ButtonClearCiphertext);
            this.Controls.Add(this.f13_label4);
            this.Controls.Add(this.f13_label2);
            this.Controls.Add(this.f13_fieldKeyword);
            this.Controls.Add(this.f13_label3);
            this.Controls.Add(this.f13_ButtonDecrypt);
            this.Controls.Add(this.f13_fieldCiphertext);
            this.Controls.Add(this.f13_ButtonEncrypt);
            this.Controls.Add(this.f13_fieldOriginal);
            this.Controls.Add(this.f13_label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(100, 100);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form13";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Шифрование методом гаммирования";
            ((System.ComponentModel.ISupportInitialize)(this.f13_paramB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f13_paramA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f13_paramX0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label f13_label1;
        private System.Windows.Forms.Label f13_ButtonGenKeyword;
        private System.Windows.Forms.Label f13_ButtonClearOriginal;
        private System.Windows.Forms.Label f13_ButtonClearKeyword;
        private System.Windows.Forms.Label f13_ButtonClearCiphertext;
        private System.Windows.Forms.Label f13_label4;
        private System.Windows.Forms.Label f13_label2;
        private System.Windows.Forms.TextBox f13_fieldKeyword;
        private System.Windows.Forms.Label f13_label3;
        private System.Windows.Forms.Button f13_ButtonDecrypt;
        private System.Windows.Forms.TextBox f13_fieldCiphertext;
        private System.Windows.Forms.Button f13_ButtonEncrypt;
        private System.Windows.Forms.TextBox f13_fieldOriginal;
        private System.Windows.Forms.Label f13_ButtonSaveOriginal;
        private System.Windows.Forms.Label f13_ButtonReadOriginal;
        private System.Windows.Forms.Label f13_ButtonReadKeyword;
        private System.Windows.Forms.Label f13_ButtonSaveKeyword;
        private System.Windows.Forms.Label f13_ButtonReadCiphertext;
        private System.Windows.Forms.Label f13_ButtonSaveCiphertext;
        private System.Windows.Forms.NumericUpDown f13_paramB;
        private System.Windows.Forms.NumericUpDown f13_paramA;
        private System.Windows.Forms.NumericUpDown f13_paramX0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}