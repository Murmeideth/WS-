namespace UchebniyUchet
{
    partial class Delete_stud
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
            this.main = new System.Windows.Forms.TextBox();
            this.Stud_del = new System.Windows.Forms.Button();
            this.Back_to_studlist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Введите номер удаляемого студента:";
            // 
            // main
            // 
            this.main.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.main.Location = new System.Drawing.Point(17, 56);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(249, 26);
            this.main.TabIndex = 10;
            // 
            // Stud_del
            // 
            this.Stud_del.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Stud_del.Location = new System.Drawing.Point(174, 97);
            this.Stud_del.Name = "Stud_del";
            this.Stud_del.Size = new System.Drawing.Size(92, 30);
            this.Stud_del.TabIndex = 9;
            this.Stud_del.Text = "Удалить";
            this.Stud_del.UseVisualStyleBackColor = true;
            this.Stud_del.Click += new System.EventHandler(this.Group_del_Click);
            // 
            // Back_to_studlist
            // 
            this.Back_to_studlist.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_to_studlist.Location = new System.Drawing.Point(17, 97);
            this.Back_to_studlist.Name = "Back_to_studlist";
            this.Back_to_studlist.Size = new System.Drawing.Size(87, 30);
            this.Back_to_studlist.TabIndex = 8;
            this.Back_to_studlist.Text = "Назад";
            this.Back_to_studlist.UseVisualStyleBackColor = true;
            this.Back_to_studlist.Click += new System.EventHandler(this.Back_to_grouplist_Click);
            // 
            // Delete_stud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 151);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.main);
            this.Controls.Add(this.Stud_del);
            this.Controls.Add(this.Back_to_studlist);
            this.Name = "Delete_stud";
            this.Text = "Delete_stud";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox main;
        private System.Windows.Forms.Button Stud_del;
        private System.Windows.Forms.Button Back_to_studlist;
    }
}