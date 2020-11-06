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
    public partial class Kurator_add : Form
    {
        functions Func = new functions();
        public Kurator_add()
        {
            InitializeComponent();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            Func.addInfoAdditional(Id_box, Name_box, Position_box);
            this.Close();
        }
    }
}
