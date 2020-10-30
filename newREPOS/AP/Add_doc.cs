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
    public partial class Add_doc : Form
    {
        functions Func = new functions();
        public Add_doc()
        {
            InitializeComponent();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Done_button_Click(object sender, EventArgs e)
        {
            Func.Add_Doc(ID_box, Name_box, Disc_box);
            this.Close();
        }
    }
}
