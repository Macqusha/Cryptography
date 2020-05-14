namespace Labs
{
    partial class Form14_2
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
            this.f14_2_dataGridView = new System.Windows.Forms.DataGridView();
            this.Letter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Statistic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f14_2_label6 = new System.Windows.Forms.Label();
            this.f14_2_key3 = new System.Windows.Forms.TextBox();
            this.f14_2_key2 = new System.Windows.Forms.TextBox();
            this.f14_2_key1 = new System.Windows.Forms.TextBox();
            this.f14_buttonCountKey = new System.Windows.Forms.Button();
            this.f14_2_ButtonSaveOriginal = new System.Windows.Forms.Label();
            this.f14_2_ButtonClearOriginal = new System.Windows.Forms.Label();
            this.f14_2_label4 = new System.Windows.Forms.Label();
            this.f14_2_fieldOriginal = new System.Windows.Forms.TextBox();
            this.f14_2_ButtonReadCiphertext = new System.Windows.Forms.Label();
            this.f14_2_ButtonClearCiphertext = new System.Windows.Forms.Label();
            this.f14_2_label2 = new System.Windows.Forms.Label();
            this.f14_2_fieldCiphertext = new System.Windows.Forms.TextBox();
            this.f14_2_label1 = new System.Windows.Forms.Label();
            this.f14_2_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.f14_2_useKey1 = new System.Windows.Forms.Button();
            this.f14_2_useKey2 = new System.Windows.Forms.Button();
            this.f14_2_useKey3 = new System.Windows.Forms.Button();
            this.f14_2_fieldKey = new System.Windows.Forms.TextBox();
            this.f14_2_alf = new System.Windows.Forms.TextBox();
            this.f14_2_alf2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.f14_2_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f14_2_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // f14_2_dataGridView
            // 
            this.f14_2_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.f14_2_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.f14_2_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Letter,
            this.Amount,
            this.Frequency,
            this.Statistic});
            this.f14_2_dataGridView.Location = new System.Drawing.Point(354, 185);
            this.f14_2_dataGridView.Name = "f14_2_dataGridView";
            this.f14_2_dataGridView.RowTemplate.Height = 24;
            this.f14_2_dataGridView.Size = new System.Drawing.Size(479, 109);
            this.f14_2_dataGridView.TabIndex = 74;
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
            // f14_2_label6
            // 
            this.f14_2_label6.AutoSize = true;
            this.f14_2_label6.Location = new System.Drawing.Point(357, 161);
            this.f14_2_label6.Name = "f14_2_label6";
            this.f14_2_label6.Size = new System.Drawing.Size(358, 17);
            this.f14_2_label6.TabIndex = 59;
            this.f14_2_label6.Text = "Частота встречаемости символов в исходном тексте";
            // 
            // f14_2_key3
            // 
            this.f14_2_key3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.f14_2_key3.Location = new System.Drawing.Point(359, 136);
            this.f14_2_key3.Name = "f14_2_key3";
            this.f14_2_key3.ReadOnly = true;
            this.f14_2_key3.Size = new System.Drawing.Size(290, 22);
            this.f14_2_key3.TabIndex = 9;
            // 
            // f14_2_key2
            // 
            this.f14_2_key2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.f14_2_key2.Location = new System.Drawing.Point(359, 108);
            this.f14_2_key2.Name = "f14_2_key2";
            this.f14_2_key2.ReadOnly = true;
            this.f14_2_key2.Size = new System.Drawing.Size(290, 22);
            this.f14_2_key2.TabIndex = 7;
            // 
            // f14_2_key1
            // 
            this.f14_2_key1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.f14_2_key1.Location = new System.Drawing.Point(359, 82);
            this.f14_2_key1.Name = "f14_2_key1";
            this.f14_2_key1.ReadOnly = true;
            this.f14_2_key1.Size = new System.Drawing.Size(290, 22);
            this.f14_2_key1.TabIndex = 5;
            // 
            // f14_buttonCountKey
            // 
            this.f14_buttonCountKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.f14_buttonCountKey.Location = new System.Drawing.Point(736, 18);
            this.f14_buttonCountKey.Name = "f14_buttonCountKey";
            this.f14_buttonCountKey.Size = new System.Drawing.Size(97, 23);
            this.f14_buttonCountKey.TabIndex = 4;
            this.f14_buttonCountKey.Text = "Расчёт";
            this.f14_buttonCountKey.UseVisualStyleBackColor = true;
            this.f14_buttonCountKey.Click += new System.EventHandler(this.f14_buttonCountKey_Click);
            // 
            // f14_2_ButtonSaveOriginal
            // 
            this.f14_2_ButtonSaveOriginal.AutoSize = true;
            this.f14_2_ButtonSaveOriginal.ForeColor = System.Drawing.Color.Gray;
            this.f14_2_ButtonSaveOriginal.Location = new System.Drawing.Point(187, 270);
            this.f14_2_ButtonSaveOriginal.Name = "f14_2_ButtonSaveOriginal";
            this.f14_2_ButtonSaveOriginal.Size = new System.Drawing.Size(77, 17);
            this.f14_2_ButtonSaveOriginal.TabIndex = 72;
            this.f14_2_ButtonSaveOriginal.Text = "Сохранить";
            this.f14_2_ButtonSaveOriginal.Click += new System.EventHandler(this.f14_2_ButtonSaveOriginal_Click);
            // 
            // f14_2_ButtonClearOriginal
            // 
            this.f14_2_ButtonClearOriginal.AutoSize = true;
            this.f14_2_ButtonClearOriginal.ForeColor = System.Drawing.Color.Gray;
            this.f14_2_ButtonClearOriginal.Location = new System.Drawing.Point(263, 270);
            this.f14_2_ButtonClearOriginal.Name = "f14_2_ButtonClearOriginal";
            this.f14_2_ButtonClearOriginal.Size = new System.Drawing.Size(71, 17);
            this.f14_2_ButtonClearOriginal.TabIndex = 71;
            this.f14_2_ButtonClearOriginal.Text = "Очистить";
            this.f14_2_ButtonClearOriginal.Click += new System.EventHandler(this.f14_2_ButtonClearOriginal_Click);
            // 
            // f14_2_label4
            // 
            this.f14_2_label4.AutoSize = true;
            this.f14_2_label4.Location = new System.Drawing.Point(15, 266);
            this.f14_2_label4.Name = "f14_2_label4";
            this.f14_2_label4.Size = new System.Drawing.Size(113, 17);
            this.f14_2_label4.TabIndex = 70;
            this.f14_2_label4.Text = "Исходный текст";
            // 
            // f14_2_fieldOriginal
            // 
            this.f14_2_fieldOriginal.Location = new System.Drawing.Point(15, 289);
            this.f14_2_fieldOriginal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f14_2_fieldOriginal.Multiline = true;
            this.f14_2_fieldOriginal.Name = "f14_2_fieldOriginal";
            this.f14_2_fieldOriginal.ReadOnly = true;
            this.f14_2_fieldOriginal.Size = new System.Drawing.Size(320, 140);
            this.f14_2_fieldOriginal.TabIndex = 3;
            this.f14_2_fieldOriginal.TextChanged += new System.EventHandler(this.f14_2_fieldOriginal_TextChanged);
            // 
            // f14_2_ButtonReadCiphertext
            // 
            this.f14_2_ButtonReadCiphertext.AutoSize = true;
            this.f14_2_ButtonReadCiphertext.ForeColor = System.Drawing.Color.Gray;
            this.f14_2_ButtonReadCiphertext.Location = new System.Drawing.Point(199, 55);
            this.f14_2_ButtonReadCiphertext.Name = "f14_2_ButtonReadCiphertext";
            this.f14_2_ButtonReadCiphertext.Size = new System.Drawing.Size(62, 17);
            this.f14_2_ButtonReadCiphertext.TabIndex = 69;
            this.f14_2_ButtonReadCiphertext.Text = "Считать";
            this.f14_2_ButtonReadCiphertext.Click += new System.EventHandler(this.f14_2_ButtonReadCiphertext_Click);
            // 
            // f14_2_ButtonClearCiphertext
            // 
            this.f14_2_ButtonClearCiphertext.AutoSize = true;
            this.f14_2_ButtonClearCiphertext.ForeColor = System.Drawing.Color.Gray;
            this.f14_2_ButtonClearCiphertext.Location = new System.Drawing.Point(261, 55);
            this.f14_2_ButtonClearCiphertext.Name = "f14_2_ButtonClearCiphertext";
            this.f14_2_ButtonClearCiphertext.Size = new System.Drawing.Size(71, 17);
            this.f14_2_ButtonClearCiphertext.TabIndex = 68;
            this.f14_2_ButtonClearCiphertext.Text = "Очистить";
            this.f14_2_ButtonClearCiphertext.Click += new System.EventHandler(this.f14_2_ButtonClearCiphertext_Click);
            // 
            // f14_2_label2
            // 
            this.f14_2_label2.AutoSize = true;
            this.f14_2_label2.Location = new System.Drawing.Point(12, 50);
            this.f14_2_label2.Name = "f14_2_label2";
            this.f14_2_label2.Size = new System.Drawing.Size(82, 17);
            this.f14_2_label2.TabIndex = 67;
            this.f14_2_label2.Text = "Шифртекст";
            // 
            // f14_2_fieldCiphertext
            // 
            this.f14_2_fieldCiphertext.Location = new System.Drawing.Point(15, 74);
            this.f14_2_fieldCiphertext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f14_2_fieldCiphertext.Multiline = true;
            this.f14_2_fieldCiphertext.Name = "f14_2_fieldCiphertext";
            this.f14_2_fieldCiphertext.Size = new System.Drawing.Size(320, 140);
            this.f14_2_fieldCiphertext.TabIndex = 1;
            this.f14_2_fieldCiphertext.TextChanged += new System.EventHandler(this.f14_2_fieldCiphertext_TextChanged);
            // 
            // f14_2_label1
            // 
            this.f14_2_label1.AutoSize = true;
            this.f14_2_label1.Location = new System.Drawing.Point(303, 24);
            this.f14_2_label1.Name = "f14_2_label1";
            this.f14_2_label1.Size = new System.Drawing.Size(273, 17);
            this.f14_2_label1.TabIndex = 63;
            this.f14_2_label1.Text = "Расширенный частотный криптоанализ";
            // 
            // f14_2_chart
            // 
            this.f14_2_chart.BackColor = System.Drawing.Color.Transparent;
            this.f14_2_chart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.f14_2_chart.ChartAreas.Add(chartArea1);
            this.f14_2_chart.Location = new System.Drawing.Point(316, 292);
            this.f14_2_chart.Name = "f14_2_chart";
            this.f14_2_chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Name = "Series1";
            this.f14_2_chart.Series.Add(series1);
            this.f14_2_chart.Size = new System.Drawing.Size(540, 148);
            this.f14_2_chart.TabIndex = 75;
            this.f14_2_chart.Text = "Chart";
            // 
            // f14_2_useKey1
            // 
            this.f14_2_useKey1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.f14_2_useKey1.Location = new System.Drawing.Point(655, 82);
            this.f14_2_useKey1.Name = "f14_2_useKey1";
            this.f14_2_useKey1.Size = new System.Drawing.Size(97, 23);
            this.f14_2_useKey1.TabIndex = 6;
            this.f14_2_useKey1.Text = "Применить";
            this.f14_2_useKey1.UseVisualStyleBackColor = true;
            this.f14_2_useKey1.Click += new System.EventHandler(this.f14_2_useKey1_Click);
            // 
            // f14_2_useKey2
            // 
            this.f14_2_useKey2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.f14_2_useKey2.Location = new System.Drawing.Point(655, 109);
            this.f14_2_useKey2.Name = "f14_2_useKey2";
            this.f14_2_useKey2.Size = new System.Drawing.Size(97, 23);
            this.f14_2_useKey2.TabIndex = 8;
            this.f14_2_useKey2.Text = "Применить";
            this.f14_2_useKey2.UseVisualStyleBackColor = true;
            this.f14_2_useKey2.Click += new System.EventHandler(this.f14_2_useKey2_Click);
            // 
            // f14_2_useKey3
            // 
            this.f14_2_useKey3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.f14_2_useKey3.Location = new System.Drawing.Point(655, 137);
            this.f14_2_useKey3.Name = "f14_2_useKey3";
            this.f14_2_useKey3.Size = new System.Drawing.Size(97, 23);
            this.f14_2_useKey3.TabIndex = 10;
            this.f14_2_useKey3.Text = "Применить";
            this.f14_2_useKey3.UseVisualStyleBackColor = true;
            this.f14_2_useKey3.Click += new System.EventHandler(this.f14_2_useKey3_Click);
            // 
            // f14_2_fieldKey
            // 
            this.f14_2_fieldKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.f14_2_fieldKey.Location = new System.Drawing.Point(22, 241);
            this.f14_2_fieldKey.Name = "f14_2_fieldKey";
            this.f14_2_fieldKey.Size = new System.Drawing.Size(290, 22);
            this.f14_2_fieldKey.TabIndex = 2;
            this.f14_2_fieldKey.TextChanged += new System.EventHandler(this.f14_2_fieldKey_TextChanged);
            // 
            // f14_2_alf
            // 
            this.f14_2_alf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.f14_2_alf.Location = new System.Drawing.Point(22, 219);
            this.f14_2_alf.Name = "f14_2_alf";
            this.f14_2_alf.ReadOnly = true;
            this.f14_2_alf.Size = new System.Drawing.Size(290, 22);
            this.f14_2_alf.TabIndex = 81;
            // 
            // f14_2_alf2
            // 
            this.f14_2_alf2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.f14_2_alf2.Location = new System.Drawing.Point(359, 55);
            this.f14_2_alf2.Name = "f14_2_alf2";
            this.f14_2_alf2.ReadOnly = true;
            this.f14_2_alf2.Size = new System.Drawing.Size(290, 22);
            this.f14_2_alf2.TabIndex = 82;
            // 
            // Form14_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 444);
            this.Controls.Add(this.f14_2_alf2);
            this.Controls.Add(this.f14_2_fieldKey);
            this.Controls.Add(this.f14_2_alf);
            this.Controls.Add(this.f14_2_useKey3);
            this.Controls.Add(this.f14_2_useKey2);
            this.Controls.Add(this.f14_2_useKey1);
            this.Controls.Add(this.f14_2_key3);
            this.Controls.Add(this.f14_2_dataGridView);
            this.Controls.Add(this.f14_2_key2);
            this.Controls.Add(this.f14_2_label6);
            this.Controls.Add(this.f14_2_key1);
            this.Controls.Add(this.f14_2_ButtonSaveOriginal);
            this.Controls.Add(this.f14_buttonCountKey);
            this.Controls.Add(this.f14_2_ButtonClearOriginal);
            this.Controls.Add(this.f14_2_label4);
            this.Controls.Add(this.f14_2_fieldOriginal);
            this.Controls.Add(this.f14_2_ButtonReadCiphertext);
            this.Controls.Add(this.f14_2_ButtonClearCiphertext);
            this.Controls.Add(this.f14_2_label2);
            this.Controls.Add(this.f14_2_fieldCiphertext);
            this.Controls.Add(this.f14_2_label1);
            this.Controls.Add(this.f14_2_chart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "Form14_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Расширенный частотный криптоанализ";
            ((System.ComponentModel.ISupportInitialize)(this.f14_2_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f14_2_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView f14_2_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Letter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Statistic;
        private System.Windows.Forms.Label f14_2_label6;
        private System.Windows.Forms.TextBox f14_2_key3;
        private System.Windows.Forms.TextBox f14_2_key2;
        private System.Windows.Forms.TextBox f14_2_key1;
        private System.Windows.Forms.Button f14_buttonCountKey;
        private System.Windows.Forms.Label f14_2_ButtonSaveOriginal;
        private System.Windows.Forms.Label f14_2_ButtonClearOriginal;
        private System.Windows.Forms.Label f14_2_label4;
        private System.Windows.Forms.TextBox f14_2_fieldOriginal;
        private System.Windows.Forms.Label f14_2_ButtonReadCiphertext;
        private System.Windows.Forms.Label f14_2_ButtonClearCiphertext;
        private System.Windows.Forms.Label f14_2_label2;
        private System.Windows.Forms.TextBox f14_2_fieldCiphertext;
        private System.Windows.Forms.Label f14_2_label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart f14_2_chart;
        private System.Windows.Forms.Button f14_2_useKey1;
        private System.Windows.Forms.Button f14_2_useKey2;
        private System.Windows.Forms.Button f14_2_useKey3;
        private System.Windows.Forms.TextBox f14_2_fieldKey;
        private System.Windows.Forms.TextBox f14_2_alf;
        private System.Windows.Forms.TextBox f14_2_alf2;
    }
}