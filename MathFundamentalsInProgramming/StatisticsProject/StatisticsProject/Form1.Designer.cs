namespace StatisticsProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.SortedOutput = new System.Windows.Forms.TextBox();
            this.AnalyseBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChNMV_TextBox = new System.Windows.Forms.TextBox();
            this.NMV_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NGV_TextBox = new System.Windows.Forms.TextBox();
            this.ChNGV_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AVG_TextBox = new System.Windows.Forms.TextBox();
            this.Moda_TextBox = new System.Windows.Forms.TextBox();
            this.Mediana_TextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SA0_TextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.SKO_TextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.Dispersia_TextBox = new System.Windows.Forms.TextBox();
            this.Obem_TextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputTextBox
            // 
            this.InputTextBox.BackColor = System.Drawing.Color.White;
            this.InputTextBox.Location = new System.Drawing.Point(12, 55);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(80, 330);
            this.InputTextBox.TabIndex = 0;
            this.InputTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SortedOutput
            // 
            this.SortedOutput.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.SortedOutput.Enabled = false;
            this.SortedOutput.Location = new System.Drawing.Point(153, 55);
            this.SortedOutput.Multiline = true;
            this.SortedOutput.Name = "SortedOutput";
            this.SortedOutput.Size = new System.Drawing.Size(80, 330);
            this.SortedOutput.TabIndex = 1;
            // 
            // AnalyseBtn
            // 
            this.AnalyseBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.AnalyseBtn.Location = new System.Drawing.Point(108, 55);
            this.AnalyseBtn.Name = "AnalyseBtn";
            this.AnalyseBtn.Size = new System.Drawing.Size(30, 330);
            this.AnalyseBtn.TabIndex = 2;
            this.AnalyseBtn.Text = "АНАЛИЗИРАЙ !";
            this.AnalyseBtn.UseVisualStyleBackColor = false;
            this.AnalyseBtn.Click += new System.EventHandler(this.AnalyseBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ChNMV_TextBox);
            this.panel1.Controls.Add(this.NMV_TextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(282, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 49);
            this.panel1.TabIndex = 3;
            // 
            // ChNMV_TextBox
            // 
            this.ChNMV_TextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ChNMV_TextBox.Enabled = false;
            this.ChNMV_TextBox.Location = new System.Drawing.Point(432, 11);
            this.ChNMV_TextBox.Name = "ChNMV_TextBox";
            this.ChNMV_TextBox.Size = new System.Drawing.Size(60, 27);
            this.ChNMV_TextBox.TabIndex = 4;
            // 
            // NMV_TextBox
            // 
            this.NMV_TextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.NMV_TextBox.Enabled = false;
            this.NMV_TextBox.Location = new System.Drawing.Point(191, 11);
            this.NMV_TextBox.Name = "NMV_TextBox";
            this.NMV_TextBox.Size = new System.Drawing.Size(60, 27);
            this.NMV_TextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(363, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Честота";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Най-малка варианта";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.NGV_TextBox);
            this.panel2.Controls.Add(this.ChNGV_TextBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(282, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 49);
            this.panel2.TabIndex = 4;
            // 
            // NGV_TextBox
            // 
            this.NGV_TextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.NGV_TextBox.Enabled = false;
            this.NGV_TextBox.Location = new System.Drawing.Point(191, 11);
            this.NGV_TextBox.Name = "NGV_TextBox";
            this.NGV_TextBox.Size = new System.Drawing.Size(60, 27);
            this.NGV_TextBox.TabIndex = 5;
            // 
            // ChNGV_TextBox
            // 
            this.ChNGV_TextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ChNGV_TextBox.Enabled = false;
            this.ChNGV_TextBox.Location = new System.Drawing.Point(432, 11);
            this.ChNGV_TextBox.Name = "ChNGV_TextBox";
            this.ChNGV_TextBox.Size = new System.Drawing.Size(60, 27);
            this.ChNGV_TextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(23, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Най-голяма варианта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(363, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Честота";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.AVG_TextBox);
            this.panel3.Controls.Add(this.Moda_TextBox);
            this.panel3.Controls.Add(this.Mediana_TextBox);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(282, 165);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(497, 49);
            this.panel3.TabIndex = 5;
            // 
            // AVG_TextBox
            // 
            this.AVG_TextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.AVG_TextBox.Enabled = false;
            this.AVG_TextBox.Location = new System.Drawing.Point(158, 11);
            this.AVG_TextBox.Name = "AVG_TextBox";
            this.AVG_TextBox.Size = new System.Drawing.Size(60, 27);
            this.AVG_TextBox.TabIndex = 6;
            // 
            // Moda_TextBox
            // 
            this.Moda_TextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Moda_TextBox.Enabled = false;
            this.Moda_TextBox.Location = new System.Drawing.Point(432, 11);
            this.Moda_TextBox.Name = "Moda_TextBox";
            this.Moda_TextBox.Size = new System.Drawing.Size(60, 27);
            this.Moda_TextBox.TabIndex = 5;
            // 
            // Mediana_TextBox
            // 
            this.Mediana_TextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Mediana_TextBox.Enabled = false;
            this.Mediana_TextBox.Location = new System.Drawing.Point(314, 11);
            this.Mediana_TextBox.Name = "Mediana_TextBox";
            this.Mediana_TextBox.Size = new System.Drawing.Size(60, 27);
            this.Mediana_TextBox.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label7.Location = new System.Drawing.Point(23, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Средна стойност";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.Location = new System.Drawing.Point(236, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Медиана";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Location = new System.Drawing.Point(380, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Мода";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.SA0_TextBox);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(282, 220);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(497, 49);
            this.panel4.TabIndex = 6;
            // 
            // SA0_TextBox
            // 
            this.SA0_TextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.SA0_TextBox.Enabled = false;
            this.SA0_TextBox.Location = new System.Drawing.Point(272, 12);
            this.SA0_TextBox.Name = "SA0_TextBox";
            this.SA0_TextBox.Size = new System.Drawing.Size(60, 27);
            this.SA0_TextBox.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label8.Location = new System.Drawing.Point(23, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(243, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Средно аритметично отклонение";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.SKO_TextBox);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(282, 275);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(497, 49);
            this.panel5.TabIndex = 7;
            // 
            // SKO_TextBox
            // 
            this.SKO_TextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.SKO_TextBox.Enabled = false;
            this.SKO_TextBox.Location = new System.Drawing.Point(272, 14);
            this.SKO_TextBox.Name = "SKO_TextBox";
            this.SKO_TextBox.Size = new System.Drawing.Size(60, 27);
            this.SKO_TextBox.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label9.Location = new System.Drawing.Point(23, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(240, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Средно квадратично отклонение";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.Dispersia_TextBox);
            this.panel6.Location = new System.Drawing.Point(282, 330);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(497, 49);
            this.panel6.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label10.Location = new System.Drawing.Point(23, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Дисперсия";
            // 
            // Dispersia_TextBox
            // 
            this.Dispersia_TextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Dispersia_TextBox.Enabled = false;
            this.Dispersia_TextBox.Location = new System.Drawing.Point(114, 10);
            this.Dispersia_TextBox.Name = "Dispersia_TextBox";
            this.Dispersia_TextBox.Size = new System.Drawing.Size(60, 27);
            this.Dispersia_TextBox.TabIndex = 10;
            // 
            // Obem_TextBox
            // 
            this.Obem_TextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Obem_TextBox.Enabled = false;
            this.Obem_TextBox.Location = new System.Drawing.Point(107, 403);
            this.Obem_TextBox.Name = "Obem_TextBox";
            this.Obem_TextBox.Size = new System.Drawing.Size(40, 27);
            this.Obem_TextBox.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label11.Location = new System.Drawing.Point(53, 406);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Обем";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(64, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 38);
            this.label12.TabIndex = 13;
            this.label12.Text = "Извадка";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Obem_TextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AnalyseBtn);
            this.Controls.Add(this.SortedOutput);
            this.Controls.Add(this.InputTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "СТАТИСТИЧЕСКИ ИЗЧИСЛЕНИЯ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox InputTextBox;
        private TextBox SortedOutput;
        private Button AnalyseBtn;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label3;
        private Label label1;
        private Label label4;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label8;
        private Label label9;
        private TextBox NMV_TextBox;
        private TextBox ChNMV_TextBox;
        private TextBox NGV_TextBox;
        private TextBox ChNGV_TextBox;
        private TextBox AVG_TextBox;
        private TextBox Moda_TextBox;
        private TextBox Mediana_TextBox;
        private TextBox SA0_TextBox;
        private TextBox SKO_TextBox;
        private Panel panel6;
        private Label label10;
        private TextBox Dispersia_TextBox;
        private TextBox Obem_TextBox;
        private Label label11;
        private Label label12;
    }
}