namespace Labs
{
    partial class Form03
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form03));
            this.f3_textOpenA = new System.Windows.Forms.TextBox();
            this.f3_label3 = new System.Windows.Forms.Label();
            this.f3_label2 = new System.Windows.Forms.Label();
            this.f3_buttonSetKeys = new System.Windows.Forms.Button();
            this.f3_label_q = new System.Windows.Forms.Label();
            this.f3_label1 = new System.Windows.Forms.Label();
            this.f3_buttonClearKeys = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.f3_buttonNextGenerator = new System.Windows.Forms.Button();
            this.f3_buttonNextPrime = new System.Windows.Forms.Button();
            this.f3_textG = new System.Windows.Forms.TextBox();
            this.f3_textQ = new System.Windows.Forms.TextBox();
            this.f3_textP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.f3_textSecretA = new System.Windows.Forms.TextBox();
            this.f3_textCommonSecret_inWindowA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.f3_textOpenB_inWindowA = new System.Windows.Forms.TextBox();
            this.f3_button_SetSecretA = new System.Windows.Forms.Button();
            this.f3_textSecretB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.f3_textCommonSecret_inWindowB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.f3_button_SetSecretB = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.f3_textOpenB = new System.Windows.Forms.TextBox();
            this.f3_textOpenA_inWindowB = new System.Windows.Forms.TextBox();
            this.f3_button_GetRandomSecretA = new System.Windows.Forms.Button();
            this.f3_button_GetRandomSecretB = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // f3_textOpenA
            // 
            this.f3_textOpenA.Location = new System.Drawing.Point(86, 65);
            this.f3_textOpenA.Name = "f3_textOpenA";
            this.f3_textOpenA.ReadOnly = true;
            this.f3_textOpenA.Size = new System.Drawing.Size(192, 22);
            this.f3_textOpenA.TabIndex = 53;
            // 
            // f3_label3
            // 
            this.f3_label3.AutoSize = true;
            this.f3_label3.Location = new System.Drawing.Point(6, 35);
            this.f3_label3.Name = "f3_label3";
            this.f3_label3.Size = new System.Drawing.Size(75, 17);
            this.f3_label3.TabIndex = 44;
            this.f3_label3.Text = "Secret key";
            // 
            // f3_label2
            // 
            this.f3_label2.AutoSize = true;
            this.f3_label2.Location = new System.Drawing.Point(6, 68);
            this.f3_label2.Name = "f3_label2";
            this.f3_label2.Size = new System.Drawing.Size(69, 17);
            this.f3_label2.TabIndex = 43;
            this.f3_label2.Text = "Open key";
            // 
            // f3_buttonSetKeys
            // 
            this.f3_buttonSetKeys.Location = new System.Drawing.Point(596, 13);
            this.f3_buttonSetKeys.Name = "f3_buttonSetKeys";
            this.f3_buttonSetKeys.Size = new System.Drawing.Size(195, 50);
            this.f3_buttonSetKeys.TabIndex = 41;
            this.f3_buttonSetKeys.Text = "Установить параметры";
            this.f3_buttonSetKeys.UseVisualStyleBackColor = true;
            this.f3_buttonSetKeys.Click += new System.EventHandler(this.f3_buttonSetKeys_Click);
            // 
            // f3_label_q
            // 
            this.f3_label_q.AutoSize = true;
            this.f3_label_q.Location = new System.Drawing.Point(58, 58);
            this.f3_label_q.Name = "f3_label_q";
            this.f3_label_q.Size = new System.Drawing.Size(16, 17);
            this.f3_label_q.TabIndex = 36;
            this.f3_label_q.Text = "q";
            // 
            // f3_label1
            // 
            this.f3_label1.AutoSize = true;
            this.f3_label1.Location = new System.Drawing.Point(264, 18);
            this.f3_label1.Name = "f3_label1";
            this.f3_label1.Size = new System.Drawing.Size(300, 17);
            this.f3_label1.TabIndex = 32;
            this.f3_label1.Text = "Метод ключевого обмена Диффи-Хеллмана";
            // 
            // f3_buttonClearKeys
            // 
            this.f3_buttonClearKeys.Enabled = false;
            this.f3_buttonClearKeys.Location = new System.Drawing.Point(596, 67);
            this.f3_buttonClearKeys.Name = "f3_buttonClearKeys";
            this.f3_buttonClearKeys.Size = new System.Drawing.Size(195, 50);
            this.f3_buttonClearKeys.TabIndex = 59;
            this.f3_buttonClearKeys.Text = "Сбросить параметры";
            this.f3_buttonClearKeys.UseVisualStyleBackColor = true;
            this.f3_buttonClearKeys.Click += new System.EventHandler(this.f3_buttonClearKeys_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.f3_buttonNextGenerator);
            this.groupBox1.Controls.Add(this.f3_buttonNextPrime);
            this.groupBox1.Controls.Add(this.f3_textG);
            this.groupBox1.Controls.Add(this.f3_textQ);
            this.groupBox1.Controls.Add(this.f3_textP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.f3_buttonClearKeys);
            this.groupBox1.Controls.Add(this.f3_label_q);
            this.groupBox1.Controls.Add(this.f3_buttonSetKeys);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 123);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройка параметров системы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 70;
            this.label2.Text = "p = 2q + 1";
            // 
            // f3_buttonNextGenerator
            // 
            this.f3_buttonNextGenerator.Location = new System.Drawing.Point(548, 85);
            this.f3_buttonNextGenerator.Name = "f3_buttonNextGenerator";
            this.f3_buttonNextGenerator.Size = new System.Drawing.Size(25, 23);
            this.f3_buttonNextGenerator.TabIndex = 69;
            this.f3_buttonNextGenerator.Text = ">";
            this.f3_buttonNextGenerator.UseVisualStyleBackColor = true;
            this.f3_buttonNextGenerator.Click += new System.EventHandler(this.f3_buttonNextGenerator_Click);
            // 
            // f3_buttonNextPrime
            // 
            this.f3_buttonNextPrime.Location = new System.Drawing.Point(548, 55);
            this.f3_buttonNextPrime.Name = "f3_buttonNextPrime";
            this.f3_buttonNextPrime.Size = new System.Drawing.Size(25, 23);
            this.f3_buttonNextPrime.TabIndex = 68;
            this.f3_buttonNextPrime.Text = ">";
            this.f3_buttonNextPrime.UseVisualStyleBackColor = true;
            this.f3_buttonNextPrime.Click += new System.EventHandler(this.f3_buttonNextPrime_Click);
            // 
            // f3_textG
            // 
            this.f3_textG.Location = new System.Drawing.Point(85, 85);
            this.f3_textG.Name = "f3_textG";
            this.f3_textG.Size = new System.Drawing.Size(457, 22);
            this.f3_textG.TabIndex = 66;
            this.f3_textG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f3_textParam_KeyPress);
            // 
            // f3_textQ
            // 
            this.f3_textQ.Location = new System.Drawing.Point(85, 55);
            this.f3_textQ.Name = "f3_textQ";
            this.f3_textQ.Size = new System.Drawing.Size(457, 22);
            this.f3_textQ.TabIndex = 65;
            this.f3_textQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f3_textParam_KeyPress);
            this.f3_textQ.Validated += new System.EventHandler(this.f3_textQ_Validated);
            // 
            // f3_textP
            // 
            this.f3_textP.Location = new System.Drawing.Point(85, 25);
            this.f3_textP.Name = "f3_textP";
            this.f3_textP.ReadOnly = true;
            this.f3_textP.Size = new System.Drawing.Size(457, 22);
            this.f3_textP.TabIndex = 64;
            this.f3_textP.TextChanged += new System.EventHandler(this.f3_textP_TextChanged);
            this.f3_textP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f3_textParam_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 63;
            this.label4.Text = "g";
            // 
            // f3_textSecretA
            // 
            this.f3_textSecretA.Location = new System.Drawing.Point(86, 32);
            this.f3_textSecretA.Name = "f3_textSecretA";
            this.f3_textSecretA.ReadOnly = true;
            this.f3_textSecretA.Size = new System.Drawing.Size(161, 22);
            this.f3_textSecretA.TabIndex = 71;
            this.f3_textSecretA.TextChanged += new System.EventHandler(this.f3_textSecretA_TextChanged);
            this.f3_textSecretA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f3_textParam_KeyPress);
            // 
            // f3_textCommonSecret_inWindowA
            // 
            this.f3_textCommonSecret_inWindowA.Location = new System.Drawing.Point(153, 155);
            this.f3_textCommonSecret_inWindowA.Name = "f3_textCommonSecret_inWindowA";
            this.f3_textCommonSecret_inWindowA.ReadOnly = true;
            this.f3_textCommonSecret_inWindowA.Size = new System.Drawing.Size(216, 22);
            this.f3_textCommonSecret_inWindowA.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 69;
            this.label3.Text = "Common secret key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 68;
            this.label1.Text = "Bob\'s open key";
            // 
            // f3_textOpenB_inWindowA
            // 
            this.f3_textOpenB_inWindowA.Location = new System.Drawing.Point(153, 126);
            this.f3_textOpenB_inWindowA.Name = "f3_textOpenB_inWindowA";
            this.f3_textOpenB_inWindowA.ReadOnly = true;
            this.f3_textOpenB_inWindowA.Size = new System.Drawing.Size(216, 22);
            this.f3_textOpenB_inWindowA.TabIndex = 66;
            // 
            // f3_button_SetSecretA
            // 
            this.f3_button_SetSecretA.Enabled = false;
            this.f3_button_SetSecretA.Location = new System.Drawing.Point(282, 30);
            this.f3_button_SetSecretA.Name = "f3_button_SetSecretA";
            this.f3_button_SetSecretA.Size = new System.Drawing.Size(100, 27);
            this.f3_button_SetSecretA.TabIndex = 64;
            this.f3_button_SetSecretA.Text = "Установить";
            this.f3_button_SetSecretA.UseVisualStyleBackColor = true;
            this.f3_button_SetSecretA.Click += new System.EventHandler(this.f3_button_SetSecretA_Click);
            // 
            // f3_textSecretB
            // 
            this.f3_textSecretB.Location = new System.Drawing.Point(86, 32);
            this.f3_textSecretB.Name = "f3_textSecretB";
            this.f3_textSecretB.ReadOnly = true;
            this.f3_textSecretB.Size = new System.Drawing.Size(161, 22);
            this.f3_textSecretB.TabIndex = 80;
            this.f3_textSecretB.TextChanged += new System.EventHandler(this.f3_textSecretB_TextChanged);
            this.f3_textSecretB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f3_textParam_KeyPress);
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
            // f3_textCommonSecret_inWindowB
            // 
            this.f3_textCommonSecret_inWindowB.Location = new System.Drawing.Point(153, 155);
            this.f3_textCommonSecret_inWindowB.Name = "f3_textCommonSecret_inWindowB";
            this.f3_textCommonSecret_inWindowB.ReadOnly = true;
            this.f3_textCommonSecret_inWindowB.Size = new System.Drawing.Size(216, 22);
            this.f3_textCommonSecret_inWindowB.TabIndex = 79;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 17);
            this.label5.TabIndex = 78;
            this.label5.Text = "Common secret key";
            // 
            // f3_button_SetSecretB
            // 
            this.f3_button_SetSecretB.Enabled = false;
            this.f3_button_SetSecretB.Location = new System.Drawing.Point(282, 30);
            this.f3_button_SetSecretB.Name = "f3_button_SetSecretB";
            this.f3_button_SetSecretB.Size = new System.Drawing.Size(100, 27);
            this.f3_button_SetSecretB.TabIndex = 75;
            this.f3_button_SetSecretB.Text = "Установить";
            this.f3_button_SetSecretB.UseVisualStyleBackColor = true;
            this.f3_button_SetSecretB.Click += new System.EventHandler(this.f3_button_SetSecretB_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 77;
            this.label6.Text = "Alice\'s open key";
            // 
            // f3_textOpenB
            // 
            this.f3_textOpenB.Location = new System.Drawing.Point(86, 65);
            this.f3_textOpenB.Name = "f3_textOpenB";
            this.f3_textOpenB.ReadOnly = true;
            this.f3_textOpenB.Size = new System.Drawing.Size(192, 22);
            this.f3_textOpenB.TabIndex = 74;
            // 
            // f3_textOpenA_inWindowB
            // 
            this.f3_textOpenA_inWindowB.Location = new System.Drawing.Point(153, 126);
            this.f3_textOpenA_inWindowB.Name = "f3_textOpenA_inWindowB";
            this.f3_textOpenA_inWindowB.ReadOnly = true;
            this.f3_textOpenA_inWindowB.Size = new System.Drawing.Size(216, 22);
            this.f3_textOpenA_inWindowB.TabIndex = 76;
            // 
            // f3_button_GetRandomSecretA
            // 
            this.f3_button_GetRandomSecretA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("f3_button_GetRandomSecretA.BackgroundImage")));
            this.f3_button_GetRandomSecretA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.f3_button_GetRandomSecretA.Enabled = false;
            this.f3_button_GetRandomSecretA.Location = new System.Drawing.Point(252, 30);
            this.f3_button_GetRandomSecretA.Margin = new System.Windows.Forms.Padding(1);
            this.f3_button_GetRandomSecretA.Name = "f3_button_GetRandomSecretA";
            this.f3_button_GetRandomSecretA.Size = new System.Drawing.Size(26, 27);
            this.f3_button_GetRandomSecretA.TabIndex = 71;
            this.f3_button_GetRandomSecretA.UseVisualStyleBackColor = true;
            this.f3_button_GetRandomSecretA.Click += new System.EventHandler(this.f3_button_GetRandomSecretA_Click);
            // 
            // f3_button_GetRandomSecretB
            // 
            this.f3_button_GetRandomSecretB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("f3_button_GetRandomSecretB.BackgroundImage")));
            this.f3_button_GetRandomSecretB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.f3_button_GetRandomSecretB.Enabled = false;
            this.f3_button_GetRandomSecretB.Location = new System.Drawing.Point(252, 30);
            this.f3_button_GetRandomSecretB.Margin = new System.Windows.Forms.Padding(1);
            this.f3_button_GetRandomSecretB.Name = "f3_button_GetRandomSecretB";
            this.f3_button_GetRandomSecretB.Size = new System.Drawing.Size(26, 27);
            this.f3_button_GetRandomSecretB.TabIndex = 72;
            this.f3_button_GetRandomSecretB.UseVisualStyleBackColor = true;
            this.f3_button_GetRandomSecretB.Click += new System.EventHandler(this.f3_button_GetRandomSecretB_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.f3_button_GetRandomSecretA);
            this.groupBox2.Controls.Add(this.f3_textSecretA);
            this.groupBox2.Controls.Add(this.f3_label3);
            this.groupBox2.Controls.Add(this.f3_textCommonSecret_inWindowA);
            this.groupBox2.Controls.Add(this.f3_label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.f3_button_SetSecretA);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.f3_textOpenA);
            this.groupBox2.Controls.Add(this.f3_textOpenB_inWindowA);
            this.groupBox2.Location = new System.Drawing.Point(12, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 218);
            this.groupBox2.TabIndex = 68;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alice";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.f3_button_GetRandomSecretB);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.f3_textSecretB);
            this.groupBox3.Controls.Add(this.f3_textOpenA_inWindowB);
            this.groupBox3.Controls.Add(this.f3_textOpenB);
            this.groupBox3.Controls.Add(this.f3_textCommonSecret_inWindowB);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.f3_button_SetSecretB);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(422, 202);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(411, 218);
            this.groupBox3.TabIndex = 69;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bob";
            // 
            // Form03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 444);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.f3_label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "Form03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Метод ключевого обмена Диффи-Хеллмана";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox f3_textOpenA;
        private System.Windows.Forms.Label f3_label3;
        private System.Windows.Forms.Label f3_label2;
        private System.Windows.Forms.Button f3_buttonSetKeys;
        private System.Windows.Forms.Label f3_label_q;
        private System.Windows.Forms.Label f3_label1;
        private System.Windows.Forms.Button f3_buttonClearKeys;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox f3_textOpenB_inWindowA;
        private System.Windows.Forms.Button f3_button_SetSecretA;
        private System.Windows.Forms.TextBox f3_textCommonSecret_inWindowA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox f3_textQ;
        private System.Windows.Forms.TextBox f3_textP;
        private System.Windows.Forms.TextBox f3_textG;
        private System.Windows.Forms.Button f3_buttonNextGenerator;
        private System.Windows.Forms.Button f3_buttonNextPrime;
        private System.Windows.Forms.TextBox f3_textSecretA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox f3_textSecretB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox f3_textCommonSecret_inWindowB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button f3_button_SetSecretB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox f3_textOpenB;
        private System.Windows.Forms.TextBox f3_textOpenA_inWindowB;
        private System.Windows.Forms.Button f3_button_GetRandomSecretA;
        private System.Windows.Forms.Button f3_button_GetRandomSecretB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}