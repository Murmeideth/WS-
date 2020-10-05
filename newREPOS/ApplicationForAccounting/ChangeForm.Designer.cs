namespace ApplicationForAccounting
{
    partial class ChangeForm
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
            this.WName = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.Adress = new System.Windows.Forms.Label();
            this.Sex = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.AdresBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SexList = new System.Windows.Forms.ListBox();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // WName
            // 
            this.WName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WName.Location = new System.Drawing.Point(12, 9);
            this.WName.Name = "WName";
            this.WName.Size = new System.Drawing.Size(77, 39);
            this.WName.TabIndex = 0;
            this.WName.Text = "Имя:";
            this.WName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Phone
            // 
            this.Phone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Phone.Location = new System.Drawing.Point(12, 48);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(88, 39);
            this.Phone.TabIndex = 0;
            this.Phone.Text = "Телефон:";
            this.Phone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Adress
            // 
            this.Adress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Adress.Location = new System.Drawing.Point(12, 87);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(77, 39);
            this.Adress.TabIndex = 0;
            this.Adress.Text = "Адрес:";
            this.Adress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Sex
            // 
            this.Sex.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sex.Location = new System.Drawing.Point(12, 126);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(77, 39);
            this.Sex.TabIndex = 0;
            this.Sex.Text = "Пол:";
            this.Sex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameBox.Location = new System.Drawing.Point(125, 15);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(243, 29);
            this.NameBox.TabIndex = 1;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneBox.Location = new System.Drawing.Point(154, 54);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(214, 29);
            this.PhoneBox.TabIndex = 1;
            // 
            // AdresBox
            // 
            this.AdresBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdresBox.Location = new System.Drawing.Point(125, 93);
            this.AdresBox.Name = "AdresBox";
            this.AdresBox.Size = new System.Drawing.Size(243, 29);
            this.AdresBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(121, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "+7";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SexList
            // 
            this.SexList.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SexList.FormattingEnabled = true;
            this.SexList.ItemHeight = 21;
            this.SexList.Items.AddRange(new object[] {
            "Мужской",
            "Женский",
            "Неизвестно",
            "Засекречено"});
            this.SexList.Location = new System.Drawing.Point(125, 133);
            this.SexList.Name = "SexList";
            this.SexList.Size = new System.Drawing.Size(243, 88);
            this.SexList.TabIndex = 3;
            // 
            // ChangeButton
            // 
            this.ChangeButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeButton.Location = new System.Drawing.Point(264, 247);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(104, 31);
            this.ChangeButton.TabIndex = 4;
            this.ChangeButton.Text = "Готово";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(154, 247);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(104, 31);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 290);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.SexList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdresBox);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.Adress);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.WName);
            this.Name = "ChangeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WName;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label Adress;
        private System.Windows.Forms.Label Sex;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox AdresBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox SexList;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}