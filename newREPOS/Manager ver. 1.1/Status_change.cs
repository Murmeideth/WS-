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
    public partial class Status_change : Form
    {
        functions Func = new functions();
        public Status_change()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void change_status_Click(object sender, EventArgs e)
        {
            Func.ChangeStatus(id_quest, status_index_box);
            this.Close();
        }
    }
}
