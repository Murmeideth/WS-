namespace Manager
{
    partial class Status_change
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.status_index_box = new System.Windows.Forms.ListBox();
            this.id_quest = new System.Windows.Forms.TextBox();
            this.change_status = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер задачи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Статус";
            // 
            // status_index_box
            // 
            this.status_index_box.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status_index_box.FormattingEnabled = true;
            this.status_index_box.ItemHeight = 19;
            this.status_index_box.Items.AddRange(new object[] {
            "Выполняется",
            "Выполнено"});
            this.status_index_box.Location = new System.Drawing.Point(119, 97);
            this.status_index_box.Name = "status_index_box";
            this.status_index_box.Size = new System.Drawing.Size(214, 42);
            this.status_index_box.TabIndex = 2;
            // 
            // id_quest
            // 
            this.id_quest.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_quest.Location = new System.Drawing.Point(119, 49);
            this.id_quest.Name = "id_quest";
            this.id_quest.Size = new System.Drawing.Size(214, 26);
            this.id_quest.TabIndex = 3;
            // 
            // change_status
            // 
            this.change_status.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change_status.Location = new System.Drawing.Point(248, 155);
            this.change_status.Name = "change_status";
            this.change_status.Size = new System.Drawing.Size(85, 33);
            this.change_status.TabIndex = 4;
            this.change_status.Text = "Изменить";
            this.change_status.UseVisualStyleBackColor = true;
            this.change_status.Click += new System.EventHandler(this.change_status_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.Location = new System.Drawing.Point(162, 155);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(80, 33);
            this.back.TabIndex = 5;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Status_change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 200);
            this.Controls.Add(this.back);
            this.Controls.Add(this.change_status);
            this.Controls.Add(this.id_quest);
            this.Controls.Add(this.status_index_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Status_change";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Status_change";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox status_index_box;
        private System.Windows.Forms.TextBox id_quest;
        private System.Windows.Forms.Button change_status;
        private System.Windows.Forms.Button back;
    }
}