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
using MySql.Data.MySqlClient;


using iTextSharp.text;
using iTextSharp.text.pdf;



namespace NewForms
{
    public partial class Form1 : Form
    {
        WorkWithEmplo Func = new WorkWithEmplo();
        public Form1()
        {
            InitializeComponent();            
            Func.ShowEmplo(Spisok);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void вывестиВPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            BaseFont Tfont = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, "Cp1251", BaseFont.EMBEDDED);
            iTextSharp.text.Font Times = new iTextSharp.text.Font(Tfont, 12);
            string folder = folderBrowserDialog1.SelectedPath;
            PdfPTable table = new PdfPTable(Spisok.Columns.Count);            
            table.DefaultCell.Padding = 3;      
            table.HorizontalAlignment = Element.ALIGN_CENTER;
            table.DefaultCell.BorderWidth = 1;
                                                            

            foreach (ListViewItem itemRow in Spisok.Items)
            {
                for (int i = 0; i < itemRow.SubItems.Count; i++)
                {
                    table.AddCell(new Phrase(itemRow.SubItems[i].Text, Times));
                }
            }
            if (File.Exists(folder + "\\Soisok.pdf"))
            {
                File.Delete(folder + "\\Soisok.pdf");
            }
            var document = new Document(iTextSharp.text.PageSize.A4, 25, 25, 25, 25);
            try
            {
                using (FileStream stream = new FileStream(folder + "\\Spisok.pdf", FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    PdfWriter.GetInstance(document, stream);
                    document.Open();
                    document.AddTitle("Список сотрудников");
                    document.Add(table);
                    document.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Закройте сохранённый список!");
                return;
            }
        }

        private void OpenStripMenu_Click(object sender, EventArgs e)
        {

        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

           
        }

        private void DeleteStripMenu_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonForChange_Click(object sender, EventArgs e)
        {
            Update Upd = new Update();
            Upd.Show();
            this.Visible = false;
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Spisok.Items.Clear();
            Func.ShowEmplo(Spisok);
        }

        private void ButtonForNew_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Create New = new Create();
            New.Show();
        }

        private void ButtonForDelete_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Delete DelInfo = new Delete();
            DelInfo.Show();
        }
    }
}
