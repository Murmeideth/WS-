namespace AP
{
    partial class Employers
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
            this.Employers_list = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name_emp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Add_emplo = new System.Windows.Forms.Button();
            this.Delete_emplo = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Employers_list
            // 
            this.Employers_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Name_emp,
            this.Description,
            this.Position});
            this.Employers_list.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employers_list.GridLines = true;
            this.Employers_list.HideSelection = false;
            this.Employers_list.Location = new System.Drawing.Point(12, 12);
            this.Employers_list.Name = "Employers_list";
            this.Employers_list.Size = new System.Drawing.Size(615, 248);
            this.Employers_list.TabIndex = 0;
            this.Employers_list.UseCompatibleStateImageBehavior = false;
            this.Employers_list.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Name_emp
            // 
            this.Name_emp.Text = "ФИО";
            this.Name_emp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Description
            // 
            this.Description.Text = "Характеристика";
            this.Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Position
            // 
            this.Position.Text = "Должность";
            this.Position.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Add_emplo
            // 
            this.Add_emplo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_emplo.Location = new System.Drawing.Point(12, 280);
            this.Add_emplo.Name = "Add_emplo";
            this.Add_emplo.Size = new System.Drawing.Size(140, 34);
            this.Add_emplo.TabIndex = 1;
            this.Add_emplo.Text = "Добавить";
            this.Add_emplo.UseVisualStyleBackColor = true;
            this.Add_emplo.Click += new System.EventHandler(this.Add_emplo_Click);
            // 
            // Delete_emplo
            // 
            this.Delete_emplo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_emplo.Location = new System.Drawing.Point(158, 280);
            this.Delete_emplo.Name = "Delete_emplo";
            this.Delete_emplo.Size = new System.Drawing.Size(140, 34);
            this.Delete_emplo.TabIndex = 1;
            this.Delete_emplo.Text = "Удалить";
            this.Delete_emplo.UseVisualStyleBackColor = true;
            this.Delete_emplo.Click += new System.EventHandler(this.Delete_emplo_Click);
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(355, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Employers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 329);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Delete_emplo);
            this.Controls.Add(this.Add_emplo);
            this.Controls.Add(this.Employers_list);
            this.Name = "Employers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Employers_list;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Name_emp;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Position;
        private System.Windows.Forms.Button Add_emplo;
        private System.Windows.Forms.Button Delete_emplo;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button button1;
    }
}