
namespace str43_zad3
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
            this.startButton = new System.Windows.Forms.Button();
            this.tryButton = new System.Windows.Forms.Button();
            this.enterNumTextbox = new System.Windows.Forms.TextBox();
            this.enterNumLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.tryCountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.startButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.startButton.Location = new System.Drawing.Point(80, 26);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(141, 40);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Начало";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // tryButton
            // 
            this.tryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tryButton.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tryButton.Location = new System.Drawing.Point(80, 121);
            this.tryButton.Name = "tryButton";
            this.tryButton.Size = new System.Drawing.Size(141, 38);
            this.tryButton.TabIndex = 1;
            this.tryButton.Text = "Опит";
            this.tryButton.UseVisualStyleBackColor = false;
            this.tryButton.Click += new System.EventHandler(this.tryButton_Click);
            // 
            // enterNumTextbox
            // 
            this.enterNumTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.enterNumTextbox.Enabled = false;
            this.enterNumTextbox.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.enterNumTextbox.Location = new System.Drawing.Point(167, 82);
            this.enterNumTextbox.Name = "enterNumTextbox";
            this.enterNumTextbox.Size = new System.Drawing.Size(100, 26);
            this.enterNumTextbox.TabIndex = 4;
            // 
            // enterNumLabel
            // 
            this.enterNumLabel.AutoSize = true;
            this.enterNumLabel.BackColor = System.Drawing.Color.Snow;
            this.enterNumLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.enterNumLabel.Location = new System.Drawing.Point(46, 85);
            this.enterNumLabel.Name = "enterNumLabel";
            this.enterNumLabel.Size = new System.Drawing.Size(115, 18);
            this.enterNumLabel.TabIndex = 5;
            this.enterNumLabel.Text = "Въведи число:";
            this.enterNumLabel.Click += new System.EventHandler(this.enterNumLabel_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.BackColor = System.Drawing.Color.Snow;
            this.resultLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.resultLabel.Location = new System.Drawing.Point(78, 193);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(83, 18);
            this.resultLabel.TabIndex = 6;
            this.resultLabel.Text = "Отговор:";
            // 
            // tryCountLabel
            // 
            this.tryCountLabel.AutoSize = true;
            this.tryCountLabel.BackColor = System.Drawing.Color.Snow;
            this.tryCountLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tryCountLabel.Location = new System.Drawing.Point(80, 222);
            this.tryCountLabel.Name = "tryCountLabel";
            this.tryCountLabel.Size = new System.Drawing.Size(105, 18);
            this.tryCountLabel.TabIndex = 7;
            this.tryCountLabel.Text = "Брой опити:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(203, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(203, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "x";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(321, 290);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tryCountLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.enterNumLabel);
            this.Controls.Add(this.enterNumTextbox);
            this.Controls.Add(this.tryButton);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Guess The Number- The Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button tryButton;
        private System.Windows.Forms.TextBox enterNumTextbox;
        private System.Windows.Forms.Label enterNumLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label tryCountLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

