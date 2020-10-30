namespace AP
{
    partial class NewEvent
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
            this.Name_label = new System.Windows.Forms.Label();
            this.Desc_label = new System.Windows.Forms.Label();
            this.Emp_label = new System.Windows.Forms.Label();
            this.Date_label = new System.Windows.Forms.Label();
            this.Doc_label = new System.Windows.Forms.Label();
            this.Event_name = new System.Windows.Forms.TextBox();
            this.Event_description = new System.Windows.Forms.TextBox();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.employers = new System.Windows.Forms.ListBox();
            this.documents = new System.Windows.Forms.ListBox();
            this.Back_button = new System.Windows.Forms.Button();
            this.Done_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_label.Location = new System.Drawing.Point(26, 45);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(169, 19);
            this.Name_label.TabIndex = 0;
            this.Name_label.Text = "Название мероприятия:";
            // 
            // Desc_label
            // 
            this.Desc_label.AutoSize = true;
            this.Desc_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Desc_label.Location = new System.Drawing.Point(26, 88);
            this.Desc_label.Name = "Desc_label";
            this.Desc_label.Size = new System.Drawing.Size(135, 19);
            this.Desc_label.TabIndex = 0;
            this.Desc_label.Text = "Краткое описание:";
            // 
            // Emp_label
            // 
            this.Emp_label.AutoSize = true;
            this.Emp_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Emp_label.Location = new System.Drawing.Point(26, 127);
            this.Emp_label.Name = "Emp_label";
            this.Emp_label.Size = new System.Drawing.Size(106, 19);
            this.Emp_label.TabIndex = 0;
            this.Emp_label.Text = "Кто проводит:";
            // 
            // Date_label
            // 
            this.Date_label.AutoSize = true;
            this.Date_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date_label.Location = new System.Drawing.Point(26, 164);
            this.Date_label.Name = "Date_label";
            this.Date_label.Size = new System.Drawing.Size(128, 19);
            this.Date_label.TabIndex = 0;
            this.Date_label.Text = "Дата проведения:";
            // 
            // Doc_label
            // 
            this.Doc_label.AutoSize = true;
            this.Doc_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Doc_label.Location = new System.Drawing.Point(26, 198);
            this.Doc_label.Name = "Doc_label";
            this.Doc_label.Size = new System.Drawing.Size(224, 19);
            this.Doc_label.TabIndex = 0;
            this.Doc_label.Text = "Документация к ознакомлению:";
            // 
            // Event_name
            // 
            this.Event_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Event_name.Location = new System.Drawing.Point(257, 42);
            this.Event_name.Name = "Event_name";
            this.Event_name.Size = new System.Drawing.Size(227, 26);
            this.Event_name.TabIndex = 1;
            // 
            // Event_description
            // 
            this.Event_description.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Event_description.Location = new System.Drawing.Point(257, 85);
            this.Event_description.Name = "Event_description";
            this.Event_description.Size = new System.Drawing.Size(227, 26);
            this.Event_description.TabIndex = 1;
            // 
            // DatePicker
            // 
            this.DatePicker.CalendarFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DatePicker.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicker.Location = new System.Drawing.Point(257, 161);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(227, 22);
            this.DatePicker.TabIndex = 2;
            // 
            // employers
            // 
            this.employers.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employers.FormattingEnabled = true;
            this.employers.ItemHeight = 19;
            this.employers.Location = new System.Drawing.Point(257, 123);
            this.employers.Name = "employers";
            this.employers.Size = new System.Drawing.Size(227, 23);
            this.employers.TabIndex = 3;
            // 
            // documents
            // 
            this.documents.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.documents.FormattingEnabled = true;
            this.documents.ItemHeight = 19;
            this.documents.Location = new System.Drawing.Point(256, 198);
            this.documents.Name = "documents";
            this.documents.Size = new System.Drawing.Size(227, 23);
            this.documents.TabIndex = 3;
            // 
            // Back_button
            // 
            this.Back_button.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_button.Location = new System.Drawing.Point(268, 246);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(105, 29);
            this.Back_button.TabIndex = 4;
            this.Back_button.Text = "Назад";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Done_button
            // 
            this.Done_button.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Done_button.Location = new System.Drawing.Point(379, 246);
            this.Done_button.Name = "Done_button";
            this.Done_button.Size = new System.Drawing.Size(105, 29);
            this.Done_button.TabIndex = 4;
            this.Done_button.Text = "Готово";
            this.Done_button.UseVisualStyleBackColor = true;
            this.Done_button.Click += new System.EventHandler(this.Done_button_Click);
            // 
            // NewEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 287);
            this.Controls.Add(this.Done_button);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.documents);
            this.Controls.Add(this.employers);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.Event_description);
            this.Controls.Add(this.Event_name);
            this.Controls.Add(this.Doc_label);
            this.Controls.Add(this.Date_label);
            this.Controls.Add(this.Emp_label);
            this.Controls.Add(this.Desc_label);
            this.Controls.Add(this.Name_label);
            this.Name = "NewEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewEvent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.Label Desc_label;
        private System.Windows.Forms.Label Emp_label;
        private System.Windows.Forms.Label Date_label;
        private System.Windows.Forms.Label Doc_label;
        private System.Windows.Forms.TextBox Event_name;
        private System.Windows.Forms.TextBox Event_description;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.ListBox employers;
        private System.Windows.Forms.ListBox documents;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button Done_button;
    }
}