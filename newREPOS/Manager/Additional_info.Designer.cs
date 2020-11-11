namespace Manager
{
    partial class Additional_info
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
            this.emplo_list = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FIO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.refresh_emplo = new System.Windows.Forms.Button();
            this.delete_emplo = new System.Windows.Forms.Button();
            this.update_emplo = new System.Windows.Forms.Button();
            this.new_emplo = new System.Windows.Forms.Button();
            this.cat_list = new System.Windows.Forms.ListView();
            this.ID_cat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Desc_cat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.refresh_cat = new System.Windows.Forms.Button();
            this.delete_cat = new System.Windows.Forms.Button();
            this.update_cat = new System.Windows.Forms.Button();
            this.add_cat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emplo_list
            // 
            this.emplo_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.FIO,
            this.Position});
            this.emplo_list.Enabled = false;
            this.emplo_list.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emplo_list.GridLines = true;
            this.emplo_list.HideSelection = false;
            this.emplo_list.Location = new System.Drawing.Point(11, 12);
            this.emplo_list.Name = "emplo_list";
            this.emplo_list.Size = new System.Drawing.Size(440, 340);
            this.emplo_list.TabIndex = 0;
            this.emplo_list.UseCompatibleStateImageBehavior = false;
            this.emplo_list.View = System.Windows.Forms.View.Details;
            this.emplo_list.Visible = false;
            // 
            // ID
            // 
            this.ID.Text = "№ п/п";
            // 
            // FIO
            // 
            this.FIO.Text = "ФИО";
            this.FIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Position
            // 
            this.Position.Text = "Должность";
            this.Position.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // refresh_emplo
            // 
            this.refresh_emplo.Enabled = false;
            this.refresh_emplo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refresh_emplo.Location = new System.Drawing.Point(360, 356);
            this.refresh_emplo.Name = "refresh_emplo";
            this.refresh_emplo.Size = new System.Drawing.Size(91, 35);
            this.refresh_emplo.TabIndex = 1;
            this.refresh_emplo.Text = "Обновить";
            this.refresh_emplo.UseVisualStyleBackColor = true;
            this.refresh_emplo.Visible = false;
            this.refresh_emplo.Click += new System.EventHandler(this.refresh_emplo_Click);
            // 
            // delete_emplo
            // 
            this.delete_emplo.Enabled = false;
            this.delete_emplo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_emplo.Location = new System.Drawing.Point(204, 358);
            this.delete_emplo.Name = "delete_emplo";
            this.delete_emplo.Size = new System.Drawing.Size(91, 35);
            this.delete_emplo.TabIndex = 1;
            this.delete_emplo.Text = "Удалить";
            this.delete_emplo.UseVisualStyleBackColor = true;
            this.delete_emplo.Visible = false;
            this.delete_emplo.Click += new System.EventHandler(this.delete_emplo_Click);
            // 
            // update_emplo
            // 
            this.update_emplo.Enabled = false;
            this.update_emplo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update_emplo.Location = new System.Drawing.Point(107, 358);
            this.update_emplo.Name = "update_emplo";
            this.update_emplo.Size = new System.Drawing.Size(91, 35);
            this.update_emplo.TabIndex = 1;
            this.update_emplo.Text = "Изменить";
            this.update_emplo.UseVisualStyleBackColor = true;
            this.update_emplo.Visible = false;
            this.update_emplo.Click += new System.EventHandler(this.update_emplo_Click);
            // 
            // new_emplo
            // 
            this.new_emplo.Enabled = false;
            this.new_emplo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.new_emplo.Location = new System.Drawing.Point(10, 358);
            this.new_emplo.Name = "new_emplo";
            this.new_emplo.Size = new System.Drawing.Size(91, 35);
            this.new_emplo.TabIndex = 1;
            this.new_emplo.Text = "Добавить";
            this.new_emplo.UseVisualStyleBackColor = true;
            this.new_emplo.Visible = false;
            this.new_emplo.Click += new System.EventHandler(this.new_emplo_Click);
            // 
            // cat_list
            // 
            this.cat_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_cat,
            this.Desc_cat});
            this.cat_list.Enabled = false;
            this.cat_list.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cat_list.GridLines = true;
            this.cat_list.HideSelection = false;
            this.cat_list.Location = new System.Drawing.Point(11, 11);
            this.cat_list.Name = "cat_list";
            this.cat_list.Size = new System.Drawing.Size(206, 340);
            this.cat_list.TabIndex = 2;
            this.cat_list.UseCompatibleStateImageBehavior = false;
            this.cat_list.View = System.Windows.Forms.View.Details;
            this.cat_list.Visible = false;
            // 
            // ID_cat
            // 
            this.ID_cat.Text = "№ п/п";
            // 
            // Desc_cat
            // 
            this.Desc_cat.Text = "Категория";
            this.Desc_cat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // refresh_cat
            // 
            this.refresh_cat.Enabled = false;
            this.refresh_cat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refresh_cat.Location = new System.Drawing.Point(126, 399);
            this.refresh_cat.Name = "refresh_cat";
            this.refresh_cat.Size = new System.Drawing.Size(91, 35);
            this.refresh_cat.TabIndex = 1;
            this.refresh_cat.Text = "Обновить";
            this.refresh_cat.UseVisualStyleBackColor = true;
            this.refresh_cat.Visible = false;
            this.refresh_cat.Click += new System.EventHandler(this.refresh_cat_Click);
            // 
            // delete_cat
            // 
            this.delete_cat.Enabled = false;
            this.delete_cat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_cat.Location = new System.Drawing.Point(10, 399);
            this.delete_cat.Name = "delete_cat";
            this.delete_cat.Size = new System.Drawing.Size(91, 35);
            this.delete_cat.TabIndex = 1;
            this.delete_cat.Text = "Удалить";
            this.delete_cat.UseVisualStyleBackColor = true;
            this.delete_cat.Visible = false;
            this.delete_cat.Click += new System.EventHandler(this.delete_cat_Click);
            // 
            // update_cat
            // 
            this.update_cat.Enabled = false;
            this.update_cat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update_cat.Location = new System.Drawing.Point(126, 358);
            this.update_cat.Name = "update_cat";
            this.update_cat.Size = new System.Drawing.Size(91, 35);
            this.update_cat.TabIndex = 1;
            this.update_cat.Text = "Изменить";
            this.update_cat.UseVisualStyleBackColor = true;
            this.update_cat.Visible = false;
            this.update_cat.Click += new System.EventHandler(this.update_cat_Click);
            // 
            // add_cat
            // 
            this.add_cat.Enabled = false;
            this.add_cat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_cat.Location = new System.Drawing.Point(10, 357);
            this.add_cat.Name = "add_cat";
            this.add_cat.Size = new System.Drawing.Size(91, 35);
            this.add_cat.TabIndex = 1;
            this.add_cat.Text = "Добавить";
            this.add_cat.UseVisualStyleBackColor = true;
            this.add_cat.Visible = false;
            this.add_cat.Click += new System.EventHandler(this.add_cat_Click);
            // 
            // Additional_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 446);
            this.Controls.Add(this.cat_list);
            this.Controls.Add(this.add_cat);
            this.Controls.Add(this.new_emplo);
            this.Controls.Add(this.update_cat);
            this.Controls.Add(this.delete_cat);
            this.Controls.Add(this.update_emplo);
            this.Controls.Add(this.refresh_cat);
            this.Controls.Add(this.delete_emplo);
            this.Controls.Add(this.refresh_emplo);
            this.Controls.Add(this.emplo_list);
            this.Name = "Additional_info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Additional_info";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView emplo_list;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader FIO;
        private System.Windows.Forms.ColumnHeader Position;
        private System.Windows.Forms.Button refresh_emplo;
        private System.Windows.Forms.Button delete_emplo;
        private System.Windows.Forms.Button update_emplo;
        private System.Windows.Forms.Button new_emplo;
        private System.Windows.Forms.ListView cat_list;
        private System.Windows.Forms.ColumnHeader ID_cat;
        private System.Windows.Forms.ColumnHeader Desc_cat;
        private System.Windows.Forms.Button refresh_cat;
        private System.Windows.Forms.Button delete_cat;
        private System.Windows.Forms.Button update_cat;
        private System.Windows.Forms.Button add_cat;
    }
}