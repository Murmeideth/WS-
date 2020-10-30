using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;


namespace AP
{
    class functions
    {
        public void ShowList(ListView List)
        {
            string query = "select m.id, m.name, m.decription, e.name, m.date, d.docs from main as m, employers as e, documents as d where m.id_employer = e.id_emp and m.id_doc = d.id_doc;";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand comDB = new MySqlCommand(query, conn);
            comDB.CommandTimeout = 60;
            MySqlDataReader rd;
            try
            {
                conn.Open();
                rd = comDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), rd.GetString(4), rd.GetString(5) };
                        var listVievItem = new ListViewItem(row);
                        List.Items.Add(listVievItem);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при загрузке данных работников!");
                MessageBox.Show(ex.Message);
            }

        }


        public void ShowEmplo(ListView List)
        {
            string query = "select * from employers;";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand comDB = new MySqlCommand(query, conn);
            comDB.CommandTimeout = 60;
            MySqlDataReader rd;
            try
            {
                conn.Open();
                rd = comDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3)};
                        var listVievItem = new ListViewItem(row);
                        List.Items.Add(listVievItem);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при загрузке данных работников!");
                MessageBox.Show(ex.Message);
            }
        }

        public void ShowDoc(ListView List)
        {
            string query = "select * from documents;";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand comDB = new MySqlCommand(query, conn);
            comDB.CommandTimeout = 60;
            MySqlDataReader rd;
            try
            {
                conn.Open();
                rd = comDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2)};
                        var listVievItem = new ListViewItem(row);
                        List.Items.Add(listVievItem);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при загрузке документации!");
                MessageBox.Show(ex.Message);
            }
        }


        public void getInfo(ListBox List)
        {
            string query = "";
            if (List.Name.ToString() == "employers")
            {
                query = "select name from " + List.Name.ToString() + ";";
            }
            else if (List.Name.ToString() == "documents")
            {
                query = "select docs from " + List.Name.ToString() + ";";
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
                MessageBox.Show("Произошла ошибка!");
                MessageBox.Show(ex.Message);
            }
        }

        public void NewEvent(TextBox Name, TextBox Description, ListBox Employer, DateTimePicker Date, ListBox Documents)
        {
            string query = "insert into main(name, decription, id_employer, Date, id_doc) values('" + Name.Text + "', '" + Description.Text + "' , " + Convert.ToString(Employer.SelectedIndex + 1) + ", '" + Date.Value.ToString("yyyy-MM-dd") + "', " + Convert.ToString(Documents.SelectedIndex + 1) + ");";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                MySqlDataReader myReader = cmDB.ExecuteReader();
                conn.Close();
                MessageBox.Show("Новое мероприятие внесено в список!");                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка!");
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteEvent(TextBox ID)
        {
            
            string query = "delete from main where id = " + ID.Text + ";";
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

        public void Add_Emplo(TextBox ID, TextBox Emp_Name, TextBox Desc, TextBox Position)
        {
            string query = "insert into employers values('" + ID.Text + "', '" + Emp_Name.Text + "', '" + Desc.Text + "', '" + Position.Text + "');";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                conn.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Add_Doc(TextBox ID, TextBox Doc_Name, TextBox Desc)
        {
            string query = "insert into documents values('" + ID.Text + "', '" + Doc_Name.Text + "', '" + Desc.Text + "');";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Delete_info(TextBox ID)
        {
            string ID_name = "";
            if(ID.Name == "documents")
            {
                ID_name = "documents";
            }
            else if(ID.Name == "employers")
            {
                ID_name = "employers";
            }
            string query = "delete from " + ID_name + " where id = " + ID.Text + ";";
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
