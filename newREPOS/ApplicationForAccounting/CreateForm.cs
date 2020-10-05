using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationForAccounting
{
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
            Form1 form = new Form1();
            form.Close();
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        // сохранение файла
        private void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {

                try
                {
                    Convert.ToInt32(PhoneBox.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Введите корректный номер телефона!");
                    return;
                }

                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                string filename = saveFileDialog1.FileName;
                // сохраняем текст в файл
                System.IO.File.WriteAllText(filename, NameBox.Text + Environment.NewLine + PhoneBox.Text + Environment.NewLine + AdressBox.Text + Environment.NewLine + SexList.SelectedItem.ToString());
                MessageBox.Show("Файл сохранен");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Вы забыли указать пол!");
                return;
            }
        }
    }
}
