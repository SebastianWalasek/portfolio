namespace AlgorytmGenetycznyMaxFunkcji
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonStart = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.labelA = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.labelB = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.numericUpDown_ilsocPowtorzen = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDalej = new System.Windows.Forms.Button();
            this.chartWykres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxFunkcja = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ilsocPowtorzen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWykres)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(21, 21);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(21, 79);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(75, 23);
            this.button_Reset.TabIndex = 2;
            this.button_Reset.Text = "RESET";
            this.button_Reset.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.Location = new System.Drawing.Point(151, 45);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(448, 304);
            this.richTextBox.TabIndex = 3;
            this.richTextBox.Text = "";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(9, 140);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(23, 13);
            this.labelA.TabIndex = 4;
            this.labelA.Text = "A =";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(34, 137);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(62, 20);
            this.textBoxA.TabIndex = 5;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(9, 166);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(23, 13);
            this.labelB.TabIndex = 6;
            this.labelB.Text = "B =";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(34, 163);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(62, 20);
            this.textBoxB.TabIndex = 7;
            // 
            // numericUpDown_ilsocPowtorzen
            // 
            this.numericUpDown_ilsocPowtorzen.Location = new System.Drawing.Point(12, 263);
            this.numericUpDown_ilsocPowtorzen.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_ilsocPowtorzen.Name = "numericUpDown_ilsocPowtorzen";
            this.numericUpDown_ilsocPowtorzen.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_ilsocPowtorzen.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ilość powtórzeń:";
            // 
            // buttonDalej
            // 
            this.buttonDalej.Enabled = false;
            this.buttonDalej.Location = new System.Drawing.Point(21, 50);
            this.buttonDalej.Name = "buttonDalej";
            this.buttonDalej.Size = new System.Drawing.Size(75, 23);
            this.buttonDalej.TabIndex = 13;
            this.buttonDalej.Text = "DALEJ";
            this.buttonDalej.UseVisualStyleBackColor = true;
            this.buttonDalej.Click += new System.EventHandler(this.buttonDalej_Click);
            // 
            // chartWykres
            // 
            this.chartWykres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartWykres.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "ChartArea1";
            this.chartWykres.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.chartWykres.Legends.Add(legend1);
            this.chartWykres.Location = new System.Drawing.Point(12, 355);
            this.chartWykres.Name = "chartWykres";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Najlepszy osobnik iteracjii";
            this.chartWykres.Series.Add(series1);
            this.chartWykres.Size = new System.Drawing.Size(584, 170);
            this.chartWykres.TabIndex = 14;
            this.chartWykres.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(148, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "f(x) = ax^2 + b";
            // 
            // comboBoxFunkcja
            // 
            this.comboBoxFunkcja.FormattingEnabled = true;
            this.comboBoxFunkcja.Location = new System.Drawing.Point(285, 13);
            this.comboBoxFunkcja.Name = "comboBoxFunkcja";
            this.comboBoxFunkcja.Size = new System.Drawing.Size(311, 21);
            this.comboBoxFunkcja.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 542);
            this.Controls.Add(this.comboBoxFunkcja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chartWykres);
            this.Controls.Add(this.buttonDalej);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_ilsocPowtorzen);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Szukanie maksimum funkcji ";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ilsocPowtorzen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWykres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.NumericUpDown numericUpDown_ilsocPowtorzen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDalej;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWykres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxFunkcja;
    }
}

