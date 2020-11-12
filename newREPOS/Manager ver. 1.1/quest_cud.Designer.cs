namespace Manager
{
    partial class quest_cud
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
            this.qcud_add_button = new System.Windows.Forms.Button();
            this.quest_cud_back = new System.Windows.Forms.Button();
            this.category = new System.Windows.Forms.ListBox();
            this.emplo = new System.Windows.Forms.ListBox();
            this.descBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.qcud_id_box = new System.Windows.Forms.TextBox();
            this.qcud_delete_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.get_chenged_id = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.qcud_change_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.date_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // qcud_add_button
            // 
            this.qcud_add_button.Enabled = false;
            this.qcud_add_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qcud_add_button.Location = new System.Drawing.Point(291, 344);
            this.qcud_add_button.Name = "qcud_add_button";
            this.qcud_add_button.Size = new System.Drawing.Size(96, 31);
            this.qcud_add_button.TabIndex = 0;
            this.qcud_add_button.Text = "Добавить";
            this.qcud_add_button.UseVisualStyleBackColor = true;
            this.qcud_add_button.Visible = false;
            this.qcud_add_button.Click += new System.EventHandler(this.qcud_add_button_Click);
            // 
            // quest_cud_back
            // 
            this.quest_cud_back.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quest_cud_back.Location = new System.Drawing.Point(189, 344);
            this.quest_cud_back.Name = "quest_cud_back";
            this.quest_cud_back.Size = new System.Drawing.Size(96, 31);
            this.quest_cud_back.TabIndex = 0;
            this.quest_cud_back.Text = "Назад";
            this.quest_cud_back.UseVisualStyleBackColor = true;
            this.quest_cud_back.Click += new System.EventHandler(this.quest_cud_back_Click);
            // 
            // category
            // 
            this.category.Enabled = false;
            this.category.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.category.FormattingEnabled = true;
            this.category.ItemHeight = 19;
            this.category.Location = new System.Drawing.Point(132, 116);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(257, 80);
            this.category.TabIndex = 1;
            this.category.Visible = false;
            // 
            // emplo
            // 
            this.emplo.Enabled = false;
            this.emplo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emplo.FormattingEnabled = true;
            this.emplo.ItemHeight = 19;
            this.emplo.Location = new System.Drawing.Point(132, 202);
            this.emplo.Name = "emplo";
            this.emplo.Size = new System.Drawing.Size(257, 80);
            this.emplo.TabIndex = 1;
            this.emplo.Visible = false;
            // 
            // descBox
            // 
            this.descBox.Enabled = false;
            this.descBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descBox.Location = new System.Drawing.Point(132, 30);
            this.descBox.Multiline = true;
            this.descBox.Name = "descBox";
            this.descBox.Size = new System.Drawing.Size(257, 80);
            this.descBox.TabIndex = 2;
            this.descBox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Задача";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Категория";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Исполнитель";
            this.label3.Visible = false;
            // 
            // qcud_id_box
            // 
            this.qcud_id_box.Enabled = false;
            this.qcud_id_box.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qcud_id_box.Location = new System.Drawing.Point(65, 140);
            this.qcud_id_box.Name = "qcud_id_box";
            this.qcud_id_box.Size = new System.Drawing.Size(280, 26);
            this.qcud_id_box.TabIndex = 4;
            this.qcud_id_box.Visible = false;
            // 
            // qcud_delete_button
            // 
            this.qcud_delete_button.Enabled = false;
            this.qcud_delete_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qcud_delete_button.Location = new System.Drawing.Point(292, 298);
            this.qcud_delete_button.Name = "qcud_delete_button";
            this.qcud_delete_button.Size = new System.Drawing.Size(95, 31);
            this.qcud_delete_button.TabIndex = 5;
            this.qcud_delete_button.Text = "Удалить";
            this.qcud_delete_button.UseVisualStyleBackColor = true;
            this.qcud_delete_button.Visible = false;
            this.qcud_delete_button.Click += new System.EventHandler(this.qcud_delete_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(82, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Введите № удаляемой задачи";
            this.label4.Visible = false;
            // 
            // get_chenged_id
            // 
            this.get_chenged_id.Enabled = false;
            this.get_chenged_id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.get_chenged_id.Location = new System.Drawing.Point(292, 344);
            this.get_chenged_id.Name = "get_chenged_id";
            this.get_chenged_id.Size = new System.Drawing.Size(95, 31);
            this.get_chenged_id.TabIndex = 7;
            this.get_chenged_id.Text = "Выбрать";
            this.get_chenged_id.UseVisualStyleBackColor = true;
            this.get_chenged_id.Visible = false;
            this.get_chenged_id.Click += new System.EventHandler(this.get_chenged_id_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(82, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Введите № изменяемой задачи";
            this.label5.Visible = false;
            // 
            // qcud_change_button
            // 
            this.qcud_change_button.Enabled = false;
            this.qcud_change_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qcud_change_button.Location = new System.Drawing.Point(291, 343);
            this.qcud_change_button.Name = "qcud_change_button";
            this.qcud_change_button.Size = new System.Drawing.Size(95, 31);
            this.qcud_change_button.TabIndex = 9;
            this.qcud_change_button.Text = "Изменить";
            this.qcud_change_button.UseVisualStyleBackColor = true;
            this.qcud_change_button.Visible = false;
            this.qcud_change_button.Click += new System.EventHandler(this.qcud_change_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(16, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Дата";
            this.label6.Visible = false;
            // 
            // date_box
            // 
            this.date_box.Enabled = false;
            this.date_box.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_box.Location = new System.Drawing.Point(132, 312);
            this.date_box.Name = "date_box";
            this.date_box.Size = new System.Drawing.Size(255, 26);
            this.date_box.TabIndex = 11;
            this.date_box.Text = "ГГГГ-ММ-ДД";
            this.date_box.Visible = false;
            // 
            // quest_cud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 386);
            this.Controls.Add(this.date_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.qcud_change_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.get_chenged_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.qcud_delete_button);
            this.Controls.Add(this.qcud_id_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descBox);
            this.Controls.Add(this.emplo);
            this.Controls.Add(this.category);
            this.Controls.Add(this.quest_cud_back);
            this.Controls.Add(this.qcud_add_button);
            this.Name = "quest_cud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "quest_cud";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button qcud_add_button;
        private System.Windows.Forms.Button quest_cud_back;
        private System.Windows.Forms.ListBox category;
        private System.Windows.Forms.ListBox emplo;
        private System.Windows.Forms.TextBox descBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox qcud_id_box;
        private System.Windows.Forms.Button qcud_delete_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button get_chenged_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button qcud_change_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox date_box;
    }
}