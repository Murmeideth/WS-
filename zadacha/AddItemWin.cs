using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace metodichka
{
    public partial class AddItemWin : Form
    {
        public string modeS = "";
        int item;
        void setMode(string mode)
        {
            if (mode == "add")
            {
                AddButton.Text = "Добавить";
            }
            else if (mode == "change")
            {
                AddButton.Text = "Изменить";
                string Info = "select name, content, id_autor from articles where Id_article =" + item.ToString()  +";";
                MySqlConnection conn = DBUtils.GetDbConnection();
                MySqlCommand cmInfo = new MySqlCommand(Info, conn);
                MySqlDataReader inRead;
                cmInfo.CommandTimeout = 60;
                try
                {
                    conn.Open();
                    inRead = cmInfo.ExecuteReader();
                    if (inRead.HasRows)
                    {
                        while (inRead.Read())
                        {
                            nameBox.Text = inRead.GetString(0);
                            contentBox.Text = inRead.GetString(1);
                            comboBox1.SelectedIndex = Convert.ToInt32(inRead.GetString(2)) - 1;
                        }
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        void getNames(ComboBox Box)
        {
            string query = "select name from autors;";
            MySqlConnection conn = DBUtils.GetDbConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            MySqlDataReader rd;
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        string row = rd.GetString(0);
                        Box.Items.Add(row);
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public AddItemWin(string mode, int id)
        {
            InitializeComponent();
            getNames(comboBox1);
            modeS = mode;
            item = id;
            setMode(mode);            
        }

       
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            if (modeS == "add")
            {
                string query = "insert into articles(name, content, publ, id_autor) values('" + nameBox.Text + "', '" + contentBox.Text + "', now(), " + Convert.ToString(comboBox1.SelectedIndex + 1) + ");";
                MySqlConnection conn = DBUtils.GetDbConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                cmDB.CommandTimeout = 60;
                try
                {
                    conn.Open();
                    MySqlDataReader rd = cmDB.ExecuteReader();
                    conn.Close();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if(modeS == "change")
            {
                string content = contentBox.Text.ToString();                
                string query = "update articles set name ='" + nameBox.Text + "', content ='" + content + "', id_autor = " + Convert.ToString(comboBox1.SelectedIndex + 1) + " where Id_article =" + item.ToString() + ";";
                MySqlConnection conn = DBUtils.GetDbConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                cmDB.CommandTimeout = 60;
                try
                {
                    conn.Open();
                    MySqlDataReader rd = cmDB.ExecuteReader();
                    conn.Close();

                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
