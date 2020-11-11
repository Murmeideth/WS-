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


namespace Manager
{
    public partial class Login : Form
    {
        string mode = "";
        string worker = "";
        public Login()
        {
            InitializeComponent();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_button_Click(object sender, EventArgs e)
        {   if(log_box.Text == "" || pass_box.Text == "")
            {
                MessageBox.Show("Заполните поля!");
                return;
            }
            int id_log = 0;
            int res = 0;
            string query = "select count(*) from log where login = '" + log_box.Text + "' and password = '" + pass_box.Text + "';";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                res = Convert.ToInt16(cmDB.ExecuteScalar());
                if(res == 1)
                {
                    string query_select = "select id_log from log where login = '" + log_box.Text + "';";
                    MySqlCommand cmDB_select = new MySqlCommand(query_select, conn);
                    id_log = Convert.ToInt16(cmDB_select.ExecuteScalar());
                    if(id_log == 1)
                    {
                        mode = "admin";
                        Quests QWin = new Quests(mode, worker);                        
                        QWin.Owner = this;
                        QWin.Show();
                        log_box.Text = "";
                        pass_box.Text = "";
                        this.Hide();
                    }
                    else
                    {
                        try 
                        {
                            string query_worker = "select name from emplo where id_emplo = " + (id_log - 1);
                            MySqlCommand cmDB_worker = new MySqlCommand(query_worker, conn);
                            worker = Convert.ToString(cmDB_worker.ExecuteScalar());
                            mode = "user";
                            Quests QWin = new Quests(mode, worker);                        
                            QWin.Owner = this;
                            QWin.Show();
                            log_box.Text = "";
                            pass_box.Text = "";
                            this.Hide();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка авторизации");
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
