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
    public partial class ReadForm : Form
    {
        public string SomeName, SomePhone, SomeAdress, SomeSex, filename;

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            ChangeForm Form = new ChangeForm();
            this.Hide();
            Form.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form1 Form = new Form1();
            this.Hide();
            Form.Show();
        }

        public ReadForm()
        {
            InitializeComponent();
            Form1 Form = new Form1();
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                this.Hide();
                Form.Show();
            }
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            using (var sr = new StreamReader(filename))
            {
                SomeName = sr.ReadLine();
                SomePhone = sr.ReadLine();
                SomeAdress = sr.ReadLine();
                SomeSex = sr.ReadLine();
            }
            Form.Close();
            NameLabel.Text = SomeName;
            PhoneLabel.Text = SomePhone;
            AdressLabel.Text = SomeAdress;
            SexLabel.Text = SomeSex;            
        }

        
    }
}
