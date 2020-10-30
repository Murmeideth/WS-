namespace AP
{
    partial class Add_doc
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
            this.Disc_label = new System.Windows.Forms.Label();
            this.Name_label = new System.Windows.Forms.Label();
            this.Num_label = new System.Windows.Forms.Label();
            this.ID_box = new System.Windows.Forms.TextBox();
            this.Name_box = new System.Windows.Forms.TextBox();
            this.Disc_box = new System.Windows.Forms.TextBox();
            this.Done_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Disc_label
            // 
            this.Disc_label.AutoSize = true;
            this.Disc_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Disc_label.Location = new System.Drawing.Point(12, 110);
            this.Disc_label.Name = "Disc_label";
            this.Disc_label.Size = new System.Drawing.Size(78, 19);
            this.Disc_label.TabIndex = 2;
            this.Disc_label.Text = "Описание";
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_label.Location = new System.Drawing.Point(12, 73);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(73, 19);
            this.Name_label.TabIndex = 3;
            this.Name_label.Text = "Название";
            // 
            // Num_label
            // 
            this.Num_label.AutoSize = true;
            this.Num_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Num_label.Location = new System.Drawing.Point(12, 35);
            this.Num_label.Name = "Num_label";
            this.Num_label.Size = new System.Drawing.Size(24, 19);
            this.Num_label.TabIndex = 4;
            this.Num_label.Text = "№";
            // 
            // ID_box
            // 
            this.ID_box.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID_box.Location = new System.Drawing.Point(189, 32);
            this.ID_box.Name = "ID_box";
            this.ID_box.Size = new System.Drawing.Size(240, 26);
            this.ID_box.TabIndex = 5;
            // 
            // Name_box
            // 
            this.Name_box.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_box.Location = new System.Drawing.Point(189, 70);
            this.Name_box.Name = "Name_box";
            this.Name_box.Size = new System.Drawing.Size(240, 26);
            this.Name_box.TabIndex = 5;
            // 
            // Disc_box
            // 
            this.Disc_box.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Disc_box.Location = new System.Drawing.Point(189, 111);
            this.Disc_box.Name = "Disc_box";
            this.Disc_box.Size = new System.Drawing.Size(240, 26);
            this.Disc_box.TabIndex = 5;
            // 
            // Done_button
            // 
            this.Done_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Done_button.Location = new System.Drawing.Point(341, 156);
            this.Done_button.Name = "Done_button";
            this.Done_button.Size = new System.Drawing.Size(88, 30);
            this.Done_button.TabIndex = 6;
            this.Done_button.Text = "Готово";
            this.Done_button.UseVisualStyleBackColor = true;
            this.Done_button.Click += new System.EventHandler(this.Done_button_Click);
            // 
            // Back_button
            // 
            this.Back_button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_button.Location = new System.Drawing.Point(247, 156);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(88, 30);
            this.Back_button.TabIndex = 6;
            this.Back_button.Text = "Назад";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Add_doc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 198);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Done_button);
            this.Controls.Add(this.Disc_box);
            this.Controls.Add(this.Name_box);
            this.Controls.Add(this.ID_box);
            this.Controls.Add(this.Disc_label);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.Num_label);
            this.Name = "Add_doc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_doc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Disc_label;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.Label Num_label;
        private System.Windows.Forms.TextBox ID_box;
        private System.Windows.Forms.TextBox Name_box;
        private System.Windows.Forms.TextBox Disc_box;
        private System.Windows.Forms.Button Done_button;
        private System.Windows.Forms.Button Back_button;
    }
}