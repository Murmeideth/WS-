namespace ApplicationForAccounting
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Open = new System.Windows.Forms.Button();
            this.CloseApp = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.GreetingText = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Open
            // 
            this.Open.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Open.Location = new System.Drawing.Point(122, 116);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(105, 37);
            this.Open.TabIndex = 0;
            this.Open.Text = "Открыть";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // CloseApp
            // 
            this.CloseApp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseApp.Location = new System.Drawing.Point(122, 159);
            this.CloseApp.Name = "CloseApp";
            this.CloseApp.Size = new System.Drawing.Size(105, 37);
            this.CloseApp.TabIndex = 0;
            this.CloseApp.Text = "Выйти";
            this.CloseApp.UseVisualStyleBackColor = true;
            this.CloseApp.Click += new System.EventHandler(this.CloseApp_Click);
            // 
            // Create
            // 
            this.Create.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Create.Location = new System.Drawing.Point(16, 116);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(105, 37);
            this.Create.TabIndex = 0;
            this.Create.Text = "Создать";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // GreetingText
            // 
            this.GreetingText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GreetingText.Location = new System.Drawing.Point(12, 5);
            this.GreetingText.Name = "GreetingText";
            this.GreetingText.Size = new System.Drawing.Size(325, 108);
            this.GreetingText.TabIndex = 1;
            this.GreetingText.Text = "Вас приветствует окно для работы с личными делами работников учреждения. \r\nПожалу" +
    "йста, выберите дальнейшее действие.";
            this.GreetingText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.Location = new System.Drawing.Point(232, 116);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(105, 37);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 208);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.GreetingText);
            this.Controls.Add(this.CloseApp);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Open);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Диалоговое окно";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button CloseApp;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Label GreetingText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Delete;
    }
}

