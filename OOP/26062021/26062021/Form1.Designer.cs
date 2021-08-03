
namespace _26062021
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
            this.CalcButton = new System.Windows.Forms.Button();
            this.MLabel = new System.Windows.Forms.Label();
            this.NLabel = new System.Windows.Forms.Label();
            this.MTextbox = new System.Windows.Forms.TextBox();
            this.NTextbox = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.PowRadioButton = new System.Windows.Forms.RadioButton();
            this.FactorielRadioButton = new System.Windows.Forms.RadioButton();
            this.BinomRadioButton = new System.Windows.Forms.RadioButton();
            this.VariaciiRadioButton = new System.Windows.Forms.RadioButton();
            this.CombWithoutRadioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.CombWithRadioButton = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CalcButton
            // 
            this.CalcButton.BackColor = System.Drawing.Color.SandyBrown;
            this.CalcButton.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.CalcButton.Location = new System.Drawing.Point(86, 321);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(106, 37);
            this.CalcButton.TabIndex = 0;
            this.CalcButton.Text = "Пресметни";
            this.CalcButton.UseVisualStyleBackColor = false;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // MLabel
            // 
            this.MLabel.AutoSize = true;
            this.MLabel.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.MLabel.Location = new System.Drawing.Point(86, 205);
            this.MLabel.Name = "MLabel";
            this.MLabel.Size = new System.Drawing.Size(0, 18);
            this.MLabel.TabIndex = 1;
            // 
            // NLabel
            // 
            this.NLabel.AutoSize = true;
            this.NLabel.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.NLabel.Location = new System.Drawing.Point(86, 245);
            this.NLabel.Name = "NLabel";
            this.NLabel.Size = new System.Drawing.Size(0, 18);
            this.NLabel.TabIndex = 2;
            this.NLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // MTextbox
            // 
            this.MTextbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MTextbox.Enabled = false;
            this.MTextbox.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.MTextbox.Location = new System.Drawing.Point(143, 205);
            this.MTextbox.Name = "MTextbox";
            this.MTextbox.Size = new System.Drawing.Size(100, 25);
            this.MTextbox.TabIndex = 3;
            // 
            // NTextbox
            // 
            this.NTextbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NTextbox.Enabled = false;
            this.NTextbox.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.NTextbox.Location = new System.Drawing.Point(143, 242);
            this.NTextbox.Name = "NTextbox";
            this.NTextbox.Size = new System.Drawing.Size(100, 25);
            this.NTextbox.TabIndex = 4;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ResultLabel.Location = new System.Drawing.Point(192, 284);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(95, 18);
            this.ResultLabel.TabIndex = 5;
            this.ResultLabel.Text = "Резултат: ";
            this.ResultLabel.Visible = false;
            // 
            // PowRadioButton
            // 
            this.PowRadioButton.AutoSize = true;
            this.PowRadioButton.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.PowRadioButton.Location = new System.Drawing.Point(61, 49);
            this.PowRadioButton.Name = "PowRadioButton";
            this.PowRadioButton.Size = new System.Drawing.Size(82, 22);
            this.PowRadioButton.TabIndex = 6;
            this.PowRadioButton.TabStop = true;
            this.PowRadioButton.Text = "Степен";
            this.PowRadioButton.UseVisualStyleBackColor = true;
            this.PowRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // FactorielRadioButton
            // 
            this.FactorielRadioButton.AutoSize = true;
            this.FactorielRadioButton.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.FactorielRadioButton.Location = new System.Drawing.Point(61, 73);
            this.FactorielRadioButton.Name = "FactorielRadioButton";
            this.FactorielRadioButton.Size = new System.Drawing.Size(110, 22);
            this.FactorielRadioButton.TabIndex = 7;
            this.FactorielRadioButton.TabStop = true;
            this.FactorielRadioButton.Text = "Факториел";
            this.FactorielRadioButton.UseVisualStyleBackColor = true;
            this.FactorielRadioButton.CheckedChanged += new System.EventHandler(this.FactorielRadioButton_CheckedChanged);
            // 
            // BinomRadioButton
            // 
            this.BinomRadioButton.AutoSize = true;
            this.BinomRadioButton.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.BinomRadioButton.Location = new System.Drawing.Point(61, 97);
            this.BinomRadioButton.Name = "BinomRadioButton";
            this.BinomRadioButton.Size = new System.Drawing.Size(131, 22);
            this.BinomRadioButton.TabIndex = 8;
            this.BinomRadioButton.TabStop = true;
            this.BinomRadioButton.Text = "Биномен коеф.";
            this.BinomRadioButton.UseVisualStyleBackColor = true;
            this.BinomRadioButton.CheckedChanged += new System.EventHandler(this.BinomRadioButton_CheckedChanged);
            // 
            // VariaciiRadioButton
            // 
            this.VariaciiRadioButton.AutoSize = true;
            this.VariaciiRadioButton.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.VariaciiRadioButton.Location = new System.Drawing.Point(61, 121);
            this.VariaciiRadioButton.Name = "VariaciiRadioButton";
            this.VariaciiRadioButton.Size = new System.Drawing.Size(96, 22);
            this.VariaciiRadioButton.TabIndex = 9;
            this.VariaciiRadioButton.TabStop = true;
            this.VariaciiRadioButton.Text = "Вариации";
            this.VariaciiRadioButton.UseVisualStyleBackColor = true;
            this.VariaciiRadioButton.CheckedChanged += new System.EventHandler(this.VariaciiRadioButton_CheckedChanged);
            // 
            // CombWithoutRadioButton
            // 
            this.CombWithoutRadioButton.AutoSize = true;
            this.CombWithoutRadioButton.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.CombWithoutRadioButton.Location = new System.Drawing.Point(61, 143);
            this.CombWithoutRadioButton.Name = "CombWithoutRadioButton";
            this.CombWithoutRadioButton.Size = new System.Drawing.Size(226, 22);
            this.CombWithoutRadioButton.TabIndex = 10;
            this.CombWithoutRadioButton.TabStop = true;
            this.CombWithoutRadioButton.Text = "Комбинации без повтаряне";
            this.CombWithoutRadioButton.UseVisualStyleBackColor = true;
            this.CombWithoutRadioButton.CheckedChanged += new System.EventHandler(this.CombWithoutRadioButton_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(44, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Избери операция:";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.SandyBrown;
            this.ExitButton.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.Location = new System.Drawing.Point(404, 321);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(90, 37);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "Изход";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CombWithRadioButton
            // 
            this.CombWithRadioButton.AutoSize = true;
            this.CombWithRadioButton.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.CombWithRadioButton.Location = new System.Drawing.Point(61, 168);
            this.CombWithRadioButton.Name = "CombWithRadioButton";
            this.CombWithRadioButton.Size = new System.Drawing.Size(211, 22);
            this.CombWithRadioButton.TabIndex = 13;
            this.CombWithRadioButton.TabStop = true;
            this.CombWithRadioButton.Text = "Комбинации с повтаряне";
            this.CombWithRadioButton.UseVisualStyleBackColor = true;
            this.CombWithRadioButton.CheckedChanged += new System.EventHandler(this.CombWithRadioButton_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(329, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(539, 398);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CombWithRadioButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CombWithoutRadioButton);
            this.Controls.Add(this.VariaciiRadioButton);
            this.Controls.Add(this.BinomRadioButton);
            this.Controls.Add(this.FactorielRadioButton);
            this.Controls.Add(this.PowRadioButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.NTextbox);
            this.Controls.Add(this.MTextbox);
            this.Controls.Add(this.NLabel);
            this.Controls.Add(this.MLabel);
            this.Controls.Add(this.CalcButton);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Label MLabel;
        private System.Windows.Forms.Label NLabel;
        private System.Windows.Forms.TextBox EMTextbox;
        private System.Windows.Forms.TextBox NTextbox;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.RadioButton PowRadioButton;
        private System.Windows.Forms.RadioButton FactorielRadioButton;
        private System.Windows.Forms.RadioButton BinomRadioButton;
        private System.Windows.Forms.RadioButton VariaciiRadioButton;
        private System.Windows.Forms.RadioButton CombWithoutRadioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.RadioButton CombWithRadioButton;
        private System.Windows.Forms.TextBox MTextbox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

