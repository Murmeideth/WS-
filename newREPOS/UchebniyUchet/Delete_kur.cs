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
    public partial class Delete_kur : Form
    {
        functions Func = new functions();
        public Delete_kur()
        {
            InitializeComponent();
        }

        private void Back_to_kurlist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Kur_del_Click(object sender, EventArgs e)
        {
            Func.DeleteRow(kurator);
            this.Close();
        }
    }
}
