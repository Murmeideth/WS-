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
    public partial class Kurators : Form
    {
        functions Func = new functions();
        public Kurators()
        {
            InitializeComponent();
            Func.getInfo(kurator);
            kurator.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void Back_kur_Click(object sender, EventArgs e)
        {
            Form1 MainWin = new Form1();
            this.Close();
            MainWin.Show();
        }

        private void Refresh_kur_Click(object sender, EventArgs e)
        {
            kurator.Items.Clear();
            Func.getInfo(kurator);
            kurator.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void Delete_kur_Click(object sender, EventArgs e)
        {
            Delete_kur DelKWin = new Delete_kur();
            DelKWin.Show();
        }

        private void Add_kur_Click(object sender, EventArgs e)
        {
            Kurator_add AddKWin = new Kurator_add();
            AddKWin.Show();
        }
    }
}
