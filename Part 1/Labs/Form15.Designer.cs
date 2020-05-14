namespace Labs
{
    partial class Form15
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.f15_label1 = new System.Windows.Forms.Label();
            this.f15_fieldKey = new System.Windows.Forms.TextBox();
            this.f15_ButtonSaveOriginal = new System.Windows.Forms.Label();
            this.f15_ButtonClearOriginal = new System.Windows.Forms.Label();
            this.f15_label4 = new System.Windows.Forms.Label();
            this.f15_fieldOriginal = new System.Windows.Forms.TextBox();
            this.f15_ButtonReadCiphertext = new System.Windows.Forms.Label();
            this.f15_ButtonClearCiphertext = new System.Windows.Forms.Label();
            this.f15_label2 = new System.Windows.Forms.Label();
            this.f15_fieldCiphertext = new System.Windows.Forms.TextBox();
            this.f15_useFoundedKey = new System.Windows.Forms.Button();
            this.f15_dataGridView = new System.Windows.Forms.DataGridView();
            this.Letter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Statistic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f15_label8 = new System.Windows.Forms.Label();
            this.f15_foundedKey = new System.Windows.Forms.TextBox();
            this.f15_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.f15_label3 = new System.Windows.Forms.Label();
            this.f15_keyLengthUpDown = new System.Windows.Forms.NumericUpDown();
            this.f15_label5 = new System.Windows.Forms.Label();
            this.f15_buttonFindKeyLength = new System.Windows.Forms.Button();
            this.f15_buttonFindKeys = new System.Windows.Forms.Button();
            this.f15_comboBoxMethods = new System.Windows.Forms.ComboBox();
            this.f15_label6 = new System.Windows.Forms.Label();
            this.f15_alfExtended = new System.Windows.Forms.TextBox();
            this.f15_label7 = new System.Windows.Forms.Label();
            this.f15_alf = new System.Windows.Forms.TextBox();
            this.label_plus = new System.Windows.Forms.Label();
            this.f15_checkBox_alfEx = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.f15_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f15_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f15_keyLengthUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // f15_label1
            // 
            this.f15_label1.AutoSize = true;
            this.f15_label1.Location = new System.Drawing.Point(283, 25);
            this.f15_label1.Name = "f15_label1";
            this.f15_label1.Size = new System.Drawing.Size(277, 17);
            this.f15_label1.TabIndex = 3;
            this.f15_label1.Text = "Криптоанализ полиалфавитных шифров";
            // 
            // f15_fieldKey
            // 
            this.f15_fieldKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.f15_fieldKey.Location = new System.Drawing.Point(64, 230);
            this.f15_fieldKey.Name = "f15_fieldKey";
            this.f15_fieldKey.Size = new System.Drawing.Size(270, 22);
            this.f15_fieldKey.TabIndex = 74;
            this.f15_fieldKey.TextChanged += new System.EventHandler(this.f15_fieldKey_TextChanged);
            this.f15_fieldKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f15_fieldKey_KeyPress);
            // 
            // f15_ButtonSaveOriginal
            // 
            this.f15_ButtonSaveOriginal.AutoSize = true;
            this.f15_ButtonSaveOriginal.ForeColor = System.Drawing.Color.Gray;
            this.f15_ButtonSaveOriginal.Location = new System.Drawing.Point(187, 270);
            this.f15_ButtonSaveOriginal.Name = "f15_ButtonSaveOriginal";
            this.f15_ButtonSaveOriginal.Size = new System.Drawing.Size(77, 17);
            this.f15_ButtonSaveOriginal.TabIndex = 81;
            this.f15_ButtonSaveOriginal.Text = "Сохранить";
            this.f15_ButtonSaveOriginal.Click += new System.EventHandler(this.f15_ButtonSaveOriginal_Click);
            // 
            // f15_ButtonClearOriginal
            // 
            this.f15_ButtonClearOriginal.AutoSize = true;
            this.f15_ButtonClearOriginal.ForeColor = System.Drawing.Color.Gray;
            this.f15_ButtonClearOriginal.Location = new System.Drawing.Point(263, 270);
            this.f15_ButtonClearOriginal.Name = "f15_ButtonClearOriginal";
            this.f15_ButtonClearOriginal.Size = new System.Drawing.Size(71, 17);
            this.f15_ButtonClearOriginal.TabIndex = 80;
            this.f15_ButtonClearOriginal.Text = "Очистить";
            this.f15_ButtonClearOriginal.Click += new System.EventHandler(this.f15_ButtonClearOriginal_Click);
            // 
            // f15_label4
            // 
            this.f15_label4.AutoSize = true;
            this.f15_label4.Location = new System.Drawing.Point(15, 266);
            this.f15_label4.Name = "f15_label4";
            this.f15_label4.Size = new System.Drawing.Size(113, 17);
            this.f15_label4.TabIndex = 79;
            this.f15_label4.Text = "Исходный текст";
            // 
            // f15_fieldOriginal
            // 
            this.f15_fieldOriginal.Location = new System.Drawing.Point(15, 289);
            this.f15_fieldOriginal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f15_fieldOriginal.Multiline = true;
            this.f15_fieldOriginal.Name = "f15_fieldOriginal";
            this.f15_fieldOriginal.ReadOnly = true;
            this.f15_fieldOriginal.Size = new System.Drawing.Size(320, 140);
            this.f15_fieldOriginal.TabIndex = 75;
            this.f15_fieldOriginal.TextChanged += new System.EventHandler(this.f15_fieldOriginal_TextChanged);
            // 
            // f15_ButtonReadCiphertext
            // 
            this.f15_ButtonReadCiphertext.AutoSize = true;
            this.f15_ButtonReadCiphertext.ForeColor = System.Drawing.Color.Gray;
            this.f15_ButtonReadCiphertext.Location = new System.Drawing.Point(199, 55);
            this.f15_ButtonReadCiphertext.Name = "f15_ButtonReadCiphertext";
            this.f15_ButtonReadCiphertext.Size = new System.Drawing.Size(62, 17);
            this.f15_ButtonReadCiphertext.TabIndex = 78;
            this.f15_ButtonReadCiphertext.Text = "Считать";
            this.f15_ButtonReadCiphertext.Click += new System.EventHandler(this.f15_ButtonReadCiphertext_Click);
            // 
            // f15_ButtonClearCiphertext
            // 
            this.f15_ButtonClearCiphertext.AutoSize = true;
            this.f15_ButtonClearCiphertext.ForeColor = System.Drawing.Color.Gray;
            this.f15_ButtonClearCiphertext.Location = new System.Drawing.Point(261, 55);
            this.f15_ButtonClearCiphertext.Name = "f15_ButtonClearCiphertext";
            this.f15_ButtonClearCiphertext.Size = new System.Drawing.Size(71, 17);
            this.f15_ButtonClearCiphertext.TabIndex = 77;
            this.f15_ButtonClearCiphertext.Text = "Очистить";
            this.f15_ButtonClearCiphertext.Click += new System.EventHandler(this.f15_ButtonClearCiphertext_Click);
            // 
            // f15_label2
            // 
            this.f15_label2.AutoSize = true;
            this.f15_label2.Location = new System.Drawing.Point(12, 50);
            this.f15_label2.Name = "f15_label2";
            this.f15_label2.Size = new System.Drawing.Size(82, 17);
            this.f15_label2.TabIndex = 76;
            this.f15_label2.Text = "Шифртекст";
            // 
            // f15_fieldCiphertext
            // 
            this.f15_fieldCiphertext.Location = new System.Drawing.Point(15, 74);
            this.f15_fieldCiphertext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f15_fieldCiphertext.Multiline = true;
            this.f15_fieldCiphertext.Name = "f15_fieldCiphertext";
            this.f15_fieldCiphertext.Size = new System.Drawing.Size(320, 140);
            this.f15_fieldCiphertext.TabIndex = 73;
            this.f15_fieldCiphertext.TextChanged += new System.EventHandler(this.f15_fieldCiphertext_TextChanged);
            // 
            // f15_useFoundedKey
            // 
            this.f15_useFoundedKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.f15_useFoundedKey.Location = new System.Drawing.Point(619, 141);
            this.f15_useFoundedKey.Name = "f15_useFoundedKey";
            this.f15_useFoundedKey.Size = new System.Drawing.Size(101, 25);
            this.f15_useFoundedKey.TabIndex = 83;
            this.f15_useFoundedKey.Text = "Применить";
            this.f15_useFoundedKey.UseVisualStyleBackColor = true;
            this.f15_useFoundedKey.Click += new System.EventHandler(this.f15_useFoundedKey_Click);
            // 
            // f15_dataGridView
            // 
            this.f15_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.f15_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.f15_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Letter,
            this.Amount,
            this.Frequency,
            this.Statistic});
            this.f15_dataGridView.Location = new System.Drawing.Point(352, 192);
            this.f15_dataGridView.Name = "f15_dataGridView";
            this.f15_dataGridView.RowTemplate.Height = 24;
            this.f15_dataGridView.Size = new System.Drawing.Size(479, 109);
            this.f15_dataGridView.TabIndex = 89;
            // 
            // Letter
            // 
            this.Letter.HeaderText = "Буква";
            this.Letter.Name = "Letter";
            this.Letter.Width = 75;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Кол-во";
            this.Amount.Name = "Amount";
            this.Amount.Width = 82;
            // 
            // Frequency
            // 
            this.Frequency.HeaderText = "Частота";
            this.Frequency.Name = "Frequency";
            this.Frequency.Width = 92;
            // 
            // Statistic
            // 
            this.Statistic.HeaderText = "Табличная";
            this.Statistic.Name = "Statistic";
            this.Statistic.Width = 110;
            // 
            // f15_label8
            // 
            this.f15_label8.AutoSize = true;
            this.f15_label8.Location = new System.Drawing.Point(355, 168);
            this.f15_label8.Name = "f15_label8";
            this.f15_label8.Size = new System.Drawing.Size(358, 17);
            this.f15_label8.TabIndex = 88;
            this.f15_label8.Text = "Частота встречаемости символов в исходном тексте";
            // 
            // f15_foundedKey
            // 
            this.f15_foundedKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.f15_foundedKey.Location = new System.Drawing.Point(407, 141);
            this.f15_foundedKey.Name = "f15_foundedKey";
            this.f15_foundedKey.ReadOnly = true;
            this.f15_foundedKey.Size = new System.Drawing.Size(206, 22);
            this.f15_foundedKey.TabIndex = 82;
            // 
            // f15_chart
            // 
            this.f15_chart.BackColor = System.Drawing.Color.Transparent;
            this.f15_chart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea2.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.f15_chart.ChartAreas.Add(chartArea2);
            this.f15_chart.Location = new System.Drawing.Point(314, 299);
            this.f15_chart.Name = "f15_chart";
            this.f15_chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.Name = "Series1";
            this.f15_chart.Series.Add(series2);
            this.f15_chart.Size = new System.Drawing.Size(540, 148);
            this.f15_chart.TabIndex = 90;
            this.f15_chart.Text = "Chart";
            // 
            // f15_label3
            // 
            this.f15_label3.AutoSize = true;
            this.f15_label3.Location = new System.Drawing.Point(17, 233);
            this.f15_label3.Name = "f15_label3";
            this.f15_label3.Size = new System.Drawing.Size(43, 17);
            this.f15_label3.TabIndex = 91;
            this.f15_label3.Text = "Ключ";
            // 
            // f15_keyLengthUpDown
            // 
            this.f15_keyLengthUpDown.Location = new System.Drawing.Point(457, 112);
            this.f15_keyLengthUpDown.Name = "f15_keyLengthUpDown";
            this.f15_keyLengthUpDown.Size = new System.Drawing.Size(68, 22);
            this.f15_keyLengthUpDown.TabIndex = 92;
            // 
            // f15_label5
            // 
            this.f15_label5.AutoSize = true;
            this.f15_label5.Location = new System.Drawing.Point(355, 114);
            this.f15_label5.Name = "f15_label5";
            this.f15_label5.Size = new System.Drawing.Size(96, 17);
            this.f15_label5.TabIndex = 93;
            this.f15_label5.Text = "Длина ключа";
            // 
            // f15_buttonFindKeyLength
            // 
            this.f15_buttonFindKeyLength.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.f15_buttonFindKeyLength.Location = new System.Drawing.Point(726, 110);
            this.f15_buttonFindKeyLength.Name = "f15_buttonFindKeyLength";
            this.f15_buttonFindKeyLength.Size = new System.Drawing.Size(101, 25);
            this.f15_buttonFindKeyLength.TabIndex = 94;
            this.f15_buttonFindKeyLength.Text = "Вычислить";
            this.f15_buttonFindKeyLength.UseVisualStyleBackColor = true;
            this.f15_buttonFindKeyLength.Click += new System.EventHandler(this.f15_buttonFindKeyLength_Click);
            // 
            // f15_buttonFindKeys
            // 
            this.f15_buttonFindKeys.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.f15_buttonFindKeys.Location = new System.Drawing.Point(726, 141);
            this.f15_buttonFindKeys.Name = "f15_buttonFindKeys";
            this.f15_buttonFindKeys.Size = new System.Drawing.Size(101, 25);
            this.f15_buttonFindKeys.TabIndex = 95;
            this.f15_buttonFindKeys.Text = "Найти";
            this.f15_buttonFindKeys.UseVisualStyleBackColor = true;
            this.f15_buttonFindKeys.Click += new System.EventHandler(this.f15_buttonFindKeys_Click);
            // 
            // f15_comboBoxMethods
            // 
            this.f15_comboBoxMethods.FormattingEnabled = true;
            this.f15_comboBoxMethods.Items.AddRange(new object[] {
            "Метод индекса совпадений",
            "Автокорреляционный метод",
            "Тест Казиски"});
            this.f15_comboBoxMethods.Location = new System.Drawing.Point(546, 111);
            this.f15_comboBoxMethods.Name = "f15_comboBoxMethods";
            this.f15_comboBoxMethods.Size = new System.Drawing.Size(174, 24);
            this.f15_comboBoxMethods.TabIndex = 96;
            // 
            // f15_label6
            // 
            this.f15_label6.AutoSize = true;
            this.f15_label6.Location = new System.Drawing.Point(355, 141);
            this.f15_label6.Name = "f15_label6";
            this.f15_label6.Size = new System.Drawing.Size(43, 17);
            this.f15_label6.TabIndex = 99;
            this.f15_label6.Text = "Ключ";
            // 
            // f15_alfExtended
            // 
            this.f15_alfExtended.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.f15_alfExtended.Location = new System.Drawing.Point(726, 74);
            this.f15_alfExtended.Name = "f15_alfExtended";
            this.f15_alfExtended.Size = new System.Drawing.Size(105, 22);
            this.f15_alfExtended.TabIndex = 100;
            this.f15_alfExtended.TextChanged += new System.EventHandler(this.f15_alfExtended_TextChanged);
            // 
            // f15_label7
            // 
            this.f15_label7.AutoSize = true;
            this.f15_label7.Location = new System.Drawing.Point(355, 77);
            this.f15_label7.Name = "f15_label7";
            this.f15_label7.Size = new System.Drawing.Size(142, 17);
            this.f15_label7.TabIndex = 101;
            this.f15_label7.Text = "Расширить алфавит";
            // 
            // f15_alf
            // 
            this.f15_alf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.f15_alf.Location = new System.Drawing.Point(503, 74);
            this.f15_alf.Name = "f15_alf";
            this.f15_alf.Size = new System.Drawing.Size(199, 22);
            this.f15_alf.TabIndex = 102;
            this.f15_alf.TextChanged += new System.EventHandler(this.f15_alfExtended_TextChanged);
            // 
            // label_plus
            // 
            this.label_plus.AutoSize = true;
            this.label_plus.Location = new System.Drawing.Point(706, 77);
            this.label_plus.Name = "label_plus";
            this.label_plus.Size = new System.Drawing.Size(16, 17);
            this.label_plus.TabIndex = 103;
            this.label_plus.Text = "+";
            // 
            // f15_checkBox_alfEx
            // 
            this.f15_checkBox_alfEx.AutoSize = true;
            this.f15_checkBox_alfEx.Location = new System.Drawing.Point(740, 50);
            this.f15_checkBox_alfEx.Name = "f15_checkBox_alfEx";
            this.f15_checkBox_alfEx.Size = new System.Drawing.Size(91, 21);
            this.f15_checkBox_alfEx.TabIndex = 104;
            this.f15_checkBox_alfEx.Text = "В начало";
            this.f15_checkBox_alfEx.UseVisualStyleBackColor = true;
            this.f15_checkBox_alfEx.CheckedChanged += new System.EventHandler(this.f15_checkBox_alfEx_CheckedChanged);
            // 
            // Form15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 444);
            this.Controls.Add(this.f15_checkBox_alfEx);
            this.Controls.Add(this.label_plus);
            this.Controls.Add(this.f15_alf);
            this.Controls.Add(this.f15_label7);
            this.Controls.Add(this.f15_alfExtended);
            this.Controls.Add(this.f15_label6);
            this.Controls.Add(this.f15_comboBoxMethods);
            this.Controls.Add(this.f15_buttonFindKeys);
            this.Controls.Add(this.f15_buttonFindKeyLength);
            this.Controls.Add(this.f15_label5);
            this.Controls.Add(this.f15_keyLengthUpDown);
            this.Controls.Add(this.f15_label3);
            this.Controls.Add(this.f15_fieldOriginal);
            this.Controls.Add(this.f15_useFoundedKey);
            this.Controls.Add(this.f15_dataGridView);
            this.Controls.Add(this.f15_label8);
            this.Controls.Add(this.f15_foundedKey);
            this.Controls.Add(this.f15_chart);
            this.Controls.Add(this.f15_fieldKey);
            this.Controls.Add(this.f15_ButtonSaveOriginal);
            this.Controls.Add(this.f15_ButtonClearOriginal);
            this.Controls.Add(this.f15_label4);
            this.Controls.Add(this.f15_ButtonReadCiphertext);
            this.Controls.Add(this.f15_ButtonClearCiphertext);
            this.Controls.Add(this.f15_label2);
            this.Controls.Add(this.f15_fieldCiphertext);
            this.Controls.Add(this.f15_label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(100, 100);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form15";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Криптоанализ полиалфавитных шифров";
            ((System.ComponentModel.ISupportInitialize)(this.f15_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f15_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f15_keyLengthUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label f15_label1;
        private System.Windows.Forms.TextBox f15_fieldKey;
        private System.Windows.Forms.Label f15_ButtonSaveOriginal;
        private System.Windows.Forms.Label f15_ButtonClearOriginal;
        private System.Windows.Forms.Label f15_label4;
        private System.Windows.Forms.TextBox f15_fieldOriginal;
        private System.Windows.Forms.Label f15_ButtonReadCiphertext;
        private System.Windows.Forms.Label f15_ButtonClearCiphertext;
        private System.Windows.Forms.Label f15_label2;
        private System.Windows.Forms.TextBox f15_fieldCiphertext;
        private System.Windows.Forms.Button f15_useFoundedKey;
        private System.Windows.Forms.DataGridView f15_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Letter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Statistic;
        private System.Windows.Forms.Label f15_label8;
        private System.Windows.Forms.TextBox f15_foundedKey;
        private System.Windows.Forms.DataVisualization.Charting.Chart f15_chart;
        private System.Windows.Forms.Label f15_label3;
        private System.Windows.Forms.NumericUpDown f15_keyLengthUpDown;
        private System.Windows.Forms.Label f15_label5;
        private System.Windows.Forms.Button f15_buttonFindKeyLength;
        private System.Windows.Forms.Button f15_buttonFindKeys;
        private System.Windows.Forms.ComboBox f15_comboBoxMethods;
        private System.Windows.Forms.Label f15_label6;
        private System.Windows.Forms.TextBox f15_alfExtended;
        private System.Windows.Forms.Label f15_label7;
        private System.Windows.Forms.TextBox f15_alf;
        private System.Windows.Forms.Label label_plus;
        private System.Windows.Forms.CheckBox f15_checkBox_alfEx;
    }
}