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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void outButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logButton_Click(object sender, EventArgs e)        
        {
            int Count = 0;
            string query = "select count(*) from users where name ='" + logBox.Text + "' and pass = '" + pasBox.Text + "';";
            MySqlConnection conn = DBUtils.GetDbConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                Count = Convert.ToInt32(cmDB.ExecuteScalar());                
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка авторизации. Попробуйте еще раз.");
                MessageBox.Show(ex.Message);
            }
            if (Count > 0)
            {
                Items Win = new Items();
                Win.Show();
                this.Hide();
            }
        }
    }
}
