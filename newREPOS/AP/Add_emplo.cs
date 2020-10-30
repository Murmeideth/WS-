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
    public partial class Add_emplo : Form
    {
        functions Func = new functions();
        public Add_emplo()
        {
            InitializeComponent();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Done_button_Click(object sender, EventArgs e)
        {
            Func.Add_Emplo(ID_box, Name_box, Desc_box, Position_box);            
            this.Close();
        }
    }
}
