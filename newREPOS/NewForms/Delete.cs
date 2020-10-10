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
    public partial class Delete : Form
    {
        WorkWithEmplo Func = new WorkWithEmplo();
        Form1 FirstForm = new Form1();
        public Delete()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            FirstForm.Visible = true;
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Вы уверены, что хотите удалить данные сотрудника?", "Вы уверены?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if(Result == DialogResult.Yes)
            {
                try
                {
                    try
                    {
                        Convert.ToInt32(IDBox.Text);
                        Func.deleteInfo(IDBox);
                        FirstForm.Visible = true;
                        this.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                
            }
        }
    }
}
