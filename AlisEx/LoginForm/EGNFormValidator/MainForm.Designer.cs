
namespace EGNFormValidator
{
    partial class MainForm
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
            this.buttonValidateForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonValidateForm
            // 
            this.buttonValidateForm.Location = new System.Drawing.Point(198, 162);
            this.buttonValidateForm.Name = "buttonValidateForm";
            this.buttonValidateForm.Size = new System.Drawing.Size(94, 29);
            this.buttonValidateForm.TabIndex = 0;
            this.buttonValidateForm.Text = "Validator Form";
            this.buttonValidateForm.UseVisualStyleBackColor = true;
            this.buttonValidateForm.Click += new System.EventHandler(this.buttonValidateForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonValidateForm);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonValidateForm;
    }
}

