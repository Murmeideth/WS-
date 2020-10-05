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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            Close();            
        }

        private void Create_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateForm FormC = new CreateForm();
            FormC.Show();           
        }

        private void Open_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReadForm FormR = new ReadForm();
            FormR.Show();
            /*try
            {
                using (var sr = new StreamReader(filename))
                {
                    Form.SomeName = sr.ReadLine();
                    Form.SomePhone = sr.ReadLine();
                    Form.SomeAdress = sr.ReadLine();
                    Form.SomeSex = sr.ReadLine();
                }
            
            }
            catch (IOException)
            {
                MessageBox.Show("Этот файл не может быть открыт!");
            } */   
            

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string filename = openFileDialog1.FileName;
            if (File.Exists(filename))
                {
                    File.Delete(filename);
                }
        }
    }
    }

