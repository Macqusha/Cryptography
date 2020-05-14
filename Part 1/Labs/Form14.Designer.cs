namespace Labs
{
    partial class Form14
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.f14_label1 = new System.Windows.Forms.Label();
            this.f14_ButtonReadCiphertext = new System.Windows.Forms.Label();
            this.f14_ButtonClearCiphertext = new System.Windows.Forms.Label();
            this.f14_label2 = new System.Windows.Forms.Label();
            this.f14_fieldCiphertext = new System.Windows.Forms.TextBox();
            this.f14_ButtonSaveOriginal = new System.Windows.Forms.Label();
            this.f14_ButtonClearOriginal = new System.Windows.Forms.Label();
            this.f14_label4 = new System.Windows.Forms.Label();
            this.f14_fieldOriginal = new System.Windows.Forms.TextBox();
            this.f14_numRotate = new System.Windows.Forms.NumericUpDown();
            this.f14_label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.f14_key3 = new System.Windows.Forms.TextBox();
            this.f14_key2 = new System.Windows.Forms.TextBox();
            this.f14_label5 = new System.Windows.Forms.Label();
            this.f14_key1 = new System.Windows.Forms.TextBox();
            this.f14_buttonCountKey = new System.Windows.Forms.Button();
            this.f14_label6 = new System.Windows.Forms.Label();
            this.f14_dataGridView = new System.Windows.Forms.DataGridView();
            this.Letter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Statistic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f14_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.f14_check4 = new System.Windows.Forms.CheckBox();
            this.f14_check2 = new System.Windows.Forms.CheckBox();
            this.f14_check3 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.f14_numMistake = new System.Windows.Forms.NumericUpDown();
            this.f14_check5 = new System.Windows.Forms.CheckBox();
            this.f14_check1 = new System.Windows.Forms.CheckBox();
            this.f14_buttonExtended = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.f14_numRotate)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.f14_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f14_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f14_numMistake)).BeginInit();
            this.SuspendLayout();
            // 
            // f14_label1
            // 
            this.f14_label1.AutoSize = true;
            this.f14_label1.Location = new System.Drawing.Point(332, 25);
            this.f14_label1.Name = "f14_label1";
            this.f14_label1.Size = new System.Drawing.Size(178, 17);
            this.f14_label1.TabIndex = 3;
            this.f14_label1.Text = "Частотный криптоанализ";
            // 
            // f14_ButtonReadCiphertext
            // 
            this.f14_ButtonReadCiphertext.AutoSize = true;
            this.f14_ButtonReadCiphertext.ForeColor = System.Drawing.Color.Gray;
            this.f14_ButtonReadCiphertext.Location = new System.Drawing.Point(199, 56);
            this.f14_ButtonReadCiphertext.Name = "f14_ButtonReadCiphertext";
            this.f14_ButtonReadCiphertext.Size = new System.Drawing.Size(62, 17);
            this.f14_ButtonReadCiphertext.TabIndex = 37;
            this.f14_ButtonReadCiphertext.Text = "Считать";
            this.f14_ButtonReadCiphertext.Click += new System.EventHandler(this.f14_ButtonReadCiphertext_Click);
            // 
            // f14_ButtonClearCiphertext
            // 
            this.f14_ButtonClearCiphertext.AutoSize = true;
            this.f14_ButtonClearCiphertext.ForeColor = System.Drawing.Color.Gray;
            this.f14_ButtonClearCiphertext.Location = new System.Drawing.Point(261, 56);
            this.f14_ButtonClearCiphertext.Name = "f14_ButtonClearCiphertext";
            this.f14_ButtonClearCiphertext.Size = new System.Drawing.Size(71, 17);
            this.f14_ButtonClearCiphertext.TabIndex = 36;
            this.f14_ButtonClearCiphertext.Text = "Очистить";
            this.f14_ButtonClearCiphertext.Click += new System.EventHandler(this.f14_ButtonClearCiphertext_Click);
            // 
            // f14_label2
            // 
            this.f14_label2.AutoSize = true;
            this.f14_label2.Location = new System.Drawing.Point(12, 51);
            this.f14_label2.Name = "f14_label2";
            this.f14_label2.Size = new System.Drawing.Size(82, 17);
            this.f14_label2.TabIndex = 34;
            this.f14_label2.Text = "Шифртекст";
            // 
            // f14_fieldCiphertext
            // 
            this.f14_fieldCiphertext.Location = new System.Drawing.Point(15, 75);
            this.f14_fieldCiphertext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f14_fieldCiphertext.Multiline = true;
            this.f14_fieldCiphertext.Name = "f14_fieldCiphertext";
            this.f14_fieldCiphertext.Size = new System.Drawing.Size(320, 140);
            this.f14_fieldCiphertext.TabIndex = 1;
            this.f14_fieldCiphertext.TextChanged += new System.EventHandler(this.f14_Ciphertext_Changed);
            // 
            // f14_ButtonSaveOriginal
            // 
            this.f14_ButtonSaveOriginal.AutoSize = true;
            this.f14_ButtonSaveOriginal.ForeColor = System.Drawing.Color.Gray;
            this.f14_ButtonSaveOriginal.Location = new System.Drawing.Point(187, 271);
            this.f14_ButtonSaveOriginal.Name = "f14_ButtonSaveOriginal";
            this.f14_ButtonSaveOriginal.Size = new System.Drawing.Size(77, 17);
            this.f14_ButtonSaveOriginal.TabIndex = 41;
            this.f14_ButtonSaveOriginal.Text = "Сохранить";
            this.f14_ButtonSaveOriginal.Click += new System.EventHandler(this.f14_ButtonSaveOriginal_Click);
            // 
            // f14_ButtonClearOriginal
            // 
            this.f14_ButtonClearOriginal.AutoSize = true;
            this.f14_ButtonClearOriginal.ForeColor = System.Drawing.Color.Gray;
            this.f14_ButtonClearOriginal.Location = new System.Drawing.Point(263, 271);
            this.f14_ButtonClearOriginal.Name = "f14_ButtonClearOriginal";
            this.f14_ButtonClearOriginal.Size = new System.Drawing.Size(71, 17);
            this.f14_ButtonClearOriginal.TabIndex = 40;
            this.f14_ButtonClearOriginal.Text = "Очистить";
            this.f14_ButtonClearOriginal.Click += new System.EventHandler(this.f14_ButtonClearOriginal_Click);
            // 
            // f14_label4
            // 
            this.f14_label4.AutoSize = true;
            this.f14_label4.Location = new System.Drawing.Point(15, 267);
            this.f14_label4.Name = "f14_label4";
            this.f14_label4.Size = new System.Drawing.Size(113, 17);
            this.f14_label4.TabIndex = 38;
            this.f14_label4.Text = "Исходный текст";
            // 
            // f14_fieldOriginal
            // 
            this.f14_fieldOriginal.Location = new System.Drawing.Point(15, 290);
            this.f14_fieldOriginal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f14_fieldOriginal.Multiline = true;
            this.f14_fieldOriginal.Name = "f14_fieldOriginal";
            this.f14_fieldOriginal.ReadOnly = true;
            this.f14_fieldOriginal.Size = new System.Drawing.Size(320, 140);
            this.f14_fieldOriginal.TabIndex = 2;
            // 
            // f14_numRotate
            // 
            this.f14_numRotate.Location = new System.Drawing.Point(222, 229);
            this.f14_numRotate.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.f14_numRotate.Name = "f14_numRotate";
            this.f14_numRotate.Size = new System.Drawing.Size(68, 22);
            this.f14_numRotate.TabIndex = 2;
            this.f14_numRotate.ValueChanged += new System.EventHandler(this.f14_Rotate_ValueChanged);
            // 
            // f14_label3
            // 
            this.f14_label3.AutoSize = true;
            this.f14_label3.Location = new System.Drawing.Point(44, 231);
            this.f14_label3.Name = "f14_label3";
            this.f14_label3.Size = new System.Drawing.Size(161, 17);
            this.f14_label3.TabIndex = 43;
            this.f14_label3.Text = "Предполагаемый сдвиг";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.90909F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.09091F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.f14_key3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.f14_key2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.f14_label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.f14_key1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.f14_buttonCountKey, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(354, 56);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(479, 32);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // f14_key3
            // 
            this.f14_key3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.f14_key3.Location = new System.Drawing.Point(324, 5);
            this.f14_key3.Name = "f14_key3";
            this.f14_key3.ReadOnly = true;
            this.f14_key3.Size = new System.Drawing.Size(50, 22);
            this.f14_key3.TabIndex = 3;
            // 
            // f14_key2
            // 
            this.f14_key2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.f14_key2.Location = new System.Drawing.Point(266, 5);
            this.f14_key2.Name = "f14_key2";
            this.f14_key2.ReadOnly = true;
            this.f14_key2.Size = new System.Drawing.Size(50, 22);
            this.f14_key2.TabIndex = 2;
            // 
            // f14_label5
            // 
            this.f14_label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.f14_label5.AutoSize = true;
            this.f14_label5.Location = new System.Drawing.Point(3, 7);
            this.f14_label5.Name = "f14_label5";
            this.f14_label5.Size = new System.Drawing.Size(173, 17);
            this.f14_label5.TabIndex = 0;
            this.f14_label5.Text = "Самые вероятные ключи";
            // 
            // f14_key1
            // 
            this.f14_key1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.f14_key1.Location = new System.Drawing.Point(211, 5);
            this.f14_key1.Name = "f14_key1";
            this.f14_key1.ReadOnly = true;
            this.f14_key1.Size = new System.Drawing.Size(49, 22);
            this.f14_key1.TabIndex = 1;
            this.f14_key1.TextChanged += new System.EventHandler(this.f14_key1_TextChanged);
            // 
            // f14_buttonCountKey
            // 
            this.f14_buttonCountKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.f14_buttonCountKey.Location = new System.Drawing.Point(387, 4);
            this.f14_buttonCountKey.Name = "f14_buttonCountKey";
            this.f14_buttonCountKey.Size = new System.Drawing.Size(83, 23);
            this.f14_buttonCountKey.TabIndex = 4;
            this.f14_buttonCountKey.Text = "Расчёт";
            this.f14_buttonCountKey.UseVisualStyleBackColor = true;
            this.f14_buttonCountKey.Click += new System.EventHandler(this.f14_buttonCountKey_Click);
            // 
            // f14_label6
            // 
            this.f14_label6.AutoSize = true;
            this.f14_label6.Location = new System.Drawing.Point(357, 162);
            this.f14_label6.Name = "f14_label6";
            this.f14_label6.Size = new System.Drawing.Size(358, 17);
            this.f14_label6.TabIndex = 1;
            this.f14_label6.Text = "Частота встречаемости символов в исходном тексте";
            // 
            // f14_dataGridView
            // 
            this.f14_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.f14_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.f14_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Letter,
            this.Amount,
            this.Frequency,
            this.Statistic});
            this.f14_dataGridView.Location = new System.Drawing.Point(354, 186);
            this.f14_dataGridView.Name = "f14_dataGridView";
            this.f14_dataGridView.RowTemplate.Height = 24;
            this.f14_dataGridView.Size = new System.Drawing.Size(479, 109);
            this.f14_dataGridView.TabIndex = 45;
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
            // f14_chart
            // 
            this.f14_chart.BackColor = System.Drawing.Color.Transparent;
            this.f14_chart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.f14_chart.ChartAreas.Add(chartArea1);
            this.f14_chart.Location = new System.Drawing.Point(316, 293);
            this.f14_chart.Name = "f14_chart";
            this.f14_chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Name = "Series1";
            this.f14_chart.Series.Add(series1);
            this.f14_chart.Size = new System.Drawing.Size(540, 148);
            this.f14_chart.TabIndex = 46;
            this.f14_chart.Text = "Chart";
            // 
            // f14_check4
            // 
            this.f14_check4.AutoSize = true;
            this.f14_check4.Checked = true;
            this.f14_check4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.f14_check4.Location = new System.Drawing.Point(354, 135);
            this.f14_check4.Name = "f14_check4";
            this.f14_check4.Size = new System.Drawing.Size(202, 21);
            this.f14_check4.TabIndex = 6;
            this.f14_check4.Text = "Недопустимые сочетания";
            this.f14_check4.UseVisualStyleBackColor = true;
            // 
            // f14_check2
            // 
            this.f14_check2.AutoSize = true;
            this.f14_check2.Checked = true;
            this.f14_check2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.f14_check2.Location = new System.Drawing.Point(354, 115);
            this.f14_check2.Name = "f14_check2";
            this.f14_check2.Size = new System.Drawing.Size(96, 21);
            this.f14_check2.TabIndex = 7;
            this.f14_check2.Text = "Биграммы";
            this.f14_check2.UseVisualStyleBackColor = true;
            // 
            // f14_check3
            // 
            this.f14_check3.AutoSize = true;
            this.f14_check3.Checked = true;
            this.f14_check3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.f14_check3.Location = new System.Drawing.Point(471, 115);
            this.f14_check3.Name = "f14_check3";
            this.f14_check3.Size = new System.Drawing.Size(104, 21);
            this.f14_check3.TabIndex = 8;
            this.f14_check3.Text = "Триграммы";
            this.f14_check3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(575, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Погрешность:";
            // 
            // f14_numMistake
            // 
            this.f14_numMistake.DecimalPlaces = 2;
            this.f14_numMistake.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.f14_numMistake.Location = new System.Drawing.Point(680, 93);
            this.f14_numMistake.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            131072});
            this.f14_numMistake.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.f14_numMistake.Name = "f14_numMistake";
            this.f14_numMistake.Size = new System.Drawing.Size(65, 22);
            this.f14_numMistake.TabIndex = 54;
            this.f14_numMistake.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // f14_check5
            // 
            this.f14_check5.AutoSize = true;
            this.f14_check5.Checked = true;
            this.f14_check5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.f14_check5.Location = new System.Drawing.Point(580, 135);
            this.f14_check5.Name = "f14_check5";
            this.f14_check5.Size = new System.Drawing.Size(200, 21);
            this.f14_check5.TabIndex = 55;
            this.f14_check5.Text = "Позиции (правила языка)";
            this.f14_check5.UseVisualStyleBackColor = true;
            // 
            // f14_check1
            // 
            this.f14_check1.AutoSize = true;
            this.f14_check1.Checked = true;
            this.f14_check1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.f14_check1.Location = new System.Drawing.Point(354, 94);
            this.f14_check1.Name = "f14_check1";
            this.f14_check1.Size = new System.Drawing.Size(196, 21);
            this.f14_check1.TabIndex = 56;
            this.f14_check1.Text = "Частоты одиночных букв";
            this.f14_check1.UseVisualStyleBackColor = true;
            // 
            // f14_buttonExtended
            // 
            this.f14_buttonExtended.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.f14_buttonExtended.Location = new System.Drawing.Point(680, 12);
            this.f14_buttonExtended.Name = "f14_buttonExtended";
            this.f14_buttonExtended.Size = new System.Drawing.Size(144, 23);
            this.f14_buttonExtended.TabIndex = 57;
            this.f14_buttonExtended.Text = "Расширенный";
            this.f14_buttonExtended.UseVisualStyleBackColor = true;
            this.f14_buttonExtended.Click += new System.EventHandler(this.f14_buttonExtended_Click);
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 444);
            this.Controls.Add(this.f14_buttonExtended);
            this.Controls.Add(this.f14_check1);
            this.Controls.Add(this.f14_check5);
            this.Controls.Add(this.f14_numMistake);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.f14_check3);
            this.Controls.Add(this.f14_check2);
            this.Controls.Add(this.f14_check4);
            this.Controls.Add(this.f14_dataGridView);
            this.Controls.Add(this.f14_label6);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.f14_label3);
            this.Controls.Add(this.f14_numRotate);
            this.Controls.Add(this.f14_ButtonSaveOriginal);
            this.Controls.Add(this.f14_ButtonClearOriginal);
            this.Controls.Add(this.f14_label4);
            this.Controls.Add(this.f14_fieldOriginal);
            this.Controls.Add(this.f14_ButtonReadCiphertext);
            this.Controls.Add(this.f14_ButtonClearCiphertext);
            this.Controls.Add(this.f14_label2);
            this.Controls.Add(this.f14_fieldCiphertext);
            this.Controls.Add(this.f14_label1);
            this.Controls.Add(this.f14_chart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(100, 100);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form14";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Частотный криптоанализ";
            ((System.ComponentModel.ISupportInitialize)(this.f14_numRotate)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.f14_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f14_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f14_numMistake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label f14_label1;
        private System.Windows.Forms.Label f14_ButtonReadCiphertext;
        private System.Windows.Forms.Label f14_ButtonClearCiphertext;
        private System.Windows.Forms.Label f14_label2;
        private System.Windows.Forms.TextBox f14_fieldCiphertext;
        private System.Windows.Forms.Label f14_ButtonSaveOriginal;
        private System.Windows.Forms.Label f14_ButtonClearOriginal;
        private System.Windows.Forms.Label f14_label4;
        private System.Windows.Forms.TextBox f14_fieldOriginal;
        private System.Windows.Forms.NumericUpDown f14_numRotate;
        private System.Windows.Forms.Label f14_label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox f14_key3;
        private System.Windows.Forms.TextBox f14_key2;
        private System.Windows.Forms.Label f14_label5;
        private System.Windows.Forms.TextBox f14_key1;
        private System.Windows.Forms.Button f14_buttonCountKey;
        private System.Windows.Forms.Label f14_label6;
        private System.Windows.Forms.DataGridView f14_dataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart f14_chart;
        private System.Windows.Forms.CheckBox f14_check4;
        private System.Windows.Forms.CheckBox f14_check2;
        private System.Windows.Forms.CheckBox f14_check3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown f14_numMistake;
        private System.Windows.Forms.CheckBox f14_check5;
        private System.Windows.Forms.CheckBox f14_check1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Letter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Statistic;
        private System.Windows.Forms.Button f14_buttonExtended;
    }
}