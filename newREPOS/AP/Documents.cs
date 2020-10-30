using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP
{
    public partial class Documents : Form
    {
        functions Func = new functions();
        public Documents()
        {
            InitializeComponent();
            Func.ShowDoc(Doc_list);
            Doc_list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void Refresh_button_Click(object sender, EventArgs e)
        {
            Doc_list.Items.Clear();
            Func.ShowDoc(Doc_list);
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Form1 MainForm = new Form1();
            MainForm.Show();
            this.Close();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            Delete_doc DelWin = new Delete_doc();
            DelWin.Show();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            Add_doc AddWin = new Add_doc();
            AddWin.Show();
        }
    }
}
 