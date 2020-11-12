using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{
    
    public partial class additional_cud : Form
    {
        functions Func = new functions();

        static string symbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        static Random r = new Random();
        static string GetRandom(string type)
        {
            string Result = "";
            if(type == "login")
            {
                for(int i = 0; i < 4; i++)
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
        public additional_cud(string mode)
        {
            InitializeComponent();
            if(mode == "emplo_create")
            {
                this.Text = "Добавление пользователя";
                name_label.Enabled = true;
                Name_box.Enabled = true;
                position_label.Enabled = true;
                Position_box.Enabled = true;
                login_label.Enabled = true;
                login.Enabled = true;
                password_label.Enabled = true;
                password.Enabled = true;
                create.Enabled = true;
                name_label.Visible = true;
                Name_box.Visible = true;
                position_label.Visible = true;
                Position_box.Visible = true;
                login_label.Visible = true;
                login.Visible = true;
                password_label.Visible = true;
                password.Visible = true;
                create.Visible = true;
                login.Text = GetRandom(login.Name.ToString());
                password.Text = GetRandom(password.Name.ToString());
            }
            else if(mode == "emplo_update")
            {
                this.Text = "Изменение пользователя";
                id_box.Enabled = true;
                id_box.Visible = true;
                set_change_id_emplo.Enabled = true;
                set_change_id_emplo.Visible = true;
                update_label.Visible = true;
                update_label.Enabled = true;
            }
            else if(mode == "emplo_delete")
            {
                this.Text = "Удаление пользователя";
                id_box.Enabled = true;
                id_box.Visible = true;
                delete_button.Enabled = true;
                delete_button.Visible = true;
                delete_label.Visible = true;
                delete_label.Enabled = true;
            }
            else if(mode == "cat_add")
            {
                this.Text = "Добавление категории";
                cat_label.Enabled = true;
                cat_label.Visible = true;
                Name_box.Enabled = true;
                Name_box.Visible = true;
                add_cat.Enabled = true;
                add_cat.Visible = true;
            }
            else if(mode == "cat_update")
            {
                this.Text = "Изменение категории";
                id_box.Enabled = true;
                id_box.Visible = true;
                cat_upd_label.Enabled = true;
                cat_upd_label.Visible = true;
                update_cat.Enabled = true;
                update_cat.Visible = true;
            }
            else if(mode == "cat_delete")
            {
                this.Text = "Удаление категории";
                id_box.Enabled = true;
                id_box.Visible = true;
                cat_del_label.Enabled = true;
                cat_del_label.Visible = true;
                del_cat.Enabled = true;
                del_cat.Visible = true;
            }
        }

        private void create_Click(object sender, EventArgs e)
        {
            if(Name_box.Text == "" || Position_box.Text == "")
            {
                MessageBox.Show("Возникла ошибка. Попробуйте еще раз.");
                return;
            }
            DialogResult Res = MessageBox.Show("Вы запомнили логин и пароль?", "Продолжить?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Res == DialogResult.Yes)
            {
                Func.NewEmployer(login, password, Name_box, Position_box);
                this.Close();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void set_change_id_Click(object sender, EventArgs e)
        {
            try
            {
                Func.GetChangedInfo(Name_box, Position_box, id_box, "emplo");
                id_box.Enabled = false;
                id_box.Visible = false;
                set_change_id_emplo.Enabled = false;
                set_change_id_emplo.Visible = false;
                update_label.Visible = false;
                update_label.Enabled = false;
                name_label.Enabled = true;
                name_label.Visible = true;
                Name_box.Visible = true;
                Name_box.Enabled = true;
                position_label.Enabled = true;
                position_label.Visible = true;
                Position_box.Enabled = true;
                Position_box.Visible = true;
                update_button.Enabled = true;
                update_button.Visible = true;                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Возникла ошибка. Попробуйте еще раз.");
                return;
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            if (id_box.Text == "")
            {
                MessageBox.Show("Возникла ошибка. Попробуйте еще раз.");
                return;
            }
            try
            {
                DialogResult Res = MessageBox.Show("Вы уверены что хотите изменить информацию?", "Продолжить?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Res == DialogResult.Yes)
                {
                    Func.ChangeInfo(Name_box, Position_box, id_box, "emplo");
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Возникла ошибка. Попробуйте еще раз.");
                return;
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (id_box.Text == "")
            {
                MessageBox.Show("Возникла ошибка. Попробуйте еще раз.");
                return;
            }
            try
            {
                DialogResult Res = MessageBox.Show("Вы уверены что хотите удалить информацию?", "Продолжить?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Res == DialogResult.Yes)
                {
                    Func.Delete_info(id_box, "emplo");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла ошибка. Попробуйте еще раз.");
                return;
            }
        }

        private void add_cat_Click(object sender, EventArgs e)
        {
            if (Name_box.Text == "")
            {
                MessageBox.Show("Возникла ошибка. Попробуйте еще раз.");
                return;
            }
            try
            {
                Func.NewCat(Name_box);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла ошибка. Попробуйте еще раз.");
                return;
            }
        }

        private void update_cat_Click(object sender, EventArgs e)
        {
            try
            {
                Func.GetChangedInfo(Name_box, Position_box, id_box, "category");
                id_box.Enabled = false;
                id_box.Visible = false;
                cat_upd_label.Enabled = false;
                cat_upd_label.Visible = false;
                update_cat.Enabled = false;
                update_cat.Visible = false;
                Name_box.Visible = true;
                Name_box.Enabled = true;
                cat_label.Enabled = true;
                cat_label.Visible = true;
                cat_change.Enabled = true;
                cat_change.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла ошибка. Попробуйте еще раз.");
                return;
            }
        }

        private void cat_change_Click(object sender, EventArgs e)
        {
            if (id_box.Text == "")
            {
                MessageBox.Show("Возникла ошибка. Попробуйте еще раз.");
                return;
            }
            try
            {
                DialogResult Res = MessageBox.Show("Вы уверены что хотите изменить информацию?", "Продолжить?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Res == DialogResult.Yes)
                {
                    Func.ChangeInfo(Name_box, Position_box, id_box, "category");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла ошибка. Попробуйте еще раз.");
                return;
            }
        }

        private void del_cat_Click(object sender, EventArgs e)
        {
            if (id_box.Text == "")
            {
                MessageBox.Show("Возникла ошибка. Попробуйте еще раз.");
                return;
            }
            try
            {
                DialogResult Res = MessageBox.Show("Вы уверены что хотите удалить информацию?", "Продолжить?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Res == DialogResult.Yes)
                {
                    Func.Delete_info(id_box, "category");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла ошибка. Попробуйте еще раз.");
                return;
            }
}
    }
}
