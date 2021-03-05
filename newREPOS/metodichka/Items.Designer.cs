
namespace metodichka
{
    partial class Items
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
            this.list = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quatity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Refresh = new System.Windows.Forms.Button();
            this.add_item = new System.Windows.Forms.Button();
            this.Prihod = new System.Windows.Forms.Button();
            this.Rashod = new System.Windows.Forms.Button();
            this.Order = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.name,
            this.quatity,
            this.Price});
            this.list.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list.GridLines = true;
            this.list.HideSelection = false;
            this.list.Location = new System.Drawing.Point(12, 12);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(411, 241);
            this.list.TabIndex = 0;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "№ п/п";
            // 
            // name
            // 
            this.name.Text = "Наименование";
            this.name.Width = 131;
            // 
            // quatity
            // 
            this.quatity.Text = "Количество";
            this.quatity.Width = 114;
            // 
            // Price
            // 
            this.Price.Text = "Стоимость";
            this.Price.Width = 101;
            // 
            // Refresh
            // 
            this.Refresh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Refresh.Location = new System.Drawing.Point(446, 12);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(126, 31);
            this.Refresh.TabIndex = 1;
            this.Refresh.Text = "Обновить";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // add_item
            // 
            this.add_item.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_item.Location = new System.Drawing.Point(446, 49);
            this.add_item.Name = "add_item";
            this.add_item.Size = new System.Drawing.Size(126, 50);
            this.add_item.TabIndex = 2;
            this.add_item.Text = "Добавить товар";
            this.add_item.UseVisualStyleBackColor = true;
            this.add_item.Click += new System.EventHandler(this.Add_item_Click);
            // 
            // Prihod
            // 
            this.Prihod.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Prihod.Location = new System.Drawing.Point(446, 106);
            this.Prihod.Name = "Prihod";
            this.Prihod.Size = new System.Drawing.Size(126, 45);
            this.Prihod.TabIndex = 3;
            this.Prihod.Text = "Приход";
            this.Prihod.UseVisualStyleBackColor = true;
            this.Prihod.Click += new System.EventHandler(this.Prihod_Click);
            // 
            // Rashod
            // 
            this.Rashod.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rashod.Location = new System.Drawing.Point(446, 157);
            this.Rashod.Name = "Rashod";
            this.Rashod.Size = new System.Drawing.Size(126, 45);
            this.Rashod.TabIndex = 3;
            this.Rashod.Text = "Расход";
            this.Rashod.UseVisualStyleBackColor = true;
            // 
            // Order
            // 
            this.Order.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Order.Location = new System.Drawing.Point(446, 208);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(126, 45);
            this.Order.TabIndex = 3;
            this.Order.Text = "Заказы";
            this.Order.UseVisualStyleBackColor = true;
            this.Order.Click += new System.EventHandler(this.Orders_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(579, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 87);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить пользователя";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 264);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.Rashod);
            this.Controls.Add(this.Prihod);
            this.Controls.Add(this.add_item);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.list);
            this.Name = "Items";
            this.Text = "Items";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader quatity;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button add_item;
        private System.Windows.Forms.Button Prihod;
        private System.Windows.Forms.Button Rashod;
        private System.Windows.Forms.Button Order;
        private System.Windows.Forms.Button button1;
    }

}