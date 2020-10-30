namespace AP
{
    partial class Documents
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
            this.Doc_list = new System.Windows.Forms.ListView();
            this.ID_doc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Doc_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Add_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.Refresh_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Doc_list
            // 
            this.Doc_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_doc,
            this.Doc_name,
            this.Description});
            this.Doc_list.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Doc_list.GridLines = true;
            this.Doc_list.HideSelection = false;
            this.Doc_list.Location = new System.Drawing.Point(12, 12);
            this.Doc_list.Name = "Doc_list";
            this.Doc_list.Size = new System.Drawing.Size(615, 248);
            this.Doc_list.TabIndex = 0;
            this.Doc_list.UseCompatibleStateImageBehavior = false;
            this.Doc_list.View = System.Windows.Forms.View.Details;
            // 
            // ID_doc
            // 
            this.ID_doc.Text = "ÌD";
            this.ID_doc.Width = 40;
            // 
            // Doc_name
            // 
            this.Doc_name.Text = "Название";
            this.Doc_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Doc_name.Width = 253;
            // 
            // Description
            // 
            this.Description.Text = "Описание";
            this.Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Description.Width = 260;
            // 
            // Add_button
            // 
            this.Add_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_button.Location = new System.Drawing.Point(12, 280);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(140, 34);
            this.Add_button.TabIndex = 1;
            this.Add_button.Text = "Добавить";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_button.Location = new System.Drawing.Point(158, 280);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(140, 34);
            this.Delete_button.TabIndex = 1;
            this.Delete_button.Text = "Удалить";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Back_button
            // 
            this.Back_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_button.Location = new System.Drawing.Point(487, 280);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(140, 34);
            this.Back_button.TabIndex = 1;
            this.Back_button.Text = "Назад";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Refresh_button
            // 
            this.Refresh_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Refresh_button.Location = new System.Drawing.Point(356, 280);
            this.Refresh_button.Name = "Refresh_button";
            this.Refresh_button.Size = new System.Drawing.Size(91, 34);
            this.Refresh_button.TabIndex = 1;
            this.Refresh_button.Text = "Обновить";
            this.Refresh_button.UseVisualStyleBackColor = true;
            this.Refresh_button.Click += new System.EventHandler(this.Refresh_button_Click);
            // 
            // Documents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 329);
            this.Controls.Add(this.Refresh_button);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Doc_list);
            this.Name = "Documents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documents";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Doc_list;
        private System.Windows.Forms.ColumnHeader ID_doc;
        private System.Windows.Forms.ColumnHeader Doc_name;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button Refresh_button;
    }
}