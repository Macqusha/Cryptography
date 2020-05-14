namespace Labs
{
    partial class Form01
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
            this.f01_fieldMessage = new System.Windows.Forms.TextBox();
            this.f01_Button_Crypt = new System.Windows.Forms.Button();
            this.f01_label1 = new System.Windows.Forms.Label();
            this.f01_ButtonClear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // f01_fieldMessage
            // 
            this.f01_fieldMessage.Location = new System.Drawing.Point(92, 55);
            this.f01_fieldMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f01_fieldMessage.Multiline = true;
            this.f01_fieldMessage.Name = "f01_fieldMessage";
            this.f01_fieldMessage.Size = new System.Drawing.Size(450, 250);
            this.f01_fieldMessage.TabIndex = 2;
            // 
            // f01_Button_Crypt
            // 
            this.f01_Button_Crypt.Location = new System.Drawing.Point(181, 320);
            this.f01_Button_Crypt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f01_Button_Crypt.Name = "f01_Button_Crypt";
            this.f01_Button_Crypt.Size = new System.Drawing.Size(272, 19);
            this.f01_Button_Crypt.TabIndex = 3;
            this.f01_Button_Crypt.Text = "Зашифровать / Расшифровать";
            this.f01_Button_Crypt.UseVisualStyleBackColor = true;
            this.f01_Button_Crypt.Click += new System.EventHandler(this.f01_Button_Crypt_Click);
            // 
            // f01_label1
            // 
            this.f01_label1.AutoSize = true;
            this.f01_label1.Location = new System.Drawing.Point(282, 20);
            this.f01_label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f01_label1.Name = "f01_label1";
            this.f01_label1.Size = new System.Drawing.Size(71, 13);
            this.f01_label1.TabIndex = 1;
            this.f01_label1.Text = "Шифр Атбаш";
            // 
            // f01_ButtonClear
            // 
            this.f01_ButtonClear.AutoSize = true;
            this.f01_ButtonClear.ForeColor = System.Drawing.Color.Gray;
            this.f01_ButtonClear.Location = new System.Drawing.Point(488, 40);
            this.f01_ButtonClear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.f01_ButtonClear.Name = "f01_ButtonClear";
            this.f01_ButtonClear.Size = new System.Drawing.Size(54, 13);
            this.f01_ButtonClear.TabIndex = 25;
            this.f01_ButtonClear.Text = "Очистить";
            this.f01_ButtonClear.Click += new System.EventHandler(this.f01_ButtonClear_Click);
            // 
            // Form01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.f01_ButtonClear);
            this.Controls.Add(this.f01_label1);
            this.Controls.Add(this.f01_fieldMessage);
            this.Controls.Add(this.f01_Button_Crypt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(100, 100);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Шифр Атбаш";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox f01_fieldMessage;
        private System.Windows.Forms.Button f01_Button_Crypt;
        private System.Windows.Forms.Label f01_label1;
        private System.Windows.Forms.Label f01_ButtonClear;
    }
}