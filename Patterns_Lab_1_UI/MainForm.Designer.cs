namespace Patterns_Lab_1_UI
{
    partial class MainForm
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
            this.table = new System.Windows.Forms.DataGridView();
            this.openButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tranportComboBox = new System.Windows.Forms.ComboBox();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.fromTimePicker = new System.Windows.Forms.DateTimePicker();
            this.weekdaysСheckBox = new System.Windows.Forms.CheckBox();
            this.weekendCheckBox = new System.Windows.Forms.CheckBox();
            this.departurePointComboBox = new System.Windows.Forms.ComboBox();
            this.destinationComboBox = new System.Windows.Forms.ComboBox();
            this.NumberComboBox = new System.Windows.Forms.ComboBox();
            this.toTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.customTimePicker = new System.Windows.Forms.DateTimePicker();
            this.customDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customDateRadioButton = new System.Windows.Forms.RadioButton();
            this.currentDateRadioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.allRadioButton = new System.Windows.Forms.RadioButton();
            this.favouriteRadioButton = new System.Windows.Forms.RadioButton();
            this.clearFavouriteButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ApplyFiltersButton = new System.Windows.Forms.Button();
            this.clearFiltersButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(12, 12);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersVisible = false;
            this.table.Size = new System.Drawing.Size(858, 469);
            this.table.TabIndex = 0;
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(890, 12);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(91, 23);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "Открыть";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Xml|*.xml";
            // 
            // tranportComboBox
            // 
            this.tranportComboBox.FormattingEnabled = true;
            this.tranportComboBox.Items.AddRange(new object[] {
            "Bus",
            "Train"});
            this.tranportComboBox.Location = new System.Drawing.Point(890, 62);
            this.tranportComboBox.Name = "tranportComboBox";
            this.tranportComboBox.Size = new System.Drawing.Size(91, 21);
            this.tranportComboBox.TabIndex = 2;
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.CustomFormat = "dd.MM.yyyy HH.mm";
            this.fromDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDatePicker.Location = new System.Drawing.Point(11, 19);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(123, 20);
            this.fromDatePicker.TabIndex = 3;
            // 
            // fromTimePicker
            // 
            this.fromTimePicker.CustomFormat = "HH:mm";
            this.fromTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromTimePicker.Location = new System.Drawing.Point(140, 19);
            this.fromTimePicker.Name = "fromTimePicker";
            this.fromTimePicker.ShowUpDown = true;
            this.fromTimePicker.Size = new System.Drawing.Size(52, 20);
            this.fromTimePicker.TabIndex = 4;
            // 
            // weekdaysСheckBox
            // 
            this.weekdaysСheckBox.AutoSize = true;
            this.weekdaysСheckBox.Checked = true;
            this.weekdaysСheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.weekdaysСheckBox.Location = new System.Drawing.Point(11, 79);
            this.weekdaysСheckBox.Name = "weekdaysСheckBox";
            this.weekdaysСheckBox.Size = new System.Drawing.Size(62, 17);
            this.weekdaysСheckBox.TabIndex = 5;
            this.weekdaysСheckBox.Text = "Будние";
            this.weekdaysСheckBox.UseVisualStyleBackColor = true;
            // 
            // weekendCheckBox
            // 
            this.weekendCheckBox.AutoSize = true;
            this.weekendCheckBox.Checked = true;
            this.weekendCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.weekendCheckBox.Location = new System.Drawing.Point(112, 79);
            this.weekendCheckBox.Name = "weekendCheckBox";
            this.weekendCheckBox.Size = new System.Drawing.Size(78, 17);
            this.weekendCheckBox.TabIndex = 6;
            this.weekendCheckBox.Text = "Выходные";
            this.weekendCheckBox.UseVisualStyleBackColor = true;
            // 
            // departurePointComboBox
            // 
            this.departurePointComboBox.FormattingEnabled = true;
            this.departurePointComboBox.Location = new System.Drawing.Point(71, 15);
            this.departurePointComboBox.Name = "departurePointComboBox";
            this.departurePointComboBox.Size = new System.Drawing.Size(121, 21);
            this.departurePointComboBox.TabIndex = 7;
            // 
            // destinationComboBox
            // 
            this.destinationComboBox.FormattingEnabled = true;
            this.destinationComboBox.Location = new System.Drawing.Point(71, 42);
            this.destinationComboBox.Name = "destinationComboBox";
            this.destinationComboBox.Size = new System.Drawing.Size(121, 21);
            this.destinationComboBox.TabIndex = 8;
            // 
            // NumberComboBox
            // 
            this.NumberComboBox.FormattingEnabled = true;
            this.NumberComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.NumberComboBox.Location = new System.Drawing.Point(8, 108);
            this.NumberComboBox.Name = "NumberComboBox";
            this.NumberComboBox.Size = new System.Drawing.Size(121, 21);
            this.NumberComboBox.TabIndex = 10;
            // 
            // toTimePicker
            // 
            this.toTimePicker.CustomFormat = "HH:mm";
            this.toTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toTimePicker.Location = new System.Drawing.Point(140, 53);
            this.toTimePicker.Name = "toTimePicker";
            this.toTimePicker.ShowUpDown = true;
            this.toTimePicker.Size = new System.Drawing.Size(52, 20);
            this.toTimePicker.TabIndex = 12;
            // 
            // toDatePicker
            // 
            this.toDatePicker.CustomFormat = "dd.MM.yyyy HH.mm";
            this.toDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDatePicker.Location = new System.Drawing.Point(11, 53);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(123, 20);
            this.toDatePicker.TabIndex = 11;
            // 
            // customTimePicker
            // 
            this.customTimePicker.CustomFormat = "HH:mm";
            this.customTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.customTimePicker.Location = new System.Drawing.Point(137, 45);
            this.customTimePicker.Name = "customTimePicker";
            this.customTimePicker.ShowUpDown = true;
            this.customTimePicker.Size = new System.Drawing.Size(52, 20);
            this.customTimePicker.TabIndex = 14;
            // 
            // customDatePicker
            // 
            this.customDatePicker.CustomFormat = "dd.MM.yyyy HH.mm";
            this.customDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.customDatePicker.Location = new System.Drawing.Point(8, 45);
            this.customDatePicker.Name = "customDatePicker";
            this.customDatePicker.Size = new System.Drawing.Size(123, 20);
            this.customDatePicker.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(888, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Транспорт";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toTimePicker);
            this.groupBox1.Controls.Add(this.toDatePicker);
            this.groupBox1.Controls.Add(this.fromTimePicker);
            this.groupBox1.Controls.Add(this.fromDatePicker);
            this.groupBox1.Controls.Add(this.weekdaysСheckBox);
            this.groupBox1.Controls.Add(this.weekendCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(883, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 105);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор временного интервала";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.destinationComboBox);
            this.groupBox2.Controls.Add(this.departurePointComboBox);
            this.groupBox2.Location = new System.Drawing.Point(884, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 71);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выбор пунктов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Куда";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Откуда";
            // 
            // customDateRadioButton
            // 
            this.customDateRadioButton.AutoSize = true;
            this.customDateRadioButton.Location = new System.Drawing.Point(13, 22);
            this.customDateRadioButton.Name = "customDateRadioButton";
            this.customDateRadioButton.Size = new System.Drawing.Size(100, 17);
            this.customDateRadioButton.TabIndex = 18;
            this.customDateRadioButton.Text = "Заданная дата";
            this.customDateRadioButton.UseVisualStyleBackColor = true;
            // 
            // currentDateRadioButton
            // 
            this.currentDateRadioButton.AutoSize = true;
            this.currentDateRadioButton.Checked = true;
            this.currentDateRadioButton.Location = new System.Drawing.Point(13, 71);
            this.currentDateRadioButton.Name = "currentDateRadioButton";
            this.currentDateRadioButton.Size = new System.Drawing.Size(105, 17);
            this.currentDateRadioButton.TabIndex = 19;
            this.currentDateRadioButton.TabStop = true;
            this.currentDateRadioButton.Text = "Текущее время";
            this.currentDateRadioButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Количество рейсов";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.currentDateRadioButton);
            this.groupBox3.Controls.Add(this.customDateRadioButton);
            this.groupBox3.Controls.Add(this.customTimePicker);
            this.groupBox3.Controls.Add(this.customDatePicker);
            this.groupBox3.Controls.Add(this.NumberComboBox);
            this.groupBox3.Location = new System.Drawing.Point(886, 314);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(203, 142);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Выбор ближайших рейсов";
            // 
            // allRadioButton
            // 
            this.allRadioButton.AutoSize = true;
            this.allRadioButton.Checked = true;
            this.allRadioButton.Location = new System.Drawing.Point(12, 24);
            this.allRadioButton.Name = "allRadioButton";
            this.allRadioButton.Size = new System.Drawing.Size(44, 17);
            this.allRadioButton.TabIndex = 22;
            this.allRadioButton.TabStop = true;
            this.allRadioButton.Text = "Все";
            this.allRadioButton.UseVisualStyleBackColor = true;
            // 
            // favouriteRadioButton
            // 
            this.favouriteRadioButton.AutoSize = true;
            this.favouriteRadioButton.Location = new System.Drawing.Point(12, 47);
            this.favouriteRadioButton.Name = "favouriteRadioButton";
            this.favouriteRadioButton.Size = new System.Drawing.Size(84, 17);
            this.favouriteRadioButton.TabIndex = 23;
            this.favouriteRadioButton.Text = "Выбранные";
            this.favouriteRadioButton.UseVisualStyleBackColor = true;
            // 
            // clearFavouriteButton
            // 
            this.clearFavouriteButton.Location = new System.Drawing.Point(12, 70);
            this.clearFavouriteButton.Name = "clearFavouriteButton";
            this.clearFavouriteButton.Size = new System.Drawing.Size(75, 23);
            this.clearFavouriteButton.TabIndex = 24;
            this.clearFavouriteButton.Text = "Очистить";
            this.clearFavouriteButton.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.clearFavouriteButton);
            this.groupBox4.Controls.Add(this.favouriteRadioButton);
            this.groupBox4.Controls.Add(this.allRadioButton);
            this.groupBox4.Location = new System.Drawing.Point(987, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(102, 104);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Отображение";
            // 
            // ApplyFiltersButton
            // 
            this.ApplyFiltersButton.Location = new System.Drawing.Point(894, 462);
            this.ApplyFiltersButton.Name = "ApplyFiltersButton";
            this.ApplyFiltersButton.Size = new System.Drawing.Size(87, 23);
            this.ApplyFiltersButton.TabIndex = 26;
            this.ApplyFiltersButton.Text = "Прменить";
            this.ApplyFiltersButton.UseVisualStyleBackColor = true;
            this.ApplyFiltersButton.Click += new System.EventHandler(this.ApplyFiltersButton_Click);
            // 
            // clearFiltersButton
            // 
            this.clearFiltersButton.Location = new System.Drawing.Point(989, 462);
            this.clearFiltersButton.Name = "clearFiltersButton";
            this.clearFiltersButton.Size = new System.Drawing.Size(87, 23);
            this.clearFiltersButton.TabIndex = 27;
            this.clearFiltersButton.Text = "Очистить фильтры";
            this.clearFiltersButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 493);
            this.Controls.Add(this.clearFiltersButton);
            this.Controls.Add(this.ApplyFiltersButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tranportComboBox);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.table);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ComboBox tranportComboBox;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.DateTimePicker fromTimePicker;
        private System.Windows.Forms.CheckBox weekdaysСheckBox;
        private System.Windows.Forms.CheckBox weekendCheckBox;
        private System.Windows.Forms.ComboBox departurePointComboBox;
        private System.Windows.Forms.ComboBox destinationComboBox;
        private System.Windows.Forms.ComboBox NumberComboBox;
        private System.Windows.Forms.DateTimePicker toTimePicker;
        private System.Windows.Forms.DateTimePicker toDatePicker;
        private System.Windows.Forms.DateTimePicker customTimePicker;
        private System.Windows.Forms.DateTimePicker customDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton customDateRadioButton;
        private System.Windows.Forms.RadioButton currentDateRadioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton allRadioButton;
        private System.Windows.Forms.RadioButton favouriteRadioButton;
        private System.Windows.Forms.Button clearFavouriteButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button ApplyFiltersButton;
        private System.Windows.Forms.Button clearFiltersButton;
    }
}

