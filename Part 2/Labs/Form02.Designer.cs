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
            this.f2_numericP = new System.Windows.Forms.NumericUpDown();
            this.f2_label_p = new System.Windows.Forms.Label();
            this.f2_label_q = new System.Windows.Forms.Label();
            this.f2_numericQ = new System.Windows.Forms.NumericUpDown();
            this.f2_buttonCheckPrimes = new System.Windows.Forms.Button();
            this.f2_buttonGenPrimes = new System.Windows.Forms.Button();
            this.f2_label5 = new System.Windows.Forms.Label();
            this.f2_label4 = new System.Windows.Forms.Label();
            this.f2_buttonGetKeys = new System.Windows.Forms.Button();
            this.f2_textBoxKeyE = new System.Windows.Forms.TextBox();
            this.f2_label2 = new System.Windows.Forms.Label();
            this.f2_label3 = new System.Windows.Forms.Label();
            this.f2_textBoxAlf = new System.Windows.Forms.TextBox();
            this.f2_Original = new System.Windows.Forms.TextBox();
            this.f2_Ciphertext = new System.Windows.Forms.TextBox();
            this.f2_label6 = new System.Windows.Forms.Label();
            this.f2_buttonEncrypt = new System.Windows.Forms.Button();
            this.f2_buttonDecrypt = new System.Windows.Forms.Button();
            this.f2_textBoxKeyN = new System.Windows.Forms.TextBox();
            this.f2_textBoxKeyN2 = new System.Windows.Forms.TextBox();
            this.f2_textBoxKeyD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.f2_numericP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f2_numericQ)).BeginInit();
            this.SuspendLayout();
            // 
            // f2_label1
            // 
            this.f2_label1.AutoSize = true;
            this.f2_label1.Location = new System.Drawing.Point(265, 29);
            this.f2_label1.Name = "f2_label1";
            this.f2_label1.Size = new System.Drawing.Size(304, 17);
            this.f2_label1.TabIndex = 2;
            this.f2_label1.Text = "Алгоритмы шифрования с открытым ключом";
            // 
            // f2_numericP
            // 
            this.f2_numericP.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.f2_numericP.Location = new System.Drawing.Point(185, 144);
            this.f2_numericP.Maximum = new decimal(new int[] {
            16777213,
            0,
            0,
            0});
            this.f2_numericP.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.f2_numericP.Name = "f2_numericP";
            this.f2_numericP.Size = new System.Drawing.Size(117, 22);
            this.f2_numericP.TabIndex = 6;
            this.f2_numericP.Value = new decimal(new int[] {
            113,
            0,
            0,
            0});
            this.f2_numericP.ValueChanged += new System.EventHandler(this.f2_numericP_ValueChanged);
            // 
            // f2_label_p
            // 
            this.f2_label_p.AutoSize = true;
            this.f2_label_p.Location = new System.Drawing.Point(163, 146);
            this.f2_label_p.Name = "f2_label_p";
            this.f2_label_p.Size = new System.Drawing.Size(16, 17);
            this.f2_label_p.TabIndex = 9;
            this.f2_label_p.Text = "p";
            // 
            // f2_label_q
            // 
            this.f2_label_q.AutoSize = true;
            this.f2_label_q.Location = new System.Drawing.Point(342, 146);
            this.f2_label_q.Name = "f2_label_q";
            this.f2_label_q.Size = new System.Drawing.Size(16, 17);
            this.f2_label_q.TabIndex = 11;
            this.f2_label_q.Text = "q";
            // 
            // f2_numericQ
            // 
            this.f2_numericQ.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.f2_numericQ.Location = new System.Drawing.Point(364, 144);
            this.f2_numericQ.Maximum = new decimal(new int[] {
            16777213,
            0,
            0,
            0});
            this.f2_numericQ.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.f2_numericQ.Name = "f2_numericQ";
            this.f2_numericQ.Size = new System.Drawing.Size(117, 22);
            this.f2_numericQ.TabIndex = 10;
            this.f2_numericQ.Value = new decimal(new int[] {
            281,
            0,
            0,
            0});
            this.f2_numericQ.ValueChanged += new System.EventHandler(this.f2_numericQ_ValueChanged);
            // 
            // f2_buttonCheckPrimes
            // 
            this.f2_buttonCheckPrimes.Location = new System.Drawing.Point(537, 143);
            this.f2_buttonCheckPrimes.Name = "f2_buttonCheckPrimes";
            this.f2_buttonCheckPrimes.Size = new System.Drawing.Size(122, 23);
            this.f2_buttonCheckPrimes.TabIndex = 12;
            this.f2_buttonCheckPrimes.Text = "Проверить";
            this.f2_buttonCheckPrimes.UseVisualStyleBackColor = true;
            this.f2_buttonCheckPrimes.Click += new System.EventHandler(this.f2_buttonCheckPrimes_Click);
            // 
            // f2_buttonGenPrimes
            // 
            this.f2_buttonGenPrimes.Location = new System.Drawing.Point(690, 143);
            this.f2_buttonGenPrimes.Name = "f2_buttonGenPrimes";
            this.f2_buttonGenPrimes.Size = new System.Drawing.Size(122, 23);
            this.f2_buttonGenPrimes.TabIndex = 13;
            this.f2_buttonGenPrimes.Text = "Сгенерировать";
            this.f2_buttonGenPrimes.UseVisualStyleBackColor = true;
            this.f2_buttonGenPrimes.Click += new System.EventHandler(this.f2_buttonGenPrimes_Click);
            // 
            // f2_label5
            // 
            this.f2_label5.AutoSize = true;
            this.f2_label5.Location = new System.Drawing.Point(53, 295);
            this.f2_label5.Name = "f2_label5";
            this.f2_label5.Size = new System.Drawing.Size(113, 17);
            this.f2_label5.TabIndex = 14;
            this.f2_label5.Text = "Исходный текст";
            // 
            // f2_label4
            // 
            this.f2_label4.AutoSize = true;
            this.f2_label4.Location = new System.Drawing.Point(35, 54);
            this.f2_label4.Name = "f2_label4";
            this.f2_label4.Size = new System.Drawing.Size(66, 17);
            this.f2_label4.TabIndex = 15;
            this.f2_label4.Text = "Алфавит";
            // 
            // f2_buttonGetKeys
            // 
            this.f2_buttonGetKeys.Enabled = false;
            this.f2_buttonGetKeys.Location = new System.Drawing.Point(336, 175);
            this.f2_buttonGetKeys.Name = "f2_buttonGetKeys";
            this.f2_buttonGetKeys.Size = new System.Drawing.Size(195, 31);
            this.f2_buttonGetKeys.TabIndex = 16;
            this.f2_buttonGetKeys.Text = "Получить ключи";
            this.f2_buttonGetKeys.UseVisualStyleBackColor = true;
            this.f2_buttonGetKeys.Click += new System.EventHandler(this.f2_buttonGetKeys_Click);
            // 
            // f2_textBoxKeyE
            // 
            this.f2_textBoxKeyE.Location = new System.Drawing.Point(154, 230);
            this.f2_textBoxKeyE.Name = "f2_textBoxKeyE";
            this.f2_textBoxKeyE.ReadOnly = true;
            this.f2_textBoxKeyE.Size = new System.Drawing.Size(257, 22);
            this.f2_textBoxKeyE.TabIndex = 17;
            // 
            // f2_label2
            // 
            this.f2_label2.AutoSize = true;
            this.f2_label2.Location = new System.Drawing.Point(35, 246);
            this.f2_label2.Name = "f2_label2";
            this.f2_label2.Size = new System.Drawing.Size(113, 17);
            this.f2_label2.TabIndex = 18;
            this.f2_label2.Text = "Открытый ключ";
            // 
            // f2_label3
            // 
            this.f2_label3.AutoSize = true;
            this.f2_label3.Location = new System.Drawing.Point(432, 246);
            this.f2_label3.Name = "f2_label3";
            this.f2_label3.Size = new System.Drawing.Size(112, 17);
            this.f2_label3.TabIndex = 20;
            this.f2_label3.Text = "Закрытый ключ";
            // 
            // f2_textBoxAlf
            // 
            this.f2_textBoxAlf.Location = new System.Drawing.Point(38, 74);
            this.f2_textBoxAlf.Multiline = true;
            this.f2_textBoxAlf.Name = "f2_textBoxAlf";
            this.f2_textBoxAlf.Size = new System.Drawing.Size(774, 43);
            this.f2_textBoxAlf.TabIndex = 21;
            this.f2_textBoxAlf.Text = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZабвгдеёжзийклмнопрстуфхцчшщъы" +
    "ьэюя\r\nАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ0123456789.,:;!?() -";
            // 
            // f2_Original
            // 
            this.f2_Original.Location = new System.Drawing.Point(56, 315);
            this.f2_Original.Multiline = true;
            this.f2_Original.Name = "f2_Original";
            this.f2_Original.Size = new System.Drawing.Size(211, 97);
            this.f2_Original.TabIndex = 22;
            // 
            // f2_Ciphertext
            // 
            this.f2_Ciphertext.Location = new System.Drawing.Point(581, 315);
            this.f2_Ciphertext.Multiline = true;
            this.f2_Ciphertext.Name = "f2_Ciphertext";
            this.f2_Ciphertext.Size = new System.Drawing.Size(211, 97);
            this.f2_Ciphertext.TabIndex = 24;
            // 
            // f2_label6
            // 
            this.f2_label6.AutoSize = true;
            this.f2_label6.Location = new System.Drawing.Point(578, 295);
            this.f2_label6.Name = "f2_label6";
            this.f2_label6.Size = new System.Drawing.Size(82, 17);
            this.f2_label6.TabIndex = 23;
            this.f2_label6.Text = "Шифртекст";
            // 
            // f2_buttonEncrypt
            // 
            this.f2_buttonEncrypt.Enabled = false;
            this.f2_buttonEncrypt.Location = new System.Drawing.Point(326, 329);
            this.f2_buttonEncrypt.Name = "f2_buttonEncrypt";
            this.f2_buttonEncrypt.Size = new System.Drawing.Size(195, 33);
            this.f2_buttonEncrypt.TabIndex = 26;
            this.f2_buttonEncrypt.Text = "Зашифровать";
            this.f2_buttonEncrypt.UseVisualStyleBackColor = true;
            this.f2_buttonEncrypt.Click += new System.EventHandler(this.f2_buttonEncrypt_Click);
            // 
            // f2_buttonDecrypt
            // 
            this.f2_buttonDecrypt.Enabled = false;
            this.f2_buttonDecrypt.Location = new System.Drawing.Point(326, 368);
            this.f2_buttonDecrypt.Name = "f2_buttonDecrypt";
            this.f2_buttonDecrypt.Size = new System.Drawing.Size(195, 33);
            this.f2_buttonDecrypt.TabIndex = 27;
            this.f2_buttonDecrypt.Text = "Расшифровать";
            this.f2_buttonDecrypt.UseVisualStyleBackColor = true;
            this.f2_buttonDecrypt.Click += new System.EventHandler(this.f2_buttonDecrypt_Click);
            // 
            // f2_textBoxKeyN
            // 
            this.f2_textBoxKeyN.Location = new System.Drawing.Point(154, 258);
            this.f2_textBoxKeyN.Name = "f2_textBoxKeyN";
            this.f2_textBoxKeyN.ReadOnly = true;
            this.f2_textBoxKeyN.Size = new System.Drawing.Size(257, 22);
            this.f2_textBoxKeyN.TabIndex = 28;
            // 
            // f2_textBoxKeyN2
            // 
            this.f2_textBoxKeyN2.Location = new System.Drawing.Point(555, 260);
            this.f2_textBoxKeyN2.Name = "f2_textBoxKeyN2";
            this.f2_textBoxKeyN2.ReadOnly = true;
            this.f2_textBoxKeyN2.Size = new System.Drawing.Size(257, 22);
            this.f2_textBoxKeyN2.TabIndex = 30;
            // 
            // f2_textBoxKeyD
            // 
            this.f2_textBoxKeyD.Location = new System.Drawing.Point(555, 232);
            this.f2_textBoxKeyD.Name = "f2_textBoxKeyD";
            this.f2_textBoxKeyD.ReadOnly = true;
            this.f2_textBoxKeyD.Size = new System.Drawing.Size(257, 22);
            this.f2_textBoxKeyD.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Простые числа";
            // 
            // Form02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 444);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.f2_textBoxKeyN2);
            this.Controls.Add(this.f2_textBoxKeyD);
            this.Controls.Add(this.f2_textBoxKeyN);
            this.Controls.Add(this.f2_buttonDecrypt);
            this.Controls.Add(this.f2_buttonEncrypt);
            this.Controls.Add(this.f2_Ciphertext);
            this.Controls.Add(this.f2_label6);
            this.Controls.Add(this.f2_Original);
            this.Controls.Add(this.f2_textBoxAlf);
            this.Controls.Add(this.f2_label3);
            this.Controls.Add(this.f2_label2);
            this.Controls.Add(this.f2_textBoxKeyE);
            this.Controls.Add(this.f2_buttonGetKeys);
            this.Controls.Add(this.f2_label4);
            this.Controls.Add(this.f2_label5);
            this.Controls.Add(this.f2_buttonGenPrimes);
            this.Controls.Add(this.f2_buttonCheckPrimes);
            this.Controls.Add(this.f2_label_q);
            this.Controls.Add(this.f2_numericQ);
            this.Controls.Add(this.f2_label_p);
            this.Controls.Add(this.f2_numericP);
            this.Controls.Add(this.f2_label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "Form02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Алгоритмы шифрования с открытым ключом";
            ((System.ComponentModel.ISupportInitialize)(this.f2_numericP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f2_numericQ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label f2_label1;
        private System.Windows.Forms.NumericUpDown f2_numericP;
        private System.Windows.Forms.Label f2_label_p;
        private System.Windows.Forms.Label f2_label_q;
        private System.Windows.Forms.NumericUpDown f2_numericQ;
        private System.Windows.Forms.Button f2_buttonCheckPrimes;
        private System.Windows.Forms.Button f2_buttonGenPrimes;
        private System.Windows.Forms.Label f2_label5;
        private System.Windows.Forms.Label f2_label4;
        private System.Windows.Forms.Button f2_buttonGetKeys;
        private System.Windows.Forms.TextBox f2_textBoxKeyE;
        private System.Windows.Forms.Label f2_label2;
        private System.Windows.Forms.Label f2_label3;
        private System.Windows.Forms.TextBox f2_textBoxAlf;
        private System.Windows.Forms.TextBox f2_Original;
        private System.Windows.Forms.TextBox f2_Ciphertext;
        private System.Windows.Forms.Label f2_label6;
        private System.Windows.Forms.Button f2_buttonEncrypt;
        private System.Windows.Forms.Button f2_buttonDecrypt;
        private System.Windows.Forms.TextBox f2_textBoxKeyN;
        private System.Windows.Forms.TextBox f2_textBoxKeyN2;
        private System.Windows.Forms.TextBox f2_textBoxKeyD;
        private System.Windows.Forms.Label label1;
    }
}