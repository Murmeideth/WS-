namespace UchebniyUchet
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.main = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ID_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID_group = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID_kur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileButtonMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitButtonMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_strudent = new System.Windows.Forms.Button();
            this.Delete_student = new System.Windows.Forms.Button();
            this.Refresh_main = new System.Windows.Forms.Button();
            this.OpenGroupList = new System.Windows.Forms.Button();
            this.OpenKuratorList = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // main
            // 
            this.main.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_col,
            this.Name_col,
            this.ID_group,
            this.ID_kur});
            this.main.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.main.GridLines = true;
            this.main.HideSelection = false;
            this.main.Location = new System.Drawing.Point(12, 34);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(609, 309);
            this.main.TabIndex = 0;
            this.main.UseCompatibleStateImageBehavior = false;
            this.main.View = System.Windows.Forms.View.Details;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileButtonMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ID_col
            // 
            this.ID_col.Text = "№ п/п";
            // 
            // Name_col
            // 
            this.Name_col.Text = "ФИО";
            this.Name_col.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ID_group
            // 
            this.ID_group.Text = "Группа";
            this.ID_group.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ID_kur
            // 
            this.ID_kur.Text = "Куратор";
            this.ID_kur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FileButtonMenu
            // 
            this.FileButtonMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitButtonMenu});
            this.FileButtonMenu.Name = "FileButtonMenu";
            this.FileButtonMenu.Size = new System.Drawing.Size(48, 20);
            this.FileButtonMenu.Text = "Файл";
            // 
            // exitButtonMenu
            // 
            this.exitButtonMenu.Name = "exitButtonMenu";
            this.exitButtonMenu.Size = new System.Drawing.Size(180, 22);
            this.exitButtonMenu.Text = "Exit";
            this.exitButtonMenu.Click += new System.EventHandler(this.exitButtonMenu_Click);
            // 
            // Add_strudent
            // 
            this.Add_strudent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_strudent.Location = new System.Drawing.Point(13, 350);
            this.Add_strudent.Name = "Add_strudent";
            this.Add_strudent.Size = new System.Drawing.Size(97, 31);
            this.Add_strudent.TabIndex = 2;
            this.Add_strudent.Text = "Добавить";
            this.Add_strudent.UseVisualStyleBackColor = true;
            this.Add_strudent.Click += new System.EventHandler(this.Add_strudent_Click);
            // 
            // Delete_student
            // 
            this.Delete_student.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_student.Location = new System.Drawing.Point(116, 350);
            this.Delete_student.Name = "Delete_student";
            this.Delete_student.Size = new System.Drawing.Size(97, 31);
            this.Delete_student.TabIndex = 2;
            this.Delete_student.Text = "Удалить";
            this.Delete_student.UseVisualStyleBackColor = true;
            this.Delete_student.Click += new System.EventHandler(this.Delete_student_Click);
            // 
            // Refresh_main
            // 
            this.Refresh_main.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Refresh_main.Location = new System.Drawing.Point(524, 352);
            this.Refresh_main.Name = "Refresh_main";
            this.Refresh_main.Size = new System.Drawing.Size(97, 31);
            this.Refresh_main.TabIndex = 3;
            this.Refresh_main.Text = "Обновить";
            this.Refresh_main.UseVisualStyleBackColor = true;
            this.Refresh_main.Click += new System.EventHandler(this.Refresh_main_Click);
            // 
            // OpenGroupList
            // 
            this.OpenGroupList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenGroupList.Location = new System.Drawing.Point(278, 352);
            this.OpenGroupList.Name = "OpenGroupList";
            this.OpenGroupList.Size = new System.Drawing.Size(97, 30);
            this.OpenGroupList.TabIndex = 4;
            this.OpenGroupList.Text = "Группы";
            this.OpenGroupList.UseVisualStyleBackColor = true;
            this.OpenGroupList.Click += new System.EventHandler(this.OpenGroupList_Click);
            // 
            // OpenKuratorList
            // 
            this.OpenKuratorList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenKuratorList.Location = new System.Drawing.Point(381, 352);
            this.OpenKuratorList.Name = "OpenKuratorList";
            this.OpenKuratorList.Size = new System.Drawing.Size(97, 30);
            this.OpenKuratorList.TabIndex = 4;
            this.OpenKuratorList.Text = "Кураторы";
            this.OpenKuratorList.UseVisualStyleBackColor = true;
            this.OpenKuratorList.Click += new System.EventHandler(this.OpenKuratorList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 396);
            this.Controls.Add(this.OpenKuratorList);
            this.Controls.Add(this.OpenGroupList);
            this.Controls.Add(this.Refresh_main);
            this.Controls.Add(this.Delete_student);
            this.Controls.Add(this.Add_strudent);
            this.Controls.Add(this.main);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет студентов";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView main;
        private System.Windows.Forms.ColumnHeader ID_col;
        private System.Windows.Forms.ColumnHeader Name_col;
        private System.Windows.Forms.ColumnHeader ID_group;
        private System.Windows.Forms.ColumnHeader ID_kur;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileButtonMenu;
        private System.Windows.Forms.ToolStripMenuItem exitButtonMenu;
        private System.Windows.Forms.Button Add_strudent;
        private System.Windows.Forms.Button Delete_student;
        private System.Windows.Forms.Button Refresh_main;
        private System.Windows.Forms.Button OpenGroupList;
        private System.Windows.Forms.Button OpenKuratorList;
    }
}

