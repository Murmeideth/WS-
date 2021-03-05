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
    
    public partial class Prihod : Form
    {
        void getInfo(ListView List)
        {
            string query = "select items.name, prihod.quatity, prihod.price, prihod.income from items join prihod on prihod.id_tovar = items.Id_item order by income;";
            MySqlConnection conn = DBUtils.GetDbConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3)};
                        var listItem = new ListViewItem(row);
                        List.Items.Add(listItem);
                    }
                }
                conn.Close();
                List.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void getItems(ComboBox Box)
        {
            string query = "select name from Items;";
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Prihod()
        {
            InitializeComponent();
            getInfo(listView1);
            getItems(comboBox1);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            getInfo(listView1);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string query = "insert into prihod values('" + Convert.ToString(comboBox1.SelectedIndex + 1) + "', '" + textBox1.Text + "', '" + textBox2.Text + "', '" + dateTimePicker1.Text + "');";
            MySqlConnection conn = DBUtils.GetDbConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                conn.Close();
                string queryChange = "update Items set quatity = quatity + " + textBox1.Text + " where Id_item = " + Convert.ToString(comboBox1.SelectedIndex + 1) + ";";
                MySqlCommand cmDBC = new MySqlCommand(queryChange, conn);
                cmDBC.CommandTimeout = 60;
                try
                {
                    conn.Open();
                    MySqlDataReader rdc = cmDBC.ExecuteReader();
                    conn.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }
    }
}
