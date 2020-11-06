namespace UchebniyUchet
{
    partial class Delete_group
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
            this.gruppa = new System.Windows.Forms.TextBox();
            this.Group_del = new System.Windows.Forms.Button();
            this.Back_to_grouplist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Введите номер удаляемой группы:";
            // 
            // gruppa
            // 
            this.gruppa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gruppa.Location = new System.Drawing.Point(17, 56);
            this.gruppa.Name = "gruppa";
            this.gruppa.Size = new System.Drawing.Size(249, 26);
            this.gruppa.TabIndex = 6;
            // 
            // Group_del
            // 
            this.Group_del.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Group_del.Location = new System.Drawing.Point(174, 97);
            this.Group_del.Name = "Group_del";
            this.Group_del.Size = new System.Drawing.Size(92, 30);
            this.Group_del.TabIndex = 5;
            this.Group_del.Text = "Удалить";
            this.Group_del.UseVisualStyleBackColor = true;
            this.Group_del.Click += new System.EventHandler(this.Group_del_Click);
            // 
            // Back_to_grouplist
            // 
            this.Back_to_grouplist.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_to_grouplist.Location = new System.Drawing.Point(17, 97);
            this.Back_to_grouplist.Name = "Back_to_grouplist";
            this.Back_to_grouplist.Size = new System.Drawing.Size(87, 30);
            this.Back_to_grouplist.TabIndex = 4;
            this.Back_to_grouplist.Text = "Назад";
            this.Back_to_grouplist.UseVisualStyleBackColor = true;
            this.Back_to_grouplist.Click += new System.EventHandler(this.Back_to_grouplist_Click);
            // 
            // Delete_group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 151);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gruppa);
            this.Controls.Add(this.Group_del);
            this.Controls.Add(this.Back_to_grouplist);
            this.Name = "Delete_group";
            this.Text = "Delete_group";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gruppa;
        private System.Windows.Forms.Button Group_del;
        private System.Windows.Forms.Button Back_to_grouplist;
    }
}