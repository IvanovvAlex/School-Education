
namespace BooksStoreForms
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_read = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.AuthorsRadioButton = new System.Windows.Forms.RadioButton();
            this.GenresRadioButton = new System.Windows.Forms.RadioButton();
            this.BooksRadioButton = new System.Windows.Forms.RadioButton();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_ISBN = new System.Windows.Forms.TextBox();
            this.txt_GenreID = new System.Windows.Forms.TextBox();
            this.label_ID_T = new System.Windows.Forms.Label();
            this.label_Name_T = new System.Windows.Forms.Label();
            this.label_ISBN_T = new System.Windows.Forms.Label();
            this.label_GenreID_T = new System.Windows.Forms.Label();
            this.label_GenreID_Optional = new System.Windows.Forms.Label();
            this.label_ISBN_Optional = new System.Windows.Forms.Label();
            this.label_Name_Optional = new System.Windows.Forms.Label();
            this.label_ID_Optional = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(317, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(719, 234);
            this.dataGridView1.TabIndex = 2;
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(253, 389);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 7;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(349, 389);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(75, 23);
            this.btn_read.TabIndex = 8;
            this.btn_read.Text = "Read";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(448, 389);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Choose table to work with:";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(756, 389);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 18;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(654, 389);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 17;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(549, 389);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 16;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // AuthorsRadioButton
            // 
            this.AuthorsRadioButton.AutoSize = true;
            this.AuthorsRadioButton.Location = new System.Drawing.Point(456, 7);
            this.AuthorsRadioButton.Name = "AuthorsRadioButton";
            this.AuthorsRadioButton.Size = new System.Drawing.Size(67, 19);
            this.AuthorsRadioButton.TabIndex = 24;
            this.AuthorsRadioButton.TabStop = true;
            this.AuthorsRadioButton.Text = "Authors";
            this.AuthorsRadioButton.UseVisualStyleBackColor = true;
            this.AuthorsRadioButton.CheckedChanged += new System.EventHandler(this.AuthorsRadioButton_CheckedChanged);
            // 
            // GenresRadioButton
            // 
            this.GenresRadioButton.AutoSize = true;
            this.GenresRadioButton.Location = new System.Drawing.Point(529, 7);
            this.GenresRadioButton.Name = "GenresRadioButton";
            this.GenresRadioButton.Size = new System.Drawing.Size(61, 19);
            this.GenresRadioButton.TabIndex = 25;
            this.GenresRadioButton.TabStop = true;
            this.GenresRadioButton.Text = "Genres";
            this.GenresRadioButton.UseVisualStyleBackColor = true;
            this.GenresRadioButton.CheckedChanged += new System.EventHandler(this.GenresRadioButton_CheckedChanged);
            // 
            // BooksRadioButton
            // 
            this.BooksRadioButton.AutoSize = true;
            this.BooksRadioButton.Location = new System.Drawing.Point(596, 7);
            this.BooksRadioButton.Name = "BooksRadioButton";
            this.BooksRadioButton.Size = new System.Drawing.Size(57, 19);
            this.BooksRadioButton.TabIndex = 26;
            this.BooksRadioButton.TabStop = true;
            this.BooksRadioButton.Text = "Books";
            this.BooksRadioButton.UseVisualStyleBackColor = true;
            this.BooksRadioButton.CheckedChanged += new System.EventHandler(this.BooksRadioButton_CheckedChanged);
            // 
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(78, 128);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 23);
            this.txt_ID.TabIndex = 28;
            this.txt_ID.TextChanged += new System.EventHandler(this.txt_ID_TextChanged);
            // 
            // txt_Name
            // 
            this.txt_Name.Enabled = false;
            this.txt_Name.Location = new System.Drawing.Point(78, 166);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 23);
            this.txt_Name.TabIndex = 29;
            this.txt_Name.Text = " ";
            // 
            // txt_ISBN
            // 
            this.txt_ISBN.Enabled = false;
            this.txt_ISBN.Location = new System.Drawing.Point(78, 204);
            this.txt_ISBN.Name = "txt_ISBN";
            this.txt_ISBN.Size = new System.Drawing.Size(100, 23);
            this.txt_ISBN.TabIndex = 30;
            // 
            // txt_GenreID
            // 
            this.txt_GenreID.Enabled = false;
            this.txt_GenreID.Location = new System.Drawing.Point(78, 242);
            this.txt_GenreID.Name = "txt_GenreID";
            this.txt_GenreID.Size = new System.Drawing.Size(100, 23);
            this.txt_GenreID.TabIndex = 31;
            // 
            // label_ID_T
            // 
            this.label_ID_T.AutoSize = true;
            this.label_ID_T.Location = new System.Drawing.Point(24, 131);
            this.label_ID_T.Name = "label_ID_T";
            this.label_ID_T.Size = new System.Drawing.Size(18, 15);
            this.label_ID_T.TabIndex = 33;
            this.label_ID_T.Text = "ID";
            this.label_ID_T.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_Name_T
            // 
            this.label_Name_T.AutoSize = true;
            this.label_Name_T.Location = new System.Drawing.Point(24, 169);
            this.label_Name_T.Name = "label_Name_T";
            this.label_Name_T.Size = new System.Drawing.Size(39, 15);
            this.label_Name_T.TabIndex = 34;
            this.label_Name_T.Text = "Name";
            // 
            // label_ISBN_T
            // 
            this.label_ISBN_T.AutoSize = true;
            this.label_ISBN_T.Location = new System.Drawing.Point(24, 207);
            this.label_ISBN_T.Name = "label_ISBN_T";
            this.label_ISBN_T.Size = new System.Drawing.Size(32, 15);
            this.label_ISBN_T.TabIndex = 35;
            this.label_ISBN_T.Text = "ISBN";
            // 
            // label_GenreID_T
            // 
            this.label_GenreID_T.AutoSize = true;
            this.label_GenreID_T.Location = new System.Drawing.Point(24, 245);
            this.label_GenreID_T.Name = "label_GenreID_T";
            this.label_GenreID_T.Size = new System.Drawing.Size(49, 15);
            this.label_GenreID_T.TabIndex = 36;
            this.label_GenreID_T.Text = "GenreID";
            // 
            // label_GenreID_Optional
            // 
            this.label_GenreID_Optional.AutoSize = true;
            this.label_GenreID_Optional.Location = new System.Drawing.Point(203, 245);
            this.label_GenreID_Optional.Name = "label_GenreID_Optional";
            this.label_GenreID_Optional.Size = new System.Drawing.Size(61, 15);
            this.label_GenreID_Optional.TabIndex = 40;
            this.label_GenreID_Optional.Text = "(Optional)";
            // 
            // label_ISBN_Optional
            // 
            this.label_ISBN_Optional.AutoSize = true;
            this.label_ISBN_Optional.Location = new System.Drawing.Point(203, 207);
            this.label_ISBN_Optional.Name = "label_ISBN_Optional";
            this.label_ISBN_Optional.Size = new System.Drawing.Size(61, 15);
            this.label_ISBN_Optional.TabIndex = 39;
            this.label_ISBN_Optional.Text = "(Optional)";
            // 
            // label_Name_Optional
            // 
            this.label_Name_Optional.AutoSize = true;
            this.label_Name_Optional.Location = new System.Drawing.Point(203, 169);
            this.label_Name_Optional.Name = "label_Name_Optional";
            this.label_Name_Optional.Size = new System.Drawing.Size(61, 15);
            this.label_Name_Optional.TabIndex = 38;
            this.label_Name_Optional.Text = "(Optional)";
            // 
            // label_ID_Optional
            // 
            this.label_ID_Optional.AutoSize = true;
            this.label_ID_Optional.Location = new System.Drawing.Point(203, 131);
            this.label_ID_Optional.Name = "label_ID_Optional";
            this.label_ID_Optional.Size = new System.Drawing.Size(61, 15);
            this.label_ID_Optional.TabIndex = 37;
            this.label_ID_Optional.Text = "(Optional)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 450);
            this.Controls.Add(this.label_GenreID_Optional);
            this.Controls.Add(this.label_ISBN_Optional);
            this.Controls.Add(this.label_Name_Optional);
            this.Controls.Add(this.label_ID_Optional);
            this.Controls.Add(this.label_GenreID_T);
            this.Controls.Add(this.label_ISBN_T);
            this.Controls.Add(this.label_Name_T);
            this.Controls.Add(this.label_ID_T);
            this.Controls.Add(this.txt_GenreID);
            this.Controls.Add(this.txt_ISBN);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.BooksRadioButton);
            this.Controls.Add(this.GenresRadioButton);
            this.Controls.Add(this.AuthorsRadioButton);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Book Store DB Operations";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.RadioButton AuthorsRadioButton;
        private System.Windows.Forms.RadioButton GenresRadioButton;
        private System.Windows.Forms.RadioButton BooksRadioButton;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_ISBN;
        private System.Windows.Forms.TextBox txt_GenreID;
        private System.Windows.Forms.Label label_ID_T;
        private System.Windows.Forms.Label label_Name_T;
        private System.Windows.Forms.Label label_ISBN_T;
        private System.Windows.Forms.Label label_GenreID_T;
        private System.Windows.Forms.Label label_GenreID_Optional;
        private System.Windows.Forms.Label label_ISBN_Optional;
        private System.Windows.Forms.Label label_Name_Optional;
        private System.Windows.Forms.Label label_ID_Optional;
        private System.Windows.Forms.Button btn_create;
    }
}

