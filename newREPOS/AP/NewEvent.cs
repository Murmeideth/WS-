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
    public partial class NewEvent : Form
    {
        Form1 MainWin = new Form1();
        functions Func = new functions();
        public NewEvent()
        {
            InitializeComponent();
            Func.getInfo(employers);
            Func.getInfo(documents);
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            MainWin.Show();
            this.Close();
        }

        private void Done_button_Click(object sender, EventArgs e)
        {
            Func.NewEvent(Event_name, Event_description, employers, DatePicker, documents);
            MainWin.Show();
            this.Close();
        }
    }
}
