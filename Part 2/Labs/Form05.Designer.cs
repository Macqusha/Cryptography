namespace Labs
{
    partial class Form05
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form05));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.f5_textBox_MessageAlice = new System.Windows.Forms.TextBox();
            this.f5_button_GetRandomSecretA = new System.Windows.Forms.Button();
            this.f5_textSecretA = new System.Windows.Forms.TextBox();
            this.f5_label3 = new System.Windows.Forms.Label();
            this.f5_textCommonSecret_inWindowA = new System.Windows.Forms.TextBox();
            this.f5_label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.f5_button_SetSecretA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.f5_textOpenA = new System.Windows.Forms.TextBox();
            this.f5_textOpenB_inWindowA = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.f5_textBox_MessageBob = new System.Windows.Forms.TextBox();
            this.f5_button_GetRandomSecretB = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.f5_textSecretB = new System.Windows.Forms.TextBox();
            this.f5_textOpenA_inWindowB = new System.Windows.Forms.TextBox();
            this.f5_textOpenB = new System.Windows.Forms.TextBox();
            this.f5_textCommonSecret_inWindowB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.f5_button_SetSecretB = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.f5_buttonNextGenerator = new System.Windows.Forms.Button();
            this.f5_buttonNextPrime = new System.Windows.Forms.Button();
            this.f5_textG = new System.Windows.Forms.TextBox();
            this.f5_textQ = new System.Windows.Forms.TextBox();
            this.f5_textP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.f5_buttonClearKeys = new System.Windows.Forms.Button();
            this.f5_label_q = new System.Windows.Forms.Label();
            this.f5_buttonSetKeys = new System.Windows.Forms.Button();
            this.f5_label1 = new System.Windows.Forms.Label();
            this.f5_buttonSendMes = new System.Windows.Forms.Button();
            this.f5_RecievedCiphertext = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.f5_textBox_MessageAlice);
            this.groupBox2.Controls.Add(this.f5_button_GetRandomSecretA);
            this.groupBox2.Controls.Add(this.f5_textSecretA);
            this.groupBox2.Controls.Add(this.f5_label3);
            this.groupBox2.Controls.Add(this.f5_textCommonSecret_inWindowA);
            this.groupBox2.Controls.Add(this.f5_label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.f5_button_SetSecretA);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.f5_textOpenA);
            this.groupBox2.Controls.Add(this.f5_textOpenB_inWindowA);
            this.groupBox2.Location = new System.Drawing.Point(12, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 279);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alice";
            // 
            // f5_textBox_MessageAlice
            // 
            this.f5_textBox_MessageAlice.Location = new System.Drawing.Point(10, 222);
            this.f5_textBox_MessageAlice.Multiline = true;
            this.f5_textBox_MessageAlice.Name = "f5_textBox_MessageAlice";
            this.f5_textBox_MessageAlice.Size = new System.Drawing.Size(359, 39);
            this.f5_textBox_MessageAlice.TabIndex = 71;
            this.f5_textBox_MessageAlice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f5_textBoxMessage_KeyPress);
            // 
            // f5_button_GetRandomSecretA
            // 
            this.f5_button_GetRandomSecretA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("f5_button_GetRandomSecretA.BackgroundImage")));
            this.f5_button_GetRandomSecretA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.f5_button_GetRandomSecretA.Enabled = false;
            this.f5_button_GetRandomSecretA.Location = new System.Drawing.Point(252, 30);
            this.f5_button_GetRandomSecretA.Margin = new System.Windows.Forms.Padding(1);
            this.f5_button_GetRandomSecretA.Name = "f5_button_GetRandomSecretA";
            this.f5_button_GetRandomSecretA.Size = new System.Drawing.Size(26, 27);
            this.f5_button_GetRandomSecretA.TabIndex = 71;
            this.f5_button_GetRandomSecretA.UseVisualStyleBackColor = true;
            this.f5_button_GetRandomSecretA.Click += new System.EventHandler(this.f5_button_GetRandomSecretA_Click);
            // 
            // f5_textSecretA
            // 
            this.f5_textSecretA.Location = new System.Drawing.Point(86, 32);
            this.f5_textSecretA.Name = "f5_textSecretA";
            this.f5_textSecretA.ReadOnly = true;
            this.f5_textSecretA.Size = new System.Drawing.Size(161, 22);
            this.f5_textSecretA.TabIndex = 71;
            this.f5_textSecretA.TextChanged += new System.EventHandler(this.f5_textSecretA_TextChanged);
            this.f5_textSecretA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f5_textParam_KeyPress);
            // 
            // f5_label3
            // 
            this.f5_label3.AutoSize = true;
            this.f5_label3.Location = new System.Drawing.Point(6, 35);
            this.f5_label3.Name = "f5_label3";
            this.f5_label3.Size = new System.Drawing.Size(75, 17);
            this.f5_label3.TabIndex = 44;
            this.f5_label3.Text = "Secret key";
            // 
            // f5_textCommonSecret_inWindowA
            // 
            this.f5_textCommonSecret_inWindowA.Location = new System.Drawing.Point(153, 122);
            this.f5_textCommonSecret_inWindowA.Name = "f5_textCommonSecret_inWindowA";
            this.f5_textCommonSecret_inWindowA.ReadOnly = true;
            this.f5_textCommonSecret_inWindowA.Size = new System.Drawing.Size(216, 22);
            this.f5_textCommonSecret_inWindowA.TabIndex = 70;
            this.f5_textCommonSecret_inWindowA.TextChanged += new System.EventHandler(this.f5_textCommonSecret_TextChanged);
            // 
            // f5_label2
            // 
            this.f5_label2.AutoSize = true;
            this.f5_label2.Location = new System.Drawing.Point(6, 68);
            this.f5_label2.Name = "f5_label2";
            this.f5_label2.Size = new System.Drawing.Size(69, 17);
            this.f5_label2.TabIndex = 43;
            this.f5_label2.Text = "Open key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 69;
            this.label3.Text = "Common secret key";
            // 
            // f5_button_SetSecretA
            // 
            this.f5_button_SetSecretA.Enabled = false;
            this.f5_button_SetSecretA.Location = new System.Drawing.Point(282, 30);
            this.f5_button_SetSecretA.Name = "f5_button_SetSecretA";
            this.f5_button_SetSecretA.Size = new System.Drawing.Size(100, 27);
            this.f5_button_SetSecretA.TabIndex = 64;
            this.f5_button_SetSecretA.Text = "Установить";
            this.f5_button_SetSecretA.UseVisualStyleBackColor = true;
            this.f5_button_SetSecretA.Click += new System.EventHandler(this.f5_button_SetSecretA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 68;
            this.label1.Text = "Bob\'s open key";
            // 
            // f5_textOpenA
            // 
            this.f5_textOpenA.Location = new System.Drawing.Point(86, 65);
            this.f5_textOpenA.Name = "f5_textOpenA";
            this.f5_textOpenA.ReadOnly = true;
            this.f5_textOpenA.Size = new System.Drawing.Size(192, 22);
            this.f5_textOpenA.TabIndex = 53;
            // 
            // f5_textOpenB_inWindowA
            // 
            this.f5_textOpenB_inWindowA.Location = new System.Drawing.Point(153, 93);
            this.f5_textOpenB_inWindowA.Name = "f5_textOpenB_inWindowA";
            this.f5_textOpenB_inWindowA.ReadOnly = true;
            this.f5_textOpenB_inWindowA.Size = new System.Drawing.Size(216, 22);
            this.f5_textOpenB_inWindowA.TabIndex = 66;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.f5_RecievedCiphertext);
            this.groupBox3.Controls.Add(this.f5_textBox_MessageBob);
            this.groupBox3.Controls.Add(this.f5_button_GetRandomSecretB);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.f5_textSecretB);
            this.groupBox3.Controls.Add(this.f5_textOpenA_inWindowB);
            this.groupBox3.Controls.Add(this.f5_textOpenB);
            this.groupBox3.Controls.Add(this.f5_textCommonSecret_inWindowB);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.f5_button_SetSecretB);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(447, 144);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 279);
            this.groupBox3.TabIndex = 73;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bob";
            // 
            // f5_textBox_MessageBob
            // 
            this.f5_textBox_MessageBob.Location = new System.Drawing.Point(10, 222);
            this.f5_textBox_MessageBob.Multiline = true;
            this.f5_textBox_MessageBob.Name = "f5_textBox_MessageBob";
            this.f5_textBox_MessageBob.ReadOnly = true;
            this.f5_textBox_MessageBob.Size = new System.Drawing.Size(359, 39);
            this.f5_textBox_MessageBob.TabIndex = 72;
            // 
            // f5_button_GetRandomSecretB
            // 
            this.f5_button_GetRandomSecretB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("f5_button_GetRandomSecretB.BackgroundImage")));
            this.f5_button_GetRandomSecretB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.f5_button_GetRandomSecretB.Enabled = false;
            this.f5_button_GetRandomSecretB.Location = new System.Drawing.Point(252, 30);
            this.f5_button_GetRandomSecretB.Margin = new System.Windows.Forms.Padding(1);
            this.f5_button_GetRandomSecretB.Name = "f5_button_GetRandomSecretB";
            this.f5_button_GetRandomSecretB.Size = new System.Drawing.Size(26, 27);
            this.f5_button_GetRandomSecretB.TabIndex = 72;
            this.f5_button_GetRandomSecretB.UseVisualStyleBackColor = true;
            this.f5_button_GetRandomSecretB.Click += new System.EventHandler(this.f5_button_GetRandomSecretB_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 73;
            this.label7.Text = "Secret key";
            // 
            // f5_textSecretB
            // 
            this.f5_textSecretB.Location = new System.Drawing.Point(86, 32);
            this.f5_textSecretB.Name = "f5_textSecretB";
            this.f5_textSecretB.ReadOnly = true;
            this.f5_textSecretB.Size = new System.Drawing.Size(161, 22);
            this.f5_textSecretB.TabIndex = 80;
            this.f5_textSecretB.TextChanged += new System.EventHandler(this.f5_textSecretB_TextChanged);
            this.f5_textSecretB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f5_textParam_KeyPress);
            // 
            // f5_textOpenA_inWindowB
            // 
            this.f5_textOpenA_inWindowB.Location = new System.Drawing.Point(153, 96);
            this.f5_textOpenA_inWindowB.Name = "f5_textOpenA_inWindowB";
            this.f5_textOpenA_inWindowB.ReadOnly = true;
            this.f5_textOpenA_inWindowB.Size = new System.Drawing.Size(216, 22);
            this.f5_textOpenA_inWindowB.TabIndex = 76;
            // 
            // f5_textOpenB
            // 
            this.f5_textOpenB.Location = new System.Drawing.Point(86, 65);
            this.f5_textOpenB.Name = "f5_textOpenB";
            this.f5_textOpenB.ReadOnly = true;
            this.f5_textOpenB.Size = new System.Drawing.Size(192, 22);
            this.f5_textOpenB.TabIndex = 74;
            // 
            // f5_textCommonSecret_inWindowB
            // 
            this.f5_textCommonSecret_inWindowB.Location = new System.Drawing.Point(153, 125);
            this.f5_textCommonSecret_inWindowB.Name = "f5_textCommonSecret_inWindowB";
            this.f5_textCommonSecret_inWindowB.ReadOnly = true;
            this.f5_textCommonSecret_inWindowB.Size = new System.Drawing.Size(216, 22);
            this.f5_textCommonSecret_inWindowB.TabIndex = 79;
            this.f5_textCommonSecret_inWindowB.TextChanged += new System.EventHandler(this.f5_textCommonSecret_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 77;
            this.label6.Text = "Alice\'s open key";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 72;
            this.label8.Text = "Open key";
            // 
            // f5_button_SetSecretB
            // 
            this.f5_button_SetSecretB.Enabled = false;
            this.f5_button_SetSecretB.Location = new System.Drawing.Point(282, 30);
            this.f5_button_SetSecretB.Name = "f5_button_SetSecretB";
            this.f5_button_SetSecretB.Size = new System.Drawing.Size(100, 27);
            this.f5_button_SetSecretB.TabIndex = 75;
            this.f5_button_SetSecretB.Text = "Установить";
            this.f5_button_SetSecretB.UseVisualStyleBackColor = true;
            this.f5_button_SetSecretB.Click += new System.EventHandler(this.f5_button_SetSecretB_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 17);
            this.label5.TabIndex = 78;
            this.label5.Text = "Common secret key";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.f5_buttonNextGenerator);
            this.groupBox1.Controls.Add(this.f5_buttonNextPrime);
            this.groupBox1.Controls.Add(this.f5_textG);
            this.groupBox1.Controls.Add(this.f5_textQ);
            this.groupBox1.Controls.Add(this.f5_textP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.f5_buttonClearKeys);
            this.groupBox1.Controls.Add(this.f5_label_q);
            this.groupBox1.Controls.Add(this.f5_buttonSetKeys);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 109);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройка параметров системы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 70;
            this.label2.Text = "p = 2q + 1";
            // 
            // f5_buttonNextGenerator
            // 
            this.f5_buttonNextGenerator.Location = new System.Drawing.Point(548, 78);
            this.f5_buttonNextGenerator.Name = "f5_buttonNextGenerator";
            this.f5_buttonNextGenerator.Size = new System.Drawing.Size(25, 23);
            this.f5_buttonNextGenerator.TabIndex = 69;
            this.f5_buttonNextGenerator.Text = ">";
            this.f5_buttonNextGenerator.UseVisualStyleBackColor = true;
            this.f5_buttonNextGenerator.Click += new System.EventHandler(this.f5_buttonNextGenerator_Click);
            // 
            // f5_buttonNextPrime
            // 
            this.f5_buttonNextPrime.Location = new System.Drawing.Point(548, 50);
            this.f5_buttonNextPrime.Name = "f5_buttonNextPrime";
            this.f5_buttonNextPrime.Size = new System.Drawing.Size(25, 23);
            this.f5_buttonNextPrime.TabIndex = 68;
            this.f5_buttonNextPrime.Text = ">";
            this.f5_buttonNextPrime.UseVisualStyleBackColor = true;
            this.f5_buttonNextPrime.Click += new System.EventHandler(this.f5_buttonNextPrime_Click);
            // 
            // f5_textG
            // 
            this.f5_textG.Location = new System.Drawing.Point(85, 78);
            this.f5_textG.Name = "f5_textG";
            this.f5_textG.Size = new System.Drawing.Size(457, 22);
            this.f5_textG.TabIndex = 66;
            this.f5_textG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f5_textParam_KeyPress);
            // 
            // f5_textQ
            // 
            this.f5_textQ.Location = new System.Drawing.Point(85, 50);
            this.f5_textQ.Name = "f5_textQ";
            this.f5_textQ.Size = new System.Drawing.Size(457, 22);
            this.f5_textQ.TabIndex = 65;
            this.f5_textQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f5_textParam_KeyPress);
            this.f5_textQ.Validated += new System.EventHandler(this.f5_textQ_Validated);
            // 
            // f5_textP
            // 
            this.f5_textP.Location = new System.Drawing.Point(85, 22);
            this.f5_textP.Name = "f5_textP";
            this.f5_textP.ReadOnly = true;
            this.f5_textP.Size = new System.Drawing.Size(457, 22);
            this.f5_textP.TabIndex = 64;
            this.f5_textP.TextChanged += new System.EventHandler(this.f5_textP_TextChanged);
            this.f5_textP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f5_textParam_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 63;
            this.label4.Text = "g";
            // 
            // f5_buttonClearKeys
            // 
            this.f5_buttonClearKeys.Enabled = false;
            this.f5_buttonClearKeys.Location = new System.Drawing.Point(596, 58);
            this.f5_buttonClearKeys.Name = "f5_buttonClearKeys";
            this.f5_buttonClearKeys.Size = new System.Drawing.Size(195, 41);
            this.f5_buttonClearKeys.TabIndex = 59;
            this.f5_buttonClearKeys.Text = "Сбросить параметры";
            this.f5_buttonClearKeys.UseVisualStyleBackColor = true;
            this.f5_buttonClearKeys.Click += new System.EventHandler(this.f5_buttonClearKeys_Click);
            // 
            // f5_label_q
            // 
            this.f5_label_q.AutoSize = true;
            this.f5_label_q.Location = new System.Drawing.Point(58, 53);
            this.f5_label_q.Name = "f5_label_q";
            this.f5_label_q.Size = new System.Drawing.Size(16, 17);
            this.f5_label_q.TabIndex = 36;
            this.f5_label_q.Text = "q";
            // 
            // f5_buttonSetKeys
            // 
            this.f5_buttonSetKeys.Location = new System.Drawing.Point(596, 13);
            this.f5_buttonSetKeys.Name = "f5_buttonSetKeys";
            this.f5_buttonSetKeys.Size = new System.Drawing.Size(195, 41);
            this.f5_buttonSetKeys.TabIndex = 41;
            this.f5_buttonSetKeys.Text = "Установить параметры";
            this.f5_buttonSetKeys.UseVisualStyleBackColor = true;
            this.f5_buttonSetKeys.Click += new System.EventHandler(this.f5_buttonSetKeys_Click);
            // 
            // f5_label1
            // 
            this.f5_label1.AutoSize = true;
            this.f5_label1.Location = new System.Drawing.Point(358, 9);
            this.f5_label1.Name = "f5_label1";
            this.f5_label1.Size = new System.Drawing.Size(128, 17);
            this.f5_label1.TabIndex = 70;
            this.f5_label1.Text = "Шифр Эль-Гамаля";
            // 
            // f5_buttonSendMes
            // 
            this.f5_buttonSendMes.Enabled = false;
            this.f5_buttonSendMes.Location = new System.Drawing.Point(414, 375);
            this.f5_buttonSendMes.Name = "f5_buttonSendMes";
            this.f5_buttonSendMes.Size = new System.Drawing.Size(25, 23);
            this.f5_buttonSendMes.TabIndex = 71;
            this.f5_buttonSendMes.Text = ">";
            this.f5_buttonSendMes.UseVisualStyleBackColor = true;
            this.f5_buttonSendMes.Click += new System.EventHandler(this.f5_buttonSendMes_Click);
            // 
            // f5_RecievedCiphertext
            // 
            this.f5_RecievedCiphertext.Location = new System.Drawing.Point(178, 173);
            this.f5_RecievedCiphertext.Multiline = true;
            this.f5_RecievedCiphertext.Name = "f5_RecievedCiphertext";
            this.f5_RecievedCiphertext.ReadOnly = true;
            this.f5_RecievedCiphertext.Size = new System.Drawing.Size(191, 22);
            this.f5_RecievedCiphertext.TabIndex = 72;
            this.f5_RecievedCiphertext.TextChanged += new System.EventHandler(this.f5_RecievedCiphertext_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 17);
            this.label9.TabIndex = 81;
            this.label9.Text = "Last Recieved Ciphertext";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 17);
            this.label10.TabIndex = 82;
            this.label10.Text = "Message to send";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 17);
            this.label11.TabIndex = 83;
            this.label11.Text = "Recieved message";
            // 
            // Form05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 444);
            this.Controls.Add(this.f5_buttonSendMes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.f5_label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "Form05";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Шифр Эль-Гамаля";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button f5_button_GetRandomSecretA;
        private System.Windows.Forms.TextBox f5_textSecretA;
        private System.Windows.Forms.Label f5_label3;
        private System.Windows.Forms.TextBox f5_textCommonSecret_inWindowA;
        private System.Windows.Forms.Label f5_label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button f5_button_SetSecretA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox f5_textOpenA;
        private System.Windows.Forms.TextBox f5_textOpenB_inWindowA;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button f5_button_GetRandomSecretB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox f5_textSecretB;
        private System.Windows.Forms.TextBox f5_textOpenA_inWindowB;
        private System.Windows.Forms.TextBox f5_textOpenB;
        private System.Windows.Forms.TextBox f5_textCommonSecret_inWindowB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button f5_button_SetSecretB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button f5_buttonNextGenerator;
        private System.Windows.Forms.Button f5_buttonNextPrime;
        private System.Windows.Forms.TextBox f5_textG;
        private System.Windows.Forms.TextBox f5_textQ;
        private System.Windows.Forms.TextBox f5_textP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button f5_buttonClearKeys;
        private System.Windows.Forms.Label f5_label_q;
        private System.Windows.Forms.Button f5_buttonSetKeys;
        private System.Windows.Forms.Label f5_label1;
        private System.Windows.Forms.TextBox f5_textBox_MessageAlice;
        private System.Windows.Forms.TextBox f5_textBox_MessageBob;
        private System.Windows.Forms.Button f5_buttonSendMes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox f5_RecievedCiphertext;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}