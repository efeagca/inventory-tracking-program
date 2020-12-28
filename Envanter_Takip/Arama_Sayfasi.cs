using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Reflection;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Envanter_Takip
{
    public partial class Arama_Sayfasi : Form
    {
        Envanter_Database.KULLANICI kullanici;
        Envanter_Database.EnvanterContainer dbcontext = new Envanter_Database.EnvanterContainer();

        public Arama_Sayfasi(Envanter_Database.KULLANICI kullanici)
        {
            this.kullanici = kullanici;
            InitializeComponent();
        }

        private void araButton1_Click(object sender, EventArgs e)
        {
            uRUNBindingSource.Clear();

            if (subelerCheckedListBox.CheckedItems.Count ==0)
            {
                MessageBox.Show("Lütfen Şube Seçiniz");
                return;
            }
            int index = 0;
            //sadece ürün adına göre arama yapılmak istendiğinde
            if (urunAdiTextBox.Text.Length != 0 && barkodTextBox.Text.Length==0)
            {
                foreach (string subeAdi in subelerCheckedListBox.CheckedItems)
                {
                    
                   var a =
                   from k in dbcontext.URUNSet1
                   where k.Sube.SubeAdi.Equals(subeAdi) &&
                         k.KullaniciID == kullanici.KullaniciID &&
                         k.UrunAdi.Equals(urunAdiTextBox.Text)
                   select k;

                    
                    foreach (var urun in a)
                    {

                        uRUNBindingSource.Add(urun);

                        DataGridViewRow row = (DataGridViewRow)uRUNDataGridView.Rows[index];
                        row.Cells[1].Value = subeAdi;
                        index++;
                        
                    }
                }
            }
            //sadece barkod numarasına göre arama yapılmak istendiğinde
            else if (urunAdiTextBox.Text.Length == 0 && barkodTextBox.Text.Length != 0)
            {
                foreach (string subeAdi in subelerCheckedListBox.CheckedItems)
                {
                    int barkod = Convert.ToInt32(barkodTextBox.Text);
                    var a =
                    from k in dbcontext.URUNSet1
                    where k.Sube.SubeAdi.Equals(subeAdi) &&
                          k.KullaniciID == kullanici.KullaniciID &&
                          k.Barkod == barkod
                    select k;


                    foreach (var urun in a)
                    {

                        uRUNBindingSource.Add(urun);

                        DataGridViewRow row = (DataGridViewRow)uRUNDataGridView.Rows[index];
                        row.Cells[1].Value = subeAdi;
                        index++;

                    }
                }


            }// hem ürün adı hem de barkod girerse
            else if (urunAdiTextBox.Text.Length != 0 && barkodTextBox.Text.Length != 0)
            {
                foreach (string subeAdi in subelerCheckedListBox.CheckedItems)
                {
                    int barkod = Convert.ToInt32(barkodTextBox.Text);
                    var a =
                    from k in dbcontext.URUNSet1
                    where k.Sube.SubeAdi.Equals(subeAdi) &&
                          k.KullaniciID == kullanici.KullaniciID &&
                          k.Barkod == barkod &&
                          k.UrunAdi.Equals(urunAdiTextBox.Text)
                    select k;

                    
                        foreach (var urun in a)
                        {

                            uRUNBindingSource.Add(urun);

                            DataGridViewRow row = (DataGridViewRow)uRUNDataGridView.Rows[index];
                            row.Cells[1].Value = subeAdi;
                            index++;

                        }
                    
                   
                }
            }

        }

        private void Arama_Sayfasi_Load(object sender, EventArgs e)
        {
            var subeAdiQuery =
                   from k in dbcontext.SUBESet1
                   where k.KullaniciID == kullanici.KullaniciID 
                   select k;
            Array subeList = subeAdiQuery.ToArray();

            foreach (Envanter_Database.SUBE sube in subeList)
            {
                subelerCheckedListBox.Items.Add(sube.SubeAdi);
            }
            
        }

        private void backtoButton_Click(object sender, EventArgs e)
        {
            Sube_Sayfasi ss = new Sube_Sayfasi(kullanici);
            this.Close();
            ss.Show();
        }
        Yazdirma y;
        private void yazdirButton_Click(object sender, EventArgs e)
        {
            y = new Yazdirma(uRUNDataGridView);
            y.Yazdir();
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(y.bmp, 0, 0);
        }

        private void PDFbutton_Click(object sender, EventArgs e)
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(uRUNDataGridView.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in uRUNDataGridView.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in uRUNDataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value!=null)
                    {
                        pdfTable.AddCell(cell.Value.ToString());

                    }



                }
            }

            //Exporting to PDF

            folderBrowserDialog1.ShowDialog();
            using (FileStream stream = new FileStream(folderBrowserDialog1.SelectedPath + "DataGridViewExport.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A1, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }

        }
    }
}
