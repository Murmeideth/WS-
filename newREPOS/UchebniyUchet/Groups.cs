using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UchebniyUchet
{
    public partial class Groups : Form
    {
        functions Func = new functions();
        public Groups()
        {
            InitializeComponent();
            Func.getInfo(gruppa);
            gruppa.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void Back_groups_Click(object sender, EventArgs e)
        {
            Form1 MainWin = new Form1();
            this.Close();
            MainWin.Show();
        }

        private void Refresh_groups_Click(object sender, EventArgs e)
        {
            gruppa.Items.Clear();
            Func.getInfo(gruppa);
            gruppa.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void Delete_group_Click(object sender, EventArgs e)
        {
            Delete_group DelGWin = new Delete_group();
            DelGWin.Show();
        }

        private void Add_group_Click(object sender, EventArgs e)
        {
            Group_add AddGWin = new Group_add();
            AddGWin.Show();
        }
    }
}
