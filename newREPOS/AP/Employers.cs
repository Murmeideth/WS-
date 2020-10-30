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
    public partial class Employers : Form
    {
        functions Func = new functions();
                
        public Employers()
        {
            InitializeComponent();
            Func.ShowEmplo(Employers_list);
            Employers_list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);            
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Form1 MainWin = new Form1();
            MainWin.Show();
            this.Close();
        }

        private void Add_emplo_Click(object sender, EventArgs e)
        {
            Add_emplo AddWin = new Add_emplo();
            AddWin.Show();
        }

        private void Delete_emplo_Click(object sender, EventArgs e)
        {
            Delete_empl DelWin = new Delete_empl();
            DelWin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employers_list.Items.Clear();
            Func.ShowEmplo(Employers_list);
        }
    }
}
