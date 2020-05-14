namespace Labs
{
    partial class Form09
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form09));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.f9_buttonClearParams = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.f9_buttonSetParams = new System.Windows.Forms.Button();
            this.f9_button_ClearSecretKey = new System.Windows.Forms.Button();
            this.f9_chooseHashFun = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.f9_buttonSign = new System.Windows.Forms.Button();
            this.f9_buttonNextPrimeQ = new System.Windows.Forms.Button();
            this.f9_textBoxSign = new System.Windows.Forms.TextBox();
            this.f9_buttonNextPrimeP = new System.Windows.Forms.Button();
            this.f9_button_GetRandomSecret = new System.Windows.Forms.Button();
            this.f9_textN = new System.Windows.Forms.TextBox();
            this.f9_textSecretKey = new System.Windows.Forms.TextBox();
            this.f9_textQ = new System.Windows.Forms.TextBox();
            this.f5_label3 = new System.Windows.Forms.Label();
            this.f9_textP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.f5_label2 = new System.Windows.Forms.Label();
            this.f9_button_SetSecretKey = new System.Windows.Forms.Button();
            this.f5_label_q = new System.Windows.Forms.Label();
            this.f9_textOpenKey = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.f9_buttonSendSign = new System.Windows.Forms.Button();
            this.f9_chooseHashFunRecieved = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.f9_textVerificationResult = new System.Windows.Forms.TextBox();
            this.f9_textNRecieved = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.f9_textOpenKeyRecieved = new System.Windows.Forms.TextBox();
            this.f9_buttonCheckSign = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.f9_textBoxSignRecieved = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.f9_buttonClearParams);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.f9_buttonSetParams);
            this.groupBox2.Controls.Add(this.f9_button_ClearSecretKey);
            this.groupBox2.Controls.Add(this.f9_chooseHashFun);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.f9_buttonSign);
            this.groupBox2.Controls.Add(this.f9_buttonNextPrimeQ);
            this.groupBox2.Controls.Add(this.f9_textBoxSign);
            this.groupBox2.Controls.Add(this.f9_buttonNextPrimeP);
            this.groupBox2.Controls.Add(this.f9_button_GetRandomSecret);
            this.groupBox2.Controls.Add(this.f9_textN);
            this.groupBox2.Controls.Add(this.f9_textSecretKey);
            this.groupBox2.Controls.Add(this.f9_textQ);
            this.groupBox2.Controls.Add(this.f5_label3);
            this.groupBox2.Controls.Add(this.f9_textP);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.f5_label2);
            this.groupBox2.Controls.Add(this.f9_button_SetSecretKey);
            this.groupBox2.Controls.Add(this.f5_label_q);
            this.groupBox2.Controls.Add(this.f9_textOpenKey);
            this.groupBox2.Location = new System.Drawing.Point(17, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 420);
            this.groupBox2.TabIndex = 76;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Подписывающий";
            // 
            // f9_buttonClearParams
            // 
            this.f9_buttonClearParams.Enabled = false;
            this.f9_buttonClearParams.Location = new System.Drawing.Point(213, 111);
            this.f9_buttonClearParams.Name = "f9_buttonClearParams";
            this.f9_buttonClearParams.Size = new System.Drawing.Size(121, 30);
            this.f9_buttonClearParams.TabIndex = 7;
            this.f9_buttonClearParams.Text = "Сбросить ";
            this.f9_buttonClearParams.UseVisualStyleBackColor = true;
            this.f9_buttonClearParams.Click += new System.EventHandler(this.f9_buttonClearParams_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 86;
            this.label8.Text = "Hash alg";
            // 
            // f9_buttonSetParams
            // 
            this.f9_buttonSetParams.Location = new System.Drawing.Point(74, 111);
            this.f9_buttonSetParams.Name = "f9_buttonSetParams";
            this.f9_buttonSetParams.Size = new System.Drawing.Size(133, 30);
            this.f9_buttonSetParams.TabIndex = 6;
            this.f9_buttonSetParams.Text = "Установить ";
            this.f9_buttonSetParams.UseVisualStyleBackColor = true;
            this.f9_buttonSetParams.Click += new System.EventHandler(this.f9_buttonSetParams_Click);
            // 
            // f9_button_ClearSecretKey
            // 
            this.f9_button_ClearSecretKey.Enabled = false;
            this.f9_button_ClearSecretKey.Location = new System.Drawing.Point(283, 233);
            this.f9_button_ClearSecretKey.Name = "f9_button_ClearSecretKey";
            this.f9_button_ClearSecretKey.Size = new System.Drawing.Size(100, 27);
            this.f9_button_ClearSecretKey.TabIndex = 13;
            this.f9_button_ClearSecretKey.Text = "Сбросить";
            this.f9_button_ClearSecretKey.UseVisualStyleBackColor = true;
            this.f9_button_ClearSecretKey.Click += new System.EventHandler(this.f9_button_ClearSecretKey_Click);
            // 
            // f9_chooseHashFun
            // 
            this.f9_chooseHashFun.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.f9_chooseHashFun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.f9_chooseHashFun.FormattingEnabled = true;
            this.f9_chooseHashFun.Items.AddRange(new object[] {
            "MD5",
            "SHA-1",
            "ГОСТ Р 34.11-2012 256 бит",
            "ГОСТ Р 34.11-2012 512 бит"});
            this.f9_chooseHashFun.Location = new System.Drawing.Point(75, 79);
            this.f9_chooseHashFun.Name = "f9_chooseHashFun";
            this.f9_chooseHashFun.Size = new System.Drawing.Size(277, 24);
            this.f9_chooseHashFun.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 85;
            this.label3.Text = "Resulting Sign";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 70;
            this.label2.Text = "Secret p";
            // 
            // f9_buttonSign
            // 
            this.f9_buttonSign.Enabled = false;
            this.f9_buttonSign.Location = new System.Drawing.Point(139, 282);
            this.f9_buttonSign.Name = "f9_buttonSign";
            this.f9_buttonSign.Size = new System.Drawing.Size(140, 45);
            this.f9_buttonSign.TabIndex = 14;
            this.f9_buttonSign.Text = "Подписать файл";
            this.f9_buttonSign.UseVisualStyleBackColor = true;
            this.f9_buttonSign.Click += new System.EventHandler(this.f9_buttonSign_Click);
            // 
            // f9_buttonNextPrimeQ
            // 
            this.f9_buttonNextPrimeQ.Location = new System.Drawing.Point(358, 46);
            this.f9_buttonNextPrimeQ.Name = "f9_buttonNextPrimeQ";
            this.f9_buttonNextPrimeQ.Size = new System.Drawing.Size(25, 23);
            this.f9_buttonNextPrimeQ.TabIndex = 4;
            this.f9_buttonNextPrimeQ.Text = ">";
            this.f9_buttonNextPrimeQ.UseVisualStyleBackColor = true;
            this.f9_buttonNextPrimeQ.Click += new System.EventHandler(this.f9_buttonNextPrimeQ_Click);
            // 
            // f9_textBoxSign
            // 
            this.f9_textBoxSign.Location = new System.Drawing.Point(14, 370);
            this.f9_textBoxSign.Multiline = true;
            this.f9_textBoxSign.Name = "f9_textBoxSign";
            this.f9_textBoxSign.ReadOnly = true;
            this.f9_textBoxSign.Size = new System.Drawing.Size(372, 39);
            this.f9_textBoxSign.TabIndex = 15;
            // 
            // f9_buttonNextPrimeP
            // 
            this.f9_buttonNextPrimeP.Location = new System.Drawing.Point(358, 17);
            this.f9_buttonNextPrimeP.Name = "f9_buttonNextPrimeP";
            this.f9_buttonNextPrimeP.Size = new System.Drawing.Size(25, 23);
            this.f9_buttonNextPrimeP.TabIndex = 2;
            this.f9_buttonNextPrimeP.Text = ">";
            this.f9_buttonNextPrimeP.UseVisualStyleBackColor = true;
            this.f9_buttonNextPrimeP.Click += new System.EventHandler(this.f9_buttonNextPrimeP_Click);
            // 
            // f9_button_GetRandomSecret
            // 
            this.f9_button_GetRandomSecret.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("f9_button_GetRandomSecret.BackgroundImage")));
            this.f9_button_GetRandomSecret.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.f9_button_GetRandomSecret.Location = new System.Drawing.Point(253, 200);
            this.f9_button_GetRandomSecret.Margin = new System.Windows.Forms.Padding(1);
            this.f9_button_GetRandomSecret.Name = "f9_button_GetRandomSecret";
            this.f9_button_GetRandomSecret.Size = new System.Drawing.Size(26, 27);
            this.f9_button_GetRandomSecret.TabIndex = 10;
            this.f9_button_GetRandomSecret.UseVisualStyleBackColor = true;
            this.f9_button_GetRandomSecret.Click += new System.EventHandler(this.f9_button_GetRandomSecret_Click);
            // 
            // f9_textN
            // 
            this.f9_textN.Location = new System.Drawing.Point(75, 174);
            this.f9_textN.Name = "f9_textN";
            this.f9_textN.ReadOnly = true;
            this.f9_textN.Size = new System.Drawing.Size(308, 22);
            this.f9_textN.TabIndex = 8;
            // 
            // f9_textSecretKey
            // 
            this.f9_textSecretKey.Location = new System.Drawing.Point(75, 204);
            this.f9_textSecretKey.Name = "f9_textSecretKey";
            this.f9_textSecretKey.Size = new System.Drawing.Size(173, 22);
            this.f9_textSecretKey.TabIndex = 9;
            this.f9_textSecretKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f9_textParam_KeyPress);
            // 
            // f9_textQ
            // 
            this.f9_textQ.Location = new System.Drawing.Point(75, 46);
            this.f9_textQ.Name = "f9_textQ";
            this.f9_textQ.Size = new System.Drawing.Size(277, 22);
            this.f9_textQ.TabIndex = 3;
            this.f9_textQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f9_textParam_KeyPress);
            // 
            // f5_label3
            // 
            this.f5_label3.AutoSize = true;
            this.f5_label3.Location = new System.Drawing.Point(3, 205);
            this.f5_label3.Name = "f5_label3";
            this.f5_label3.Size = new System.Drawing.Size(75, 17);
            this.f5_label3.TabIndex = 44;
            this.f5_label3.Text = "Secret key";
            // 
            // f9_textP
            // 
            this.f9_textP.Location = new System.Drawing.Point(75, 18);
            this.f9_textP.Name = "f9_textP";
            this.f9_textP.Size = new System.Drawing.Size(277, 22);
            this.f9_textP.TabIndex = 1;
            this.f9_textP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f9_textParam_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 17);
            this.label4.TabIndex = 63;
            this.label4.Text = "N";
            // 
            // f5_label2
            // 
            this.f5_label2.AutoSize = true;
            this.f5_label2.Location = new System.Drawing.Point(3, 238);
            this.f5_label2.Name = "f5_label2";
            this.f5_label2.Size = new System.Drawing.Size(69, 17);
            this.f5_label2.TabIndex = 43;
            this.f5_label2.Text = "Open key";
            // 
            // f9_button_SetSecretKey
            // 
            this.f9_button_SetSecretKey.Location = new System.Drawing.Point(283, 200);
            this.f9_button_SetSecretKey.Name = "f9_button_SetSecretKey";
            this.f9_button_SetSecretKey.Size = new System.Drawing.Size(100, 27);
            this.f9_button_SetSecretKey.TabIndex = 11;
            this.f9_button_SetSecretKey.Text = "Установить";
            this.f9_button_SetSecretKey.UseVisualStyleBackColor = true;
            this.f9_button_SetSecretKey.Click += new System.EventHandler(this.f9_button_SetSecretKey_Click);
            // 
            // f5_label_q
            // 
            this.f5_label_q.AutoSize = true;
            this.f5_label_q.Location = new System.Drawing.Point(11, 49);
            this.f5_label_q.Name = "f5_label_q";
            this.f5_label_q.Size = new System.Drawing.Size(61, 17);
            this.f5_label_q.TabIndex = 36;
            this.f5_label_q.Text = "Secret q";
            // 
            // f9_textOpenKey
            // 
            this.f9_textOpenKey.Location = new System.Drawing.Point(75, 237);
            this.f9_textOpenKey.Name = "f9_textOpenKey";
            this.f9_textOpenKey.ReadOnly = true;
            this.f9_textOpenKey.Size = new System.Drawing.Size(204, 22);
            this.f9_textOpenKey.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.f9_buttonSendSign);
            this.groupBox3.Controls.Add(this.f9_chooseHashFunRecieved);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.f9_textVerificationResult);
            this.groupBox3.Controls.Add(this.f9_textNRecieved);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.f9_textOpenKeyRecieved);
            this.groupBox3.Controls.Add(this.f9_buttonCheckSign);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.f9_textBoxSignRecieved);
            this.groupBox3.Location = new System.Drawing.Point(440, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 420);
            this.groupBox3.TabIndex = 77;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Проверяющий";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 88;
            this.label9.Text = "Hash alg";
            // 
            // f9_buttonSendSign
            // 
            this.f9_buttonSendSign.Location = new System.Drawing.Point(87, 22);
            this.f9_buttonSendSign.Name = "f9_buttonSendSign";
            this.f9_buttonSendSign.Size = new System.Drawing.Size(279, 28);
            this.f9_buttonSendSign.TabIndex = 16;
            this.f9_buttonSendSign.Text = "Получить от подписывающего";
            this.f9_buttonSendSign.UseVisualStyleBackColor = true;
            this.f9_buttonSendSign.Click += new System.EventHandler(this.f9_buttonSendSign_Click);
            // 
            // f9_chooseHashFunRecieved
            // 
            this.f9_chooseHashFunRecieved.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.f9_chooseHashFunRecieved.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.f9_chooseHashFunRecieved.FormattingEnabled = true;
            this.f9_chooseHashFunRecieved.Items.AddRange(new object[] {
            "MD5",
            "SHA-1",
            "ГОСТ Р 34.11-2012 256 бит",
            "ГОСТ Р 34.11-2012 512 бит"});
            this.f9_chooseHashFunRecieved.Location = new System.Drawing.Point(87, 57);
            this.f9_chooseHashFunRecieved.Name = "f9_chooseHashFunRecieved";
            this.f9_chooseHashFunRecieved.Size = new System.Drawing.Size(279, 24);
            this.f9_chooseHashFunRecieved.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 87;
            this.label7.Text = "Verification result";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 17);
            this.label6.TabIndex = 86;
            this.label6.Text = "N";
            // 
            // f9_textVerificationResult
            // 
            this.f9_textVerificationResult.Location = new System.Drawing.Point(168, 338);
            this.f9_textVerificationResult.Multiline = true;
            this.f9_textVerificationResult.Name = "f9_textVerificationResult";
            this.f9_textVerificationResult.ReadOnly = true;
            this.f9_textVerificationResult.Size = new System.Drawing.Size(198, 22);
            this.f9_textVerificationResult.TabIndex = 22;
            // 
            // f9_textNRecieved
            // 
            this.f9_textNRecieved.Location = new System.Drawing.Point(87, 140);
            this.f9_textNRecieved.Multiline = true;
            this.f9_textNRecieved.Name = "f9_textNRecieved";
            this.f9_textNRecieved.Size = new System.Drawing.Size(279, 44);
            this.f9_textNRecieved.TabIndex = 19;
            this.f9_textNRecieved.TextChanged += new System.EventHandler(this.f9_textANY_Recieved_Param_TextChanged);
            this.f9_textNRecieved.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f9_textParam_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 86;
            this.label5.Text = "Open key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 86;
            // 
            // f9_textOpenKeyRecieved
            // 
            this.f9_textOpenKeyRecieved.Location = new System.Drawing.Point(87, 87);
            this.f9_textOpenKeyRecieved.Multiline = true;
            this.f9_textOpenKeyRecieved.Name = "f9_textOpenKeyRecieved";
            this.f9_textOpenKeyRecieved.Size = new System.Drawing.Size(279, 44);
            this.f9_textOpenKeyRecieved.TabIndex = 18;
            this.f9_textOpenKeyRecieved.TextChanged += new System.EventHandler(this.f9_textANY_Recieved_Param_TextChanged);
            this.f9_textOpenKeyRecieved.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f9_textParam_KeyPress);
            // 
            // f9_buttonCheckSign
            // 
            this.f9_buttonCheckSign.Location = new System.Drawing.Point(133, 268);
            this.f9_buttonCheckSign.Name = "f9_buttonCheckSign";
            this.f9_buttonCheckSign.Size = new System.Drawing.Size(140, 45);
            this.f9_buttonCheckSign.TabIndex = 21;
            this.f9_buttonCheckSign.Text = "Проверить файл";
            this.f9_buttonCheckSign.UseVisualStyleBackColor = true;
            this.f9_buttonCheckSign.Click += new System.EventHandler(this.f9_buttonCheckSign_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 17);
            this.label11.TabIndex = 83;
            this.label11.Text = "Sign";
            // 
            // f9_textBoxSignRecieved
            // 
            this.f9_textBoxSignRecieved.Location = new System.Drawing.Point(87, 194);
            this.f9_textBoxSignRecieved.Multiline = true;
            this.f9_textBoxSignRecieved.Name = "f9_textBoxSignRecieved";
            this.f9_textBoxSignRecieved.Size = new System.Drawing.Size(279, 44);
            this.f9_textBoxSignRecieved.TabIndex = 20;
            this.f9_textBoxSignRecieved.TextChanged += new System.EventHandler(this.f9_textANY_Recieved_Param_TextChanged);
            // 
            // Form09
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 444);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "Form09";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ЭП RSA";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button f9_button_GetRandomSecret;
        private System.Windows.Forms.TextBox f9_textSecretKey;
        private System.Windows.Forms.Label f5_label3;
        private System.Windows.Forms.Label f5_label2;
        private System.Windows.Forms.Button f9_button_SetSecretKey;
        private System.Windows.Forms.TextBox f9_textOpenKey;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox f9_textBoxSignRecieved;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button f9_buttonNextPrimeQ;
        private System.Windows.Forms.Button f9_buttonNextPrimeP;
        private System.Windows.Forms.TextBox f9_textN;
        private System.Windows.Forms.TextBox f9_textQ;
        private System.Windows.Forms.TextBox f9_textP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button f9_buttonClearParams;
        private System.Windows.Forms.Label f5_label_q;
        private System.Windows.Forms.Button f9_buttonSetParams;
        private System.Windows.Forms.Button f9_buttonSign;
        private System.Windows.Forms.ComboBox f9_chooseHashFun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox f9_textBoxSign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button f9_buttonCheckSign;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox f9_textVerificationResult;
        private System.Windows.Forms.TextBox f9_textNRecieved;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox f9_textOpenKeyRecieved;
        private System.Windows.Forms.Button f9_buttonSendSign;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button f9_button_ClearSecretKey;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox f9_chooseHashFunRecieved;
    }
}