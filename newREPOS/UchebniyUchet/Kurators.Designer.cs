namespace UchebniyUchet
{
    partial class Kurators
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
            this.kurator = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name_kur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Refresh_kur = new System.Windows.Forms.Button();
            this.Back_kur = new System.Windows.Forms.Button();
            this.Add_kur = new System.Windows.Forms.Button();
            this.Delete_kur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kurator
            // 
            this.kurator.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Name_kur,
            this.Position});
            this.kurator.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kurator.GridLines = true;
            this.kurator.HideSelection = false;
            this.kurator.Location = new System.Drawing.Point(13, 13);
            this.kurator.Name = "kurator";
            this.kurator.Size = new System.Drawing.Size(513, 345);
            this.kurator.TabIndex = 0;
            this.kurator.UseCompatibleStateImageBehavior = false;
            this.kurator.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "№ п/п";
            // 
            // Name_kur
            // 
            this.Name_kur.Text = "ФИО";
            this.Name_kur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Position
            // 
            this.Position.Text = "Должность";
            this.Position.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Refresh_kur
            // 
            this.Refresh_kur.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Refresh_kur.Location = new System.Drawing.Point(426, 369);
            this.Refresh_kur.Name = "Refresh_kur";
            this.Refresh_kur.Size = new System.Drawing.Size(100, 30);
            this.Refresh_kur.TabIndex = 1;
            this.Refresh_kur.Text = "Обновить";
            this.Refresh_kur.UseVisualStyleBackColor = true;
            this.Refresh_kur.Click += new System.EventHandler(this.Refresh_kur_Click);
            // 
            // Back_kur
            // 
            this.Back_kur.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_kur.Location = new System.Drawing.Point(320, 369);
            this.Back_kur.Name = "Back_kur";
            this.Back_kur.Size = new System.Drawing.Size(100, 30);
            this.Back_kur.TabIndex = 1;
            this.Back_kur.Text = "Назад";
            this.Back_kur.UseVisualStyleBackColor = true;
            this.Back_kur.Click += new System.EventHandler(this.Back_kur_Click);
            // 
            // Add_kur
            // 
            this.Add_kur.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_kur.Location = new System.Drawing.Point(12, 369);
            this.Add_kur.Name = "Add_kur";
            this.Add_kur.Size = new System.Drawing.Size(100, 30);
            this.Add_kur.TabIndex = 1;
            this.Add_kur.Text = "Добавить";
            this.Add_kur.UseVisualStyleBackColor = true;
            this.Add_kur.Click += new System.EventHandler(this.Add_kur_Click);
            // 
            // Delete_kur
            // 
            this.Delete_kur.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_kur.Location = new System.Drawing.Point(118, 369);
            this.Delete_kur.Name = "Delete_kur";
            this.Delete_kur.Size = new System.Drawing.Size(100, 30);
            this.Delete_kur.TabIndex = 1;
            this.Delete_kur.Text = "Удалить";
            this.Delete_kur.UseVisualStyleBackColor = true;
            this.Delete_kur.Click += new System.EventHandler(this.Delete_kur_Click);
            // 
            // Kurators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 411);
            this.Controls.Add(this.Delete_kur);
            this.Controls.Add(this.Add_kur);
            this.Controls.Add(this.Back_kur);
            this.Controls.Add(this.Refresh_kur);
            this.Controls.Add(this.kurator);
            this.Name = "Kurators";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kurators";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView kurator;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Name_kur;
        private System.Windows.Forms.ColumnHeader Position;
        private System.Windows.Forms.Button Refresh_kur;
        private System.Windows.Forms.Button Back_kur;
        private System.Windows.Forms.Button Add_kur;
        private System.Windows.Forms.Button Delete_kur;
    }
}