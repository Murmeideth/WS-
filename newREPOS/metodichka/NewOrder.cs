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
    public partial class NewOrder : Form
    {
        void getInfo(ListView List)
        {
            string query = "select items.name, cort.quatity from items join cort on cort.id_tovar = items.Id_item where id_cort = " + Counter +";";
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
                        string[] row = { rd.GetString(0), rd.GetString(1) };
                        var listItem = new ListViewItem(row);
                        List.Items.Add(listItem);
                    }
                }
                conn.Close();
                List.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch (Exception ex)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int Counter = 0;
        void CreateCort()
        {
            string query = "select count(*) from orders;";
            MySqlConnection conn = DBUtils.GetDbConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                Counter = Convert.ToInt32(cmDB.ExecuteScalar()) + 1;
                conn.Close();
                string queryNew = "insert into orders(id_cort, sale, emplo, price) values('" + Counter + "', '2000-01-01', ' ', '0');";
                MySqlCommand cmDBC = new MySqlCommand(queryNew, conn);
                cmDBC.CommandTimeout = 60;
                try
                {
                    conn.Open();
                    MySqlDataReader rd = cmDBC.ExecuteReader();
                    conn.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public NewOrder()
        {
            InitializeComponent();
            getInfo(listView1);
            getItems(comboBox1);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Value = DateTime.Today;
            CreateCort();
        }

        private void Add_item_Click(object sender, EventArgs e)
        {
            string query = "insert into cort values(" + Counter +"," + Convert.ToString(comboBox1.SelectedIndex + 1) + ", " + Convert.ToInt32(textBox1.Text) + ");";
            MySqlConnection conn = DBUtils.GetDbConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                conn.Close();
                listView1.Items.Clear();
                getInfo(listView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Canel_add_Click(object sender, EventArgs e)
        {
            string quer = "delete from cort where id_cort =" + Counter + ";";
            string query = "delete from orders where id_cort = " + Counter + ";";
            MySqlConnection conn = DBUtils.GetDbConnection();
            MySqlCommand cmDB = new MySqlCommand(quer, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                conn.Close();
                MySqlCommand cmDBD = new MySqlCommand(query, conn);
                cmDBD.CommandTimeout = 60;
                try
                {
                    conn.Open();
                    MySqlDataReader rdr = cmDBD.ExecuteReader();
                    conn.Close();
                    this.Close();
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

        int getPrice()
        {
            string query = "select cort.quatity, items.price from cort join items on items.Id_item = cort.id_tovar where cort.id_cort = " + Counter + ";";
            MySqlConnection conn = DBUtils.GetDbConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            MySqlDataReader rd;
            int Result = 0;
            try
            {
                conn.Open();
                rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        int A = Convert.ToInt32(rd.GetString(0));
                        int B = Convert.ToInt32(rd.GetString(1));
                        Result += A * B;
                    }
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return Result;
        }
        
        public void DeleteItems()
        {
            string query = "select quatity, id_tovar from cort where id_cort = " + Counter + ";";
            MySqlConnection conn = DBUtils.GetDbConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                if(rd.HasRows)
                {
                    while (rd.Read())
                    {
                        string rowQ = rd.GetString(0);
                        string rowID = rd.GetString(1);
                        string queryUPD = "update items set quatity = quatity - " + rowQ + " where Id_item = " + rowID + ";";
                        MySqlConnection connUPD = DBUtils.GetDbConnection();
                        MySqlCommand cmDBU = new MySqlCommand(queryUPD, connUPD);
                        cmDBU.CommandTimeout = 60;
                        try
                        {
                            connUPD.Open();
                            MySqlDataReader rdUPD = cmDBU.ExecuteReader();
                            connUPD.Close();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Add_order_Click(object sender, EventArgs e)
        {
            float Result = getPrice();
            string query = "update orders set sale = '" + dateTimePicker1.Text + "', emplo = '" + textBox2.Text + "', price = " + Result + " where id_cort = " + Counter + ";";
            MySqlConnection conn = DBUtils.GetDbConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                conn.Close();
                DeleteItems();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delItem_Click(object sender, EventArgs e)
        {
            int ID = 0;
            string queryF = "select Id_item from items where items.name = '" + listView1.Items[listView1.SelectedIndices[0]].Text + "';";
            MySqlConnection conn = DBUtils.GetDbConnection();
            MySqlCommand cmDB = new MySqlCommand(queryF, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                ID = Convert.ToInt32(cmDB.ExecuteScalar());
                conn.Close();
                string query = "delete from cort where id_cort = " + Counter + " and id_tovar = '" + ID + "';";
                MySqlCommand cmDBD = new MySqlCommand(query, conn);
                cmDBD.CommandTimeout = 60;
                try
                {
                    conn.Open();
                    MySqlDataReader rd = cmDBD.ExecuteReader();
                    conn.Close();
                    listView1.Items.Clear();
                    getInfo(listView1);
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
