using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using Microsoft.Office.Interop.Word;


namespace Manager
{
    class functions
    {
        public void getQuests(string mode, string worker, ListView Quest_list)
        {
            if(mode == "admin")
            {
                string query = "select q.id_quest, q.desc, c.desc, e.name, if(q.status = 0, 'Выполняется', 'Выполнено'), q.quest_date from quest_list as q, category as c, emplo as e where q.id_cat = c.id_cat and q.id_emplo_resp = e.id_emplo order by q.id_quest;";
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
                            string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), rd.GetString(4), rd.GetString(5) };
                            var listViewItem = new ListViewItem(row);
                            Quest_list.Items.Add(listViewItem);
                        }
                    }
                    conn.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                string query = "select q.id_quest, q.desc, c.desc, e.name, if(q.status = 0, 'Выполняется', 'Выполнено'), q.quest_date from quest_list as q, category as c, emplo as e where q.id_cat = c.id_cat and q.id_emplo_resp = e.id_emplo and e.name = '" + worker + "' order by q.id_quest;";
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
                            string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), rd.GetString(4), rd.GetString(5) };
                            var listViewItem = new ListViewItem(row);
                            Quest_list.Items.Add(listViewItem);
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
        public void AddQuest(TextBox Desc, ListBox Category, ListBox Emplo, TextBox Date)
        {
            int last_id;
            string query = "select max(id_quest) from quest_list;";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                last_id = Convert.ToInt16(cmDB.ExecuteScalar());
                string query_add = "insert into quest_list values("+ (last_id + 1) + ", '" + Desc.Text + "', " + (Convert.ToInt16(Category.SelectedIndex) + 1) + ", " + (Convert.ToInt16(Emplo.SelectedIndex) + 1) + ", 0, '" + Date.Text + "');";
                MySqlCommand cmDB_add = new MySqlCommand(query_add, conn);
                cmDB_add.CommandTimeout = 60;
                try
                {
                    MySqlDataReader rd = cmDB_add.ExecuteReader();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void getValues(ListBox List)
        {
            string query = "";
            if(List.Name.ToString() == "emplo")
            {
                query = "select name from emplo;";
            }
            else if(List.Name.ToString() == "category")
            {
                query = "select c.desc from category as c;";
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
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void GetChengedQuest(TextBox Desc, ListBox Category, ListBox Emplo, TextBox ChangeID, TextBox Date)
        {
            string query = "select * from quest_list where id_quest = " + Convert.ToInt16(ChangeID.Text) + ";";
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
                        int ch_id = Convert.ToInt16(rd.GetString(0));
                        Desc.Text = rd.GetString(1);
                        Category.SelectedIndex = (Convert.ToInt16(rd.GetString(2)) - 1);
                        Emplo.SelectedIndex = (Convert.ToInt16(rd.GetString(3)) - 1);
                        string st = rd.GetString(4);
                        Date.Text = rd.GetString(5);
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void GetChangedInfo(TextBox One, TextBox Two, TextBox ID, string mode)
        {
            string query = "";
            if (mode == "emplo")
            {
                query = "select * from emplo where id_emplo = " + Convert.ToInt16(ID.Text) + ";";
            }
            else if (mode == "category")
            {
                query = "select * from category where id_cat = " + Convert.ToInt16(ID.Text) + ";";
            }
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    if(mode == "emplo")
                    {
                        while (rd.Read())
                        {
                            One.Text = rd.GetString(1);
                            Two.Text = rd.GetString(2);
                        }
                    }
                    else if(mode == "category")
                    {
                        while (rd.Read())
                        {
                            One.Text = rd.GetString(1);
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
        public void ChangeQuest(TextBox ch_id, TextBox Desc, ListBox Category, ListBox Emplo, TextBox Date)
        {
            string query = "update quest_list as q set q.desc = '" + Desc.Text + "', q.id_cat = " + (Convert.ToInt16(Category.SelectedIndex) + 1) + ", q.id_emplo_resp = " + (Convert.ToInt16(Emplo.SelectedIndex) + 1) + ", q.quest_date = '" + Date.Text + "' where q.id_quest = " + Convert.ToInt16(ch_id.Text) + ";";
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
        public void ChangeInfo(TextBox One, TextBox Two, TextBox ID, string mode)
        {
            string query = "";
            if(mode == "emplo")
            {
                query = "update emplo as e set e.name = '" + One.Text + "', e.position = '" + Two.Text + "' where e.id_emplo = " + Convert.ToInt16(ID.Text) + ";";
            }
            else if(mode == "category")
            {
                query = "update category as c set c.desc = '" + One.Text + "' where c.id_cat = " + Convert.ToInt16(ID.Text) + ";";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DeleteQuest(TextBox DelID)
        {
            string query = "delete from quest_list where id_quest = " + Convert.ToInt16(DelID.Text) + ";";
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
        public void Delete_info(TextBox ID, string mode)
        {
            string query = "";
            if(mode == "emplo")
            {
                query = "delete from emplo where id_emplo = " + Convert.ToInt16(ID.Text) + ";";
            }
            else if (mode == "category")
            {
                query = "delete from category where id_cat = " + Convert.ToInt16(ID.Text) + ";";
            }
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                conn.Close();
                if (mode == "emplo")
                {
                    string query_log = "delete from log where id_log = " + (Convert.ToInt16(ID.Text) + 1) + ";";
                    MySqlCommand cmDB_log = new MySqlCommand(query_log, conn);
                    cmDB_log.CommandTimeout = 60;
                    try
                    {
                        conn.Open();
                        MySqlDataReader rd_log = cmDB_log.ExecuteReader();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void FindQuest(TextBox FindBox, ListView List, string mode, string worker)
        {
            string query = "";
            if (mode == "admin")
            {
                query = "select q.id_quest, q.desc, c.desc, e.name, if(q.status = 0, 'Выполняется', 'Выполнено') from quest_list as q, category as c, emplo as e where q.id_cat = c.id_cat and q.id_emplo_resp = e.id_emplo and q.desc like '%" + FindBox.Text + "%' order by q.id_quest ;";
            }
            else if(mode == "user")
            {
                query = "select q.id_quest, q.desc, c.desc, e.name, if(q.status = 0, 'Выполняется', 'Выполнено') from quest_list as q, category as c, emplo as e where q.id_cat = c.id_cat and q.id_emplo_resp = e.id_emplo and e.name = '" + worker + "' and q.desc like '%" + FindBox.Text + "%' order by q.id_quest;";
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
                    List.Items.Clear();
                    while (rd.Read())
                    {
                        string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), rd.GetString(4), rd.GetString(5) };
                        var listViewItem = new ListViewItem(row);
                        List.Items.Add(listViewItem);
                    }
                }
                else
                {
                    MessageBox.Show("Не было найдено ни одного совпадения.");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void FindQuestDate(TextBox One, TextBox Two, ListView List, System.Windows.Forms.CheckBox Check)
        {
            int status = Convert.ToInt16(Check.Checked);
            string query = "select q.id_quest, q.desc, c.desc, e.name, if(q.status = 0, 'Выполняется', 'Выполнено'), q.quest_date from quest_list as q, category as c, emplo as e where q.id_cat = c.id_cat and q.id_emplo_resp = e.id_emplo and q.status = " + status +" and (q.quest_date >@'"+ One.Text + "' and q.quest_date <@'" + Two.Text + "') order by q.id_quest ;";
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
                    List.Items.Clear();
                    while (rd.Read())
                    {
                        string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), rd.GetString(4), rd.GetString(5) };
                        var listViewItem = new ListViewItem(row);
                        List.Items.Add(listViewItem);
                    }
                }
                else
                {
                    MessageBox.Show("Не было найдено ни одного совпадения.");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void FindQuestFam(TextBox Fam, ListView List, System.Windows.Forms.CheckBox Check) 
        {
            int status = Convert.ToInt16(Check.Checked);
            string query = "select q.id_quest, q.desc, c.desc, e.name, if(q.status = 0, 'Выполняется', 'Выполнено'), q.quest_date from quest_list as q, category as c, emplo as e where q.id_cat = c.id_cat and q.id_emplo_resp = e.id_emplo and q.status = " + status + " and e.name like '%" + Fam.Text + "%' order by q.id_quest ;";
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
                    List.Items.Clear();
                    while (rd.Read())
                    {
                        string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), rd.GetString(4), rd.GetString(5) };
                        var listViewItem = new ListViewItem(row);
                        List.Items.Add(listViewItem);
                    }
                }
                else
                {
                    MessageBox.Show("Не было найдено ни одного совпадения.");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ChangeStatus(TextBox id, ListBox Index)
        {
            string query = "update quest_list set status = " + Convert.ToInt16(Index.SelectedIndex) + " where id_quest = " + Convert.ToInt16(id.Text) + ";";
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
        public void getInfo(string mode, ListView List)
        {
            string query = "";
            if(mode == "category")
            {
                query = "select * from category;";
            }
            else if (mode == "emplo")
            {
                query = "select * from emplo;";
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
                    if(mode == "category")
                    {
                        while (rd.Read())
                        {
                            string[] row = {rd.GetString(0), rd.GetString(1) };
                            var listViewItem = new ListViewItem(row);
                            List.Items.Add(listViewItem);
                        }
                    }
                    else if(mode == "emplo")
                    {
                        while (rd.Read())
                        {
                            string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2) };
                            var listViewItem = new ListViewItem(row);
                            List.Items.Add(listViewItem);
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
        public void NewEmployer(Label login, Label password, TextBox Name, TextBox Position)
        {
            int id;

            string query = "select max(id_emplo) from emplo;";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                id = (Convert.ToInt16(cmDB.ExecuteScalar()) + 1);
                string query_add = "insert into emplo values("+ id + ", '" + Name.Text + "', '" + Position.Text + "');";
                MySqlCommand cmDB_add = new MySqlCommand(query_add, conn);
                cmDB_add.CommandTimeout = 60;
                try
                {
                    MySqlDataReader rd = cmDB_add.ExecuteReader();
                    conn.Close();
                    string query_log_pass = "insert into log values(" + (id + 1) + ", '" + login.Text + "', '" + password.Text + "');";
                    MySqlCommand cmDB_log_pass = new MySqlCommand(query_log_pass, conn);
                    cmDB_add.CommandTimeout = 60;
                    try
                    {
                        conn.Open();
                        MySqlDataReader rd_log = cmDB_log_pass.ExecuteReader();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void NewCat(TextBox Description)
        {
            int id;

            string query = "select max(id_cat) from category;";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                id = (Convert.ToInt16(cmDB.ExecuteScalar()) + 1);
                string query_add = "insert into category values(" + id + ", '" + Description.Text + "');";
                MySqlCommand cmDB_add = new MySqlCommand(query_add, conn);
                cmDB_add.CommandTimeout = 60;
                try
                {
                    MySqlDataReader rd = cmDB_add.ExecuteReader();
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
        public void createwordtable(ListView List)
        {
            object objMissing = System.Reflection.Missing.Value;
            object objEndOfDocument = "\\endofdoc";
            Microsoft.Office.Interop.Word._Application appobj;
            Microsoft.Office.Interop.Word.Document docobj;
            appobj = new Microsoft.Office.Interop.Word.Application();
            appobj.Visible = true;
            docobj = appobj.Documents.Add(ref objMissing, ref objMissing, ref objMissing, ref objMissing);
            int i = 0;
            int j = 0;
            Microsoft.Office.Interop.Word.Table tableObj;
            Microsoft.Office.Interop.Word.Range RangeofWord = docobj.Bookmarks.get_Item(ref objEndOfDocument).Range;
            tableObj = docobj.Tables.Add(RangeofWord, List.Items.Count, List.Columns.Count, ref objMissing, ref objMissing);
            tableObj.Range.ParagraphFormat.SpaceAfter = 8;
            string str;
            for (i = 0; i < List.Items.Count; i++)
            {
                for (j = 0; j < List.Columns.Count; j++)
                {
                    str = List.Items[i].SubItems[j].Text;                    
                    tableObj.Cell(i+1, j+1).Range.Text = str;
                }
            }
            tableObj.Borders.Enable = 1;
            tableObj.Columns.AutoFit();
        }
    }
}
