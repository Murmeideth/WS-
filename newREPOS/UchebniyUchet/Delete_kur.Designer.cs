namespace UchebniyUchet
{
    partial class Delete_kur
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
            this.Back_to_kurlist = new System.Windows.Forms.Button();
            this.Kur_del = new System.Windows.Forms.Button();
            this.kurator = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Back_to_kurlist
            // 
            this.Back_to_kurlist.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_to_kurlist.Location = new System.Drawing.Point(16, 102);
            this.Back_to_kurlist.Name = "Back_to_kurlist";
            this.Back_to_kurlist.Size = new System.Drawing.Size(87, 30);
            this.Back_to_kurlist.TabIndex = 0;
            this.Back_to_kurlist.Text = "Назад";
            this.Back_to_kurlist.UseVisualStyleBackColor = true;
            this.Back_to_kurlist.Click += new System.EventHandler(this.Back_to_kurlist_Click);
            // 
            // Kur_del
            // 
            this.Kur_del.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Kur_del.Location = new System.Drawing.Point(173, 102);
            this.Kur_del.Name = "Kur_del";
            this.Kur_del.Size = new System.Drawing.Size(92, 30);
            this.Kur_del.TabIndex = 1;
            this.Kur_del.Text = "Удалить";
            this.Kur_del.UseVisualStyleBackColor = true;
            this.Kur_del.Click += new System.EventHandler(this.Kur_del_Click);
            // 
            // kurator
            // 
            this.kurator.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kurator.Location = new System.Drawing.Point(16, 61);
            this.kurator.Name = "kurator";
            this.kurator.Size = new System.Drawing.Size(249, 26);
            this.kurator.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите номер удаляемого куратора";
            // 
            // Delete_kur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 151);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kurator);
            this.Controls.Add(this.Kur_del);
            this.Controls.Add(this.Back_to_kurlist);
            this.Name = "Delete_kur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete_kur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back_to_kurlist;
        private System.Windows.Forms.Button Kur_del;
        private System.Windows.Forms.TextBox kurator;
        private System.Windows.Forms.Label label1;
    }
}