using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace Manager
{   
    public partial class Quests : Form
    {
        public int Size_mode = 0;
        functions Func = new functions();
        public Quests(string mode, string worker)
        {           
            InitializeComponent();
            mode_label.Text = mode;
            if(mode != "admin")
            {
                add_quest_button.Enabled = false;
                delete_quest_button.Enabled = false;
                change_quest_button.Enabled = false;
                show_category_button.Enabled = false;
                show_emplo_button.Enabled = false;
                status_pick.Enabled = false;
                date_pick.Enabled = false;
                worker_label.Text = worker;
            }
            if (Size_mode == 0)
            {
                this.Width = 610;
                this.Height = 495;
                label1.Enabled = false;
                label1.Visible = false;
                find_box.Enabled = false;
                find_box.Visible = false;
                find_button.Enabled = false;
                find_button.Visible = false;
            }
            Func.getQuests(mode, worker, Quest_list);
            Quest_list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
        

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void reLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login Log_win = new Login();
            Log_win.Show();
            this.Close();            
        }

        private void add_quest_button_Click(object sender, EventArgs e)
        {
            quest_cud QC_win = new quest_cud("add");
            QC_win.Show();
        }

        private void change_quest_button_Click(object sender, EventArgs e)
        {
            quest_cud QC_win = new quest_cud("change");
            QC_win.Show();
        }

        private void delete_quest_button_Click(object sender, EventArgs e)
        {
            quest_cud QC_win = new quest_cud("delete");
            QC_win.Show();
        }

        private void refresh_quests_Click(object sender, EventArgs e)
        {
            Quest_list.Items.Clear();
            Func.getQuests(mode_label.Text, worker_label.Text, Quest_list);
            Quest_list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void find_quest_button_Click(object sender, EventArgs e)
        {
            if(Size_mode == 0)
            {
                this.Width = 610;
                this.Height = 535;
                label1.Enabled = true;
                label1.Visible = true;
                find_box.Enabled = true;
                find_box.Visible = true;
                find_button.Enabled = true;
                find_button.Visible = true;
                Size_mode = 1;
            }
            else if(Size_mode == 1)
            {
                this.Width = 610;
                this.Height = 495;
                label1.Enabled = false;
                label1.Visible = false;
                find_box.Enabled = false;
                find_box.Visible = false;
                find_button.Enabled = false;
                find_button.Visible = false;
                Size_mode = 0;
            }
        }

        private void find_button_Click(object sender, EventArgs e)
        {
            Func.FindQuest(find_box, Quest_list, mode_label.Text, worker_label.Text);
        }

        private void change_status_button_Click(object sender, EventArgs e)
        {
            Status_change Stat_win = new Status_change();
            Stat_win.Show();
        }

        private void show_emplo_button_Click(object sender, EventArgs e)
        {
            Additional_info Win = new Additional_info("emplo");
            Win.Show();
        }

        private void show_category_button_Click(object sender, EventArgs e)
        {
            Additional_info Win = new Additional_info("category");
            Win.Show();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Func.createwordtable(Quest_list);
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void status_pick_Click(object sender, EventArgs e)
        {
            if (Size_mode == 0)
            {
                this.Width = 610;
                this.Height = 535;
                status_find.Enabled = true;
                status_find.Visible = true;
                label4.Visible = true;
                label4.Enabled = true;
                fam_box.Enabled = true;
                fam_box.Visible = true;
                label5.Visible = true;
                label5.Enabled = true;
                status_box.Enabled = true;
                status_box.Visible = true;
                Size_mode = 1;
            }
            else if (Size_mode == 1)
            {
                this.Width = 610;
                this.Height = 495;
                status_find.Enabled = false;
                status_find.Visible = false;
                label4.Visible = false;
                label4.Enabled = false;
                fam_box.Enabled = false;
                fam_box.Visible = false;
                label5.Visible = false;
                label5.Enabled = false; 
                status_box.Enabled = false;
                status_box.Visible = false;
                Size_mode = 0;
            }
        }

        private void date_find_Click(object sender, EventArgs e)
        {
            if(first_date.Text == ""||second_date.Text == "")
            {
                MessageBox.Show("Условия заданы не корректно!");
                return;
            }
            try
            {
                Quest_list.Items.Clear();
                Func.FindQuestDate(first_date, second_date, Quest_list, status_box);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Условия заданы не корректно!");
                return;
            }
        }

        private void date_pick_Click(object sender, EventArgs e)
        {
            if (Size_mode == 0)
            {
                this.Width = 610;
                this.Height = 535;
                date_find.Enabled = true;
                date_find.Visible = true;
                label2.Enabled = true;
                label2.Visible = true;
                label3.Enabled = true;
                label3.Visible = true;
                label5.Visible = true;
                label5.Enabled = true;
                first_date.Enabled = true;
                first_date.Visible = true;
                second_date.Enabled = true;
                second_date.Visible = true;
                status_box.Enabled = true;
                status_box.Visible = true;
                Size_mode = 1;
            }
            else if (Size_mode == 1)
            {
                this.Width = 610;
                this.Height = 495;
                date_find.Enabled = false;
                date_find.Visible = false;
                label2.Enabled = false;
                label2.Visible = false;
                label3.Enabled = false;
                label3.Visible = false;
                label5.Visible = false;
                label5.Enabled = false;
                first_date.Enabled = false;
                first_date.Visible = false;
                second_date.Enabled = false;
                second_date.Visible = false;
                status_box.Enabled = false;
                status_box.Visible = false;
                Size_mode = 0;
            }
        }

        private void status_find_Click(object sender, EventArgs e)
        {
            if (fam_box.Text == "")
            {
                MessageBox.Show("Условия заданы не корректно!");
                return;
            }
            try
            {
                Quest_list.Items.Clear();
                Func.FindQuestFam(fam_box, Quest_list, status_box);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Условия заданы не корректно!");
                return;
            }
        }
    }
}
