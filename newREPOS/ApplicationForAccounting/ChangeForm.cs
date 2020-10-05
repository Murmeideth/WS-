using System;
using System.IO;
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
    public partial class ChangeForm : Form
    {
        public string SName, SPhone, SAdress, SSex, SFileName;

        private void ChangeButton_Click(object sender, EventArgs e)
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
                // сохраняем текст в файл
                System.IO.File.WriteAllText(SFileName, NameBox.Text + Environment.NewLine + PhoneBox.Text + Environment.NewLine + AdresBox.Text + Environment.NewLine + SexList.SelectedItem.ToString());
                MessageBox.Show("Файл сохранен");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Вы забыли выбрать пол!");
                return;
            }
        }

        public ChangeForm()
        {
            InitializeComponent();
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {                
                return;
            }
            // получаем выбранный файл
            SFileName = openFileDialog1.FileName;
            using (var sr = new StreamReader(SFileName))
            {
                SName = sr.ReadLine();
                SPhone = sr.ReadLine();
                SAdress = sr.ReadLine();
                SSex = sr.ReadLine();
            }
            NameBox.Text = SName;
            PhoneBox.Text = SPhone;
            AdresBox.Text = SAdress;
            if (SSex == "Мужской")
                SexList.SelectedValue = 0;
            else if (SSex == "Женский")
                SexList.SelectedValue = 1;
            else if (SSex == "Неизвестно")
                SexList.SelectedValue = 2;
            else if (SSex == "Засекречено")
                SexList.SelectedValue = 3;
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ReadForm Form = new ReadForm();
            this.Hide();
            Form.Show();
        }
    }
}
