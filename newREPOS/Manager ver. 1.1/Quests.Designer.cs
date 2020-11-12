namespace Manager
{
    partial class Quests
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Quest_list = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Res_employer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.add_quest_button = new System.Windows.Forms.Button();
            this.show_category_button = new System.Windows.Forms.Button();
            this.show_emplo_button = new System.Windows.Forms.Button();
            this.change_status_button = new System.Windows.Forms.Button();
            this.delete_quest_button = new System.Windows.Forms.Button();
            this.change_quest_button = new System.Windows.Forms.Button();
            this.refresh_quests = new System.Windows.Forms.Button();
            this.mode_label = new System.Windows.Forms.Label();
            this.worker_label = new System.Windows.Forms.Label();
            this.find_quest_button = new System.Windows.Forms.Button();
            this.find_button = new System.Windows.Forms.Button();
            this.find_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Date_quest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date_pick = new System.Windows.Forms.Button();
            this.status_pick = new System.Windows.Forms.Button();
            this.date_find = new System.Windows.Forms.Button();
            this.status_find = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.first_date = new System.Windows.Forms.TextBox();
            this.second_date = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fam_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.status_box = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(594, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.reLoginToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.exportToolStripMenuItem.Text = "Экспорт";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // reLoginToolStripMenuItem
            // 
            this.reLoginToolStripMenuItem.Name = "reLoginToolStripMenuItem";
            this.reLoginToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.reLoginToolStripMenuItem.Text = "Зайти под другим профилем";
            this.reLoginToolStripMenuItem.Click += new System.EventHandler(this.reLoginToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Quest_list
            // 
            this.Quest_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Description,
            this.Category,
            this.Res_employer,
            this.Status,
            this.Date_quest});
            this.Quest_list.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Quest_list.GridLines = true;
            this.Quest_list.HideSelection = false;
            this.Quest_list.Location = new System.Drawing.Point(12, 39);
            this.Quest_list.Name = "Quest_list";
            this.Quest_list.Size = new System.Drawing.Size(566, 307);
            this.Quest_list.TabIndex = 1;
            this.Quest_list.UseCompatibleStateImageBehavior = false;
            this.Quest_list.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "№ п/п";
            // 
            // Description
            // 
            this.Description.Text = "Задача";
            this.Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Category
            // 
            this.Category.Text = "Категория";
            this.Category.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Res_employer
            // 
            this.Res_employer.Text = "Ответственный";
            this.Res_employer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Status
            // 
            this.Status.Text = "Статус";
            this.Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // add_quest_button
            // 
            this.add_quest_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_quest_button.Location = new System.Drawing.Point(129, 370);
            this.add_quest_button.Name = "add_quest_button";
            this.add_quest_button.Size = new System.Drawing.Size(86, 31);
            this.add_quest_button.TabIndex = 2;
            this.add_quest_button.Text = "Добавить";
            this.add_quest_button.UseVisualStyleBackColor = true;
            this.add_quest_button.Click += new System.EventHandler(this.add_quest_button_Click);
            // 
            // show_category_button
            // 
            this.show_category_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.show_category_button.Location = new System.Drawing.Point(12, 412);
            this.show_category_button.Name = "show_category_button";
            this.show_category_button.Size = new System.Drawing.Size(97, 31);
            this.show_category_button.TabIndex = 3;
            this.show_category_button.Text = "Категории";
            this.show_category_button.UseVisualStyleBackColor = true;
            this.show_category_button.Click += new System.EventHandler(this.show_category_button_Click);
            // 
            // show_emplo_button
            // 
            this.show_emplo_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.show_emplo_button.Location = new System.Drawing.Point(12, 370);
            this.show_emplo_button.Name = "show_emplo_button";
            this.show_emplo_button.Size = new System.Drawing.Size(99, 31);
            this.show_emplo_button.TabIndex = 3;
            this.show_emplo_button.Text = "Сотрудники";
            this.show_emplo_button.UseVisualStyleBackColor = true;
            this.show_emplo_button.Click += new System.EventHandler(this.show_emplo_button_Click);
            // 
            // change_status_button
            // 
            this.change_status_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change_status_button.Location = new System.Drawing.Point(457, 370);
            this.change_status_button.Name = "change_status_button";
            this.change_status_button.Size = new System.Drawing.Size(133, 31);
            this.change_status_button.TabIndex = 4;
            this.change_status_button.Text = "Изменить статус";
            this.change_status_button.UseVisualStyleBackColor = true;
            this.change_status_button.Click += new System.EventHandler(this.change_status_button_Click);
            // 
            // delete_quest_button
            // 
            this.delete_quest_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_quest_button.Location = new System.Drawing.Point(129, 412);
            this.delete_quest_button.Name = "delete_quest_button";
            this.delete_quest_button.Size = new System.Drawing.Size(86, 31);
            this.delete_quest_button.TabIndex = 2;
            this.delete_quest_button.Text = "Удалить";
            this.delete_quest_button.UseVisualStyleBackColor = true;
            this.delete_quest_button.Click += new System.EventHandler(this.delete_quest_button_Click);
            // 
            // change_quest_button
            // 
            this.change_quest_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change_quest_button.Location = new System.Drawing.Point(221, 370);
            this.change_quest_button.Name = "change_quest_button";
            this.change_quest_button.Size = new System.Drawing.Size(86, 31);
            this.change_quest_button.TabIndex = 2;
            this.change_quest_button.Text = "Изменить";
            this.change_quest_button.UseVisualStyleBackColor = true;
            this.change_quest_button.Click += new System.EventHandler(this.change_quest_button_Click);
            // 
            // refresh_quests
            // 
            this.refresh_quests.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refresh_quests.Location = new System.Drawing.Point(502, 412);
            this.refresh_quests.Name = "refresh_quests";
            this.refresh_quests.Size = new System.Drawing.Size(88, 31);
            this.refresh_quests.TabIndex = 5;
            this.refresh_quests.Text = "Обновить";
            this.refresh_quests.UseVisualStyleBackColor = true;
            this.refresh_quests.Click += new System.EventHandler(this.refresh_quests_Click);
            // 
            // mode_label
            // 
            this.mode_label.AutoSize = true;
            this.mode_label.Location = new System.Drawing.Point(230, 422);
            this.mode_label.Name = "mode_label";
            this.mode_label.Size = new System.Drawing.Size(0, 13);
            this.mode_label.TabIndex = 6;
            this.mode_label.Visible = false;
            // 
            // worker_label
            // 
            this.worker_label.AutoSize = true;
            this.worker_label.Location = new System.Drawing.Point(272, 422);
            this.worker_label.Name = "worker_label";
            this.worker_label.Size = new System.Drawing.Size(0, 13);
            this.worker_label.TabIndex = 7;
            this.worker_label.Visible = false;
            // 
            // find_quest_button
            // 
            this.find_quest_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.find_quest_button.Location = new System.Drawing.Point(408, 412);
            this.find_quest_button.Name = "find_quest_button";
            this.find_quest_button.Size = new System.Drawing.Size(88, 31);
            this.find_quest_button.TabIndex = 8;
            this.find_quest_button.Text = "Найти";
            this.find_quest_button.UseVisualStyleBackColor = true;
            this.find_quest_button.Click += new System.EventHandler(this.find_quest_button_Click);
            // 
            // find_button
            // 
            this.find_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.find_button.Location = new System.Drawing.Point(502, 453);
            this.find_button.Name = "find_button";
            this.find_button.Size = new System.Drawing.Size(88, 31);
            this.find_button.TabIndex = 9;
            this.find_button.Text = "Поиск";
            this.find_button.UseVisualStyleBackColor = true;
            this.find_button.Click += new System.EventHandler(this.find_button_Click);
            // 
            // find_box
            // 
            this.find_box.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.find_box.Location = new System.Drawing.Point(291, 456);
            this.find_box.Name = "find_box";
            this.find_box.Size = new System.Drawing.Size(205, 26);
            this.find_box.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(165, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ключевое слово";
            // 
            // Date_quest
            // 
            this.Date_quest.Text = "Дата выполнения до";
            // 
            // date_pick
            // 
            this.date_pick.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_pick.Location = new System.Drawing.Point(221, 412);
            this.date_pick.Name = "date_pick";
            this.date_pick.Size = new System.Drawing.Size(181, 31);
            this.date_pick.TabIndex = 12;
            this.date_pick.Text = "Выборка за период";
            this.date_pick.UseVisualStyleBackColor = true;
            this.date_pick.Click += new System.EventHandler(this.date_pick_Click);
            // 
            // status_pick
            // 
            this.status_pick.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status_pick.Location = new System.Drawing.Point(313, 370);
            this.status_pick.Name = "status_pick";
            this.status_pick.Size = new System.Drawing.Size(138, 31);
            this.status_pick.TabIndex = 13;
            this.status_pick.Text = "Выборка готовых";
            this.status_pick.UseVisualStyleBackColor = true;
            this.status_pick.Click += new System.EventHandler(this.status_pick_Click);
            // 
            // date_find
            // 
            this.date_find.Enabled = false;
            this.date_find.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_find.Location = new System.Drawing.Point(502, 453);
            this.date_find.Name = "date_find";
            this.date_find.Size = new System.Drawing.Size(88, 31);
            this.date_find.TabIndex = 14;
            this.date_find.Text = "Поиск";
            this.date_find.UseVisualStyleBackColor = true;
            this.date_find.Visible = false;
            this.date_find.Click += new System.EventHandler(this.date_find_Click);
            // 
            // status_find
            // 
            this.status_find.Enabled = false;
            this.status_find.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status_find.Location = new System.Drawing.Point(502, 453);
            this.status_find.Name = "status_find";
            this.status_find.Size = new System.Drawing.Size(88, 31);
            this.status_find.TabIndex = 14;
            this.status_find.Text = "Поиск";
            this.status_find.UseVisualStyleBackColor = true;
            this.status_find.Visible = false;
            this.status_find.Click += new System.EventHandler(this.status_find_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(73, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "C";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(205, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "по";
            this.label3.Visible = false;
            // 
            // first_date
            // 
            this.first_date.Enabled = false;
            this.first_date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.first_date.Location = new System.Drawing.Point(99, 457);
            this.first_date.Name = "first_date";
            this.first_date.Size = new System.Drawing.Size(100, 26);
            this.first_date.TabIndex = 16;
            this.first_date.Visible = false;
            // 
            // second_date
            // 
            this.second_date.Enabled = false;
            this.second_date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.second_date.Location = new System.Drawing.Point(237, 456);
            this.second_date.Name = "second_date";
            this.second_date.Size = new System.Drawing.Size(100, 26);
            this.second_date.TabIndex = 16;
            this.second_date.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(143, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Фамилия";
            this.label4.Visible = false;
            // 
            // fam_box
            // 
            this.fam_box.Enabled = false;
            this.fam_box.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fam_box.Location = new System.Drawing.Point(224, 456);
            this.fam_box.Name = "fam_box";
            this.fam_box.Size = new System.Drawing.Size(116, 26);
            this.fam_box.TabIndex = 18;
            this.fam_box.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(346, 459);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Выполнено";
            this.label5.Visible = false;
            // 
            // status_box
            // 
            this.status_box.AutoSize = true;
            this.status_box.Enabled = false;
            this.status_box.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status_box.Location = new System.Drawing.Point(440, 463);
            this.status_box.Name = "status_box";
            this.status_box.Size = new System.Drawing.Size(15, 14);
            this.status_box.TabIndex = 20;
            this.status_box.UseVisualStyleBackColor = true;
            this.status_box.Visible = false;
            // 
            // Quests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 496);
            this.Controls.Add(this.status_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fam_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.second_date);
            this.Controls.Add(this.first_date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.status_find);
            this.Controls.Add(this.date_find);
            this.Controls.Add(this.status_pick);
            this.Controls.Add(this.date_pick);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.find_box);
            this.Controls.Add(this.find_button);
            this.Controls.Add(this.find_quest_button);
            this.Controls.Add(this.worker_label);
            this.Controls.Add(this.mode_label);
            this.Controls.Add(this.refresh_quests);
            this.Controls.Add(this.change_status_button);
            this.Controls.Add(this.show_emplo_button);
            this.Controls.Add(this.show_category_button);
            this.Controls.Add(this.change_quest_button);
            this.Controls.Add(this.delete_quest_button);
            this.Controls.Add(this.add_quest_button);
            this.Controls.Add(this.Quest_list);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Quests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список задач";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ListView Quest_list;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader Res_employer;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.Button add_quest_button;
        private System.Windows.Forms.Button show_category_button;
        private System.Windows.Forms.Button show_emplo_button;
        private System.Windows.Forms.Button change_status_button;
        private System.Windows.Forms.Button delete_quest_button;
        private System.Windows.Forms.Button change_quest_button;
        private System.Windows.Forms.Button refresh_quests;
        private System.Windows.Forms.Label mode_label;
        private System.Windows.Forms.Label worker_label;
        private System.Windows.Forms.Button find_quest_button;
        private System.Windows.Forms.Button find_button;
        private System.Windows.Forms.TextBox find_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ColumnHeader Date_quest;
        private System.Windows.Forms.Button date_pick;
        private System.Windows.Forms.Button status_pick;
        private System.Windows.Forms.Button date_find;
        private System.Windows.Forms.Button status_find;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox first_date;
        private System.Windows.Forms.TextBox second_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fam_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox status_box;
    }
}