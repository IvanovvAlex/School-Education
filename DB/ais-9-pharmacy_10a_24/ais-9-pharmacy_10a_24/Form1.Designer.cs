
namespace ais_9_pharmacy_10a_24
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
            this.AllDataGridView = new System.Windows.Forms.DataGridView();
            this.SampleDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NameТextBox = new System.Windows.Forms.TextBox();
            this.QuantityТextBox = new System.Windows.Forms.TextBox();
            this.PriceТextBox = new System.Windows.Forms.TextBox();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CleanButton = new System.Windows.Forms.Button();
            this.SearchByNameButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.ExpiredDateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.TheLastDateButton = new System.Windows.Forms.Button();
            this.MostExpensiveButton = new System.Windows.Forms.Button();
            this.SumAllButton = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AllDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SampleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AllDataGridView
            // 
            this.AllDataGridView.AllowUserToAddRows = false;
            this.AllDataGridView.AllowUserToDeleteRows = false;
            this.AllDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllDataGridView.Location = new System.Drawing.Point(91, 583);
            this.AllDataGridView.Name = "AllDataGridView";
            this.AllDataGridView.ReadOnly = true;
            this.AllDataGridView.RowHeadersWidth = 51;
            this.AllDataGridView.RowTemplate.Height = 29;
            this.AllDataGridView.Size = new System.Drawing.Size(821, 170);
            this.AllDataGridView.TabIndex = 0;
            // 
            // SampleDataGridView
            // 
            this.SampleDataGridView.AllowUserToAddRows = false;
            this.SampleDataGridView.AllowUserToDeleteRows = false;
            this.SampleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SampleDataGridView.Location = new System.Drawing.Point(91, 39);
            this.SampleDataGridView.Name = "SampleDataGridView";
            this.SampleDataGridView.ReadOnly = true;
            this.SampleDataGridView.RowHeadersWidth = 51;
            this.SampleDataGridView.RowTemplate.Height = 29;
            this.SampleDataGridView.Size = new System.Drawing.Size(821, 170);
            this.SampleDataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Извадка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 550);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Всички данни";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Име";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Тип";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Цена";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Количество";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Годност";
            // 
            // NameТextBox
            // 
            this.NameТextBox.Location = new System.Drawing.Point(216, 276);
            this.NameТextBox.Multiline = true;
            this.NameТextBox.Name = "NameТextBox";
            this.NameТextBox.Size = new System.Drawing.Size(190, 30);
            this.NameТextBox.TabIndex = 9;
            // 
            // QuantityТextBox
            // 
            this.QuantityТextBox.Location = new System.Drawing.Point(216, 386);
            this.QuantityТextBox.Multiline = true;
            this.QuantityТextBox.Name = "QuantityТextBox";
            this.QuantityТextBox.Size = new System.Drawing.Size(190, 30);
            this.QuantityТextBox.TabIndex = 10;
            // 
            // PriceТextBox
            // 
            this.PriceТextBox.Location = new System.Drawing.Point(216, 349);
            this.PriceТextBox.Multiline = true;
            this.PriceТextBox.Name = "PriceТextBox";
            this.PriceТextBox.Size = new System.Drawing.Size(190, 30);
            this.PriceТextBox.TabIndex = 11;
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "Таблетки",
            "Сироп",
            "Ампули",
            "Свещички"});
            this.TypeComboBox.Location = new System.Drawing.Point(216, 317);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(190, 28);
            this.TypeComboBox.TabIndex = 13;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(448, 281);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(100, 30);
            this.CreateButton.TabIndex = 14;
            this.CreateButton.Text = "Създай";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(216, 428);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(190, 27);
            this.DateTimePicker.TabIndex = 15;
            // 
            // CleanButton
            // 
            this.CleanButton.Location = new System.Drawing.Point(601, 391);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(100, 30);
            this.CleanButton.TabIndex = 16;
            this.CleanButton.Text = "Зачисти";
            this.CleanButton.UseVisualStyleBackColor = true;
            this.CleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // SearchByNameButton
            // 
            this.SearchByNameButton.Location = new System.Drawing.Point(574, 281);
            this.SearchByNameButton.Name = "SearchByNameButton";
            this.SearchByNameButton.Size = new System.Drawing.Size(150, 30);
            this.SearchByNameButton.TabIndex = 17;
            this.SearchByNameButton.Text = "Търси по име";
            this.SearchByNameButton.UseVisualStyleBackColor = true;
            this.SearchByNameButton.Click += new System.EventHandler(this.SearchByNameButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(448, 320);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(100, 30);
            this.EditButton.TabIndex = 18;
            this.EditButton.Text = "Промени";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // ExpiredDateButton
            // 
            this.ExpiredDateButton.Location = new System.Drawing.Point(574, 320);
            this.ExpiredDateButton.Name = "ExpiredDateButton";
            this.ExpiredDateButton.Size = new System.Drawing.Size(150, 30);
            this.ExpiredDateButton.TabIndex = 19;
            this.ExpiredDateButton.Text = "С изтекъл срок";
            this.ExpiredDateButton.UseVisualStyleBackColor = true;
            this.ExpiredDateButton.Click += new System.EventHandler(this.ExpiredDateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(448, 354);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(100, 30);
            this.DeleteButton.TabIndex = 20;
            this.DeleteButton.Text = "Изтриване";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // TheLastDateButton
            // 
            this.TheLastDateButton.Location = new System.Drawing.Point(756, 281);
            this.TheLastDateButton.Name = "TheLastDateButton";
            this.TheLastDateButton.Size = new System.Drawing.Size(220, 30);
            this.TheLastDateButton.TabIndex = 21;
            this.TheLastDateButton.Text = "С най-далечен срок";
            this.TheLastDateButton.UseVisualStyleBackColor = true;
            this.TheLastDateButton.Click += new System.EventHandler(this.TheLastDateButton_Click);
            // 
            // MostExpensiveButton
            // 
            this.MostExpensiveButton.Location = new System.Drawing.Point(756, 320);
            this.MostExpensiveButton.Name = "MostExpensiveButton";
            this.MostExpensiveButton.Size = new System.Drawing.Size(220, 30);
            this.MostExpensiveButton.TabIndex = 22;
            this.MostExpensiveButton.Text = "Най-скъпото с изтекъл срок";
            this.MostExpensiveButton.UseVisualStyleBackColor = true;
            this.MostExpensiveButton.Click += new System.EventHandler(this.MostExpensiveButton_Click);
            // 
            // SumAllButton
            // 
            this.SumAllButton.Location = new System.Drawing.Point(756, 354);
            this.SumAllButton.Name = "SumAllButton";
            this.SumAllButton.Size = new System.Drawing.Size(220, 30);
            this.SumAllButton.TabIndex = 23;
            this.SumAllButton.Text = "Изчисли всичко сумарно";
            this.SumAllButton.UseVisualStyleBackColor = true;
            this.SumAllButton.Click += new System.EventHandler(this.SumAllButton_Click);
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(574, 354);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(150, 30);
            this.SortButton.TabIndex = 24;
            this.SortButton.Text = "Сортирай";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(694, 550);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Тотал: ";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Enabled = false;
            this.TotalTextBox.Location = new System.Drawing.Point(755, 547);
            this.TotalTextBox.Multiline = true;
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(157, 30);
            this.TotalTextBox.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 765);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.SumAllButton);
            this.Controls.Add(this.MostExpensiveButton);
            this.Controls.Add(this.TheLastDateButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ExpiredDateButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.SearchByNameButton);
            this.Controls.Add(this.CleanButton);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.PriceТextBox);
            this.Controls.Add(this.QuantityТextBox);
            this.Controls.Add(this.NameТextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SampleDataGridView);
            this.Controls.Add(this.AllDataGridView);
            this.Name = "Form1";
            this.Text = "Аптека";
            this.Load += new System.EventHandler(this.Form1_LoadAsync);
            ((System.ComponentModel.ISupportInitialize)(this.AllDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SampleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AllDataGridView;
        private System.Windows.Forms.DataGridView SampleDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NameТextBox;
        private System.Windows.Forms.TextBox QuantityТextBox;
        private System.Windows.Forms.TextBox PriceТextBox;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Button CleanButton;
        private System.Windows.Forms.Button SearchByNameButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button ExpiredDateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button TheLastDateButton;
        private System.Windows.Forms.Button MostExpensiveButton;
        private System.Windows.Forms.Button SumAllButton;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TotalTextBox;
    }
}

