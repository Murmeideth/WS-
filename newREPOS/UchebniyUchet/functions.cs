using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UchebniyUchet
{
    class functions
    {
        public void getInfo(ListView List)
        {
            string ListName = List.Name;
            string query = "";

            if (ListName == "main")
            {
                query = "select m.id, m.name, g.desc, k.name from main as m, gruppa as g, kurator as k where m.group_id = g.id_group and m.kurator_id = k.id_kur order by m.id;";
                MySqlConnection con = DBUtils.GetDBConnection();
                MySqlCommand dbCm = new MySqlCommand(query, con);
                dbCm.CommandTimeout = 60;
                MySqlDataReader rd;
                try
                {
                    con.Open();
                    rd = dbCm.ExecuteReader();
                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3) };
                            var listViewItem = new ListViewItem(row);
                            List.Items.Add(listViewItem);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else if (ListName == "gruppa")
            {
                query = "select * from " + ListName + ";";
                MySqlConnection con = DBUtils.GetDBConnection();
                MySqlCommand dbCm = new MySqlCommand(query, con);
                dbCm.CommandTimeout = 60;
                MySqlDataReader rd;
                try
                {
                    con.Open();
                    rd = dbCm.ExecuteReader();
                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2) };
                            var listViewItem = new ListViewItem(row);
                            List.Items.Add(listViewItem);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (ListName == "kurator")
            {
                query = "select * from " + ListName + ";";
                MySqlConnection con = DBUtils.GetDBConnection();
                MySqlCommand dbCm = new MySqlCommand(query, con);
                dbCm.CommandTimeout = 60;
                MySqlDataReader rd;
                try
                {
                    con.Open();
                    rd = dbCm.ExecuteReader();
                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2)};
                            var listViewItem = new ListViewItem(row);
                            List.Items.Add(listViewItem);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }



        }

        public void setInfoList(ListBox List)
        {
            string query = "";
            if (List.Name == "gruppa")
            {
                query = "select g.desc from gruppa as g;";
            }
            else if (List.Name == "kurator")
            {
                query = "select name from kurator;";
            }

            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            MySqlDataReader rd;
            try
            {
                conn.Open();
                rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        string row = rd.GetString(0);
                        List.Items.Add(row);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void addInfoStudent(TextBox ID, TextBox Name, ListBox Group, ListBox Kurator)
        {
            string query = "insert into main values( " + ID.Text + ", '" + Name.Text + "', '" + Group.SelectedIndex + "', '" + Kurator.SelectedIndex + "');";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            MySqlDataReader rd;
            try
            {
                conn.Open();
                rd = cmDB.ExecuteReader();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void addInfoAdditional(TextBox ID, TextBox NameBox, TextBox Desc)
        {
            string query = "";
            if (NameBox.Name == "group")
            {
                query = "insert into gruppa values('" + ID.Text + "', '" + NameBox.Text + "', '" + Desc.Text + "');";
            }
            else if (NameBox.Name == "kurator")
            {
                query = "insert into kurator values('" + ID.Text + "', '" + NameBox.Text + "', '" + Desc.Text + "');";
            }
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            MySqlDataReader rd;
            try
            {
                conn.Open();
                rd = cmDB.ExecuteReader();
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteRow(TextBox ID)
        {
            string query = "delete from " + ID.Name + " where id = " + ID.Text + ";";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            MySqlDataReader rd;
            try
            {
                conn.Open();
                rd = cmDB.ExecuteReader();
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
