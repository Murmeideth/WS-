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
    public partial class quest_cud : Form
    {
        functions Func = new functions();
        public int ch_id;
        public int ch_st;
        public quest_cud(string mode)
        {
            InitializeComponent();
            if(mode == "add")
            {
                this.Width = 420;
                this.Height = 425;
                this.Text = "Новая задача";
                quest_cud_back.Location = new Point(190, 344);
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label6.Visible = true; 
                descBox.Visible = true;
                category.Visible = true;
                emplo.Visible = true;
                date_box.Visible = true;
                qcud_add_button.Visible = true;
                label1.Enabled = true;
                label2.Enabled = true;
                label3.Enabled = true;
                label6.Enabled = true;
                descBox.Enabled = true;
                category.Enabled = true;
                emplo.Enabled = true;
                date_box.Enabled = true;
                qcud_add_button.Enabled = true;
            }
            else if(mode == "change")
            {
                this.Width = 420;
                this.Height = 425;
                this.Text = "Изменение задачи";
                quest_cud_back.Location = new Point(190, 344);
                label5.Visible = true;
                label5.Enabled = true;
                get_chenged_id.Visible = true;
                get_chenged_id.Enabled = true;
                qcud_id_box.Visible = true;
                qcud_id_box.Enabled = true;
            }
            else if (mode == "delete")
            {
                this.Width = 420;
                this.Height = 380;
                this.Text = "Удаление задачи";
                quest_cud_back.Location = new Point(191, 298);
                label4.Visible = true;
                label4.Enabled = true;
                qcud_delete_button.Visible = true;
                qcud_delete_button.Enabled = true;
                qcud_id_box.Visible = true;
                qcud_id_box.Enabled = true;
            }
            Func.getValues(emplo);
            Func.getValues(category);
        }

        private void quest_cud_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void qcud_add_button_Click(object sender, EventArgs e)
        {
            if(date_box.Text == "ГГГГ-ММ-ДД")
            {
                MessageBox.Show("Введите корректную дату");
                return;
            }
            try
            {
                Func.AddQuest(descBox, category, emplo, date_box);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проверьте формат даты (ГГГГ-ММ-ДД)");
                return;
            }
        }

        private void qcud_delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt16(qcud_id_box.Text);
                MessageBoxButtons button = MessageBoxButtons.YesNo;
                DialogResult Result;
                Result = MessageBox.Show("Вы уверены?", "Вы уверены, что хотите удалить данную задачу?", button);
                if (Result == DialogResult.Yes)
                {
                    try
                    {
                        Func.DeleteQuest(qcud_id_box);
                        this.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Введите корректный №");
                        return;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Возникла ошибка. Попробуйте еще раз.");
                return;
            }
        }

        private void get_chenged_id_Click(object sender, EventArgs e)
        {
            if(qcud_id_box.Text == "")
            {
                MessageBox.Show("Введите корректный №");
                return;
            }
            try
            {
                Func.GetChengedQuest(descBox, category, emplo, qcud_id_box, date_box);
                this.Width = 420;
                this.Height = 425;
                label5.Enabled = false;
                label5.Visible = false;
                get_chenged_id.Visible = false;
                get_chenged_id.Enabled = false;
                qcud_id_box.Visible = false;
                qcud_id_box.Enabled = false;
                date_box.Visible = true;
                date_box.Enabled = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                descBox.Visible = true;
                category.Visible = true;
                emplo.Visible = true;
                qcud_change_button.Visible = true;
                label6.Visible = true;
                date_box.Visible = true;
                label1.Enabled = true;
                label2.Enabled = true;
                label3.Enabled = true;
                descBox.Enabled = true;
                category.Enabled = true;
                emplo.Enabled = true;
                qcud_change_button.Enabled = true;
                label6.Enabled = true;
                date_box.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла ошибка. Попробуйте еще раз.");
                return;
            }
        }

        private void qcud_change_button_Click(object sender, EventArgs e)
        {
            
            DialogResult Result = MessageBox.Show("Вы уверены что хотите изменить данные?", "Подтвердите действий", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                Func.ChangeQuest(qcud_id_box, descBox, category, emplo, date_box);
                this.Close();
            }
        }
    }
}
