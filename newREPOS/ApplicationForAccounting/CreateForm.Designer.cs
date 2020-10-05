namespace ApplicationForAccounting
{
    partial class CreateForm
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
            this.CreateButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.WorkerName = new System.Windows.Forms.Label();
            this.PhoneNum = new System.Windows.Forms.Label();
            this.Adress = new System.Windows.Forms.Label();
            this.Sex = new System.Windows.Forms.Label();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.AdressBox = new System.Windows.Forms.TextBox();
            this.FirstNUm = new System.Windows.Forms.Label();
            this.SexList = new System.Windows.Forms.ListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // CreateButton
            // 
            this.CreateButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateButton.Location = new System.Drawing.Point(264, 247);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(104, 31);
            this.CreateButton.TabIndex = 0;
            this.CreateButton.Text = "Создать";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(154, 247);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(104, 31);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // WorkerName
            // 
            this.WorkerName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkerName.Location = new System.Drawing.Point(12, 9);
            this.WorkerName.Name = "WorkerName";
            this.WorkerName.Size = new System.Drawing.Size(77, 39);
            this.WorkerName.TabIndex = 1;
            this.WorkerName.Text = "Имя:";
            this.WorkerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PhoneNum
            // 
            this.PhoneNum.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneNum.Location = new System.Drawing.Point(12, 48);
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.Size = new System.Drawing.Size(107, 39);
            this.PhoneNum.TabIndex = 1;
            this.PhoneNum.Text = "Телефон:";
            this.PhoneNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Adress
            // 
            this.Adress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Adress.Location = new System.Drawing.Point(12, 87);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(77, 39);
            this.Adress.TabIndex = 1;
            this.Adress.Text = "Адрес:";
            this.Adress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Sex
            // 
            this.Sex.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sex.Location = new System.Drawing.Point(12, 126);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(77, 39);
            this.Sex.TabIndex = 1;
            this.Sex.Text = "Пол:";
            this.Sex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneBox.Location = new System.Drawing.Point(154, 54);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(214, 29);
            this.PhoneBox.TabIndex = 2;
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameBox.Location = new System.Drawing.Point(125, 15);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(243, 29);
            this.NameBox.TabIndex = 2;
            // 
            // AdressBox
            // 
            this.AdressBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdressBox.Location = new System.Drawing.Point(125, 93);
            this.AdressBox.Name = "AdressBox";
            this.AdressBox.Size = new System.Drawing.Size(243, 29);
            this.AdressBox.TabIndex = 2;
            // 
            // FirstNUm
            // 
            this.FirstNUm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNUm.Location = new System.Drawing.Point(121, 57);
            this.FirstNUm.Name = "FirstNUm";
            this.FirstNUm.Size = new System.Drawing.Size(30, 23);
            this.FirstNUm.TabIndex = 3;
            this.FirstNUm.Text = "+7";
            // 
            // SexList
            // 
            this.SexList.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SexList.FormattingEnabled = true;
            this.SexList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SexList.ItemHeight = 21;
            this.SexList.Items.AddRange(new object[] {
            "Мужской",
            "Женский",
            "Неизвестно",
            "Засекречено"});
            this.SexList.Location = new System.Drawing.Point(125, 133);
            this.SexList.Name = "SexList";
            this.SexList.Size = new System.Drawing.Size(243, 88);
            this.SexList.TabIndex = 4;
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 290);
            this.Controls.Add(this.SexList);
            this.Controls.Add(this.FirstNUm);
            this.Controls.Add(this.AdressBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.Adress);
            this.Controls.Add(this.PhoneNum);
            this.Controls.Add(this.WorkerName);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CreateButton);
            this.Name = "CreateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label WorkerName;
        private System.Windows.Forms.Label PhoneNum;
        private System.Windows.Forms.Label Adress;
        private System.Windows.Forms.Label Sex;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox AdressBox;
        private System.Windows.Forms.Label FirstNUm;
        private System.Windows.Forms.ListBox SexList;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}