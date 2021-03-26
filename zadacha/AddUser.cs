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
    public partial class AddUser : Form
    {
        static string symbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        static Random r = new Random();
        static string GetRandom(string type)
        {
            string Result = "";
            if (type == "login")
            {
                for (int i = 0; i < 4; i++)
                {
                    var index = r.Next(symbols.Length);
                    Result += symbols[index];
                }
            }
            else if (type == "password")
            {
                for (int i = 0; i < 6; i++)
                {
                    var index = r.Next(symbols.Length);
                    Result += symbols[index];
                }
            }
            return Result;
        }


        public AddUser()
        {
            InitializeComponent();
            login.Text = GetRandom(login.Name.ToString());
            password.Text = GetRandom(password.Name.ToString());
        }

        private void getNew_Click(object sender, EventArgs e)
        {
            login.Text = "";
            password.Text = "";
            login.Text = GetRandom(login.Name.ToString());
            password.Text = GetRandom(password.Name.ToString());
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string query = "insert into users(name, pass) values('" + login.Text + "', '" + password.Text + "');" ;
            MySqlConnection conn = DBUtils.GetDbConnection();
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
    }
}
