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
    public partial class Form1 : Form
    {
        functions Func = new functions();
        public Form1()
        {
            InitializeComponent();
            Func.getInfo(main);
            main.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void exitButtonMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Refresh_main_Click(object sender, EventArgs e)
        {
            main.Items.Clear();
            Func.getInfo(main);
            main.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void OpenGroupList_Click(object sender, EventArgs e)
        {
            Groups WinGroups = new Groups();
            WinGroups.Show();
            this.Hide();
        }

        private void OpenKuratorList_Click(object sender, EventArgs e)
        {
            Kurators WinKur = new Kurators();
            WinKur.Show();
            this.Hide();
        }

        private void Delete_student_Click(object sender, EventArgs e)
        {
            Delete_stud DelMWin = new Delete_stud();
            DelMWin.Show();
        }

        private void Add_strudent_Click(object sender, EventArgs e)
        {
            Stud_add AddSWin = new Stud_add();
            AddSWin.Show();
        }
    }
}
