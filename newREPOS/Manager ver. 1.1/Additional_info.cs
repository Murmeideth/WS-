using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{
    public partial class Additional_info : Form
    {
        functions Func = new functions();
        public Additional_info(string mode)
        {
            InitializeComponent();
            if(mode == "category")
            {
                this.Width = 245;
                this.Height = 485;
                this.Text = "Категории";
                cat_list.Enabled = true;
                add_cat.Enabled = true;
                update_cat.Enabled = true;
                delete_cat.Enabled = true;
                refresh_cat.Enabled = true;
                cat_list.Visible = true;
                add_cat.Visible = true;
                update_cat.Visible = true;
                delete_cat.Visible = true;
                refresh_cat.Visible = true;
                Func.getInfo(mode, cat_list);
                cat_list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            else if(mode == "emplo")
            {
                this.Width = 480;
                this.Height = 440;
                this.Text = "Работники";
                emplo_list.Enabled = true;
                new_emplo.Enabled = true;
                update_emplo.Enabled = true;
                delete_emplo.Enabled = true;
                refresh_emplo.Enabled = true;
                emplo_list.Visible = true;
                new_emplo.Visible = true;
                update_emplo.Visible = true;
                delete_emplo.Visible = true;
                refresh_emplo.Visible = true;
                Func.getInfo(mode, emplo_list);
                emplo_list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }

        private void refresh_cat_Click(object sender, EventArgs e)
        {
            cat_list.Items.Clear();
            Func.getInfo("category", cat_list);
            cat_list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void refresh_emplo_Click(object sender, EventArgs e)
        {
            emplo_list.Items.Clear();
            Func.getInfo("emplo", emplo_list);
            emplo_list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void new_emplo_Click(object sender, EventArgs e)
        {
            additional_cud Win = new additional_cud("emplo_create");
            Win.Show();
        }

        private void update_emplo_Click(object sender, EventArgs e)
        {
            additional_cud Win = new additional_cud("emplo_update");
            Win.Show();
        }

        private void delete_emplo_Click(object sender, EventArgs e)
        {
            additional_cud Win = new additional_cud("emplo_delete");
            Win.Show();
        }

        private void add_cat_Click(object sender, EventArgs e)
        {
            additional_cud Win = new additional_cud("cat_add");
            Win.Show();
        }

        private void update_cat_Click(object sender, EventArgs e)
        {
            additional_cud Win = new additional_cud("cat_update");
            Win.Show();
        }

        private void delete_cat_Click(object sender, EventArgs e)
        {
            additional_cud Win = new additional_cud("cat_delete");
            Win.Show();
        }
    }
}
