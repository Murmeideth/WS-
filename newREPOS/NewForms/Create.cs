using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewForms
{
    public partial class Create : Form
    {
        WorkWithEmplo Func = new WorkWithEmplo();
        public Create()
        {
            InitializeComponent();
            toolTip1.SetToolTip(BirthBox, "Вводите дату в форме 'ГГГГ-ММ-ДД'");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 FirstForm = new Form1();
            FirstForm.Visible = true;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 FirstForm = new Form1();
                if (PhoneBox.Text != "")
                {
                    Convert.ToInt64(PhoneBox.Text);
                }
                Func.SaveEmplo(NameBox, BirthBox, PhoneBox, AdressBox);
                FirstForm.Visible = true;
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Номер телефона введен некорректно!");
                return;
            }
        }
    }
}
