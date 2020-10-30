using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AP
{
    public partial class Form1 : Form
    {
        
        functions Func = new functions();
        public Form1()
        {
            InitializeComponent();
            Func.ShowList(List);
            List.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void NewHoli_Click(object sender, EventArgs e)
        {
            NewEvent WinEvent = new NewEvent();
            WinEvent.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteEvent_Click(object sender, EventArgs e)
        {
            Delete_event DelWin = new Delete_event();
            DelWin.Show();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            List.Items.Clear();
            Func.ShowList(List);
        }

        private void employersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employers WinEmp = new Employers();
            WinEmp.Show();
            this.Hide();
        }

        private void documentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documents WinDoc = new Documents();
            WinDoc.Show();
            this.Hide();
        }
    }
}
