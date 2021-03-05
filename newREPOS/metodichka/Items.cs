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
    public partial class Items : Form
    {
        void get_Info(ListView List)
        {
            string query = "select * from Items;";
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
                        string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3) };
                        var listItem = new ListViewItem(row);
                        List.Items.Add(listItem);
                    }
                }
                List.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Items()
        {
            InitializeComponent();
            get_Info(list);
            this.FormClosing += Items_FormClosing;
        }


        private void Items_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            list.Items.Clear();
            get_Info(list);
        }

        private void Add_item_Click(object sender, EventArgs e)
        {
            AddItemWin Win = new AddItemWin();
            Win.Show();
        }

        private void Prihod_Click(object sender, EventArgs e)
        {
            Prihod Win = new Prihod();
            Win.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUser Win = new AddUser();
            Win.Show();
        }

        private void Orders_Click(object sender, EventArgs e)
        {
            Orders Win = new Orders();
            Win.Show();
        }
    }

    
}
