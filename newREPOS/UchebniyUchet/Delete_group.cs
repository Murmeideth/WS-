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
    public partial class Delete_group : Form
    {
        functions Func = new functions();
        public Delete_group()
        {
            InitializeComponent();
        }

        private void Group_del_Click(object sender, EventArgs e)
        {
            Func.DeleteRow(gruppa);
            this.Close();
        }

        private void Back_to_grouplist_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
