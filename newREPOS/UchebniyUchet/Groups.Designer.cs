namespace UchebniyUchet
{
    partial class Groups
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
            this.gruppa = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Refresh_groups = new System.Windows.Forms.Button();
            this.Back_groups = new System.Windows.Forms.Button();
            this.Delete_group = new System.Windows.Forms.Button();
            this.Add_group = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gruppa
            // 
            this.gruppa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Code,
            this.Description});
            this.gruppa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gruppa.GridLines = true;
            this.gruppa.HideSelection = false;
            this.gruppa.Location = new System.Drawing.Point(12, 12);
            this.gruppa.Name = "gruppa";
            this.gruppa.Size = new System.Drawing.Size(500, 345);
            this.gruppa.TabIndex = 0;
            this.gruppa.UseCompatibleStateImageBehavior = false;
            this.gruppa.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "№ п/п";
            // 
            // Code
            // 
            this.Code.Text = "Код группы";
            this.Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Description
            // 
            this.Description.Text = "Наименование";
            this.Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Refresh_groups
            // 
            this.Refresh_groups.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Refresh_groups.Location = new System.Drawing.Point(410, 371);
            this.Refresh_groups.Name = "Refresh_groups";
            this.Refresh_groups.Size = new System.Drawing.Size(103, 28);
            this.Refresh_groups.TabIndex = 1;
            this.Refresh_groups.Text = "Обновить";
            this.Refresh_groups.UseVisualStyleBackColor = true;
            this.Refresh_groups.Click += new System.EventHandler(this.Refresh_groups_Click);
            // 
            // Back_groups
            // 
            this.Back_groups.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_groups.Location = new System.Drawing.Point(301, 371);
            this.Back_groups.Name = "Back_groups";
            this.Back_groups.Size = new System.Drawing.Size(103, 28);
            this.Back_groups.TabIndex = 1;
            this.Back_groups.Text = "Назад";
            this.Back_groups.UseVisualStyleBackColor = true;
            this.Back_groups.Click += new System.EventHandler(this.Back_groups_Click);
            // 
            // Delete_group
            // 
            this.Delete_group.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_group.Location = new System.Drawing.Point(122, 370);
            this.Delete_group.Name = "Delete_group";
            this.Delete_group.Size = new System.Drawing.Size(103, 28);
            this.Delete_group.TabIndex = 1;
            this.Delete_group.Text = "Удалить";
            this.Delete_group.UseVisualStyleBackColor = true;
            this.Delete_group.Click += new System.EventHandler(this.Delete_group_Click);
            // 
            // Add_group
            // 
            this.Add_group.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_group.Location = new System.Drawing.Point(12, 370);
            this.Add_group.Name = "Add_group";
            this.Add_group.Size = new System.Drawing.Size(103, 28);
            this.Add_group.TabIndex = 1;
            this.Add_group.Text = "Добавить";
            this.Add_group.UseVisualStyleBackColor = true;
            this.Add_group.Click += new System.EventHandler(this.Add_group_Click);
            // 
            // Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 411);
            this.Controls.Add(this.Add_group);
            this.Controls.Add(this.Delete_group);
            this.Controls.Add(this.Back_groups);
            this.Controls.Add(this.Refresh_groups);
            this.Controls.Add(this.gruppa);
            this.Name = "Groups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Groups";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView gruppa;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Code;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.Button Refresh_groups;
        private System.Windows.Forms.Button Back_groups;
        private System.Windows.Forms.Button Delete_group;
        private System.Windows.Forms.Button Add_group;
    }
}