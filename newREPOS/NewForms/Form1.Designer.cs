namespace NewForms
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
            this.StripMenu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitStipMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PDFStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonForNew = new System.Windows.Forms.Button();
            this.ButtonForDelete = new System.Windows.Forms.Button();
            this.ButtonForChange = new System.Windows.Forms.Button();
            this.Spisok = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Birth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Refresh = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.StripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // StripMenu
            // 
            this.StripMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StripMenu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.печатьToolStripMenuItem});
            this.StripMenu.Location = new System.Drawing.Point(0, 0);
            this.StripMenu.Name = "StripMenu";
            this.StripMenu.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.StripMenu.Size = new System.Drawing.Size(715, 29);
            this.StripMenu.TabIndex = 0;
            this.StripMenu.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitStipMenu});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(58, 23);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // ExitStipMenu
            // 
            this.ExitStipMenu.Name = "ExitStipMenu";
            this.ExitStipMenu.Size = new System.Drawing.Size(121, 24);
            this.ExitStipMenu.Text = "Выход";
            this.ExitStipMenu.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenStripMenu,
            this.ChangeStripMenu,
            this.DeleteStripMenu});
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(120, 23);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            // 
            // OpenStripMenu
            // 
            this.OpenStripMenu.Name = "OpenStripMenu";
            this.OpenStripMenu.Size = new System.Drawing.Size(144, 24);
            this.OpenStripMenu.Text = "Открыть";
            this.OpenStripMenu.Click += new System.EventHandler(this.OpenStripMenu_Click);
            // 
            // ChangeStripMenu
            // 
            this.ChangeStripMenu.Name = "ChangeStripMenu";
            this.ChangeStripMenu.Size = new System.Drawing.Size(144, 24);
            this.ChangeStripMenu.Text = "Изменить";
            this.ChangeStripMenu.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // DeleteStripMenu
            // 
            this.DeleteStripMenu.Name = "DeleteStripMenu";
            this.DeleteStripMenu.Size = new System.Drawing.Size(144, 24);
            this.DeleteStripMenu.Text = "Удалить";
            this.DeleteStripMenu.Click += new System.EventHandler(this.DeleteStripMenu_Click);
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PDFStripMenu});
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(68, 23);
            this.печатьToolStripMenuItem.Text = "Печать";
            // 
            // PDFStripMenu
            // 
            this.PDFStripMenu.Name = "PDFStripMenu";
            this.PDFStripMenu.Size = new System.Drawing.Size(182, 24);
            this.PDFStripMenu.Text = "Вывести в PDF";
            this.PDFStripMenu.Click += new System.EventHandler(this.вывестиВPDFToolStripMenuItem_Click);
            // 
            // ButtonForNew
            // 
            this.ButtonForNew.Location = new System.Drawing.Point(586, 57);
            this.ButtonForNew.Name = "ButtonForNew";
            this.ButtonForNew.Size = new System.Drawing.Size(118, 37);
            this.ButtonForNew.TabIndex = 3;
            this.ButtonForNew.Text = "Новый";
            this.ButtonForNew.UseVisualStyleBackColor = true;
            this.ButtonForNew.Click += new System.EventHandler(this.ButtonForNew_Click);
            // 
            // ButtonForDelete
            // 
            this.ButtonForDelete.Location = new System.Drawing.Point(585, 113);
            this.ButtonForDelete.Name = "ButtonForDelete";
            this.ButtonForDelete.Size = new System.Drawing.Size(118, 37);
            this.ButtonForDelete.TabIndex = 3;
            this.ButtonForDelete.Text = "Удалить";
            this.ButtonForDelete.UseVisualStyleBackColor = true;
            this.ButtonForDelete.Click += new System.EventHandler(this.ButtonForDelete_Click);
            // 
            // ButtonForChange
            // 
            this.ButtonForChange.Location = new System.Drawing.Point(585, 166);
            this.ButtonForChange.Name = "ButtonForChange";
            this.ButtonForChange.Size = new System.Drawing.Size(119, 37);
            this.ButtonForChange.TabIndex = 3;
            this.ButtonForChange.Text = "Редактировать";
            this.ButtonForChange.UseVisualStyleBackColor = true;
            this.ButtonForChange.Click += new System.EventHandler(this.ButtonForChange_Click);
            // 
            // Spisok
            // 
            this.Spisok.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.Spisok.AutoArrange = false;
            this.Spisok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Spisok.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.name,
            this.Birth,
            this.Phone,
            this.Adress});
            this.Spisok.GridLines = true;
            this.Spisok.HideSelection = false;
            this.Spisok.Location = new System.Drawing.Point(12, 50);
            this.Spisok.Name = "Spisok";
            this.Spisok.Size = new System.Drawing.Size(542, 153);
            this.Spisok.TabIndex = 4;
            this.Spisok.UseCompatibleStateImageBehavior = false;
            this.Spisok.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 32;
            // 
            // name
            // 
            this.name.Text = "ФИО";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name.Width = 168;
            // 
            // Birth
            // 
            this.Birth.Text = "Дата рождения";
            this.Birth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Birth.Width = 138;
            // 
            // Phone
            // 
            this.Phone.Text = "Телефон";
            this.Phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Phone.Width = 167;
            // 
            // Adress
            // 
            this.Adress.Text = "Адрес";
            this.Adress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Adress.Width = 181;
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(12, 220);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(91, 31);
            this.Refresh.TabIndex = 5;
            this.Refresh.Text = "Обновить";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 263);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Spisok);
            this.Controls.Add(this.ButtonForChange);
            this.Controls.Add(this.ButtonForDelete);
            this.Controls.Add(this.ButtonForNew);
            this.Controls.Add(this.StripMenu);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.StripMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.StripMenu.ResumeLayout(false);
            this.StripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip StripMenu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitStipMenu;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenStripMenu;
        private System.Windows.Forms.ToolStripMenuItem ChangeStripMenu;
        private System.Windows.Forms.ToolStripMenuItem DeleteStripMenu;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PDFStripMenu;
        private System.Windows.Forms.Button ButtonForNew;
        private System.Windows.Forms.Button ButtonForDelete;
        private System.Windows.Forms.Button ButtonForChange;
        private System.Windows.Forms.ListView Spisok;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader Birth;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ColumnHeader Adress;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

